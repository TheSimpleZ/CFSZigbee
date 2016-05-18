namespace CFSZigbee
{
	partial class RearNode
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblShutdownCurrent = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTorqueReq = new System.Windows.Forms.Label();
			this.GUIUpdate = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Shutdown Current:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Left Spring Travel:";
			// 
			// lblShutdownCurrent
			// 
			this.lblShutdownCurrent.AutoSize = true;
			this.lblShutdownCurrent.Location = new System.Drawing.Point(143, 9);
			this.lblShutdownCurrent.Name = "lblShutdownCurrent";
			this.lblShutdownCurrent.Size = new System.Drawing.Size(35, 17);
			this.lblShutdownCurrent.TabIndex = 2;
			this.lblShutdownCurrent.Text = "OFF";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Right Spring Travel:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(271, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Torque Request:";
			// 
			// lblTorqueReq
			// 
			this.lblTorqueReq.AutoSize = true;
			this.lblTorqueReq.Location = new System.Drawing.Point(392, 9);
			this.lblTorqueReq.Name = "lblTorqueReq";
			this.lblTorqueReq.Size = new System.Drawing.Size(16, 17);
			this.lblTorqueReq.TabIndex = 5;
			this.lblTorqueReq.Text = "0";
			// 
			// GUIUpdate
			// 
			this.GUIUpdate.Enabled = true;
			this.GUIUpdate.Interval = 300;
			this.GUIUpdate.Tick += new System.EventHandler(this.GUIUpdate_Tick);
			// 
			// RearNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 333);
			this.Controls.Add(this.lblTorqueReq);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblShutdownCurrent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "RearNode";
			this.Text = "RearNode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RearNode_FormClosing);
			this.VisibleChanged += new System.EventHandler(this.RearNode_VisibleChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblShutdownCurrent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTorqueReq;
		private System.Windows.Forms.Timer GUIUpdate;
	}
}