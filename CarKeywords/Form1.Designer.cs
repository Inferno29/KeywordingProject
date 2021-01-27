
namespace CarKeywords
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.keywordList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBoxEnglish = new System.Windows.Forms.CheckedListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.listViewKeywords = new System.Windows.Forms.ListView();
            this.IdColumn = new System.Windows.Forms.ColumnHeader();
            this.keywordsColumn = new System.Windows.Forms.ColumnHeader();
            this.ExportButton = new System.Windows.Forms.Button();
            this.appendButton = new System.Windows.Forms.Button();
            this.GermanTextBox = new System.Windows.Forms.TextBox();
            this.GermanSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // carPictureBox
            // 
            this.carPictureBox.Location = new System.Drawing.Point(79, 86);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(294, 252);
            this.carPictureBox.TabIndex = 0;
            this.carPictureBox.TabStop = false;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(79, 384);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(141, 29);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(219, 384);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // keywordList
            // 
            this.keywordList.FormattingEnabled = true;
            this.keywordList.ItemHeight = 20;
            this.keywordList.Location = new System.Drawing.Point(881, 127);
            this.keywordList.Name = "keywordList";
            this.keywordList.Size = new System.Drawing.Size(243, 324);
            this.keywordList.TabIndex = 4;
            this.keywordList.SelectedIndexChanged += new System.EventHandler(this.keywordList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected Keywords";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "remove selected item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "remove all items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBoxEnglish
            // 
            this.checkedListBoxEnglish.FormattingEnabled = true;
            this.checkedListBoxEnglish.Location = new System.Drawing.Point(407, 86);
            this.checkedListBoxEnglish.Name = "checkedListBoxEnglish";
            this.checkedListBoxEnglish.Size = new System.Drawing.Size(434, 466);
            this.checkedListBoxEnglish.TabIndex = 10;
            this.checkedListBoxEnglish.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(407, 48);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(189, 27);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(606, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // listViewKeywords
            // 
            this.listViewKeywords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.keywordsColumn});
            this.listViewKeywords.GridLines = true;
            this.listViewKeywords.HideSelection = false;
            this.listViewKeywords.Location = new System.Drawing.Point(1163, 48);
            this.listViewKeywords.Name = "listViewKeywords";
            this.listViewKeywords.Size = new System.Drawing.Size(611, 506);
            this.listViewKeywords.TabIndex = 14;
            this.listViewKeywords.UseCompatibleStateImageBehavior = false;
            this.listViewKeywords.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 150;
            // 
            // keywordsColumn
            // 
            this.keywordsColumn.Text = "German Keywords";
            this.keywordsColumn.Width = 800;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1163, 575);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(199, 29);
            this.ExportButton.TabIndex = 15;
            this.ExportButton.Text = "Export to .csv";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(1574, 575);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(200, 29);
            this.appendButton.TabIndex = 16;
            this.appendButton.Text = "Add to existing csv file";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // GermanTextBox
            // 
            this.GermanTextBox.Location = new System.Drawing.Point(407, 13);
            this.GermanTextBox.Name = "GermanTextBox";
            this.GermanTextBox.Size = new System.Drawing.Size(189, 27);
            this.GermanTextBox.TabIndex = 17;
            // 
            // GermanSearchButton
            // 
            this.GermanSearchButton.Location = new System.Drawing.Point(606, 13);
            this.GermanSearchButton.Name = "GermanSearchButton";
            this.GermanSearchButton.Size = new System.Drawing.Size(94, 29);
            this.GermanSearchButton.TabIndex = 18;
            this.GermanSearchButton.Text = "Search";
            this.GermanSearchButton.UseVisualStyleBackColor = true;
            this.GermanSearchButton.Click += new System.EventHandler(this.GermanSearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2108, 1325);
            this.Controls.Add(this.GermanSearchButton);
            this.Controls.Add(this.GermanTextBox);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.listViewKeywords);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.checkedListBoxEnglish);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keywordList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.carPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Keywords";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox keywordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBoxEnglish;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView listViewKeywords;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader Keywrds;
        private System.Windows.Forms.ColumnHeader germanKeywords;
        private System.Windows.Forms.ColumnHeader keywordsColumn;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.TextBox GermanTextBox;
        private System.Windows.Forms.Button GermanSearchButton;
    }
}

