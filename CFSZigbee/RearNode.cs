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

namespace CFSZigbee
{
	public partial class RearNode : Form
	{
		private readonly Racecar _car = Racecar.Instance;
		readonly SerialPort _xBee;
		public RearNode(SerialPort sp)
		{
			InitializeComponent();
			_car.PropertyChanged += CarOnPropertyChanged;

			_xBee = sp;
		}

		private void CarOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			switch (propertyChangedEventArgs.PropertyName)
			{
				case nameof(_car.ShutdownCurrent):
					SetLabelText(lblShutdownCurrent, _car.ShutdownCurrent?"ON":"OFF");
					break;

				case nameof(_car.LeftSpringTravel):
					SetLabelText(lblLeftSpring, _car.LeftSpringTravel.ToString());
					break;

				case nameof(_car.RightSpringTravel):
					SetLabelText(lblRightSpring, _car.RightSpringTravel.ToString());
					break;

				case nameof(_car.WaterTempIn):
					SetLabelText(lblWaterIn, _car.WaterTempIn.ToString());
					break;

				case nameof(_car.WaterTempOut):
					SetLabelText(lblWaterOut, _car.WaterTempOut.ToString());
					break;

				case nameof(_car.X):
					SetLabelText(lblX, _car.X.ToString());
					break;

				case nameof(_car.Y):
					SetLabelText(lblY, _car.Y.ToString());
					break;

				case nameof(_car.Z):
					SetLabelText(lblZ, _car.Z.ToString());
					break;

				case nameof(_car.Xrot):
					SetLabelText(lblXrot, _car.Xrot.ToString());
					break;

				case nameof(_car.Yrot):
					SetLabelText(lblYrot, _car.Yrot.ToString());
					break;

				case nameof(_car.Zrot):
					SetLabelText(lblZrot, _car.Zrot.ToString());
					break;

				case nameof(_car.AmbientTemp):
					SetLabelText(lblAmbientTemp, _car.AmbientTemp.ToString());
					break;
			}

		}

		private static void SetLabelText(Control l, string text)
		{
			if (l.InvokeRequired)
				l.Invoke(new MethodInvoker(delegate { l.Text = text; }));
			else
				l.Text = text;
		}

		private void RearNode_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}


		private readonly byte[] _poll = { 0x7B, 0x7B, 0x01, 0x04, 0x04 }; // Poll for rear node data
		private readonly byte[] _stopPoll = { 0x7B, 0x7B, 0x00, 0x04, 0x04 }; // Stop polling for rear node data
		private void RearNode_VisibleChanged(object sender, EventArgs e)
		{
			if (_xBee.IsOpen)
			{
				_xBee.Write(Visible ? _poll : _stopPoll, 0, 5);
			}
		}
	}
}
