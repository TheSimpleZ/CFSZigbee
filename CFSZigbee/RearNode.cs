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
	public partial class RearNode : Form
	{
		private readonly Racecar _car = Racecar.Instance;
		readonly SerialPort _xBee;
		public RearNode(SerialPort sp)
		{
			InitializeComponent();
			_car.PropertyChanged += CarOnPropertyChanged;

			_xBee = sp;
		}

		private void CarOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			switch (propertyChangedEventArgs.PropertyName)
			{
				case nameof(_car.Rtd):
					SetLabelText(lblRTD, _car.Rtd.ToString());
					break;

				case nameof(_car.ThrottlePosition):
					SetLabelText(lblThrottlePosition, _car.ThrottlePosition.ToString());
					break;

				case nameof(_car.FrontBrakePressure):
					SetLabelText(lblFrontBrakePressure, _car.FrontBrakePressure.ToString());
					break;

				case nameof(_car.LeftBrakeTemp):
					SetLabelText(lblLeftBrakeTemp, _car.LeftBrakeTemp.ToString());
					break;

				case nameof(_car.RightBrakeTemp):
					SetLabelText(lblRightBrakeTemp, _car.RightBrakeTemp.ToString());
					break;

				case nameof(_car.SteeringPosition):
					SetLabelText(lblSteeringPos, _car.SteeringPosition.ToString());
					break;

				case nameof(_car.LeftWheelSpeed):
					SetLabelText(lblLeftWheelSpeed, _car.LeftWheelSpeed.ToString());
					break;

				case nameof(_car.ThrottleImplaus):
					SetLabelText(lblThrottleImplaus, _car.ThrottleImplaus.ToString());
					break;

				case nameof(_car.Throttle1Fault):
					SetLabelText(lblThrottle1Fault, _car.Throttle1Fault.ToString());
					break;

				case nameof(_car.ThrottleBrakeImplaus):
					SetLabelText(lblThrottleBrakeImplaus, _car.ThrottleBrakeImplaus.ToString());
					break;

				case nameof(_car.FrontBrakeFault):
					SetLabelText(lblFrontBrakeFault, _car.FrontBrakeFault.ToString());
					break;
			}

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
	}
}
