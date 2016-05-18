using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;


namespace CFSZigbee
{
	public partial class Form1 : Form
	{
		Racecar car;
		private Queue<byte> recievedData = new Queue<byte>();
		Thread childThread;
		FrontNode FN;
		RearNode RN;

		public Form1()
		{
			InitializeComponent();
			car = Racecar.Instance;
			FN = new FrontNode(xBee);
			RN = new RearNode(xBee);
			ThreadStart childref = new ThreadStart(() => readSerial(xBee));
			childThread = new Thread(childref);
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

				if(childThread.ThreadState != System.Threading.ThreadState.Running)
					childThread.Start();

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


		byte[] stopPoll = new byte[10] { 0x7A, 0x7A, 0x00, 0x04, 0x04, 0x7B, 0x7B, 0x00, 0x04, 0x04 }; // Stop polling for all nodes
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{



			if(childThread.IsAlive)
				childThread.Abort();

			if (xBee.IsOpen)
			{
				xBee.Write(stopPoll, 0, 5);
				xBee.Write(stopPoll, 5, 5);
				xBee.Close();
			}
			FN.Close();
			RN.Close();

			FN.Dispose();
			RN.Dispose();
		}

		
		private void btnFrontNode_Click(object sender, EventArgs e)
		{
			FN.Show();
		}

		private void btnRearNode_Click(object sender, EventArgs e)
		{
			RN.Show();
		}

		// Read serial data from zigbee in different thread
		private static void readSerial(SerialPort sp)
		{
			Racecar rc = Racecar.Instance;

			int b1, b2;

			

			while (true)
			{

				if (!sp.IsOpen)
					continue;

				if (sp.BytesToRead < 2)
					continue;

				//2 sync bytes
				b1 = sp.ReadByte();
				if (b1 != 0x7E)
					continue;

				b2 = sp.ReadByte();

				if ((b1 & b2) == 0x7E)
				{
					//Then the function code
					switch (sp.ReadByte())
					{
						case 1: // Front Node
							//First byte is the error byte
							int error = sp.ReadByte();

							for (int i = 0; i < rc.Errors.Count; i++)
							{
								rc.Errors[(Racecar.ErrorType)i] = (error & (1 << i)) != 0;
							}

							//Second byte is RTD
							int rtd = sp.ReadByte();
							rc.RTD = rtd != 0;
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
