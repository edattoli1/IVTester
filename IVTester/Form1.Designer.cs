namespace IVTester
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
            this.getReadingButton = new System.Windows.Forms.Button();
            this.presRdgBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getReadingButton
            // 
            this.getReadingButton.Location = new System.Drawing.Point(44, 106);
            this.getReadingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getReadingButton.Name = "getReadingButton";
            this.getReadingButton.Size = new System.Drawing.Size(100, 28);
            this.getReadingButton.TabIndex = 0;
            this.getReadingButton.Text = "Get Reading";
            this.getReadingButton.UseVisualStyleBackColor = true;
            this.getReadingButton.Click += new System.EventHandler(this.getReadingButton_Click);
            // 
            // presRdgBox
            // 
            this.presRdgBox.Location = new System.Drawing.Point(179, 108);
            this.presRdgBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presRdgBox.Name = "presRdgBox";
            this.presRdgBox.ReadOnly = true;
            this.presRdgBox.Size = new System.Drawing.Size(132, 22);
            this.presRdgBox.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(44, 39);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.presRdgBox);
            this.Controls.Add(this.getReadingButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getReadingButton;
        private System.Windows.Forms.TextBox presRdgBox;
        private System.Windows.Forms.Button resetButton;
    }
}

