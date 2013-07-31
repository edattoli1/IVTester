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
            this.currentMeasurePanel.Location = new System.Drawing.Point(2, 2);
            this.currentMeasurePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentMeasurePanel.Name = "currentMeasurePanel";
            this.currentMeasurePanel.Size = new System.Drawing.Size(298, 137);
            this.currentMeasurePanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "CURRENT MEASURE CONTROL";
            // 
            // getReadingButton
            // 
            this.getReadingButton.Location = new System.Drawing.Point(13, 100);
            this.getReadingButton.Name = "getReadingButton";
            this.getReadingButton.Size = new System.Drawing.Size(75, 23);
            this.getReadingButton.TabIndex = 0;
            this.getReadingButton.Text = "Get Reading";
            this.getReadingButton.UseVisualStyleBackColor = true;
            this.getReadingButton.Click += new System.EventHandler(this.getReadingButton_Click);
            // 
            // presRdgBox
            // 
            this.presRdgBox.Location = new System.Drawing.Point(128, 102);
            this.presRdgBox.Name = "presRdgBox";
            this.presRdgBox.ReadOnly = true;
            this.presRdgBox.Size = new System.Drawing.Size(100, 20);
            this.presRdgBox.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(116, 67);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 19);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // currentMeasureComboBox
            // 
            this.currentMeasureComboBox.FormattingEnabled = true;
            this.currentMeasureComboBox.Items.AddRange(new object[] {
            "Itahaco Current Preamplifier",
            "Keithley 6517 Electrometer",
            "Keithley 648X Picoammeter"});
            this.currentMeasureComboBox.Location = new System.Drawing.Point(128, 35);
            this.currentMeasureComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentMeasureComboBox.Name = "currentMeasureComboBox";
            this.currentMeasureComboBox.Size = new System.Drawing.Size(161, 21);
            this.currentMeasureComboBox.TabIndex = 3;
            // 
            // currentMeasureEnableCheckBox
            // 
            this.currentMeasureEnableCheckBox.AutoSize = true;
            this.currentMeasureEnableCheckBox.Location = new System.Drawing.Point(13, 67);
            this.currentMeasureEnableCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentMeasureEnableCheckBox.Name = "currentMeasureEnableCheckBox";
            this.currentMeasureEnableCheckBox.Size = new System.Drawing.Size(95, 17);
            this.currentMeasureEnableCheckBox.TabIndex = 5;
            this.currentMeasureEnableCheckBox.Text = "Enable Control";
            this.currentMeasureEnableCheckBox.UseVisualStyleBackColor = true;
            this.currentMeasureEnableCheckBox.CheckedChanged += new System.EventHandler(this.currentMeasureEnableCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Measure Tool:";
            // 
            // CurrentMeasureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentMeasurePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CurrentMeasureControl";
            this.Size = new System.Drawing.Size(303, 141);
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
