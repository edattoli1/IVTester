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
            this.daqControl1 = new IVTester.DaqControl();
            this.currentMeasureControl1 = new IVTester.CurrentMeasureControl();
            this.SuspendLayout();
            // 
            // daqControl1
            // 
            this.daqControl1.Location = new System.Drawing.Point(431, 12);
            this.daqControl1.Name = "daqControl1";
            this.daqControl1.Size = new System.Drawing.Size(655, 256);
            this.daqControl1.TabIndex = 1;
            // 
            // currentMeasureControl1
            // 
            this.currentMeasureControl1.Location = new System.Drawing.Point(0, 0);
            this.currentMeasureControl1.Name = "currentMeasureControl1";
            this.currentMeasureControl1.Size = new System.Drawing.Size(404, 174);
            this.currentMeasureControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 324);
            this.Controls.Add(this.daqControl1);
            this.Controls.Add(this.currentMeasureControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CurrentMeasureControl currentMeasureControl1;
        private DaqControl daqControl1;

    }
}

