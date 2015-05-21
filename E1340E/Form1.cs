using SerialE1300B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Units;

namespace E1340E
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        Serial port = new Serial();

        Generator awg;

        public Form1()
        {
            InitializeComponent();
            port.DataReceived += port_DataReceived;
            button2.Enabled = false;
            buttonShape.Enabled = false;
        }

        void port_DataReceived(object sender, EventArgs e)
        {
             SetText(port.GetData());
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
            port.SelectDevice("ARB");
            awg = new Generator(port);
            buttonConnect.Enabled = false;
            button2.Enabled = true;
            buttonShape.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.SendData(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonShape_Click(object sender, EventArgs e)
        {
            var shape = Generator.StandardWaves.DC;
            if (radioButton1.Checked)
                shape = Generator.StandardWaves.Sine;
            else if (radioButton2.Checked)
                shape = Generator.StandardWaves.Triangle;
            else if (radioButton3.Checked)
                shape = Generator.StandardWaves.Square;

            else if (radioButtonRamp.Checked)
                shape = Generator.StandardWaves.Ramp;
            else if (radioButtonUserA.Checked)
                shape = Generator.StandardWaves.UserA;
            else if (radioButtonUserB.Checked)
                shape = Generator.StandardWaves.UserB;
            else if (radioButtonUserC.Checked)
                shape = Generator.StandardWaves.UserC;
            else if (radioButtonUserD.Checked)
                shape = Generator.StandardWaves.UserD;

            var frequency = textBoxFrequency.Text.ParseSI();
            var amplitude = textBoxAmplitude.Text.ParseSI();
            var offset = textBoxOffset.Text.ParseSI();

            awg.Function(shape, frequency, amplitude, offset, checkBoxEnabled.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnabled.Checked)
            {
                awg.Arm();
            }
            else
            {
                awg.DeArm();
            }
        }

        private void buttonQueryConfig_Click(object sender, EventArgs e)
        {
            awg.QueryConfig();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            awg.UploadWaveForm();
        }

        private void buttonCtrlC_Click(object sender, EventArgs e)
        {
            port.SendData("\u0004");
            port.SendData("ST UNKNOWN");
        }
    }
}
