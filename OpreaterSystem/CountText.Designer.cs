namespace OpreaterSystem
{
    partial class CountText
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
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbChar = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Enabled = false;
            this.tbFile.Location = new System.Drawing.Point(146, 42);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(404, 30);
            this.tbFile.TabIndex = 0;
            this.tbFile.TextChanged += new System.EventHandler(this.tbFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select File";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(556, 42);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(58, 30);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(205, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Count Line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(205, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Count Character";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.ForeColor = System.Drawing.Color.White;
            this.lbLine.Location = new System.Drawing.Point(389, 166);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(20, 23);
            this.lbLine.TabIndex = 8;
            this.lbLine.Text = "0";
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.ForeColor = System.Drawing.Color.White;
            this.lbWord.Location = new System.Drawing.Point(389, 217);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(20, 23);
            this.lbWord.TabIndex = 9;
            this.lbWord.Text = "0";
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.ForeColor = System.Drawing.Color.White;
            this.lbChar.Location = new System.Drawing.Point(389, 266);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(20, 23);
            this.lbChar.TabIndex = 10;
            this.lbChar.Text = "0";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.White;
            this.btnCount.Enabled = false;
            this.btnCount.Location = new System.Drawing.Point(260, 98);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(81, 33);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // CountText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(643, 347);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lbChar);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFile);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CountText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountText";
            this.Load += new System.EventHandler(this.CountText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.Button btnCount;
    }
}