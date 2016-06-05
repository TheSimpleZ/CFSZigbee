namespace CFSZigbee
{
	partial class Battery
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
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblBatteryVoltage = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblBatteryTemp = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Temperature";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.8134F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.1866F));
			this.tableLayoutPanel1.Controls.Add(this.lblBatteryVoltage, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblBatteryTemp, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(151, 35);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lblBatteryVoltage
			// 
			this.lblBatteryVoltage.AutoSize = true;
			this.lblBatteryVoltage.Location = new System.Drawing.Point(109, 17);
			this.lblBatteryVoltage.Name = "lblBatteryVoltage";
			this.lblBatteryVoltage.Size = new System.Drawing.Size(16, 17);
			this.lblBatteryVoltage.TabIndex = 3;
			this.lblBatteryVoltage.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Voltage";
			// 
			// lblBatteryTemp
			// 
			this.lblBatteryTemp.AutoSize = true;
			this.lblBatteryTemp.Location = new System.Drawing.Point(109, 0);
			this.lblBatteryTemp.Name = "lblBatteryTemp";
			this.lblBatteryTemp.Size = new System.Drawing.Size(16, 17);
			this.lblBatteryTemp.TabIndex = 1;
			this.lblBatteryTemp.Text = "0";
			// 
			// Battery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 64);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Battery";
			this.Text = "Battery";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battery_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.Battery_VisibleChanged);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblBatteryVoltage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblBatteryTemp;
	}
}