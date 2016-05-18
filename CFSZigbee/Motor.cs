using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFSZigbee
{
	class Motor
	{
		private byte _setBits, _statusBits;

		public Dictionary<ErrorType, bool> Errors = new Dictionary<ErrorType, bool>();

		public Motor ()
		{
			foreach (var value in Enum.GetValues(typeof(ErrorType)).Cast<ErrorType>())
			{
				Errors.Add(value, false);
			}
		}

		public enum ErrorType
		{
			OverCurrent = 0,
			HighUdc,
			LowUdc,
			EmergencyStop,
			MotorOverTemp,
			InverterOverTemp,
			MotorOverload,
			SensorFault,
			CommunicationFault,
			OverSpeed
		}

		private static bool IsBitSet(byte val, int pos)
		{
			return (val & (1 << pos)) == (1 << pos);
		}

		public static void Setbit(ref byte aByte, int pos, bool value)
		{
			if (value)
			{
				//left-shift 1, then bitwise OR
				aByte = (byte)(aByte | (1 << pos));
			}
			else
			{
				//left-shift 1, then take complement, then bitwise AND
				aByte = (byte)(aByte & ~(1 << pos));
			}
		}

		public bool ReqPwm
		{
			get { return IsBitSet(_setBits, 2); }
			set { Setbit(ref _setBits, 2, value); }
		}

		public bool ReqSpeedController
		{
			get { return IsBitSet(_setBits, 4); }
			set { Setbit(ref _setBits, 4, value); }
		}

		public bool EstPwm
		{
			get { return IsBitSet(_statusBits, 3); }
			set { Setbit(ref _statusBits, 3, value); }
		}

		public bool EstSpeedController
		{
			get { return IsBitSet(_statusBits, 5); }
			set { Setbit(ref _statusBits, 5, value); }
		}

		public int EstPower { get; set; }

		public int EstSpeed { get; set; }

		public int EstTorque { get; set; }

		public int InverterTemp { get; set; }

		public int MotorCurrent { get; set; }

		public int MotorTemp { get; set; }

		public int ReqSpeed { get; set; }

		public int ReqTorque { get; set; }

		public int SupplyVoltage { get; set; }
	}
}
