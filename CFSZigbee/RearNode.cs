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

namespace CFSZigbee
{
	public partial class RearNode : Form
	{
		Racecar car = Racecar.Instance;
		SerialPort xBee;
		public RearNode(SerialPort sp)
		{
			InitializeComponent();
			xBee = sp;
		}

		private void RearNode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}


		byte[] poll = new byte[5] { 0x7B, 0x7B, 0x01, 0x04, 0x04 }; // Poll for rear node data
		byte[] stopPoll = new byte[5] { 0x7B, 0x7B, 0x00, 0x04, 0x04 }; // Stop polling for rear node data
		private void RearNode_VisibleChanged(object sender, EventArgs e)
		{
			if (xBee.IsOpen)
			{
				if (Visible)
				{
					xBee.Write(poll, 0, 5);
				}
				else
				{
					xBee.Write(stopPoll, 0, 5);
				}
			}
		}

		private void GUIUpdate_Tick(object sender, EventArgs e)
		{
			lblShutdownCurrent.Text = car.ShutdownCurrent ? "ON" : "OFF";
			lblTorqueReq.Text = ((double)car.TorqueEncoderPosition/100).ToString() + " Nm";
		}
	}
}
