﻿using System;
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

			int b1, b2;

			

			while (true)
			{

				if (!sp.IsOpen)
					continue;

				if (sp.BytesToRead < 2)
					continue;

				//2 sync bytes
				b1 = sp.ReadByte();

				if (b1 != 0x7E) continue;

				b2 = sp.ReadByte();

				if ((b1 & b2) != 0x7E) continue;

				//Then the function code
				switch (sp.ReadByte())
				{
					case 1: // Front Node
						//First byte is the error byte
						var error = sp.ReadByte();

						for (var i = 0; i < rc.Errors.Count; i++)
						{
							rc.Errors[(Racecar.ErrorType)i] = (error & (1 << i)) != 0;
						}

						//Second byte is RTD
						var rtd = sp.ReadByte();
						rc.Rtd = rtd != 0;
						break;

					case 2: // Rear Node
						rc.ShutdownCurrent = sp.ReadByte() != 0;
						rc.TorqueEncoderPosition = sp.ReadByte() | (sp.ReadByte() << 8);
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
