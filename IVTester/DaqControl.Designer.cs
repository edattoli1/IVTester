namespace IVTester
{
    partial class DaqControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.daqConfigureButton = new System.Windows.Forms.Button();
            this.daqEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.daqEnableCheckBox);
            this.panel1.Controls.Add(this.daqConfigureButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 222);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "DAQ CONTROL";
            // 
            // daqConfigureButton
            // 
            this.daqConfigureButton.Location = new System.Drawing.Point(339, 170);
            this.daqConfigureButton.Name = "daqConfigureButton";
            this.daqConfigureButton.Size = new System.Drawing.Size(84, 32);
            this.daqConfigureButton.TabIndex = 16;
            this.daqConfigureButton.Text = "Configure";
            this.daqConfigureButton.UseVisualStyleBackColor = true;
            this.daqConfigureButton.Click += new System.EventHandler(this.daqConfigureButton_Click);
            // 
            // daqEnableCheckBox
            // 
            this.daqEnableCheckBox.AutoSize = true;
            this.daqEnableCheckBox.Location = new System.Drawing.Point(13, 43);
            this.daqEnableCheckBox.Name = "daqEnableCheckBox";
            this.daqEnableCheckBox.Size = new System.Drawing.Size(74, 21);
            this.daqEnableCheckBox.TabIndex = 17;
            this.daqEnableCheckBox.Text = "Enable";
            this.daqEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // DaqControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DaqControl";
            this.Size = new System.Drawing.Size(464, 229);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button daqConfigureButton;
        private System.Windows.Forms.CheckBox daqEnableCheckBox;
    }
}
