using System.ComponentModel;
using System.Runtime.CompilerServices;
using CFSZigbee.Annotations;
using CFSZigbee.Properties;

namespace CFSZigbee
{
	class Motor : INotifyPropertyChanged
	{
		private byte _setBits, _statusBits;
		private ushort _errors;


		private int _estSpeed;
		private int _estTorque;
		private uint _inverterTemp;
		private int _motorCurrent;
		private uint _motorTemp;
		private int _reqSpeed;
		private int _reqTorque;
		private uint _supplyVoltage;
		private uint _estPower;

		public Motor()
		{
		}

		private static bool IsBitSet(byte val, int pos)
		{
			return (val & (1 << pos)) == (1 << pos);
		}

		private static bool IsBitSet(ushort val, int pos)
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

		public static void Setbit(ref ushort aByte, int pos, bool value)
		{
			if (value)
			{
				//left-shift 1, then bitwise OR
				aByte = (ushort)(aByte | (1 << pos));
			}
			else
			{
				//left-shift 1, then take complement, then bitwise AND
				aByte = (ushort)(aByte & ~(1 << pos));
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

				OnPropertyChanged( nameof(ReqPwm));
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

				OnPropertyChanged( nameof(ReqSpeedController));
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

				OnPropertyChanged( nameof(EstPwm));
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

				OnPropertyChanged( nameof(EstSpeedController));
			}
		}

		public uint EstPower
		{
			get { return _estPower; }
			set
			{
				if (value == _estPower) return;
				_estPower = value;
				OnPropertyChanged( nameof(EstPower));
			}
		}

		public int EstSpeed
		{
			get { return _estSpeed; }
			set
			{
				if (value == _estSpeed) return;
				_estSpeed = value;
				OnPropertyChanged( nameof(EstSpeed));
			}
		}

		public int EstTorque
		{
			get { return _estTorque; }
			set
			{
				if (value == _estTorque) return;
				_estTorque = value;
				OnPropertyChanged( nameof(EstTorque));
			}
		}

		public uint InverterTemp
		{
			get { return _inverterTemp; }
			set
			{
				if (value == _inverterTemp) return;
				_inverterTemp = value;
				OnPropertyChanged( nameof(InverterTemp));
			}
		}

		public int MotorCurrent
		{
			get { return _motorCurrent; }
			set
			{
				if (value == _motorCurrent) return;
				_motorCurrent = value;
				OnPropertyChanged( nameof(MotorCurrent));
			}
		}

		public uint MotorTemp
		{
			get { return _motorTemp; }
			set
			{
				if (value == _motorTemp) return;
				_motorTemp = value;
				OnPropertyChanged( nameof(MotorTemp));
			}
		}

		public int ReqSpeed
		{
			get { return _reqSpeed; }
			set
			{
				if (value == _reqSpeed) return;
				_reqSpeed = value;
				OnPropertyChanged( nameof(ReqSpeed));
			}
		}

		public int ReqTorque
		{
			get { return _reqTorque; }
			set
			{
				if (value == _reqTorque) return;
				_reqTorque = value;
				OnPropertyChanged( nameof(ReqTorque));
			}
		}

		public uint SupplyVoltage
		{
			get { return _supplyVoltage; }
			set
			{
				if (value == _supplyVoltage) return;
				_supplyVoltage = value;
				OnPropertyChanged( nameof(SupplyVoltage));
			}
		}

		public bool OverCurrent
		{
			get { return IsBitSet(_errors, 0); }
			set
			{
				if (value && IsBitSet(_errors, 0) || !(value || IsBitSet(_errors, 0)))
					return;

				Setbit(ref _errors, 0, value);

				OnPropertyChanged( nameof(OverCurrent));
			}
		}

		public bool HighUdc
		{
			get { return IsBitSet(_errors, 1); }
			set
			{
				if (value && IsBitSet(_errors, 1) || !(value || IsBitSet(_errors, 1)))
					return;

				Setbit(ref _errors, 1, value);
				OnPropertyChanged( nameof(HighUdc));
			}
		}

		public bool LowUdc
		{
			get { return IsBitSet(_errors, 2); }
			set
			{
				if (value && IsBitSet(_errors, 2) || !(value || IsBitSet(_errors, 2)))
					return;

				Setbit(ref _errors, 2, value);
				OnPropertyChanged( nameof(LowUdc));
			}
		}

		public bool EmergencyStop
		{
			get { return IsBitSet(_errors, 3); }
			set
			{
				if (value && IsBitSet(_errors, 3) || !(value || IsBitSet(_errors, 3)))
					return;

				Setbit(ref _errors, 3, value);
				OnPropertyChanged( nameof(EmergencyStop));
			}
		}

		public bool MotorOverTemp
		{
			get { return IsBitSet(_errors, 4); }
			set
			{
				if (value && IsBitSet(_errors, 4) || !(value || IsBitSet(_errors, 4)))
					return;

				Setbit(ref _errors, 4, value);
				OnPropertyChanged( nameof(MotorOverTemp));
			}
		}

		public bool InverterOverTemp
		{
			get { return IsBitSet(_errors, 5); }
			set
			{
				if (value && IsBitSet(_errors, 5) || !(value || IsBitSet(_errors, 5)))
					return;

				Setbit(ref _errors, 5, value);
				OnPropertyChanged( nameof(InverterOverTemp));
			}
		}

		public bool MotorOverload
		{
			get { return IsBitSet(_errors, 6); }
			set
			{
				if (value && IsBitSet(_errors, 6) || !(value || IsBitSet(_errors, 6)))
					return;

				Setbit(ref _errors, 6, value);
				OnPropertyChanged( nameof(MotorOverload));
			}
		}

		public bool SensorFault
		{
			get { return IsBitSet(_errors, 7); }
			set
			{
				if (value && IsBitSet(_errors, 7) || !(value || IsBitSet(_errors, 7)))
					return;

				Setbit(ref _errors, 7, value);
				OnPropertyChanged( nameof(SensorFault));
			}
		}

		public bool CommunicationFault
		{
			get { return IsBitSet(_errors, 8); }
			set
			{
				if (value && IsBitSet(_errors, 8) || !(value || IsBitSet(_errors, 8)))
					return;

				Setbit(ref _errors, 8, value);
				OnPropertyChanged( nameof(CommunicationFault));
			}
		}

		public bool OverSpeed
		{
			get { return IsBitSet(_errors, 9); }
			set
			{
				if (value && IsBitSet(_errors, 9) || !(value || IsBitSet(_errors, 9)))
					return;

				Setbit(ref _errors, 9, value);
				OnPropertyChanged( nameof(OverSpeed));
			}
		}

		public byte SetBits
		{
			get { return _setBits; }
			set
			{
				if (_setBits == value)
					return;
				_setBits = value;
				OnPropertyChanged( nameof(ReqPwm));
				OnPropertyChanged( nameof(ReqSpeedController));
			}
		}

		public byte StatusBits
		{
			get { return _statusBits; }
			set
			{
				if(_statusBits == value)
					return;

				_statusBits = value;
				OnPropertyChanged( nameof(EstPwm));
				OnPropertyChanged( nameof(EstSpeedController));
			}
		}

		public ushort Errors
		{
			get { return _errors; }
			set
			{
				if (_errors == value)
					return;

				_errors = value;
				OnPropertyChanged( nameof(OverCurrent));
				OnPropertyChanged( nameof(HighUdc));
				OnPropertyChanged( nameof(LowUdc));
				OnPropertyChanged( nameof(EmergencyStop));
				OnPropertyChanged( nameof(InverterOverTemp));
				OnPropertyChanged( nameof(MotorOverTemp));
				OnPropertyChanged( nameof(MotorOverload));
				OnPropertyChanged( nameof(SensorFault));
				OnPropertyChanged( nameof(CommunicationFault));
				OnPropertyChanged( nameof(OverSpeed));
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
