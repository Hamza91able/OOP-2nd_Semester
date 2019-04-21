namespace Temperature_Conversion
{
    partial class MainWind
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
            this.CtextBox = new System.Windows.Forms.RichTextBox();
            this.FtextBox = new System.Windows.Forms.RichTextBox();
            this.CenLabel = new System.Windows.Forms.Label();
            this.FenLabel = new System.Windows.Forms.Label();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CtextBox
            // 
            this.CtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtextBox.ForeColor = System.Drawing.Color.Blue;
            this.CtextBox.Location = new System.Drawing.Point(126, 11);
            this.CtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CtextBox.Name = "CtextBox";
            this.CtextBox.Size = new System.Drawing.Size(92, 21);
            this.CtextBox.TabIndex = 0;
            this.CtextBox.Text = "";
            this.CtextBox.TextChanged += new System.EventHandler(this.CtextBox_TextChanged);
            // 
            // FtextBox
            // 
            this.FtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtextBox.ForeColor = System.Drawing.Color.Red;
            this.FtextBox.Location = new System.Drawing.Point(126, 56);
            this.FtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FtextBox.Name = "FtextBox";
            this.FtextBox.Size = new System.Drawing.Size(92, 21);
            this.FtextBox.TabIndex = 1;
            this.FtextBox.Text = "";
            this.FtextBox.TextChanged += new System.EventHandler(this.FtextBox_TextChanged);
            // 
            // CenLabel
            // 
            this.CenLabel.AutoSize = true;
            this.CenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenLabel.Location = new System.Drawing.Point(8, 9);
            this.CenLabel.Name = "CenLabel";
            this.CenLabel.Size = new System.Drawing.Size(112, 24);
            this.CenLabel.TabIndex = 2;
            this.CenLabel.Text = "Centigrade";
            // 
            // FenLabel
            // 
            this.FenLabel.AutoSize = true;
            this.FenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FenLabel.Location = new System.Drawing.Point(8, 54);
            this.FenLabel.Name = "FenLabel";
            this.FenLabel.Size = new System.Drawing.Size(111, 24);
            this.FenLabel.TabIndex = 3;
            this.FenLabel.Text = "Fahrenhite";
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Location = new System.Drawing.Point(12, 95);
            this.CtoF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(149, 17);
            this.CtoF.TabIndex = 4;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "Centigrade into Fahrenhite";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.CheckedChanged += new System.EventHandler(this.CtoF_CheckedChanged);
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(12, 117);
            this.FtoC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(149, 17);
            this.FtoC.TabIndex = 5;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "Fahrenhite into Centigrade";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.CheckedChanged += new System.EventHandler(this.FtoC_CheckedChanged);
            // 
            // MainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 147);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.FenLabel);
            this.Controls.Add(this.CenLabel);
            this.Controls.Add(this.FtextBox);
            this.Controls.Add(this.CtextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temeperature Conversion";
            this.Load += new System.EventHandler(this.MainWind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CtextBox;
        private System.Windows.Forms.RichTextBox FtextBox;
        private System.Windows.Forms.Label CenLabel;
        private System.Windows.Forms.Label FenLabel;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.RadioButton FtoC;

    }
}

