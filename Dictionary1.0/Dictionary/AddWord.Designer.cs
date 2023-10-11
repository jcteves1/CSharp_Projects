
namespace Dictionary
{
    partial class formAddWord
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
            this.lbWord_Add = new System.Windows.Forms.Label();
            this.lbDefinition_Add = new System.Windows.Forms.Label();
            this.tbAddDef = new System.Windows.Forms.TextBox();
            this.tbAddWord = new System.Windows.Forms.TextBox();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.llbAddBack = new System.Windows.Forms.LinkLabel();
            this.cmbAddPoS = new System.Windows.Forms.ComboBox();
            this.lbAddPoS = new System.Windows.Forms.Label();
            this.lbAddWordWarning = new System.Windows.Forms.Label();
            this.lbAddDefWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWord_Add
            // 
            this.lbWord_Add.AutoSize = true;
            this.lbWord_Add.Location = new System.Drawing.Point(33, 32);
            this.lbWord_Add.Name = "lbWord_Add";
            this.lbWord_Add.Size = new System.Drawing.Size(33, 13);
            this.lbWord_Add.TabIndex = 0;
            this.lbWord_Add.Text = "Word";
            // 
            // lbDefinition_Add
            // 
            this.lbDefinition_Add.AutoSize = true;
            this.lbDefinition_Add.Location = new System.Drawing.Point(356, 33);
            this.lbDefinition_Add.Name = "lbDefinition_Add";
            this.lbDefinition_Add.Size = new System.Drawing.Size(51, 13);
            this.lbDefinition_Add.TabIndex = 1;
            this.lbDefinition_Add.Text = "Definition";
            // 
            // tbAddDef
            // 
            this.tbAddDef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAddDef.Location = new System.Drawing.Point(420, 30);
            this.tbAddDef.Multiline = true;
            this.tbAddDef.Name = "tbAddDef";
            this.tbAddDef.Size = new System.Drawing.Size(244, 208);
            this.tbAddDef.TabIndex = 3;
            // 
            // tbAddWord
            // 
            this.tbAddWord.Location = new System.Drawing.Point(89, 29);
            this.tbAddWord.Multiline = true;
            this.tbAddWord.Name = "tbAddWord";
            this.tbAddWord.Size = new System.Drawing.Size(244, 20);
            this.tbAddWord.TabIndex = 4;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAdd.Location = new System.Drawing.Point(568, 266);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdd.TabIndex = 5;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddClear.Location = new System.Drawing.Point(446, 266);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 6;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // llbAddBack
            // 
            this.llbAddBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbAddBack.AutoSize = true;
            this.llbAddBack.Location = new System.Drawing.Point(12, 276);
            this.llbAddBack.Name = "llbAddBack";
            this.llbAddBack.Size = new System.Drawing.Size(75, 13);
            this.llbAddBack.TabIndex = 7;
            this.llbAddBack.TabStop = true;
            this.llbAddBack.Text = "Back to Home";
            this.llbAddBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAddBack_LinkClicked);
            // 
            // cmbAddPoS
            // 
            this.cmbAddPoS.FormattingEnabled = true;
            this.cmbAddPoS.Items.AddRange(new object[] {
            "noun",
            "verb",
            "adjective"});
            this.cmbAddPoS.Location = new System.Drawing.Point(125, 71);
            this.cmbAddPoS.Name = "cmbAddPoS";
            this.cmbAddPoS.Size = new System.Drawing.Size(208, 21);
            this.cmbAddPoS.TabIndex = 8;
            // 
            // lbAddPoS
            // 
            this.lbAddPoS.AutoSize = true;
            this.lbAddPoS.Location = new System.Drawing.Point(33, 74);
            this.lbAddPoS.Name = "lbAddPoS";
            this.lbAddPoS.Size = new System.Drawing.Size(78, 13);
            this.lbAddPoS.TabIndex = 9;
            this.lbAddPoS.Text = "Part of Speech";
            this.lbAddPoS.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAddWordWarning
            // 
            this.lbAddWordWarning.AutoSize = true;
            this.lbAddWordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbAddWordWarning.Location = new System.Drawing.Point(86, 52);
            this.lbAddWordWarning.Name = "lbAddWordWarning";
            this.lbAddWordWarning.Size = new System.Drawing.Size(35, 13);
            this.lbAddWordWarning.TabIndex = 10;
            this.lbAddWordWarning.Text = "label1";
            // 
            // lbAddDefWarning
            // 
            this.lbAddDefWarning.AutoSize = true;
            this.lbAddDefWarning.ForeColor = System.Drawing.Color.Red;
            this.lbAddDefWarning.Location = new System.Drawing.Point(417, 241);
            this.lbAddDefWarning.Name = "lbAddDefWarning";
            this.lbAddDefWarning.Size = new System.Drawing.Size(35, 13);
            this.lbAddDefWarning.TabIndex = 11;
            this.lbAddDefWarning.Text = "label1";
            // 
            // formAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 301);
            this.Controls.Add(this.lbAddDefWarning);
            this.Controls.Add(this.lbAddWordWarning);
            this.Controls.Add(this.lbAddPoS);
            this.Controls.Add(this.cmbAddPoS);
            this.Controls.Add(this.llbAddBack);
            this.Controls.Add(this.btnAddClear);
            this.Controls.Add(this.btnAddAdd);
            this.Controls.Add(this.tbAddWord);
            this.Controls.Add(this.tbAddDef);
            this.Controls.Add(this.lbDefinition_Add);
            this.Controls.Add(this.lbWord_Add);
            this.MaximumSize = new System.Drawing.Size(700, 1000);
            this.MinimumSize = new System.Drawing.Size(700, 340);
            this.Name = "formAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAddWord_FormClosed);
            this.Load += new System.EventHandler(this.formAddWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWord_Add;
        private System.Windows.Forms.Label lbDefinition_Add;
        private System.Windows.Forms.TextBox tbAddDef;
        private System.Windows.Forms.TextBox tbAddWord;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.LinkLabel llbAddBack;
        private System.Windows.Forms.ComboBox cmbAddPoS;
        private System.Windows.Forms.Label lbAddPoS;
        private System.Windows.Forms.Label lbAddWordWarning;
        private System.Windows.Forms.Label lbAddDefWarning;
    }
}