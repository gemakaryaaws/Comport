using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComPort
{
    public partial class Form1 : Form
    {
        string dataOUT;


        public Form1()
        {
            InitializeComponent();
            BTOPEN.Enabled = true;
            BTCLOSE.Enabled = false;
            BTSENDDATA.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CBCOMPORT.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                serialPort1.PortName = CBCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBSTOPBITS. Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBPARITYBITS. Text);

                serialPort1.Open();
                progressBar1.Value = 100;

                BTOPEN.Enabled = false;
                BTCLOSE.Enabled = true;
                BTSENDDATA.Enabled = true;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CBCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTCLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            BTCLOSE.Enabled = false;
            BTOPEN.Enabled = true;
            BTSENDDATA.Enabled = false;
        }

        private void BTSENDDATA_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = TEXTBOXDATA.Text;
                serialPort1.Write(dataOUT);
            }
        }

        private void CBBAUDRATE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
