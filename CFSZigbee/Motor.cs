using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CFSZigbee.Annotations;

namespace CFSZigbee
{
	class Motor : INotifyPropertyChanged
	{
		private byte _setBits, _statusBits;

		public Dictionary<ErrorType, bool> Errors = new Dictionary<ErrorType, bool>();
		private int _estSpeed;
		private int _estTorque;
		private int _inverterTemp;
		private int _motorCurrent;
		private int _motorTemp;
		private int _reqSpeed;
		private int _reqTorque;
		private int _supplyVoltage;
		private int _estPower;

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
			set
			{
				if (value && IsBitSet(_setBits, 2) || !(value || IsBitSet(_setBits, 2)) )
					return;

				Setbit(ref _setBits, 2, value);

				OnPropertyChanged(nameof(ReqPwm));
			}
		}

		public bool ReqSpeedController
		{
			get { return IsBitSet(_setBits, 4); }
			set
			{
				if (value && IsBitSet(_setBits, 4) || !(value || IsBitSet(_setBits, 4)))
					return;

				Setbit(ref _setBits, 4, value);

				OnPropertyChanged(nameof(ReqSpeedController));
			}
		}

		public bool EstPwm
		{
			get { return IsBitSet(_statusBits, 3); }
			set
			{
				if (value && IsBitSet(_statusBits, 3) || !(value || IsBitSet(_statusBits, 3)))
					return;

				Setbit(ref _statusBits, 3, value);

				OnPropertyChanged(nameof(EstPwm));
			}
		}

		public bool EstSpeedController
		{
			get { return IsBitSet(_statusBits, 5); }
			set
			{
				if (value && IsBitSet(_statusBits, 5) || !(value || IsBitSet(_statusBits, 5)))
					return;

				Setbit(ref _statusBits, 5, value);

				OnPropertyChanged(nameof(EstSpeedController));
			}
		}

		public int EstPower
		{
			get { return _estPower; }
			set
			{
				if (value == _estPower) return;
				_estPower = value;
				OnPropertyChanged(nameof(EstPower));
			}
		}

		public int EstSpeed
		{
			get { return _estSpeed; }
			set
			{
				if (value == _estSpeed) return;
				_estSpeed = value;
				OnPropertyChanged(nameof(EstSpeed));
			}
		}

		public int EstTorque
		{
			get { return _estTorque; }
			set
			{
				if (value == _estTorque) return;
				_estTorque = value;
				OnPropertyChanged(nameof(EstTorque));
			}
		}

		public int InverterTemp
		{
			get { return _inverterTemp; }
			set
			{
				if (value == _inverterTemp) return;
				_inverterTemp = value;
				OnPropertyChanged(nameof(InverterTemp));
			}
		}

		public int MotorCurrent
		{
			get { return _motorCurrent; }
			set
			{
				if (value == _motorCurrent) return;
				_motorCurrent = value;
				OnPropertyChanged(nameof(MotorCurrent));
			}
		}

		public int MotorTemp
		{
			get { return _motorTemp; }
			set
			{
				if (value == _motorTemp) return;
				_motorTemp = value;
				OnPropertyChanged(nameof(MotorTemp));
			}
		}

		public int ReqSpeed
		{
			get { return _reqSpeed; }
			set
			{
				if (value == _reqSpeed) return;
				_reqSpeed = value;
				OnPropertyChanged(nameof(ReqSpeed));
			}
		}

		public int ReqTorque
		{
			get { return _reqTorque; }
			set
			{
				if (value == _reqTorque) return;
				_reqTorque = value;
				OnPropertyChanged(nameof(ReqTorque));
			}
		}

		public int SupplyVoltage
		{
			get { return _supplyVoltage; }
			set
			{
				if (value == _supplyVoltage) return;
				_supplyVoltage = value;
				OnPropertyChanged(nameof(SupplyVoltage));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
