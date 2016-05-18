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
		private readonly Racecar _car = Racecar.Instance;
		readonly SerialPort _xBee;
		public RearNode(SerialPort sp)
		{
			InitializeComponent();
			_xBee = sp;
		}

		private void RearNode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}


		private readonly byte[] _poll = { 0x7B, 0x7B, 0x01, 0x04, 0x04 }; // Poll for rear node data
		private readonly byte[] _stopPoll = { 0x7B, 0x7B, 0x00, 0x04, 0x04 }; // Stop polling for rear node data
		private void RearNode_VisibleChanged(object sender, EventArgs e)
		{
			if (_xBee.IsOpen)
			{
				_xBee.Write(Visible ? _poll : _stopPoll, 0, 5);
			}
		}

		private void GUIUpdate_Tick(object sender, EventArgs e)
		{
			lblShutdownCurrent.Text = _car.ShutdownCurrent ? "ON" : "OFF";
			lblTorqueReq.Text = ((double)_car.ThrottlePosition/100) + " Nm";
		}
	}
}
