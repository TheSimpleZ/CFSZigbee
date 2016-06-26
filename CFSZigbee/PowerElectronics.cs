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

			var carListener = ChangeListener.Create(_car);

			carListener.PropertyChanged += CarOnPropertyChanged;

		}

		private void CarOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			string[] propName = propertyChangedEventArgs.PropertyName.Split('.');

			if (propName.Length == 0) return;

			if (propName[0] == nameof(_car.RightMotor))
			{
				switch (propName[1])
				{
					#region Right Motor
					case nameof(_car.RightMotor.ReqTorque):
						SetLabelText(RReqTorque, _car.RightMotor.ReqTorque.ToString());
						break;

					case nameof(_car.RightMotor.ReqPwm):
						SetLabelText(RReqPWM, _car.RightMotor.ReqPwm ? "On" : "Off");
						break;

					case nameof(_car.RightMotor.ReqSpeed):
						SetLabelText(RReqSpeed, _car.RightMotor.ReqSpeed.ToString());
						break;

					case nameof(_car.RightMotor.ReqSpeedController):
						SetLabelText(RReqSC, _car.RightMotor.ReqSpeedController ? "On" : "Off");
						break;

					case nameof(_car.RightMotor.EstTorque):
						SetLabelText(REstTorque, _car.RightMotor.EstTorque.ToString());
						break;

					case nameof(_car.RightMotor.EstSpeed):
						SetLabelText(REstSpeed, _car.RightMotor.EstSpeed.ToString());
						break;

					case nameof(_car.RightMotor.EstPower):
						SetLabelText(RPower, _car.RightMotor.EstPower.ToString());
						break;

					case nameof(_car.RightMotor.SupplyVoltage):
						SetLabelText(RVoltage, _car.RightMotor.SupplyVoltage.ToString());
						break;

					case nameof(_car.RightMotor.MotorTemp):
						SetLabelText(RMotorTemp, _car.RightMotor.MotorTemp.ToString());
						break;

					case nameof(_car.RightMotor.InverterTemp):
						SetLabelText(RInvTemp, _car.RightMotor.InverterTemp.ToString());
						break;

					case nameof(_car.RightMotor.MotorCurrent):
						SetLabelText(RCurrent, _car.RightMotor.MotorCurrent.ToString());
						break;

					case nameof(_car.RightMotor.EstPwm):
						SetLabelText(REstPWM, _car.RightMotor.EstPwm?"On":"Off");
						break;

					case nameof(_car.RightMotor.EstSpeedController):
						SetLabelText(REstSC, _car.RightMotor.EstSpeedController?"On":"Off");
						break;

					case nameof(_car.RightMotor.OverCurrent):
						SetLabelText(ROvercurrent, _car.RightMotor.OverCurrent.ToString());
						break;
					case nameof(_car.RightMotor.HighUdc):
						SetLabelText(RHUdc, _car.RightMotor.HighUdc.ToString());
						break;

					case nameof(_car.RightMotor.LowUdc):
						SetLabelText(RLUdc, _car.RightMotor.LowUdc.ToString());
						break;

					case nameof(_car.RightMotor.EmergencyStop):
						SetLabelText(REmergency, _car.RightMotor.EmergencyStop.ToString());
						break;

					case nameof(_car.RightMotor.InverterOverTemp):
						SetLabelText(RInvOvertemp, _car.RightMotor.InverterOverTemp.ToString());
						break;

					case nameof(_car.RightMotor.MotorOverTemp):
						SetLabelText(RMotorOvertemp, _car.RightMotor.MotorOverTemp.ToString());
						break;

					case nameof(_car.RightMotor.MotorOverload):
						SetLabelText(RMotorOverload, _car.RightMotor.MotorOverload.ToString());
						break;

					case nameof(_car.RightMotor.SensorFault):
						SetLabelText(RSensorFault, _car.RightMotor.SensorFault.ToString());
						break;

					case nameof(_car.RightMotor.CommunicationFault):
						SetLabelText(RCommFault, _car.RightMotor.CommunicationFault.ToString());
						break;

					case nameof(_car.RightMotor.OverSpeed):
						SetLabelText(RMotorOverspeed, _car.RightMotor.OverSpeed.ToString());
						break;

						#endregion Right Motor
				}
			}
			else
			{
				switch (propName[1])
				{
					#region Left Motor
					case nameof(_car.LeftMotor.ReqTorque):
						SetLabelText(LReqTorque, _car.LeftMotor.ReqTorque.ToString());
						break;

					case nameof(_car.LeftMotor.ReqPwm):
						SetLabelText(LReqPWM, _car.LeftMotor.ReqPwm ? "On" : "Off");
						break;

					case nameof(_car.LeftMotor.ReqSpeed):
						SetLabelText(LReqSpeed, _car.LeftMotor.ReqSpeed.ToString());
						break;

					case nameof(_car.LeftMotor.ReqSpeedController):
						SetLabelText(LReqSC, _car.LeftMotor.ReqSpeedController ? "On" : "Off");
						break;

					case nameof(_car.LeftMotor.EstTorque):
						SetLabelText(LEstTorque, _car.LeftMotor.EstTorque.ToString());
						break;

					case nameof(_car.LeftMotor.EstSpeed):
						SetLabelText(LEstSpeed, _car.LeftMotor.EstSpeed.ToString());
						break;

					case nameof(_car.LeftMotor.EstPower):
						SetLabelText(LPower, _car.LeftMotor.EstPower.ToString());
						break;

					case nameof(_car.LeftMotor.SupplyVoltage):
						SetLabelText(LVoltage, _car.LeftMotor.SupplyVoltage.ToString());
						break;

					case nameof(_car.LeftMotor.MotorTemp):
						SetLabelText(LMotorTemp, _car.LeftMotor.MotorTemp.ToString());
						break;

					case nameof(_car.LeftMotor.InverterTemp):
						SetLabelText(LInvTemp, _car.LeftMotor.InverterTemp.ToString());
						break;

					case nameof(_car.LeftMotor.MotorCurrent):
						SetLabelText(LCurrent, _car.LeftMotor.MotorCurrent.ToString());
						break;

					case nameof(_car.LeftMotor.EstPwm):
						SetLabelText(LEstPWM, _car.LeftMotor.EstPwm ? "On" : "Off");
						break;

					case nameof(_car.LeftMotor.EstSpeedController):
						SetLabelText(LEstSC, _car.LeftMotor.EstSpeedController ? "On" : "Off");
						break;

					case nameof(_car.LeftMotor.OverCurrent):
						SetLabelText(LOvercurrent, _car.LeftMotor.OverCurrent.ToString());
						break;
					case nameof(_car.LeftMotor.HighUdc):
						SetLabelText(LHUdc, _car.LeftMotor.HighUdc.ToString());
						break;

					case nameof(_car.LeftMotor.LowUdc):
						SetLabelText(LLUdc, _car.LeftMotor.LowUdc.ToString());
						break;

					case nameof(_car.LeftMotor.EmergencyStop):
						SetLabelText(LEmergency, _car.LeftMotor.EmergencyStop.ToString());
						break;

					case nameof(_car.LeftMotor.InverterOverTemp):
						SetLabelText(LInvOvertemp, _car.LeftMotor.InverterOverTemp.ToString());
						break;

					case nameof(_car.LeftMotor.MotorOverTemp):
						SetLabelText(LMotorOvertemp, _car.LeftMotor.MotorOverTemp.ToString());
						break;

					case nameof(_car.LeftMotor.MotorOverload):
						SetLabelText(LMotorOverload, _car.LeftMotor.MotorOverload.ToString());
						break;

					case nameof(_car.LeftMotor.SensorFault):
						SetLabelText(LSensorFault, _car.LeftMotor.SensorFault.ToString());
						break;

					case nameof(_car.LeftMotor.CommunicationFault):
						SetLabelText(LCommFault, _car.LeftMotor.CommunicationFault.ToString());
						break;

					case nameof(_car.LeftMotor.OverSpeed):
						SetLabelText(LMotorOverspeed, _car.LeftMotor.OverSpeed.ToString());
						break;

						#endregion Left Motor
				}
			}
			
		}

		private static void SetLabelText(Control l, string text)
		{
			if (l.InvokeRequired)
				l.Invoke(new MethodInvoker(delegate { l.Text = text; }));
			else
				l.Text = text;
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
