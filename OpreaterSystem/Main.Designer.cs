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
            this.SuspendLayout();
            // 
            // btnSortFile
            // 
            this.btnSortFile.Location = new System.Drawing.Point(134, 76);
            this.btnSortFile.Name = "btnSortFile";
            this.btnSortFile.Size = new System.Drawing.Size(138, 39);
            this.btnSortFile.TabIndex = 0;
            this.btnSortFile.Text = "Sort File";
            this.btnSortFile.UseVisualStyleBackColor = true;
            this.btnSortFile.Click += new System.EventHandler(this.butSortFile);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(134, 137);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(138, 39);
            this.btnText.TabIndex = 1;
            this.btnText.Text = "Select All Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnSortFile);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortFile;
        private System.Windows.Forms.Button btnText;
    }
}

