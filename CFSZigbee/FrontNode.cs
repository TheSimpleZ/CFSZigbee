﻿using System;
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
		private readonly Racecar _car = Racecar.Instance;
		private readonly SerialPort _xBee;
		public FrontNode(SerialPort sp)
		{
			InitializeComponent();

			_xBee = sp;
		}

		private void GUIUpdate_Tick(object sender, EventArgs e)
		{
			lblTorqueImplaus.Text				= _car.Errors[Racecar.ErrorType.TorqueImplaus].ToString();
			lblTorque1Fault.Text				= _car.Errors[Racecar.ErrorType.Throttle1Fault].ToString();
			lblTorque2Fault.Text				= _car.Errors[Racecar.ErrorType.Throttle2Fault].ToString();
			lblTroqueBrakeImplaus.Text	= _car.Errors[Racecar.ErrorType.ThrottleBrakeImplaus].ToString();
			lblBrakeFault.Text					= _car.Errors[Racecar.ErrorType.BrakeFault].ToString();

			var lblErrors = grpError.Controls.OfType<Label>();

			foreach(var err in lblErrors)
			{
				if (err.Text.ToLower() == "true")
					errorProvider.SetError(err, "Problemz!");
				else
					errorProvider.SetError(err, "");
			}
			lblRTD.Text									= _car.Rtd.ToString();
		}


		private void FrontNode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}


		private readonly byte[] _poll = { 0x7A, 0x7A, 0x01, 0x04, 0x04 }; // Poll for front node data
		private readonly byte[] _stopPoll = { 0x7A, 0x7A, 0x00, 0x04, 0x04 }; // Stop polling for front node data
		private void FrontNode_VisibleChanged(object sender, EventArgs e)
		{
			if (_xBee.IsOpen)
			{
				_xBee.Write(Visible ? _poll : _stopPoll, 0, 5);
			}
		}
	}
}