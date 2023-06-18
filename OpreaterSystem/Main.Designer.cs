namespace OpreaterSystem
{
    partial class Main
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
            this.btnSortFile = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortFile
            // 
            this.btnSortFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnSortFile.ForeColor = System.Drawing.Color.White;
            this.btnSortFile.Location = new System.Drawing.Point(4, 74);
            this.btnSortFile.Name = "btnSortFile";
            this.btnSortFile.Size = new System.Drawing.Size(265, 39);
            this.btnSortFile.TabIndex = 0;
            this.btnSortFile.Text = "Sort File";
            this.btnSortFile.UseVisualStyleBackColor = false;
            this.btnSortFile.Click += new System.EventHandler(this.butSortFile);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnText.ForeColor = System.Drawing.Color.White;
            this.btnText.Location = new System.Drawing.Point(4, 164);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(265, 39);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Select All Text";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search in file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnCount.ForeColor = System.Drawing.Color.White;
            this.btnCount.Location = new System.Drawing.Point(4, 209);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(265, 39);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count Text";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 275);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnSortFile);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortFile;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCount;
    }
}

