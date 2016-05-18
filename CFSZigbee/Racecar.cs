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

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
