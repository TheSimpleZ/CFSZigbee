using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace CFSZigbee
{
	public partial class Form1 : Form
	{
		readonly Thread _childThread;
		private readonly FrontNode _fn;
		private readonly RearNode _rn;

		public Form1()
		{
			InitializeComponent();
			_fn = new FrontNode(xBee);
			_rn = new RearNode(xBee);
			ThreadStart childref = () => ReadSerial(xBee);
			_childThread = new Thread(childref);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbComPorts.Items.AddRange(SerialPort.GetPortNames());
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			cbComPorts.Items.Clear();
			cbComPorts.Items.AddRange(SerialPort.GetPortNames());
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (!xBee.IsOpen)
			{
				xBee.PortName = (string)cbComPorts.SelectedItem;
				cbComPorts.Enabled = false;
				btnRefresh.Enabled = false;
				xBee.Open();

				if(_childThread.ThreadState != ThreadState.Running)
					_childThread.Start();

				btnOpen.Text = "Close";
			} else
			{
				cbComPorts.Enabled = true;
				btnRefresh.Enabled = true;
				//childThread.Abort();
				xBee.Close();
				btnOpen.Text = "Open";
			}
		}


		readonly byte[] _stopPoll = { 0x7A, 0x7A, 0x00, 0x04, 0x04, 0x7B, 0x7B, 0x00, 0x04, 0x04 }; // Stop polling for all nodes
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{



			if(_childThread.IsAlive)
				_childThread.Abort();

			if (xBee.IsOpen)
			{
				xBee.Write(_stopPoll, 0, 5);
				xBee.Write(_stopPoll, 5, 5);
				xBee.Close();
			}
			_fn.Close();
			_rn.Close();

			_fn.Dispose();
			_rn.Dispose();
		}

		
		private void btnFrontNode_Click(object sender, EventArgs e)
		{
			_fn.Show();
		}

		private void btnRearNode_Click(object sender, EventArgs e)
		{
			_rn.Show();
		}

		// Read serial data from zigbee in different thread
		private static void ReadSerial(SerialPort sp)
		{
			var rc = Racecar.Instance;


			while (true)
			{

				if (!sp.IsOpen)
					continue;

				if (sp.BytesToRead < 2)
					continue;

				//2 sync bytes
				var b1 = sp.ReadByte();

				if (b1 != 0x7E) continue;

				var b2 = sp.ReadByte();

				if ((b1 & b2) != 0x7E) continue;

				//Then the function code
				// ReSharper disable SwitchStatementMissingSomeCases
				switch (sp.ReadByte())
					// ReSharper restore SwitchStatementMissingSomeCases
				{
					case 1: // Front Node
						
						// First byte: RTD
						var rtd = sp.ReadByte();
						rc.Rtd = rtd != 0;

						// Second byte: error byte
						var error = sp.ReadByte();

						rc.ThrottleImplaus			= (error & (1 << 1)) != 0;
						rc.Throttle1Fault				= (error & (1 << 2)) != 0;
						rc.Throttle2Fault				= (error & (1 << 3)) != 0;
						rc.ThrottleBrakeImplaus = (error & (1 << 4)) != 0;
						rc.FrontBrakeFault						= (error & (1 << 5)) != 0;

						// Third & 4th byte: Brake temps
						rc.LeftBrakeTemp = sp.ReadByte();
						rc.RightBrakeTemp = sp.ReadByte();

						// 5th byte: Throttle position
						rc.ThrottlePosition = sp.ReadByte();
						
						// 6th byte: Front Brake Pressure
						rc.FrontBrakePressure = sp.ReadByte();
						
						// 7th byte: Steering Position
						rc.SteeringPosition = sp.ReadByte();

						// 8th byte: Right Wheel Speed
						rc.RightWheelSpeed = (uint) (sp.ReadByte() | (sp.ReadByte() << 8));

						// 9th byte: Left Wheel Speed
						rc.LeftWheelSpeed = (uint) (sp.ReadByte() | (sp.ReadByte() << 8));


						break;

					case 2: // Rear Node
						rc.ShutdownCurrent = sp.ReadByte() != 0;
						rc.ThrottlePosition = sp.ReadByte() | (sp.ReadByte() << 8);
						break;
				}

				//Remove terminators
				sp.ReadByte();
				sp.ReadByte();
			}
		}

		public static bool IsFormOpen(Type FormType)
		{
			foreach (Form OpenForm in Application.OpenForms)
			{
				if (OpenForm.GetType() == FormType)
					return true;
			}

			return false;
		}
	}
}
