
namespace Dictionary
{
    partial class formSearchWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSearchWord = new System.Windows.Forms.Label();
            this.lbSearchDef = new System.Windows.Forms.Label();
            this.tbSearchSearch = new System.Windows.Forms.TextBox();
            this.btnSearchSearch = new System.Windows.Forms.Button();
            this.lbSearchDate = new System.Windows.Forms.Label();
            this.llbSearchBack = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.lbSearchSearchWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSearchWord
            // 
            this.lbSearchWord.AutoSize = true;
            this.lbSearchWord.Location = new System.Drawing.Point(32, 94);
            this.lbSearchWord.Name = "lbSearchWord";
            this.lbSearchWord.Size = new System.Drawing.Size(33, 13);
            this.lbSearchWord.TabIndex = 1;
            this.lbSearchWord.Text = "Word";
            // 
            // lbSearchDef
            // 
            this.lbSearchDef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchDef.AutoEllipsis = true;
            this.lbSearchDef.Location = new System.Drawing.Point(32, 120);
            this.lbSearchDef.Name = "lbSearchDef";
            this.lbSearchDef.Size = new System.Drawing.Size(340, 137);
            this.lbSearchDef.TabIndex = 2;
            this.lbSearchDef.Text = "Definition";
            this.lbSearchDef.UseMnemonic = false;
            // 
            // tbSearchSearch
            // 
            this.tbSearchSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "beeeeeeeeeeeeeettt",
            "bettetet",
            "beteeet"});
            this.tbSearchSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSearchSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchSearch.Location = new System.Drawing.Point(32, 34);
            this.tbSearchSearch.Name = "tbSearchSearch";
            this.tbSearchSearch.Size = new System.Drawing.Size(259, 13);
            this.tbSearchSearch.TabIndex = 3;
            // 
            // btnSearchSearch
            // 
            this.btnSearchSearch.Location = new System.Drawing.Point(297, 32);
            this.btnSearchSearch.Name = "btnSearchSearch";
            this.btnSearchSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSearch.TabIndex = 4;
            this.btnSearchSearch.Text = "Search";
            this.btnSearchSearch.UseVisualStyleBackColor = true;
            this.btnSearchSearch.Click += new System.EventHandler(this.btnSearchSearch_Click);
            // 
            // lbSearchDate
            // 
            this.lbSearchDate.AutoSize = true;
            this.lbSearchDate.Location = new System.Drawing.Point(294, 94);
            this.lbSearchDate.Name = "lbSearchDate";
            this.lbSearchDate.Size = new System.Drawing.Size(30, 13);
            this.lbSearchDate.TabIndex = 5;
            this.lbSearchDate.Text = "Date";
            // 
            // llbSearchBack
            // 
            this.llbSearchBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbSearchBack.AutoSize = true;
            this.llbSearchBack.Location = new System.Drawing.Point(12, 279);
            this.llbSearchBack.Name = "llbSearchBack";
            this.llbSearchBack.Size = new System.Drawing.Size(75, 13);
            this.llbSearchBack.TabIndex = 8;
            this.llbSearchBack.TabStop = true;
            this.llbSearchBack.Text = "Back to Home";
            this.llbSearchBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSearchBack_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Word Here";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearchClear.Location = new System.Drawing.Point(297, 270);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClear.TabIndex = 10;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // lbSearchSearchWarning
            // 
            this.lbSearchSearchWarning.AutoSize = true;
            this.lbSearchSearchWarning.ForeColor = System.Drawing.Color.Red;
            this.lbSearchSearchWarning.Location = new System.Drawing.Point(29, 57);
            this.lbSearchSearchWarning.Name = "lbSearchSearchWarning";
            this.lbSearchSearchWarning.Size = new System.Drawing.Size(35, 13);
            this.lbSearchSearchWarning.TabIndex = 11;
            this.lbSearchSearchWarning.Text = "label2";
            // 
            // formSearchWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.lbSearchSearchWarning);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbSearchBack);
            this.Controls.Add(this.lbSearchDate);
            this.Controls.Add(this.btnSearchSearch);
            this.Controls.Add(this.tbSearchSearch);
            this.Controls.Add(this.lbSearchDef);
            this.Controls.Add(this.lbSearchWord);
            this.MaximumSize = new System.Drawing.Size(415, 1000);
            this.MinimumSize = new System.Drawing.Size(415, 340);
            this.Name = "formSearchWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSearchWord_FormClosed);
            this.Load += new System.EventHandler(this.formSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearchWord;
        private System.Windows.Forms.Label lbSearchDef;
        private System.Windows.Forms.TextBox tbSearchSearch;
        private System.Windows.Forms.Button btnSearchSearch;
        private System.Windows.Forms.Label lbSearchDate;
        private System.Windows.Forms.LinkLabel llbSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label lbSearchSearchWarning;
    }
}