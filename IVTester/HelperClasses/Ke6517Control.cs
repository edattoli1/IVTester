using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.NI4882;
using System.Windows.Forms;

namespace IVTester
{
    class Ke6517Control : CurrentMeasureToolAbstract
    {
        private int GPIBaddress = 14;
        private Device device;

        override public void InitSession()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Convert the Secondary Address Combo Text into a number.
                int currentSecondaryAddress = 0;
                int boardId = 0;

                // Intialize the device
                device = new Device(boardId, (byte)GPIBaddress, (byte)currentSecondaryAddress);
                //SetupControlState(true);
            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
                ErrorMessage();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
        }

        override public void EndSession()
        {
            device.Dispose();
        }

        public string GetIdentString()
        {
            string stringToWrite = "*idn?";

            //Write to Device
            try
            {
                device.Write(stringToWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string stringRead = "";

            //Read from Device
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                stringRead = device.ReadString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return stringRead;
        }


        // Initalize Keithley picoammeter to default state
        override public void InitDevice()
        {
            string initString1 = ":SYST:PRES;:SENS:FUNC 'CURR';:SYST:ZCH OFF";

            string initString2 = ":SENS:CURR:AVER:TYPE NONE;:SENS:CURR:MED:STAT OFF";

            string initString3 = ":FORM:ELEM READ";

            // :SENS:CURR:RANG 2E-";
            string nplcString = ":SENS:CURR:NPLC ";

            try
            {

                //reset 6517
                device.Write(initString1);
                device.Write(initString2);
                device.Write(initString3);


                //Set Range
                device.Write(":SENS:CURR:RANG 2E-" + Properties.Settings.Default.PicoammRange.ToString());

                //Set number of digits
                device.Write("SENS:CURR:DIG 7");

                //set up NPLC (analog filter)
                device.Write(nplcString + Properties.Settings.Default.PicoammNPLC.ToString());

                //Turn on Meter Connect and Vsource
                device.Write(":SOUR:VOLT:MCON ON;:OUTP1:STAT ON;:SOUR:VOLT:RANG 1");

                
                device.IOTimeout = TimeoutValue.T1s;    

            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
                ErrorMessage();
            }


        }

        override public void SetRange(int newRange)
        {

            try
            {
                device.Write(":ABORT");
                device.Write(":SENS:CURR:RANG 2E-" + newRange.ToString());
                device.Write(":INIT");
            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
                ErrorMessage();
            }
            
        }

        override public double GetReading()
        {
            double returnValue = 0;
            string retrievedString = "0.00";
            
            try
            {
            
            device.Write(":READ?");

           
            device.IOTimeout = TimeoutValue.T1s;
            retrievedString = device.ReadString(14);
            returnValue = Convert.ToDouble(retrievedString);
            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
                ErrorMessage();
                //return 0;
            }


            return returnValue;
        }

        override public void ChangeNplc(double newNplcVal)
        {
            try
            {
                device.Write(":ABORT");
                device.Write(":SENS:CURR:DC:NPLC " + newNplcVal.ToString());
                device.Write(":INIT");
            }
            catch (Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
                ErrorMessage();
            }
        }

        private void ErrorMessage()
        {
            string messageBoxText = "Do you want to exit?";
            string caption = "GPIB Problem";
            var result = MessageBox.Show(messageBoxText, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.ElectrometerControlEnable = false;
                Properties.Settings.Default.Save();
                Environment.Exit(0);
            }
        }

        //private string ReplaceCommonEscapeSequences(string s)
        //{
        //    return s.Replace("\\n", "\n").Replace("\\r", "\r");
        //}

        //private string InsertCommonEscapeSequences(string s)
        //{
        //    return s.Replace("\n", "\\n").Replace("\r", "\\r");
        //}

    }
    
}
