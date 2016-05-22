using System.ComponentModel;
using System.Runtime.CompilerServices;
using CFSZigbee.Annotations;

namespace CFSZigbee
{
	class Racecar : INotifyPropertyChanged
	{
		private static readonly Racecar _instance = new Racecar();

		static Racecar()
		{ }

		private Racecar()
		{
			RightMotor = new Motor();
			LeftMotor = new Motor();
		}

		// Errors.
		private bool _throttleImplaus;
		private bool _throttle1Fault;
		private bool _throttle2Fault;
		private bool _throttleBrakeImplaus;
		private bool _brakeFault;


		private bool _rtd;
		private bool _shutdownCurrent;
		private int _throttlePosition;
		private int _radiatorFanDutyCycle;
		private int _batteryFansDutyCycle;
		private int _steeringPosition;
		private int _frontBrakePressure;
		private int _rightBrakeTemp;
		private int _leftBrakeTemp;
		private double _x;
		private double _y;
		private double _z;
		private double _xrot;
		private double _yrot;
		private double _zrot;
		private double _ambientTemp;
		private double _waterTempIn;
		private double _waterTempOut;
		private int _leftSpringTravel;
		private int _rightSpringTravel;
		public Motor LeftMotor { get; }
		public Motor RightMotor { get; }


		public static Racecar Instance => _instance;

		public bool Rtd
		{
			get { return _rtd; }
			set
			{
				if (Equals(_rtd, value))
					return;

				_rtd = value;
				OnPropertyChanged(nameof(Rtd));
			}
		}

		public int ThrottlePosition
		{
			get { return _throttlePosition; }
			set
			{
				if (Equals(_throttlePosition, value))
					return;

				_throttlePosition = value;
				OnPropertyChanged(nameof(ThrottlePosition));
			}
		}

		public int RadiatorFanDutyCycle
		{
			get { return _radiatorFanDutyCycle; }
			set
			{
				if (Equals(_radiatorFanDutyCycle, value))
					return;

				_radiatorFanDutyCycle = value;
				OnPropertyChanged(nameof(RadiatorFanDutyCycle));
			}
		}

		public int BatteryFansDutyCycle
		{
			get { return _batteryFansDutyCycle; }
			set
			{
				if (Equals(_batteryFansDutyCycle, value))
					return;

				_batteryFansDutyCycle = value;
				OnPropertyChanged(nameof(BatteryFansDutyCycle));
			}
		}

		public bool ShutdownCurrent
		{
			get { return _shutdownCurrent; }
			set
			{
				if (Equals(_shutdownCurrent, value))
					return;

				_shutdownCurrent = value;
				OnPropertyChanged(nameof(ShutdownCurrent));
			}
		}

		public bool ThrottleImplaus
		{
			get { return _throttleImplaus; }
			set
			{
				if (Equals(_throttleImplaus, value))
					return;

				_throttleImplaus = value;
				OnPropertyChanged(nameof(ThrottleImplaus));
			}
		}

		public bool Throttle1Fault
		{
			get { return _throttle1Fault; }
			set
			{
				if (Equals(_throttle1Fault, value))
					return;

				_throttle1Fault = value;
				OnPropertyChanged(nameof(Throttle1Fault));
			}
		}

		public bool Throttle2Fault
		{
			get { return _throttle2Fault; }
			set
			{
				if (Equals(_throttle2Fault, value))
					return;

				_throttle2Fault = value;
				OnPropertyChanged(nameof(Throttle2Fault));
			}
		}

		public bool ThrottleBrakeImplaus
		{
			get { return _throttleBrakeImplaus; }
			set
			{
				if (Equals(_throttleBrakeImplaus, value))
					return;

				_throttleBrakeImplaus = value;
				OnPropertyChanged(nameof(ThrottleBrakeImplaus));
			}
		}

		public bool BrakeFault
		{
			get { return _brakeFault; }
			set
			{
				if (Equals(_brakeFault, value))
					return;

				_brakeFault = value;
				OnPropertyChanged(nameof(BrakeFault));
			}
		}

		public int LeftBrakeTemp
		{
			get { return _leftBrakeTemp; }
			set
			{
				if (value == _leftBrakeTemp) return;
				_leftBrakeTemp = value;
				OnPropertyChanged(nameof(LeftBrakeTemp));
			}
		}

		public int RightBrakeTemp
		{
			get { return _rightBrakeTemp; }
			set
			{
				if (value == _rightBrakeTemp) return;
				_rightBrakeTemp = value;
				OnPropertyChanged(nameof(RightBrakeTemp));
			}
		}

		public int FrontBrakePressure
		{
			get { return _frontBrakePressure; }
			set
			{
				if (value == _frontBrakePressure) return;
				_frontBrakePressure = value;
				OnPropertyChanged(nameof(FrontBrakePressure));
			}
		}

		public int SteeringPosition
		{
			get { return _steeringPosition; }
			set
			{
				if (value == _steeringPosition) return;
				_steeringPosition = value;
				OnPropertyChanged(nameof(SteeringPosition));
			}
		}
#region IMU
		public double X
		{
			get { return _x; }
			set
			{
				if (value.Equals(_x)) return;
				_x = value;
				OnPropertyChanged(nameof(X));
			}
		}

		public double Y
		{
			get { return _y; }
			set
			{
				if (value.Equals(_y)) return;
				_y = value;
				OnPropertyChanged(nameof(Y));
			}
		}

		public double Z
		{
			get { return _z; }
			set
			{
				if (value.Equals(_z)) return;
				_z = value;
				OnPropertyChanged(nameof(Z));
			}
		}

		public double Xrot
		{
			get { return _xrot; }
			set
			{
				if (value.Equals(_xrot)) return;
				_xrot = value;
				OnPropertyChanged(nameof(Xrot));
			}
		}

		public double Yrot
		{
			get { return _yrot; }
			set
			{
				if (value.Equals(_yrot)) return;
				_yrot = value;
				OnPropertyChanged(nameof(Yrot));
			}
		}

		public double Zrot
		{
			get { return _zrot; }
			set
			{
				if (value.Equals(_zrot)) return;
				_zrot = value;
				OnPropertyChanged(nameof(Zrot));
			}
		}

		public double AmbientTemp
		{
			get { return _ambientTemp; }
			set
			{
				if (value.Equals(_ambientTemp)) return;
				_ambientTemp = value;
				OnPropertyChanged(nameof(AmbientTemp));
			}
		}
#endregion
		public double WaterTempIn
		{
			get { return _waterTempIn; }
			set
			{
				if (value.Equals(_waterTempIn)) return;
				_waterTempIn = value;
				OnPropertyChanged(nameof(WaterTempIn));
			}
		}

		public double WaterTempOut
		{
			get { return _waterTempOut; }
			set
			{
				if (value.Equals(_waterTempOut)) return;
				_waterTempOut = value;
				OnPropertyChanged(nameof(WaterTempOut));
			}
		}

		public int LeftSpringTravel
		{
			get { return _leftSpringTravel; }
			set
			{
				if (value == _leftSpringTravel) return;
				_leftSpringTravel = value;
				OnPropertyChanged(nameof(LeftSpringTravel));
			}
		}

		public int RightSpringTravel
		{
			get { return _rightSpringTravel; }
			set
			{
				if (value == _rightSpringTravel) return;
				_rightSpringTravel = value;
				OnPropertyChanged(nameof(RightSpringTravel));
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
