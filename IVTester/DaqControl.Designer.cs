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
            this.aoutImmSetUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.aoutImmSetUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.aout1Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aoutValueBox1 = new System.Windows.Forms.TextBox();
            this.aoutValueBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aoSetImmButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aoSetImmButton2 = new System.Windows.Forms.Button();
            this.aoSweepToButton1 = new System.Windows.Forms.Button();
            this.aoSweepToButton2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aoutImmSetUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoutImmSetUpDown2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.daqEnableCheckBox);
            this.panel1.Controls.Add(this.daqConfigureButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 270);
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
            this.daqConfigureButton.Location = new System.Drawing.Point(113, 36);
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
            this.daqEnableCheckBox.CheckedChanged += new System.EventHandler(this.daqEnableCheckBox_CheckedChanged);
            // 
            // aoutImmSetUpDown1
            // 
            this.aoutImmSetUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.aoutImmSetUpDown1.Location = new System.Drawing.Point(213, 30);
            this.aoutImmSetUpDown1.Name = "aoutImmSetUpDown1";
            this.aoutImmSetUpDown1.Size = new System.Drawing.Size(75, 22);
            this.aoutImmSetUpDown1.TabIndex = 18;
            // 
            // aoutImmSetUpDown2
            // 
            this.aoutImmSetUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.aoutImmSetUpDown2.Location = new System.Drawing.Point(213, 69);
            this.aoutImmSetUpDown2.Name = "aoutImmSetUpDown2";
            this.aoutImmSetUpDown2.Size = new System.Drawing.Size(75, 22);
            this.aoutImmSetUpDown2.TabIndex = 19;
            // 
            // aout1Name
            // 
            this.aout1Name.AutoSize = true;
            this.aout1Name.Location = new System.Drawing.Point(3, 27);
            this.aout1Name.Name = "aout1Name";
            this.aout1Name.Size = new System.Drawing.Size(91, 17);
            this.aout1Name.TabIndex = 20;
            this.aout1Name.Text = "Analog Out 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Analog Out 2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54369F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.aoSweepToButton2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.aoSweepToButton1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.aoSetImmButton2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.aoSetImmButton1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.aoutImmSetUpDown2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.aoutImmSetUpDown1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.aoutValueBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.aoutValueBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.aout1Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 102);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // aoutValueBox1
            // 
            this.aoutValueBox1.Location = new System.Drawing.Point(111, 30);
            this.aoutValueBox1.Name = "aoutValueBox1";
            this.aoutValueBox1.ReadOnly = true;
            this.aoutValueBox1.Size = new System.Drawing.Size(84, 22);
            this.aoutValueBox1.TabIndex = 23;
            // 
            // aoutValueBox2
            // 
            this.aoutValueBox2.Location = new System.Drawing.Point(111, 69);
            this.aoutValueBox2.Name = "aoutValueBox2";
            this.aoutValueBox2.ReadOnly = true;
            this.aoutValueBox2.Size = new System.Drawing.Size(84, 22);
            this.aoutValueBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pres. Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Set Value";
            // 
            // aoSetImmButton1
            // 
            this.aoSetImmButton1.Location = new System.Drawing.Point(305, 30);
            this.aoSetImmButton1.Name = "aoSetImmButton1";
            this.aoSetImmButton1.Size = new System.Drawing.Size(57, 23);
            this.aoSetImmButton1.TabIndex = 23;
            this.aoSetImmButton1.Text = "Set";
            this.aoSetImmButton1.UseVisualStyleBackColor = true;
            this.aoSetImmButton1.Click += new System.EventHandler(this.aoSetImmButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Imm. Set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sweep Set";
            // 
            // aoSetImmButton2
            // 
            this.aoSetImmButton2.Location = new System.Drawing.Point(305, 69);
            this.aoSetImmButton2.Name = "aoSetImmButton2";
            this.aoSetImmButton2.Size = new System.Drawing.Size(57, 23);
            this.aoSetImmButton2.TabIndex = 24;
            this.aoSetImmButton2.Text = "Set";
            this.aoSetImmButton2.UseVisualStyleBackColor = true;
            // 
            // aoSweepToButton1
            // 
            this.aoSweepToButton1.Location = new System.Drawing.Point(399, 30);
            this.aoSweepToButton1.Name = "aoSweepToButton1";
            this.aoSweepToButton1.Size = new System.Drawing.Size(95, 33);
            this.aoSweepToButton1.TabIndex = 24;
            this.aoSweepToButton1.Text = "Sweep To";
            this.aoSweepToButton1.UseVisualStyleBackColor = true;
            // 
            // aoSweepToButton2
            // 
            this.aoSweepToButton2.Location = new System.Drawing.Point(399, 69);
            this.aoSweepToButton2.Name = "aoSweepToButton2";
            this.aoSweepToButton2.Size = new System.Drawing.Size(95, 30);
            this.aoSweepToButton2.TabIndex = 25;
            this.aoSweepToButton2.Text = "Sweep To";
            this.aoSweepToButton2.UseVisualStyleBackColor = true;
            // 
            // DaqControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DaqControl";
            this.Size = new System.Drawing.Size(736, 303);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aoutImmSetUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoutImmSetUpDown2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button daqConfigureButton;
        private System.Windows.Forms.CheckBox daqEnableCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aout1Name;
        private System.Windows.Forms.NumericUpDown aoutImmSetUpDown2;
        private System.Windows.Forms.NumericUpDown aoutImmSetUpDown1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox aoutValueBox1;
        private System.Windows.Forms.TextBox aoutValueBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aoSetImmButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aoSweepToButton2;
        private System.Windows.Forms.Button aoSweepToButton1;
        private System.Windows.Forms.Button aoSetImmButton2;
    }
}
