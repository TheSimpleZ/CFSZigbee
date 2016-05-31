using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace CFSZigbee
{
	public partial class PowerElectronics : Form
	{
		private readonly SerialPort _xBee;
		private readonly Racecar _car = Racecar.Instance;

		public PowerElectronics(SerialPort sp)
		{
			InitializeComponent();

			_xBee = sp;

			_car.PropertyChanged += CarOnPropertyChanged;

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

				case nameof(_car.Throttle2Fault):
					SetLabelText(lblThrottle2Fault, _car.Throttle2Fault.ToString());
					break;

				case nameof(_car.ThrottleBrakeImplaus):
					SetLabelText(lblThrottleBrakeImplaus, _car.ThrottleBrakeImplaus.ToString());
					break;

				case nameof(_car.FrontBrakeFault):
					SetLabelText(lblFrontBrakeFault, _car.FrontBrakeFault.ToString());
					break;
			}

		}

		private readonly byte[] _poll = { 0x7C, 0x7C, 0x01, 0x04, 0x04 }; // Poll for front node data
		private readonly byte[] _stopPoll = { 0x7C, 0x7C, 0x00, 0x04, 0x04 }; // Stop polling for front node data

		private void PowerElectronics_VisibleChanged(object sender, System.EventArgs e)
		{
			if (_xBee.IsOpen)
			{
				_xBee.Write(Visible ? _poll : _stopPoll, 0, 5);
			}
		}

		private void PowerElectronics_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}
	}
}
