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
    public partial class DaqControl : UserControl
    {
        private DaqConfigForm daqConfigForm1;
        private DaqAction daqOutputBiases;

        
        public DaqControl()
        {
            InitializeComponent();
        }

        public void DaqControlInit()
        {
            daqOutputBiases = new DaqAction(Properties.Settings.Default.DaqBiasMinRange, Properties.Settings.Default.DaqBiasMaxRange);

            ////If DAQ Analog Out is Enabled in Settings file, Update Checkmark and Zero Bias Outputs
            //if (Properties.Settings.Default.sensorBiasEnable == true)
            //{
            //    biasOutsBox.Checked = Properties.Settings.Default.sensorBiasEnable;
            //    //ZeroAllBiasOutputs();
            //}


            // Ready fields for Daq Bias Output
            aoutImmSetUpDown1.Maximum = Convert.ToDecimal(Properties.Settings.Default.DaqBiasMaxRange);
            aoutImmSetUpDown1.Maximum = Convert.ToDecimal(Properties.Settings.Default.DaqBiasMaxRange);
            aoutImmSetUpDown2.Minimum = Convert.ToDecimal(Properties.Settings.Default.DaqBiasMinRange);
            aoutImmSetUpDown2.Minimum = Convert.ToDecimal(Properties.Settings.Default.DaqBiasMinRange);
        }

        private void daqConfigureButton_Click(object sender, EventArgs e)
        {
            daqConfigForm1 = new DaqConfigForm(); 
            daqConfigForm1.Show();
        }

        private void aoSetImmButton1_Click(object sender, EventArgs e)
        {
            try
            {
                daqOutputBiases.UpdateDaqOut(Properties.Settings.Default.DaqOutput1, Convert.ToDouble(aoutImmSetUpDown1.Value));
            }
            catch
            {
                //parentForm.DaqOutputProblem();
            }
            aoutValueBox1.Text = aoutImmSetUpDown1.Value.ToString("0.00");
        }

        private void daqEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (daqEnableCheckBox.Checked == true)
            {
                DaqControlInit();
            }
            else
            {
                
            }
        }
    }
}
