namespace CFSZigbee
{
	partial class FrontNode
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBrakeFault = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTorque1Fault = new System.Windows.Forms.Label();
			this.lblTorque2Fault = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTroqueBrakeImplaus = new System.Windows.Forms.Label();
			this.lblTorqueImplaus = new System.Windows.Forms.Label();
			this.lblRTD = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.racecarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.racecarBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Throttle 1 Fault:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Throttle Implausibility:";
			// 
			// lblBrakeFault
			// 
			this.lblBrakeFault.AutoSize = true;
			this.lblBrakeFault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "BrakeFault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblBrakeFault.Location = new System.Drawing.Point(195, 124);
			this.lblBrakeFault.Name = "lblBrakeFault";
			this.lblBrakeFault.Size = new System.Drawing.Size(51, 17);
			this.lblBrakeFault.TabIndex = 12;
			this.lblBrakeFault.Text = "FALSE";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(186, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Throttle-Brake Implausibility:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Throttle 2 Fault:";
			// 
			// lblTorque1Fault
			// 
			this.lblTorque1Fault.AutoSize = true;
			this.lblTorque1Fault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Throttle1Fault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorque1Fault.Location = new System.Drawing.Point(195, 31);
			this.lblTorque1Fault.Name = "lblTorque1Fault";
			this.lblTorque1Fault.Size = new System.Drawing.Size(51, 17);
			this.lblTorque1Fault.TabIndex = 6;
			this.lblTorque1Fault.Text = "FALSE";
			// 
			// lblTorque2Fault
			// 
			this.lblTorque2Fault.AutoSize = true;
			this.lblTorque2Fault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Throttle2Fault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorque2Fault.Location = new System.Drawing.Point(195, 62);
			this.lblTorque2Fault.Name = "lblTorque2Fault";
			this.lblTorque2Fault.Size = new System.Drawing.Size(51, 17);
			this.lblTorque2Fault.TabIndex = 8;
			this.lblTorque2Fault.Text = "FALSE";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Brake Fault:";
			// 
			// lblTroqueBrakeImplaus
			// 
			this.lblTroqueBrakeImplaus.AutoSize = true;
			this.lblTroqueBrakeImplaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottleBrakeImplaus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTroqueBrakeImplaus.Location = new System.Drawing.Point(195, 93);
			this.lblTroqueBrakeImplaus.Name = "lblTroqueBrakeImplaus";
			this.lblTroqueBrakeImplaus.Size = new System.Drawing.Size(51, 17);
			this.lblTroqueBrakeImplaus.TabIndex = 10;
			this.lblTroqueBrakeImplaus.Text = "FALSE";
			// 
			// lblTorqueImplaus
			// 
			this.lblTorqueImplaus.AutoSize = true;
			this.lblTorqueImplaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottleImplaus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorqueImplaus.Location = new System.Drawing.Point(195, 0);
			this.lblTorqueImplaus.Name = "lblTorqueImplaus";
			this.lblTorqueImplaus.Size = new System.Drawing.Size(51, 17);
			this.lblTorqueImplaus.TabIndex = 1;
			this.lblTorqueImplaus.Text = "FALSE";
			// 
			// lblRTD
			// 
			this.lblRTD.AutoSize = true;
			this.lblRTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Rtd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblRTD.Location = new System.Drawing.Point(156, 0);
			this.lblRTD.Name = "lblRTD";
			this.lblRTD.Size = new System.Drawing.Size(51, 17);
			this.lblRTD.TabIndex = 16;
			this.lblRTD.Text = "FALSE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "Ready To Drive:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Throttle Position:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottlePosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0"));
			this.label8.Location = new System.Drawing.Point(156, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "0";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label20, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label19, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label18, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label16, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label15, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label14, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblRTD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 196);
			this.tableLayoutPanel1.TabIndex = 19;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "SteeringPosition", true));
			this.label16.Location = new System.Drawing.Point(156, 85);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(16, 17);
			this.label16.TabIndex = 26;
			this.label16.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "RightBrakeTemp", true));
			this.label15.Location = new System.Drawing.Point(156, 68);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(16, 17);
			this.label15.TabIndex = 25;
			this.label15.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "LeftBrakeTemp", true));
			this.label14.Location = new System.Drawing.Point(156, 51);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(16, 17);
			this.label14.TabIndex = 24;
			this.label14.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "FrontBrakePressure", true));
			this.label13.Location = new System.Drawing.Point(156, 34);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(16, 17);
			this.label13.TabIndex = 23;
			this.label13.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 34);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 17);
			this.label9.TabIndex = 19;
			this.label9.Text = "Front Brake Pressure:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(117, 17);
			this.label10.TabIndex = 20;
			this.label10.Text = "Left Brake Temp:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 68);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(126, 17);
			this.label11.TabIndex = 21;
			this.label11.Text = "Right Brake Temp:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 85);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(119, 17);
			this.label12.TabIndex = 22;
			this.label12.Text = "Steering Position:";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.lblBrakeFault, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblTroqueBrakeImplaus, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.lblTorque2Fault, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblTorqueImplaus, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblTorque1Fault, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(254, 12);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 156);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "RightWheelSpeed", true));
			this.label17.Location = new System.Drawing.Point(156, 102);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(16, 17);
			this.label17.TabIndex = 27;
			this.label17.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(3, 102);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(134, 17);
			this.label18.TabIndex = 28;
			this.label18.Text = "Right Wheel Speed:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "LeftWheelSpeed", true));
			this.label19.Location = new System.Drawing.Point(156, 119);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(16, 17);
			this.label19.TabIndex = 29;
			this.label19.Text = "0";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 119);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(125, 17);
			this.label20.TabIndex = 30;
			this.label20.Text = "Left Wheel Speed:";
			// 
			// racecarBindingSource
			// 
			this.racecarBindingSource.DataSource = typeof(CFSZigbee.Racecar);
			// 
			// FrontNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 239);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FrontNode";
			this.Text = "Front Node";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrontNode_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.FrontNode_VisibleChanged);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.racecarBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBrakeFault;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTorque1Fault;
		private System.Windows.Forms.Label lblTorque2Fault;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTroqueBrakeImplaus;
		private System.Windows.Forms.Label lblTorqueImplaus;
		private System.Windows.Forms.Label lblRTD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource racecarBindingSource;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
	}
}