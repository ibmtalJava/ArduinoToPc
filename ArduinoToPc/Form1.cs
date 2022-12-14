using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoToPc
{
    public partial class Form1 : Form
    {
        public ArduinoCommand ac;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ac= new ArduinoCommand();   
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {                         
                ac.setSerialPort(
                    System.Convert.ToInt32(portBautRate.Text)
                    , portName.Text
                );
                connectStatus.Text = "Connected.....";
            }
            catch (Exception ex) {
                connectStatus.Text = "Connection Error...";
            }
        }
    }
}
