using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFSZigbee
{
	class Racecar
	{
		private static readonly Racecar instance = new Racecar();

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



		public enum ErrorType : int
		{
			torqueImplaus = 0,
			throttle1Fault,
			throttle2Fault,
			throttleBrakeImplaus,
			brakeFault

		}

		public bool RTD = false, ShutdownCurrent = false, PWMLeft = false, PWMRight = false;
		public int TorqueEncoderPosition = 0, TorqueReqLeft = 0, TorqueReqRight = 0, RadiatorFanDutyCycle = 0, BatteryFansDutyCycle = 0;
		public byte setBits




		public static Racecar Instance
		{
			get { return instance; }
		}



		}
}
