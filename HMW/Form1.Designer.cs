namespace HMW
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._readTextButton = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._textLoadingTime = new System.Windows.Forms.Label();
            this._textBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._listBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this._distTextBox = new System.Windows.Forms.TextBox();
            this._maxThreadsTextbox = new System.Windows.Forms.TextBox();
            this._parallelSearchButton = new System.Windows.Forms.Button();
            this._searchTime = new System.Windows.Forms.Label();
            this._parallelSearchTime = new System.Windows.Forms.Label();
            this._wordsAmount = new System.Windows.Forms.Label();
            this._createReport = new System.Windows.Forms.Button();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // _readTextButton
            // 
            this._readTextButton.AutoSize = true;
            this._readTextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._readTextButton.Location = new System.Drawing.Point(12, 240);
            this._readTextButton.Name = "_readTextButton";
            this._readTextButton.Size = new System.Drawing.Size(149, 25);
            this._readTextButton.TabIndex = 0;
            this._readTextButton.Text = "Считать слова из файла";
            this._readTextButton.UseVisualStyleBackColor = true;
            this._readTextButton.Click += new System.EventHandler(this.ReadWords);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.Filter = "Текстовые файлы|*.txt";
            // 
            // _textLoadingTime
            // 
            this._textLoadingTime.AutoSize = true;
            this._textLoadingTime.Location = new System.Drawing.Point(335, 16);
            this._textLoadingTime.Name = "_textLoadingTime";
            this._textLoadingTime.Size = new System.Drawing.Size(132, 15);
            this._textLoadingTime.TabIndex = 1;
            this._textLoadingTime.Text = "Время загрузки текста:";
            // 
            // _textBox
            // 
            this._textBox.Enabled = false;
            this._textBox.Location = new System.Drawing.Point(12, 13);
            this._textBox.Name = "_textBox";
            this._textBox.PlaceholderText = "Введите слово для поиска...";
            this._textBox.Size = new System.Drawing.Size(165, 23);
            this._textBox.TabIndex = 2;
            // 
            // _searchButton
            // 
            this._searchButton.Enabled = false;
            this._searchButton.Location = new System.Drawing.Point(125, 41);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(138, 23);
            this._searchButton.TabIndex = 3;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this.SearchForWord);
            // 
            // _listBox
            // 
            this._listBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this._listBox.FullRowSelect = true;
            this._listBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._listBox.HideSelection = false;
            this._listBox.LabelWrap = false;
            this._listBox.Location = new System.Drawing.Point(11, 100);
            this._listBox.Name = "_listBox";
            this._listBox.ShowGroups = false;
            this._listBox.Size = new System.Drawing.Size(539, 134);
            this._listBox.TabIndex = 5;
            this._listBox.UseCompatibleStateImageBehavior = false;
            this._listBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Слово";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "D";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 35;
            // 
            // _distTextBox
            // 
            this._distTextBox.Enabled = false;
            this._distTextBox.Location = new System.Drawing.Point(12, 42);
            this._distTextBox.MaxLength = 7;
            this._distTextBox.Name = "_distTextBox";
            this._distTextBox.PlaceholderText = "Макс. дистанция";
            this._distTextBox.Size = new System.Drawing.Size(107, 23);
            this._distTextBox.TabIndex = 6;
            this._distTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // _maxThreadsTextbox
            // 
            this._maxThreadsTextbox.Enabled = false;
            this._maxThreadsTextbox.Location = new System.Drawing.Point(12, 71);
            this._maxThreadsTextbox.Name = "_maxThreadsTextbox";
            this._maxThreadsTextbox.PlaceholderText = "Макс. потоков";
            this._maxThreadsTextbox.Size = new System.Drawing.Size(107, 23);
            this._maxThreadsTextbox.TabIndex = 7;
            this._maxThreadsTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKeyPress);
            // 
            // _parallelSearchButton
            // 
            this._parallelSearchButton.Enabled = false;
            this._parallelSearchButton.Location = new System.Drawing.Point(125, 70);
            this._parallelSearchButton.Name = "_parallelSearchButton";
            this._parallelSearchButton.Size = new System.Drawing.Size(138, 23);
            this._parallelSearchButton.TabIndex = 8;
            this._parallelSearchButton.Text = "Параллельный поиск";
            this._parallelSearchButton.UseVisualStyleBackColor = true;
            this._parallelSearchButton.Click += new System.EventHandler(this.ParallelSearch);
            // 
            // _searchTime
            // 
            this._searchTime.AutoSize = true;
            this._searchTime.Location = new System.Drawing.Point(269, 45);
            this._searchTime.Name = "_searchTime";
            this._searchTime.Size = new System.Drawing.Size(116, 15);
            this._searchTime.TabIndex = 1;
            this._searchTime.Text = "Время поиска слов:";
            // 
            // _parallelSearchTime
            // 
            this._parallelSearchTime.AutoSize = true;
            this._parallelSearchTime.Location = new System.Drawing.Point(269, 74);
            this._parallelSearchTime.Name = "_parallelSearchTime";
            this._parallelSearchTime.Size = new System.Drawing.Size(175, 15);
            this._parallelSearchTime.TabIndex = 1;
            this._parallelSearchTime.Text = "Время параллельного поиска:";
            // 
            // _wordsAmount
            // 
            this._wordsAmount.AutoSize = true;
            this._wordsAmount.Location = new System.Drawing.Point(183, 16);
            this._wordsAmount.Name = "_wordsAmount";
            this._wordsAmount.Size = new System.Drawing.Size(104, 15);
            this._wordsAmount.TabIndex = 1;
            this._wordsAmount.Text = "Количество слов:";
            // 
            // _createReport
            // 
            this._createReport.AutoSize = true;
            this._createReport.Location = new System.Drawing.Point(457, 242);
            this._createReport.Name = "_createReport";
            this._createReport.Size = new System.Drawing.Size(93, 25);
            this._createReport.TabIndex = 9;
            this._createReport.Text = "Создать отчёт";
            this._createReport.UseVisualStyleBackColor = true;
            this._createReport.Click += new System.EventHandler(this.CreateReport);
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.Filter = "Текстовые файлы|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 279);
            this.Controls.Add(this._createReport);
            this.Controls.Add(this._wordsAmount);
            this.Controls.Add(this._parallelSearchTime);
            this.Controls.Add(this._searchTime);
            this.Controls.Add(this._parallelSearchButton);
            this.Controls.Add(this._maxThreadsTextbox);
            this.Controls.Add(this._distTextBox);
            this.Controls.Add(this._listBox);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._textLoadingTime);
            this.Controls.Add(this._readTextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _readTextButton;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Label _textLoadingTime;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ListView _listBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox _distTextBox;
        private System.Windows.Forms.TextBox _maxThreadsTextbox;
        private System.Windows.Forms.Button _parallelSearchButton;
        private System.Windows.Forms.Label _searchTime;
        private System.Windows.Forms.Label _parallelSearchTime;
        private System.Windows.Forms.Label _wordsAmount;
        private System.Windows.Forms.Button _createReport;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
    }
}

