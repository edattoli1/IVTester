namespace IVTester
{
    partial class DaqConfigForm
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
            this.daqOutSelectComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daqOutSelectComboBox2 = new System.Windows.Forms.ComboBox();
            this.daqConfigSaveExit = new System.Windows.Forms.Button();
            this.daqConfigExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daqOutSelectComboBox1
            // 
            this.daqOutSelectComboBox1.FormattingEnabled = true;
            this.daqOutSelectComboBox1.Location = new System.Drawing.Point(141, 24);
            this.daqOutSelectComboBox1.Name = "daqOutSelectComboBox1";
            this.daqOutSelectComboBox1.Size = new System.Drawing.Size(162, 24);
            this.daqOutSelectComboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analog Out 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Analog Out 2:";
            // 
            // daqOutSelectComboBox2
            // 
            this.daqOutSelectComboBox2.FormattingEnabled = true;
            this.daqOutSelectComboBox2.Location = new System.Drawing.Point(141, 62);
            this.daqOutSelectComboBox2.Name = "daqOutSelectComboBox2";
            this.daqOutSelectComboBox2.Size = new System.Drawing.Size(162, 24);
            this.daqOutSelectComboBox2.TabIndex = 3;
            // 
            // daqConfigSaveExit
            // 
            this.daqConfigSaveExit.Location = new System.Drawing.Point(25, 211);
            this.daqConfigSaveExit.Name = "daqConfigSaveExit";
            this.daqConfigSaveExit.Size = new System.Drawing.Size(130, 23);
            this.daqConfigSaveExit.TabIndex = 4;
            this.daqConfigSaveExit.Text = "Save && Close";
            this.daqConfigSaveExit.UseVisualStyleBackColor = true;
            this.daqConfigSaveExit.Click += new System.EventHandler(this.daqConfigSaveExit_Click);
            // 
            // daqConfigExit
            // 
            this.daqConfigExit.Location = new System.Drawing.Point(228, 211);
            this.daqConfigExit.Name = "daqConfigExit";
            this.daqConfigExit.Size = new System.Drawing.Size(75, 23);
            this.daqConfigExit.TabIndex = 5;
            this.daqConfigExit.Text = "Cancel";
            this.daqConfigExit.UseVisualStyleBackColor = true;
            // 
            // DaqConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 255);
            this.Controls.Add(this.daqConfigExit);
            this.Controls.Add(this.daqConfigSaveExit);
            this.Controls.Add(this.daqOutSelectComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daqOutSelectComboBox1);
            this.Name = "DaqConfigForm";
            this.Text = "DaqConfigForm";
            this.Load += new System.EventHandler(this.DaqConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox daqOutSelectComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox daqOutSelectComboBox2;
        private System.Windows.Forms.Button daqConfigSaveExit;
        private System.Windows.Forms.Button daqConfigExit;
    }
}