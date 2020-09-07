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
            this._listBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this._distTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _readTextButton
            // 
            this._readTextButton.AutoSize = true;
            this._readTextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._readTextButton.Location = new System.Drawing.Point(45, 244);
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
            this._label.Location = new System.Drawing.Point(43, 208);
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
            this._textBox.Size = new System.Drawing.Size(200, 23);
            this._textBox.TabIndex = 2;
            // 
            // _searchButton
            // 
            this._searchButton.Enabled = false;
            this._searchButton.Location = new System.Drawing.Point(137, 42);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
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
            this._listBox.Location = new System.Drawing.Point(12, 71);
            this._listBox.Name = "_listBox";
            this._listBox.ShowGroups = false;
            this._listBox.Size = new System.Drawing.Size(200, 134);
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
            this._distTextBox.Location = new System.Drawing.Point(12, 42);
            this._distTextBox.MaxLength = 7;
            this._distTextBox.Name = "_distTextBox";
            this._distTextBox.PlaceholderText = "Макс. дистанция";
            this._distTextBox.Size = new System.Drawing.Size(120, 23);
            this._distTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 281);
            this.Controls.Add(this._distTextBox);
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
        private System.Windows.Forms.ListView _listBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox _distTextBox;
    }
}

