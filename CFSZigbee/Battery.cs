using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFSZigbee
{
	public partial class Battery : Form
	{

		private readonly Racecar _car = Racecar.Instance;
		private readonly SerialPort _xBee;

		public Battery(SerialPort xBee)
		{
			_xBee = xBee;
			_car.PropertyChanged += CarOnPropertyChanged;
			InitializeComponent();
		}

		private void CarOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			switch (propertyChangedEventArgs.PropertyName)
			{
				case nameof(_car.BatteryTemp):
					SetLabelText(lblBatteryTemp, _car.BatteryTemp.ToString());
					break;

				case nameof(_car.BatteryVoltage):
					SetLabelText(lblBatteryVoltage, _car.BatteryVoltage.ToString());
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




		private readonly byte[] _poll = { 0x7D, 0x7D, 0x01, 0x04, 0x04 }; // Poll for front node data
		private readonly byte[] _stopPoll = { 0x7D, 0x7D, 0x00, 0x04, 0x04 }; // Stop polling for front node data

		private void Battery_VisibleChanged(object sender, EventArgs e)
		{
			if (_xBee.IsOpen)
			{
				_xBee.Write(Visible ? _poll : _stopPoll, 0, 5);
			}
		}

		private void Battery_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}
	}
}
