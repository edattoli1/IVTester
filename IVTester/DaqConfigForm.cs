using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace IVTester
{
    public partial class DaqConfigForm : Form
    {
        public DaqConfigForm()
        {
            InitializeComponent();
        }

        private void DaqConfigForm_Load(object sender, EventArgs e)
        {
            string[] aiChannels = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External);
            string[] aoChannels = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External);


            daqOutSelectComboBox1.Items.AddRange(aoChannels);
            daqOutSelectComboBox1.Items.Add("");
            daqOutSelectComboBox1.SelectedIndex = daqOutSelectComboBox1.FindStringExact(Properties.Settings.Default.DaqOutput1);


            daqOutSelectComboBox2.Items.AddRange(aoChannels);
            daqOutSelectComboBox2.Items.Add("");
            daqOutSelectComboBox2.SelectedIndex = daqOutSelectComboBox2.FindStringExact(Properties.Settings.Default.DaqOutput2);

        }

        private void daqConfigSaveExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DaqOutput1 = daqOutSelectComboBox1.Text;
            Properties.Settings.Default.DaqOutput2 = daqOutSelectComboBox2.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
