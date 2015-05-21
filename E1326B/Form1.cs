using SerialE1300B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1326B
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        private volatile bool waitingForResponse = false;

        Serial port = new Serial();
        DMM dmm = new DMM();

        public Form1()
        {
            InitializeComponent();
            port.DataReceived += port_DataReceived;
            button2.Enabled = false;
        }

        void port_DataReceived(object sender, EventArgs e)
        {
            var data = port.GetData();
            if (checkBox1.Checked)
            {
                SetTextLabel(data.Replace("MEAS:VOLT:DC?", "").Trim());
                waitingForResponse = false;
            }
            SetText(data);
        }

        private void SetTextLabel(string text)
        {
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label2.Text = text;
            }
        }

        private void SetText(string text)
        {
            if (this.textBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox2.AppendText(text);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            port.Init();
            port.SelectDevice("voltmtr");
            dmm = new DMM(port);
            buttonConnect.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.SendData(textBox1.Text);
            textBox1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // yuhuuu, do measure stuff
                Task<string> task = Task.Run(() => LongRunningMethod());
                // label2.Text = await task;
            }
            else
            { 
            
            }
        }

        private string LongRunningMethod()
        {
            while (checkBox1.Checked)
            {
                dmm.MeasureVoltage();
                waitingForResponse = true;
                while (waitingForResponse)
                { 
                }
            }
            return "";
        }
    }
}
