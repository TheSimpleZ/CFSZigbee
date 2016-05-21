using System.IO.Ports;
using System.Windows.Forms;

namespace CFSZigbee
{
	public partial class PowerElectronics : Form
	{
		private readonly SerialPort _xBee;

		public PowerElectronics(SerialPort sp)
		{
			InitializeComponent();

			_xBee = sp;

			// Left Req
			LReqTorque.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.ReqTorque", true, DataSourceUpdateMode.OnPropertyChanged));
			LReqSpeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.ReqSpeed", true, DataSourceUpdateMode.OnPropertyChanged));
			LReqPWM.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.ReqPwm", true, DataSourceUpdateMode.OnPropertyChanged));
			LReqSC.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.ReqSpeedController", true, DataSourceUpdateMode.OnPropertyChanged));


			// Left Est
			LEstTorque.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EstTorque", true, DataSourceUpdateMode.OnPropertyChanged));
			LEstSpeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EstSpeed", true, DataSourceUpdateMode.OnPropertyChanged));
			LEstPWM.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EstPwm", true, DataSourceUpdateMode.OnPropertyChanged));
			LEstSC.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EstSpeedController", true, DataSourceUpdateMode.OnPropertyChanged));
			LPower.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EstPower", true, DataSourceUpdateMode.OnPropertyChanged));
			LVoltage.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.SupplyVoltage", true, DataSourceUpdateMode.OnPropertyChanged));
			LMotorTemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.MotorTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			LInvTemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.InverterTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			LCurrent.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.MotorCurrent", true, DataSourceUpdateMode.OnPropertyChanged));


			// Left Errors
			LOvercurrent.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.OverCurrent", true, DataSourceUpdateMode.OnPropertyChanged));
			LHUdc.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.HighUdc", true, DataSourceUpdateMode.OnPropertyChanged));
			LLUdc.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.LowUdc", true, DataSourceUpdateMode.OnPropertyChanged));
			LEmergency.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.EmergencyStop", true, DataSourceUpdateMode.OnPropertyChanged));
			LInvOvertemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.InverterOverTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			LMotorOvertemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.MotorOverTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			LMotorOverload.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.MotorOverload", true, DataSourceUpdateMode.OnPropertyChanged));
			LSensorFault.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.SensorFault", true, DataSourceUpdateMode.OnPropertyChanged));
			LCommFault.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.CommunicationFault", true, DataSourceUpdateMode.OnPropertyChanged));
			LMotorOverspeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "LeftMotor.OverSpeed", true, DataSourceUpdateMode.OnPropertyChanged));


			// Right Req
			RReqTorque.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.ReqTorque", true, DataSourceUpdateMode.OnPropertyChanged));
			RReqSpeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.ReqSpeed", true, DataSourceUpdateMode.OnPropertyChanged));
			RReqPWM.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.ReqPwm", true, DataSourceUpdateMode.OnPropertyChanged));
			RReqSC.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.ReqSpeedController", true, DataSourceUpdateMode.OnPropertyChanged));


			// Right Est
			REstTorque.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EstTorque", true, DataSourceUpdateMode.OnPropertyChanged));
			REstSpeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EstSpeed", true, DataSourceUpdateMode.OnPropertyChanged));
			REstPWM.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EstPwm", true, DataSourceUpdateMode.OnPropertyChanged));
			REstSC.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EstSpeedController", true, DataSourceUpdateMode.OnPropertyChanged));
			RPower.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EstPower", true, DataSourceUpdateMode.OnPropertyChanged));
			RVoltage.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.SupplyVoltage", true, DataSourceUpdateMode.OnPropertyChanged));
			RMotorTemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.MotorTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			RInvTemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.InverterTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			RCurrent.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.MotorCurrent", true, DataSourceUpdateMode.OnPropertyChanged));




			// Right Errors
			ROvercurrent.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.OverCurrent", true, DataSourceUpdateMode.OnPropertyChanged));
			RHUdc.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.HighUdc", true, DataSourceUpdateMode.OnPropertyChanged));
			RLUdc.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.LowUdc", true, DataSourceUpdateMode.OnPropertyChanged));
			REmergency.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.EmergencyStop", true, DataSourceUpdateMode.OnPropertyChanged));
			RInvOvertemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.InverterOverTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			RMotorOvertemp.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.MotorOverTemp", true, DataSourceUpdateMode.OnPropertyChanged));
			RMotorOverload.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.MotorOverload", true, DataSourceUpdateMode.OnPropertyChanged));
			RSensorFault.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.SensorFault", true, DataSourceUpdateMode.OnPropertyChanged));
			RCommFault.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.CommunicationFault", true, DataSourceUpdateMode.OnPropertyChanged));
			RMotorOverspeed.DataBindings.Add(new Binding("Text", racecarBindingSource, "RightMotor.OverSpeed", true, DataSourceUpdateMode.OnPropertyChanged));

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
