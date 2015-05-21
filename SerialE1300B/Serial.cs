using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialE1300B
{
    public class Serial
    {
        public delegate void DataReceivedEventHandler(object sender, EventArgs e);

        public event DataReceivedEventHandler DataReceived;

        Queue myQ = new Queue();

        SerialPort mySerialPort;

        public void Init()
        {
                mySerialPort = new SerialPort("COM1");

                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.XOnXOff;
                mySerialPort.ReadTimeout = 10000;
                mySerialPort.WriteTimeout = 10000;

                mySerialPort.DtrEnable = true;
                mySerialPort.RtsEnable = true;

                mySerialPort.Open();
                //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.DataReceived += DataReceivedHandler;
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            System.Threading.Thread.Sleep(500);
            string indata = sp.ReadExisting();
            myQ.Enqueue(indata);

            if (DataReceived != null)
            {
                DataReceived(this, e);
            }
        }

        static Dictionary<char, char> _check = new Dictionary<char, char>
        {
	        {(char) 0, (char) 0},
	        {(char) 1, (char) 7},
	        {(char) 2, (char) 6},
	        {(char) 3, (char) 1},
	        {(char) 4, (char) 5},
	        {(char) 5, (char) 2},
	        {(char) 6, (char) 3},
	        {(char) 7,  (char) 4},
	        {(char) 8, (char) 3},
	        {(char) 9, (char) 4},
            {(char) 10, (char) 5},
	        {(char) 11, (char) 2},
	        {(char) 12, (char) 6},
	        {(char) 13, (char) 1},
	        {(char) 14, (char) 0},
	        {(char) 15, (char) 7}
        };

        private static byte[] GetUploadReadyBytes(byte[] input)
        {
            var result = new byte[input.Length * 2];
            int i = 0;
            foreach (char c in input)
            {
                var msb = (char)((c & 0xF0) >> 4);
                var lsb = (char)(c & 0x0F);
                var checkMsb = _check[msb] << 4;
                var checkLsb = _check[lsb] << 4;
                result[i++] = (byte)(msb | checkMsb | 0x80); // msbfirst
                result[i++] = (byte)(lsb | checkLsb | 0x80);
            }
            return result;
        }

        public void UploadBinaryData(string command, byte[] data)
        {
            var processedData =  GetUploadReadyBytes(data);
            var size = processedData.Length;
            var sizeDigits = size.ToString().Length;
            var definiteBlockHeader = "#" + sizeDigits.ToString() + size.ToString();

            SendData(command + definiteBlockHeader);
            SendData(processedData);
            SendData("\r"); // if using indefinite block, sent !\r
        }

        public string DisplayReadableHex(byte[] data)
        {
            StringBuilder hex = new StringBuilder(data.Length * 2);
            foreach (byte b in data)
                hex.AppendFormat("0x" + "{0:x2}\r\n".ToUpper(), b);
            return hex.ToString();
        }

        public void SystemUpload(byte[] data, string address)
        {
            // DIAG:NRAM:CRE 128
            // DIAG:BOOT
            // DIAG:NRAM:ADDR?
            // 16638188 

            var result = GetUploadReadyBytes(data);

            var size = result.Length;
            var sizeDigits = size.ToString().Length;
            var definiteBlockHeader = "#" + sizeDigits.ToString() + size.ToString();

            SendData("\u0004");
            SendData("ST UNKNOWN");
            SendData("SI SYSTEM");
            SendData("*RST");

            UploadBinaryData("DIAG:DOWN:CHEC " + address + ",", result);

            SendData("");
            SendData("");
            SendData("*OPC;");
            SendData("DIAG:UPL? " + address + "," + data.Length.ToString());
        }

        public string GetData()
        {
            var result = myQ.Dequeue();
            if (result == null)
                return "";

            return result as string;
        }

        public void SendData(string data)
        {
            var ascii = Encoding.ASCII;
            var toGo = ascii.GetBytes(data + "\r");
            mySerialPort.Write(toGo, 0, toGo.Length);
        }

        public void SendData(byte[] data)
        {
            const int slotSize = 20;
            
            var numberOfSlots = Math.Ceiling((double)(data.Length / slotSize));
            var remainingBytes = data.Length;

            for (int i = 0; i < numberOfSlots; i++ )
            {
                var toWrite = new byte[slotSize + 1];
                if (remainingBytes < slotSize)
                {
                    mySerialPort.Write(toWrite, 0, remainingBytes);
                }
                else
                {
                    Buffer.BlockCopy(data, i * slotSize, toWrite, 0, slotSize);
                    toWrite[slotSize] = (byte)'\r';
                    mySerialPort.Write(toWrite, 0, slotSize + 1);
                    remainingBytes -= slotSize;
                }
            }
                
        }

        public void SelectDevice(string device)
        {
            mySerialPort.Write("\u0004\r\nsi " + device + " + \r\n");
        }
    }
}
