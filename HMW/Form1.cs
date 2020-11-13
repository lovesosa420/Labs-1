using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;

namespace HMW
{
    public partial class MainForm : Form
    {
        private readonly List<string> _words;
        private readonly Stopwatch _stopwatch;

        public MainForm()
        {
            InitializeComponent();

            _words = new List<string>();
            _stopwatch = new Stopwatch();
        }

        private void ReadWords(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _listBox.Items.Clear();

                _stopwatch.Start();

                var text = File.ReadAllText(_openFileDialog.FileName);
                foreach (var word in text.Split(" \n\t\f\r,./\\[]{ }<>@#$%^&*();'\"|?!".ToCharArray()))
                {
                    if (!_words.Contains(word) && word != "")
                        _words.Add(word);
                }

                _stopwatch.Stop();

                _textLoadingTime.Text = $"Время загрузки текста: {_stopwatch.Elapsed}";
                _wordsAmount.Text = $"Количество слов: {_words.Count}";

                _searchButton.Enabled = true;
                _parallelSearchButton.Enabled = true;
                _maxThreadsTextbox.Enabled = true;
                _distTextBox.Enabled = true;
                _textBox.Enabled = true;

                _stopwatch.Reset();
            }
        }

        private void SearchForWord(object sender, EventArgs e)
        {
            int maxDist;
            try
            {
                maxDist = Convert.ToInt32(_distTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат ввода максимальной дистанции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _listBox.BeginUpdate();
            _listBox.Items.Clear();

            _stopwatch.Start();

            foreach (var word in _words)
            {
                if (word.Contains(_textBox.Text))
                {
                    var dist = Lab5.Methods.LevenshteinDistance(word, _textBox.Text);
                    if (dist <= maxDist)
                        _listBox.Items.Add(new ListViewItem(new string[] { word, dist.ToString() }));
                }
            }

            _stopwatch.Stop();

            _listBox.EndUpdate();

            _searchTime.Text = $"Время поиска слов: {_stopwatch.Elapsed}";

            _stopwatch.Reset();
        }

        private void ValidateKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void ParallelSearch(object sender, EventArgs e)
        {
            if (!int.TryParse(_maxThreadsTextbox.Text, out int threadsCount))
            {
                MessageBox.Show("Неправильно введено максимальное количество потокв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(_distTextBox.Text, out int maxDist))
            {
                MessageBox.Show("Неправильный формат ввода максимальной дистанции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _listBox.BeginUpdate();
            _listBox.Items.Clear();

            _stopwatch.Start();

            Parallel.ForEach(_words, new ParallelOptions() { MaxDegreeOfParallelism = threadsCount }, word =>
            {
                if (word.Contains(_textBox.Text))
                {
                    var dist = Lab5.Methods.LevenshteinDistance(word, _textBox.Text);
                    if (dist <= maxDist)
                        _listBox.Items.Add(new ListViewItem(new string[] { word, dist.ToString() }));
                }
            });

            _stopwatch.Stop();

            _listBox.EndUpdate();

            _parallelSearchTime.Text = $"Время параллельного поиска: {_stopwatch.Elapsed / threadsCount}";

            _stopwatch.Reset();
        }

        private void CreateReport(object sender, EventArgs e)
        {
            _saveFileDialog.FileName = "Report_" + DateTime.Now.ToString("yyyy_mm_dd_h_m_s");
            if (_saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var report = new StringBuilder();

                report.AppendLine($"Отчёт: {_saveFileDialog.FileName}");
                report.AppendLine(_textLoadingTime.Text);
                report.AppendLine(_wordsAmount.Text);
                report.AppendLine($"Слово для поиска: {_textBox.Text}");
                report.AppendLine($"Максимальное расстояние для поиска: {_distTextBox.Text}");
                report.AppendLine($"Количество потоков: {_maxThreadsTextbox.Text}");
                report.AppendLine(_searchTime.Text);
                report.AppendLine(_parallelSearchTime.Text);
                report.AppendLine("Результаты поиска:");
                foreach (ListViewItem item in _listBox.Items)
                {
                    report.AppendLine($"\t{item.SubItems[0].Text} - {item.SubItems[1].Text}");
                }

                File.WriteAllText(_saveFileDialog.FileName, report.ToString());
            }
        }
    }
}
