namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbMobileNo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMobileNo = new System.Windows.Forms.TextBox();
            this.lbMobileNoWarning = new System.Windows.Forms.Label();
            this.lbNameWarning = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(70, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbMobileNo
            // 
            this.lbMobileNo.AutoSize = true;
            this.lbMobileNo.Location = new System.Drawing.Point(70, 131);
            this.lbMobileNo.Name = "lbMobileNo";
            this.lbMobileNo.Size = new System.Drawing.Size(69, 16);
            this.lbMobileNo.TabIndex = 1;
            this.lbMobileNo.Text = "Mobile no.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(93, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(166, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(247, 22);
            this.tbName.TabIndex = 3;
            // 
            // tbMobileNo
            // 
            this.tbMobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMobileNo.Location = new System.Drawing.Point(166, 128);
            this.tbMobileNo.Name = "tbMobileNo";
            this.tbMobileNo.Size = new System.Drawing.Size(247, 22);
            this.tbMobileNo.TabIndex = 4;
            // 
            // lbMobileNoWarning
            // 
            this.lbMobileNoWarning.AutoSize = true;
            this.lbMobileNoWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMobileNoWarning.ForeColor = System.Drawing.Color.Red;
            this.lbMobileNoWarning.Location = new System.Drawing.Point(165, 154);
            this.lbMobileNoWarning.Name = "lbMobileNoWarning";
            this.lbMobileNoWarning.Size = new System.Drawing.Size(41, 15);
            this.lbMobileNoWarning.TabIndex = 5;
            this.lbMobileNoWarning.Text = "label1";
            // 
            // lbNameWarning
            // 
            this.lbNameWarning.AutoSize = true;
            this.lbNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lbNameWarning.Location = new System.Drawing.Point(165, 104);
            this.lbNameWarning.Name = "lbNameWarning";
            this.lbNameWarning.Size = new System.Drawing.Size(41, 15);
            this.lbNameWarning.TabIndex = 6;
            this.lbNameWarning.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbNameWarning);
            this.Controls.Add(this.lbMobileNoWarning);
            this.Controls.Add(this.tbMobileNo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbMobileNo);
            this.Controls.Add(this.lbName);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Mobile Number Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMobileNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMobileNo;
        private System.Windows.Forms.Label lbMobileNoWarning;
        private System.Windows.Forms.Label lbNameWarning;
        private System.Windows.Forms.Button btnClear;
    }
}

