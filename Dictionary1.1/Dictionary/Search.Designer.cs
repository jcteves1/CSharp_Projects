
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
            this.tbSearchSearch = new System.Windows.Forms.TextBox();
            this.btnSearchSearch = new System.Windows.Forms.Button();
            this.llbSearchBack = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.lbSearchSearchWarning = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSearchSearch
            // 
            this.tbSearchSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchSearch.Location = new System.Drawing.Point(32, 34);
            this.tbSearchSearch.Name = "tbSearchSearch";
            this.tbSearchSearch.Size = new System.Drawing.Size(259, 20);
            this.tbSearchSearch.TabIndex = 3;
            this.tbSearchSearch.TextChanged += new System.EventHandler(this.tbSearchSearch_TextChanged);
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
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbResult.Location = new System.Drawing.Point(32, 91);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(340, 173);
            this.tbResult.TabIndex = 12;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(29, 75);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 13;
            this.lbResult.Text = "Result";
            // 
            // formSearchWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbSearchSearchWarning);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbSearchBack);
            this.Controls.Add(this.btnSearchSearch);
            this.Controls.Add(this.tbSearchSearch);
            this.MaximumSize = new System.Drawing.Size(415, 700);
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
        private System.Windows.Forms.TextBox tbSearchSearch;
        private System.Windows.Forms.Button btnSearchSearch;
        private System.Windows.Forms.LinkLabel llbSearchBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label lbSearchSearchWarning;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
    }
}