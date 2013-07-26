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
        
        public DaqControl()
        {
            InitializeComponent();
        }

        private void daqConfigureButton_Click(object sender, EventArgs e)
        {
            daqConfigForm1 = new DaqConfigForm(); 
            daqConfigForm1.Show();
        }
    }
}
