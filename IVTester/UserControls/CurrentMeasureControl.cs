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

            currentMeasureComboBox.SelectedIndex = Properties.Settings.Default.CurrentMeasureTool;
            currentMeasureComboBox.SelectedIndexChanged += new EventHandler(currentMeasureComboBox_IndexChangedHandler);




        }

        internal void currentMeasureComboBox_IndexChangedHandler(object obj, EventArgs e)
        {
            Properties.Settings.Default.CurrentMeasureTool = currentMeasureComboBox.SelectedIndex;

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


    }
}
