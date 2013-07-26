namespace IVTester
{
    partial class CurrentMeasureControl
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
            this.currentMeasurePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.getReadingButton = new System.Windows.Forms.Button();
            this.presRdgBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.currentMeasureComboBox = new System.Windows.Forms.ComboBox();
            this.currentMeasureEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentMeasurePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentMeasurePanel
            // 
            this.currentMeasurePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentMeasurePanel.Controls.Add(this.label2);
            this.currentMeasurePanel.Controls.Add(this.getReadingButton);
            this.currentMeasurePanel.Controls.Add(this.presRdgBox);
            this.currentMeasurePanel.Controls.Add(this.resetButton);
            this.currentMeasurePanel.Controls.Add(this.currentMeasureComboBox);
            this.currentMeasurePanel.Controls.Add(this.currentMeasureEnableCheckBox);
            this.currentMeasurePanel.Controls.Add(this.label1);
            this.currentMeasurePanel.Location = new System.Drawing.Point(3, 3);
            this.currentMeasurePanel.Name = "currentMeasurePanel";
            this.currentMeasurePanel.Size = new System.Drawing.Size(396, 168);
            this.currentMeasurePanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "CURRENT MEASURE CONTROL";
            // 
            // getReadingButton
            // 
            this.getReadingButton.Location = new System.Drawing.Point(17, 123);
            this.getReadingButton.Margin = new System.Windows.Forms.Padding(4);
            this.getReadingButton.Name = "getReadingButton";
            this.getReadingButton.Size = new System.Drawing.Size(100, 28);
            this.getReadingButton.TabIndex = 0;
            this.getReadingButton.Text = "Get Reading";
            this.getReadingButton.UseVisualStyleBackColor = true;
            // 
            // presRdgBox
            // 
            this.presRdgBox.Location = new System.Drawing.Point(170, 126);
            this.presRdgBox.Margin = new System.Windows.Forms.Padding(4);
            this.presRdgBox.Name = "presRdgBox";
            this.presRdgBox.ReadOnly = true;
            this.presRdgBox.Size = new System.Drawing.Size(132, 22);
            this.presRdgBox.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(155, 82);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // currentMeasureComboBox
            // 
            this.currentMeasureComboBox.FormattingEnabled = true;
            this.currentMeasureComboBox.Items.AddRange(new object[] {
            "Itahaco Current Preamplifier",
            "Keithley 6517 Electrometer",
            "Keithley 648X Picoammeter"});
            this.currentMeasureComboBox.Location = new System.Drawing.Point(170, 43);
            this.currentMeasureComboBox.Name = "currentMeasureComboBox";
            this.currentMeasureComboBox.Size = new System.Drawing.Size(213, 24);
            this.currentMeasureComboBox.TabIndex = 3;
            // 
            // currentMeasureEnableCheckBox
            // 
            this.currentMeasureEnableCheckBox.AutoSize = true;
            this.currentMeasureEnableCheckBox.Location = new System.Drawing.Point(17, 82);
            this.currentMeasureEnableCheckBox.Name = "currentMeasureEnableCheckBox";
            this.currentMeasureEnableCheckBox.Size = new System.Drawing.Size(123, 21);
            this.currentMeasureEnableCheckBox.TabIndex = 5;
            this.currentMeasureEnableCheckBox.Text = "Enable Control";
            this.currentMeasureEnableCheckBox.UseVisualStyleBackColor = true;
            this.currentMeasureEnableCheckBox.CheckedChanged += new System.EventHandler(this.currentMeasureEnableCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Measure Tool:";
            // 
            // CurrentMeasureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentMeasurePanel);
            this.Name = "CurrentMeasureControl";
            this.Size = new System.Drawing.Size(404, 174);
            this.currentMeasurePanel.ResumeLayout(false);
            this.currentMeasurePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentMeasurePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getReadingButton;
        private System.Windows.Forms.TextBox presRdgBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox currentMeasureComboBox;
        private System.Windows.Forms.CheckBox currentMeasureEnableCheckBox;
        private System.Windows.Forms.Label label1;
    }
}
