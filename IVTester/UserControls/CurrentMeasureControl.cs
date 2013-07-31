using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVTester
{
    public partial class CurrentMeasureControl : UserControl
    {
        CurrentMeasureToolAbstract currentMeasureToolControlInstance;
        
        public CurrentMeasureControl()
        {
            InitializeComponent();

            currentMeasureComboBox.SelectedIndex = Properties.Settings.Default.CurrentMeasureTool1;
            currentMeasureComboBox.SelectedIndexChanged += new EventHandler(currentMeasureComboBox_IndexChangedHandler);


            switch (Properties.Settings.Default.CurrentMeasureTool1)
            {
                case (0):
                    currentMeasureToolControlInstance = new DL1211Control();
                    break;

                case (1):
                    currentMeasureToolControlInstance = new Ke6517Control();
                    //currentMeasureToolControlInstance.InitSession();
                    //currentMeasureToolControlInstance.SetRange(6);
                    break;

                case (2):
                    currentMeasureToolControlInstance = new Ke648xControl();
                    //currentMeasureToolControlInstance.InitSession();
                    break;

            }



        }

        internal void currentMeasureComboBox_IndexChangedHandler(object obj, EventArgs e)
        {
            Properties.Settings.Default.CurrentMeasureTool1 = currentMeasureComboBox.SelectedIndex;

            ChangeCurrentCurrentMeasureTool(currentMeasureComboBox.SelectedIndex);

            Properties.Settings.Default.Save();
        }

        internal void ChangeCurrentCurrentMeasureTool(int newTool)
        {
            switch (newTool)
            {
                case (0):
                    currentMeasureToolControlInstance = new DL1211Control();
                    break;

                case (1):
                    currentMeasureToolControlInstance = new Ke6517Control();
                    break;

                case (2):
                    currentMeasureToolControlInstance = new Ke648xControl();
                    break;


            }
        }

        private void currentMeasureEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMeasureEnableCheckBox.Checked == true)
            {
                currentMeasureToolControlInstance.InitSession();
            }
            else
            {
                currentMeasureToolControlInstance.EndSession();
            }
            //currentMeasureToolControlClass.
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.CurrentMeasureTool1)
            {
                case (0):
                    //currentMeasureToolControlInstance = new DL1211Control();
                    break;

                case (1):
                    currentMeasureToolControlInstance.InitDevice();
                    break;

                case (2):
                    //currentMeasureToolControlInstance = new Ke648xControl();
                    break;


            }
        }

        private void getReadingButton_Click(object sender, EventArgs e)
        {
            double rdgIn = 0;
            
            switch (Properties.Settings.Default.CurrentMeasureTool1)
            {
                case (0):
                    //currentMeasureToolControlInstance = new DL1211Control();
                    break;

                case (1):
                    rdgIn = currentMeasureToolControlInstance.GetReading();
                    break;

                case (2):
                    //currentMeasureToolControlInstance = new Ke648xControl();
                    break;

            }

            presRdgBox.Text = rdgIn.ToString();
        }




    }
}
