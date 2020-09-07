namespace Lab4
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
            this._label = new System.Windows.Forms.Label();
            this._textBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _readTextButton
            // 
            this._readTextButton.AutoSize = true;
            this._readTextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._readTextButton.Location = new System.Drawing.Point(21, 244);
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
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(12, 226);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(132, 15);
            this._label.TabIndex = 1;
            this._label.Text = "Время загрузки текста:";
            this._label.Visible = false;
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(12, 13);
            this._textBox.Name = "_textBox";
            this._textBox.PlaceholderText = "Введите слово для поиска...";
            this._textBox.Size = new System.Drawing.Size(169, 23);
            this._textBox.TabIndex = 2;
            // 
            // _searchButton
            // 
            this._searchButton.Enabled = false;
            this._searchButton.Location = new System.Drawing.Point(106, 42);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 3;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this.SearchForWord);
            // 
            // _listBox
            // 
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 15;
            this._listBox.Location = new System.Drawing.Point(12, 76);
            this._listBox.Name = "_listBox";
            this._listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBox.Size = new System.Drawing.Size(169, 124);
            this._listBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 281);
            this.Controls.Add(this._listBox);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._label);
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
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ListBox _listBox;
    }
}

