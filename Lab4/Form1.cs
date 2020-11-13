using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
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
                foreach (var word in text.Split(" \n\t,./\\[]{}<>@#$%^&*();'\"|?!".ToCharArray()))
                {
                    if (!_words.Contains(word) && word != "")
                        _words.Add(word);
                }

                _stopwatch.Stop();

                _label.Text = $"Время загрузки текста:\n{_stopwatch.Elapsed}ms";
                _label.Visible = true;
                SetLableLocation();

                _searchButton.Enabled = true;

                _stopwatch.Reset();
            }
        }

        private void SetLableLocation() =>
            _label.Location = Point.Add(_readTextButton.Location, new Size((_readTextButton.Size.Width - _label.Size.Width) / 2, -_readTextButton.Size.Height - 10));

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

            _label.Text = $"Время поиска слов:\n{_stopwatch.ElapsedMilliseconds}ms";
            SetLableLocation();

            _stopwatch.Reset();
        }
    }
}
