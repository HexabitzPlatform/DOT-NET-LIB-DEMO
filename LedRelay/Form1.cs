using System;
using System.IO.Ports;
using DOT_NET_COMS_LIB;
using MetroFramework.Forms;

namespace LedRelay
{
    public partial class Form1 : MetroForm
    {

        HexaInterface HexInter;
        int Code;
        byte red, green, blue, intensity;


        public Form1()
        {
            InitializeComponent();
            HexInter = new HexaInterface(COM.Value.ToString());
        }

        private void TestBTN_Click(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString());
            Code = (int)HexaInterface.Message_Codes.CODE_H01R0_COLOR; 
            byte[] Payload = { 90 };
            HexInter.SendMessage(3, 2, Code, Payload);
        }

        private void LedToggle_CheckedChanged(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString());
            Code = (int)HexaInterface.Message_Codes.CODE_H01R0_COLOR; // Led with colors code
            HexInter.Opt2_16_BIT_Code = "0"; // because our code is 103 (1 byte)
            if (ledToggle.Checked)
            {
                byte[] Payload = { 1, red, green, blue, intensity };
                HexInter.SendMessage(3, 2, Code, Payload);
            }
            else
            {
                Code = (int)HexaInterface.Message_Codes.CODE_H01R0_OFF; 
                byte[] Payload = new byte[0];
                HexInter.SendMessage(3, 2, Code, Payload);
            }
        }

        private void RelayToggle_CheckedChanged(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString());
            Code = (int)HexaInterface.Message_Codes.CODE_H0FR6_ON; // Led with colors code
            HexInter.Opt2_16_BIT_Code = "0"; // because our code is 750 (2 byte)

            if (relayToggle.Checked)
            {
                int timeOut = int.Parse(timeoutTB.Text);
                byte[] timeBytes = BitConverter.GetBytes(timeOut);
                byte[] Payload = { timeBytes[3], timeBytes[2], timeBytes[1], timeBytes[0] };
                HexInter.SendMessage(1, 2, Code, Payload);
            }
            else
            {
                Code = (int)HexaInterface.Message_Codes.CODE_H0FR6_OFF;
                byte[] Payload = new byte[0];
                HexInter.SendMessage(1, 2, Code, Payload);
            }
        }

        private void RedTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(3, 2, Code, Payload);
        }
       

        private void GreenTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(3, 2, Code, Payload);
        }

        private void BlueTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(3, 2, Code, Payload);
        }

        private void IntensityTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(3, 2, Code, Payload);
        }
    }
}
