using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVTester
{
    public partial class Form1 : Form
    {

        Ke6517Control ke6517Control;
        UserControl currentMeasureControl;
        
        public Form1()
        {
            InitializeComponent();
            //ke6517Control = new Ke6517Control();
            //ke6517Control.InitSession();
        }

        //private void resetButton_Click(object sender, EventArgs e)
        //{
        //    ke6517Control.InitDevice();
        //}

        //private void getReadingButton_Click(object sender, EventArgs e)
        //{
        //    double inRdg;
        //    inRdg = ke6517Control.GetReading();
        //    presRdgBox.Text = inRdg.ToString();
        //}
    }
}
