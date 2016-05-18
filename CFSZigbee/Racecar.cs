using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFSZigbee
{
	class Racecar
	{
		private static readonly Racecar _instance = new Racecar();

		static Racecar()
		{ }

		private Racecar()
		{
			foreach(var value in Enum.GetValues(typeof(ErrorType)).Cast<ErrorType>())
			{
				Errors.Add(value, false);
			}
		}

		public Dictionary<ErrorType, bool> Errors = new Dictionary<ErrorType, bool>();



		public enum ErrorType
		{
			TorqueImplaus = 0,
			Throttle1Fault,
			Throttle2Fault,
			ThrottleBrakeImplaus,
			BrakeFault

		}

		public bool Rtd = false, ShutdownCurrent = false;
		public int TorqueEncoderPosition = 0, TorqueReqLeft = 0, TorqueReqRight = 0, RadiatorFanDutyCycle = 0, BatteryFansDutyCycle = 0;
		public Motor LeftMotor = new Motor();
		public Motor RightMotor = new Motor();




		public static Racecar Instance => _instance;
	}
}
