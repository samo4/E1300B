using SerialE1300B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1340E
{
    public class Generator
    {
        Serial port = null;

        public enum StandardWaves { DC, Sine, Triangle, Square, Ramp, UserA, UserB, UserC, UserD }

        public bool IsArmed { get; set; }

        public Generator(Serial port)
        {
            this.port = port;
            port.SendData("ABOR");
            ResetAndClear();
            DeArm();
            port.SendData("SOUR:LIST:SEL NONE");
            port.SendData(":SOUR:FUNC:SHAP SIN");
            port.SendData("SOUR:ARB:DOWN EEPRom3,A,4096");
            port.SendData("SOUR:ARB:DOWN EEPRom14,B,4096");
            port.SendData("SOUR:ARB:DOWN EEPRom7,C,4096");
            port.SendData("SOUR:ARB:DOWN EEPRom15,D,4096");
        }

        private string FormatNumber(double number)
        {
            return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:E5}", number); 
        }

        public string SelfTest()
        {
            port.SendData("*TST?");
            // *TST?
            // IF Rslt <>0
            // repeat until 0 SYST:ERR?
            return "";
        }

        public string ResetAndClear()
        {
            port.SendData("*RST;*CLS;*OPC?");
            return "";
        }

        public string Reset()
        {
            port.SendData("*RST;*OPC?");
            return "";
        }

        public void Function(StandardWaves shape, double frequency, double amplitude, double offset, bool enableOutput)
        {
            DeArm();
            SetFrequency(frequency);
            SetShape(shape);
            SetAmplitude(amplitude);
            SetOffset(offset);
            if (enableOutput)
                Arm();
        }

        public void SetOffset(double offset)
        {
            port.SendData(":SOUR:VOLT:OFFS " + FormatNumber(offset) + "V");
        }

        private void SetFrequency(double frequency)
        {
            port.SendData("SOUR:FREQ:FIX " + FormatNumber(frequency) + ";");
        }

        private void SetShape(StandardWaves shape)
        {
            var s = "";
            switch (shape)
            { 
                case StandardWaves.DC:
                    s = "DC";
                    break;
                case StandardWaves.Sine:
                    s = "SIN";
                    break;
                case StandardWaves.Square:
                    s = "SQU";
                    break;
                case StandardWaves.Triangle:
                    s = "TRI";
                    break;
                case StandardWaves.Ramp:
                    s = "RAMP";
                    break;
                default:
                    s = "USER";
                    break;
            }
            port.SendData(":SOUR:FUNC:SHAP " + s + ";");

            var u = "";
            switch (shape)
            { 
                case StandardWaves.UserA:
                    u = "A";
                    break;
                case StandardWaves.UserB:
                    u = "B";
                    break;
                case StandardWaves.UserC:
                    u = "C";
                    break;
                case StandardWaves.UserD:
                    u = "D";
                    break;
            }
            if (!string.IsNullOrWhiteSpace(u))
            {
                port.SendData("SOUR:FUNC:USER " + u + ";");
            }
        }

        

        public static byte[] GetDemoWaveForm()
        {
            var size = 4096;
            var points = new int[size];
            for (int i = 0; i < size; i++)
            {
                points[i] = i;
            }


            var result = new byte[size * 2];
            int j = 0;
            foreach (var p in points)
            {
                if (p >= size)
                    throw new Exception("Out of range");

                var msb = (byte)((p & 0x0F00) >> 8);
                var lsb = (byte)(p & 0xFF);

                result[j++] = msb; // msbfirst
                result[j++] = lsb;
            }


            return result;
        }

        public string UploadWaveForm()
        {
            // this should eventually work with GPIB
            port.SendData("SOUR:LIST:SEGM:SEL A");

            var demo = GetDemoWaveForm();
            port.UploadBinaryData("SOUR:LIST:SEGM:VOLT:DAC ", demo);
            return "";
        }

        public void SetAmplitude(double amplitude)
        {
            port.SendData(":SOUR:VOLT:LEV:IMM:AMPL " + FormatNumber(amplitude) + "V");
        }

        public void Arm()
        {
            if (!IsArmed)
            {
                port.SendData("INIT:IMM");
                IsArmed = true;
            }
        }
        public void DeArm()
        {
            if (IsArmed)
            {
                port.SendData("ABOR");
                IsArmed = false;
            }
        }

        internal void QueryConfig()
        {
            port.SendData("*LRN?");
        }
    }
}
