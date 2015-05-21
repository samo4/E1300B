using SerialE1300B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1326B
{
    class DMM
    {
        Serial port = null;

        public DMM()
        { 
        
        }

        public DMM(Serial port)
        {
            this.port = port;
            port.SendData("ABOR");
            ResetAndClear();
            port.SendData("CAL:LFR 50");
            SetRangeAndIntegrationtime();

            port.SendData("CAL:ZERO:AUTO ON");
            port.SendData("VOLTage:RESolution MAX");
        }

        public string ResetAndClear()
        {
            port.SendData("*RST;*CLS;*OPC?");
            return "";
        }


        public string SetRangeAndIntegrationtime()
        {

            //Integration Time
            /*
             10 ms*   0.0005
             100 ms   0.005
             2.5 ms   0.125
             16.7 ms  1
             20 ms   1
             267 ms 16
             320 ms 16
             * 
             */
            port.SendData("VOLTage:APERture MAX");
            /* 0.113 V | 0.91 V | 7.27 V | 58.1 V | 300 V | AUTO | DEF | MIN | MAX*/
            port.SendData("CONF:VOLT:DC 7.27");
            return "";
        }

        public string MeasureVoltage()
        {
            port.SendData("MEAS:VOLT:DC?");
            return "";
        }
        
    }
}
