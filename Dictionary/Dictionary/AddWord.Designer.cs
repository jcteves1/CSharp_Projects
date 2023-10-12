
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
            this.lbAddWordWarning = new System.Windows.Forms.Label();
            this.lbAddDefWarning = new System.Windows.Forms.Label();
            this.llbExample = new System.Windows.Forms.LinkLabel();
            this.lbWordFormat = new System.Windows.Forms.Label();
            this.tbDefFormat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWord_Add
            // 
            this.lbWord_Add.AutoSize = true;
            this.lbWord_Add.Location = new System.Drawing.Point(44, 39);
            this.lbWord_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWord_Add.Name = "lbWord_Add";
            this.lbWord_Add.Size = new System.Drawing.Size(40, 16);
            this.lbWord_Add.TabIndex = 0;
            this.lbWord_Add.Text = "Word";
            // 
            // lbDefinition_Add
            // 
            this.lbDefinition_Add.AutoSize = true;
            this.lbDefinition_Add.Location = new System.Drawing.Point(33, 87);
            this.lbDefinition_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDefinition_Add.Name = "lbDefinition_Add";
            this.lbDefinition_Add.Size = new System.Drawing.Size(62, 16);
            this.lbDefinition_Add.TabIndex = 1;
            this.lbDefinition_Add.Text = "Definition";
            // 
            // tbAddDef
            // 
            this.tbAddDef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAddDef.ForeColor = System.Drawing.Color.Black;
            this.tbAddDef.Location = new System.Drawing.Point(119, 84);
            this.tbAddDef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddDef.Multiline = true;
            this.tbAddDef.Name = "tbAddDef";
            this.tbAddDef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAddDef.Size = new System.Drawing.Size(357, 275);
            this.tbAddDef.TabIndex = 3;
            this.tbAddDef.Click += new System.EventHandler(this.tbAddDef_Click);
            this.tbAddDef.TextChanged += new System.EventHandler(this.tbAddDef_TextChanged);
            // 
            // tbAddWord
            // 
            this.tbAddWord.Location = new System.Drawing.Point(119, 36);
            this.tbAddWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddWord.Multiline = true;
            this.tbAddWord.Name = "tbAddWord";
            this.tbAddWord.Size = new System.Drawing.Size(357, 24);
            this.tbAddWord.TabIndex = 4;
            this.tbAddWord.Click += new System.EventHandler(this.tbAddWord_Click);
            this.tbAddWord.TextChanged += new System.EventHandler(this.tbAddWord_TextChanged);
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAdd.Location = new System.Drawing.Point(377, 402);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAddAdd.TabIndex = 5;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddClear.Location = new System.Drawing.Point(256, 402);
            this.btnAddClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(100, 28);
            this.btnAddClear.TabIndex = 6;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // llbAddBack
            // 
            this.llbAddBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbAddBack.AutoSize = true;
            this.llbAddBack.Location = new System.Drawing.Point(7, 409);
            this.llbAddBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbAddBack.Name = "llbAddBack";
            this.llbAddBack.Size = new System.Drawing.Size(92, 16);
            this.llbAddBack.TabIndex = 7;
            this.llbAddBack.TabStop = true;
            this.llbAddBack.Text = "Back to Home";
            this.llbAddBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAddBack_LinkClicked);
            // 
            // lbAddWordWarning
            // 
            this.lbAddWordWarning.AutoSize = true;
            this.lbAddWordWarning.ForeColor = System.Drawing.Color.Red;
            this.lbAddWordWarning.Location = new System.Drawing.Point(115, 64);
            this.lbAddWordWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddWordWarning.Name = "lbAddWordWarning";
            this.lbAddWordWarning.Size = new System.Drawing.Size(93, 16);
            this.lbAddWordWarning.TabIndex = 10;
            this.lbAddWordWarning.Text = "Word Warning";
            // 
            // lbAddDefWarning
            // 
            this.lbAddDefWarning.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbAddDefWarning.AutoSize = true;
            this.lbAddDefWarning.ForeColor = System.Drawing.Color.Red;
            this.lbAddDefWarning.Location = new System.Drawing.Point(115, 363);
            this.lbAddDefWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddDefWarning.Name = "lbAddDefWarning";
            this.lbAddDefWarning.Size = new System.Drawing.Size(115, 16);
            this.lbAddDefWarning.TabIndex = 11;
            this.lbAddDefWarning.Text = "Definition Warning";
            // 
            // llbExample
            // 
            this.llbExample.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbExample.AutoSize = true;
            this.llbExample.Location = new System.Drawing.Point(111, 409);
            this.llbExample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbExample.Name = "llbExample";
            this.llbExample.Size = new System.Drawing.Size(119, 16);
            this.llbExample.TabIndex = 12;
            this.llbExample.TabStop = true;
            this.llbExample.Text = "Generate Example";
            this.llbExample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExample_LinkClicked);
            // 
            // lbWordFormat
            // 
            this.lbWordFormat.BackColor = System.Drawing.Color.White;
            this.lbWordFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordFormat.ForeColor = System.Drawing.Color.DimGray;
            this.lbWordFormat.Location = new System.Drawing.Point(120, 39);
            this.lbWordFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWordFormat.Name = "lbWordFormat";
            this.lbWordFormat.Size = new System.Drawing.Size(353, 18);
            this.lbWordFormat.TabIndex = 14;
            this.lbWordFormat.Text = "Word";
            this.lbWordFormat.Click += new System.EventHandler(this.lbWordFormat_Click);
            // 
            // tbDefFormat
            // 
            this.tbDefFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefFormat.BackColor = System.Drawing.Color.White;
            this.tbDefFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefFormat.ForeColor = System.Drawing.Color.DimGray;
            this.tbDefFormat.Location = new System.Drawing.Point(119, 84);
            this.tbDefFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDefFormat.Multiline = true;
            this.tbDefFormat.Name = "tbDefFormat";
            this.tbDefFormat.ReadOnly = true;
            this.tbDefFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDefFormat.Size = new System.Drawing.Size(357, 275);
            this.tbDefFormat.TabIndex = 15;
            this.tbDefFormat.Text = "Pronunciation\r\n\r\nPart of Speech\r\n1.Definition #1\r\n2.Definition #2\r\nExample Senten" +
    "ce: *Sentence*\r\n\r\nPart of Speech\r\n1.Definition #1\r\n2.Definition #2\r\nExample Sent" +
    "ence: *Sentence*";
            this.tbDefFormat.Click += new System.EventHandler(this.tbDefFormat_Click);
            // 
            // formAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 444);
            this.Controls.Add(this.tbDefFormat);
            this.Controls.Add(this.lbWordFormat);
            this.Controls.Add(this.llbExample);
            this.Controls.Add(this.lbAddDefWarning);
            this.Controls.Add(this.lbAddWordWarning);
            this.Controls.Add(this.llbAddBack);
            this.Controls.Add(this.btnAddClear);
            this.Controls.Add(this.btnAddAdd);
            this.Controls.Add(this.tbAddWord);
            this.Controls.Add(this.tbAddDef);
            this.Controls.Add(this.lbDefinition_Add);
            this.Controls.Add(this.lbWord_Add);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(527, 851);
            this.MinimumSize = new System.Drawing.Size(527, 481);
            this.Name = "formAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formAddWord_FormClosed);
            this.Load += new System.EventHandler(this.formAddWord_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formAddWord_MouseClick);
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
        private System.Windows.Forms.Label lbAddWordWarning;
        private System.Windows.Forms.Label lbAddDefWarning;
        private System.Windows.Forms.LinkLabel llbExample;
        private System.Windows.Forms.Label lbWordFormat;
        private System.Windows.Forms.TextBox tbDefFormat;
    }
}