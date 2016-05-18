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
	public partial class FrontNode : Form
	{
		Racecar car = Racecar.Instance;
		SerialPort xBee;
		public FrontNode(SerialPort sp)
		{
			InitializeComponent();

			xBee = sp;
		}

		private void GUIUpdate_Tick(object sender, EventArgs e)
		{
			lblTorqueImplaus.Text				= car.Errors[Racecar.ErrorType.torqueImplaus].ToString();
			lblTorque1Fault.Text				= car.Errors[Racecar.ErrorType.throttle1Fault].ToString();
			lblTorque2Fault.Text				= car.Errors[Racecar.ErrorType.throttle2Fault].ToString();
			lblTroqueBrakeImplaus.Text	= car.Errors[Racecar.ErrorType.throttleBrakeImplaus].ToString();
			lblBrakeFault.Text					= car.Errors[Racecar.ErrorType.brakeFault].ToString();

			var lblErrors = grpError.Controls.OfType<Label>();

			foreach(var err in lblErrors)
			{
				if (err.Text.ToLower() == "true")
					errorProvider.SetError(err, "Problemz!");
				else
					errorProvider.SetError(err, "");
			}
			lblRTD.Text									= car.RTD.ToString();
		}


		private void FrontNode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}


		byte[] poll = new byte[5] { 0x7A, 0x7A, 0x01, 0x04, 0x04 }; // Poll for front node data
		byte[] stopPoll = new byte[5] { 0x7A, 0x7A, 0x00, 0x04, 0x04 }; // Stop polling for front node data
		private void FrontNode_VisibleChanged(object sender, EventArgs e)
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
	}
}
