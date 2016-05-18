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
			this.grpError = new System.Windows.Forms.GroupBox();
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
			this.GUIUpdate = new System.Windows.Forms.Timer(this.components);
			this.lblRTD = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.racecarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.grpError.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.racecarBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// grpError
			// 
			this.grpError.Controls.Add(this.label3);
			this.grpError.Controls.Add(this.label1);
			this.grpError.Controls.Add(this.lblBrakeFault);
			this.grpError.Controls.Add(this.label7);
			this.grpError.Controls.Add(this.label4);
			this.grpError.Controls.Add(this.lblTorque1Fault);
			this.grpError.Controls.Add(this.lblTorque2Fault);
			this.grpError.Controls.Add(this.label5);
			this.grpError.Controls.Add(this.lblTroqueBrakeImplaus);
			this.grpError.Controls.Add(this.lblTorqueImplaus);
			this.grpError.Location = new System.Drawing.Point(12, 12);
			this.grpError.Name = "grpError";
			this.grpError.Size = new System.Drawing.Size(280, 173);
			this.grpError.TabIndex = 14;
			this.grpError.TabStop = false;
			this.grpError.Text = "Errors";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Throttle 1 Fault:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Throttle Implausibility:";
			// 
			// lblBrakeFault
			// 
			this.lblBrakeFault.AutoSize = true;
			this.lblBrakeFault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "BrakeFault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblBrakeFault.Location = new System.Drawing.Point(205, 128);
			this.lblBrakeFault.Name = "lblBrakeFault";
			this.lblBrakeFault.Size = new System.Drawing.Size(51, 17);
			this.lblBrakeFault.TabIndex = 12;
			this.lblBrakeFault.Text = "FALSE";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(186, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Throttle-Brake Implausibility:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Throttle 2 Fault:";
			// 
			// lblTorque1Fault
			// 
			this.lblTorque1Fault.AutoSize = true;
			this.lblTorque1Fault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Throttle1Fault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorque1Fault.Location = new System.Drawing.Point(205, 45);
			this.lblTorque1Fault.Name = "lblTorque1Fault";
			this.lblTorque1Fault.Size = new System.Drawing.Size(51, 17);
			this.lblTorque1Fault.TabIndex = 6;
			this.lblTorque1Fault.Text = "FALSE";
			// 
			// lblTorque2Fault
			// 
			this.lblTorque2Fault.AutoSize = true;
			this.lblTorque2Fault.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Throttle2Fault", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorque2Fault.Location = new System.Drawing.Point(205, 72);
			this.lblTorque2Fault.Name = "lblTorque2Fault";
			this.lblTorque2Fault.Size = new System.Drawing.Size(51, 17);
			this.lblTorque2Fault.TabIndex = 8;
			this.lblTorque2Fault.Text = "FALSE";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Brake Fault:";
			// 
			// lblTroqueBrakeImplaus
			// 
			this.lblTroqueBrakeImplaus.AutoSize = true;
			this.lblTroqueBrakeImplaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottleBrakeImplaus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTroqueBrakeImplaus.Location = new System.Drawing.Point(205, 102);
			this.lblTroqueBrakeImplaus.Name = "lblTroqueBrakeImplaus";
			this.lblTroqueBrakeImplaus.Size = new System.Drawing.Size(51, 17);
			this.lblTroqueBrakeImplaus.TabIndex = 10;
			this.lblTroqueBrakeImplaus.Text = "FALSE";
			// 
			// lblTorqueImplaus
			// 
			this.lblTorqueImplaus.AutoSize = true;
			this.lblTorqueImplaus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottleImplaus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblTorqueImplaus.Location = new System.Drawing.Point(205, 18);
			this.lblTorqueImplaus.Name = "lblTorqueImplaus";
			this.lblTorqueImplaus.Size = new System.Drawing.Size(51, 17);
			this.lblTorqueImplaus.TabIndex = 1;
			this.lblTorqueImplaus.Text = "FALSE";
			// 
			// GUIUpdate
			// 
			this.GUIUpdate.Enabled = true;
			this.GUIUpdate.Interval = 300;
			// 
			// lblRTD
			// 
			this.lblRTD.AutoSize = true;
			this.lblRTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "Rtd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "FALSE"));
			this.lblRTD.Location = new System.Drawing.Point(432, 30);
			this.lblRTD.Name = "lblRTD";
			this.lblRTD.Size = new System.Drawing.Size(51, 17);
			this.lblRTD.TabIndex = 16;
			this.lblRTD.Text = "FALSE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(315, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "Ready To Drive:";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// racecarBindingSource
			// 
			this.racecarBindingSource.DataSource = typeof(CFSZigbee.Racecar);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(315, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Throttle Position:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racecarBindingSource, "ThrottlePosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0"));
			this.label8.Location = new System.Drawing.Point(437, 67);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "0";
			// 
			// FrontNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 401);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblRTD);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.grpError);
			this.Name = "FrontNode";
			this.Text = "Front Node";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrontNode_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.FrontNode_VisibleChanged);
			this.grpError.ResumeLayout(false);
			this.grpError.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.racecarBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpError;
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
		private System.Windows.Forms.Timer GUIUpdate;
		private System.Windows.Forms.Label lblRTD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.BindingSource racecarBindingSource;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
	}
}