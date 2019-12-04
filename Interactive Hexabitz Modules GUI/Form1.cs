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

        byte DestinationID, SourceID;


        public Form1()
        {
            InitializeComponent();
            baudRateCB.SelectedIndex = 10;
            HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));
            DestinationID = (byte)destinationID_N.Value;
            SourceID = (byte)sourceID_N.Value;
        }

        private void TestBTN_Click(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));
            Code = (int)HexaInterface.Message_Codes.CODE_H01R0_COLOR; 
            byte[] Payload = { 90 };
            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
        }

        private void LedToggle_CheckedChanged(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));
            Code = (int)HexaInterface.Message_Codes.CODE_H01R0_COLOR; // Led with colors code
            HexInter.Opt2_16_BIT_Code = "0"; // because our code is 103 (1 byte)
            if (ledToggle.Checked)
            {
                byte[] Payload = { 1, red, green, blue, intensity };
                HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
            }
            else
            {
                Code = (int)HexaInterface.Message_Codes.CODE_H01R0_OFF; 
                byte[] Payload = new byte[0];
                HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
            }
        }

        private void RelayToggle_CheckedChanged(object sender, EventArgs e)
        {
            HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));
            Code = (int)HexaInterface.Message_Codes.CODE_H0FR6_ON; // Relay on code
            HexInter.Opt2_16_BIT_Code = "1"; // because our code is 750 (2 byte)

            if (relayToggle.Checked)
            {
                int timeOut = int.Parse(timeoutTB.Text);
                byte[] timeBytes = BitConverter.GetBytes(timeOut);
                byte[] Payload = { timeBytes[3], timeBytes[2], timeBytes[1], timeBytes[0] };
                HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
            }
            else
            {
                Code = (int)HexaInterface.Message_Codes.CODE_H0FR6_OFF; // Relay off code
                byte[] Payload = new byte[0];
                HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
            }
        }

        private void DestinationID_ValueChanged(object sender, EventArgs e)
        {
            DestinationID = (byte)destinationID_N.Value;
        }

        private void SourceID_N_ValueChanged(object sender, EventArgs e)
        {
            SourceID = (byte)sourceID_N.Value;
        }

        private void RedTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
        }
       

        private void GreenTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
        }

        private void BlueTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
        }

        private void IntensityTB_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            red = (byte)redTB.Value;
            green = (byte)greenTB.Value;
            blue = (byte)blueTB.Value;
            intensity = (byte)intensityTB.Value;
            byte[] Payload = { 1, red, green, blue, intensity };
            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);
        }
    }
}
