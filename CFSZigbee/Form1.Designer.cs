namespace CFSZigbee
{
	partial class Form1
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
			this.xBee = new System.IO.Ports.SerialPort(this.components);
			this.cbComPorts = new System.Windows.Forms.ComboBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnFrontNode = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnRearNode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xBee
			// 
			this.xBee.BaudRate = 57600;
			// 
			// cbComPorts
			// 
			this.cbComPorts.FormattingEnabled = true;
			this.cbComPorts.Location = new System.Drawing.Point(15, 12);
			this.cbComPorts.Name = "cbComPorts";
			this.cbComPorts.Size = new System.Drawing.Size(215, 24);
			this.cbComPorts.TabIndex = 2;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 58);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(100, 50);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(71, 272);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 50);
			this.button2.TabIndex = 14;
			this.button2.Text = "Battery";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(130, 58);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(100, 50);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnFrontNode
			// 
			this.btnFrontNode.Location = new System.Drawing.Point(71, 347);
			this.btnFrontNode.Name = "btnFrontNode";
			this.btnFrontNode.Size = new System.Drawing.Size(100, 50);
			this.btnFrontNode.TabIndex = 15;
			this.btnFrontNode.Text = "Front Node";
			this.btnFrontNode.UseVisualStyleBackColor = true;
			this.btnFrontNode.Click += new System.EventHandler(this.btnFrontNode_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(71, 205);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 50);
			this.button4.TabIndex = 16;
			this.button4.Text = "Power Electronics";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnRearNode
			// 
			this.btnRearNode.Location = new System.Drawing.Point(71, 135);
			this.btnRearNode.Name = "btnRearNode";
			this.btnRearNode.Size = new System.Drawing.Size(100, 50);
			this.btnRearNode.TabIndex = 17;
			this.btnRearNode.Text = "Rear Node";
			this.btnRearNode.UseVisualStyleBackColor = true;
			this.btnRearNode.Click += new System.EventHandler(this.btnRearNode_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 429);
			this.Controls.Add(this.btnRearNode);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnFrontNode);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.cbComPorts);
			this.Name = "Form1";
			this.Text = "CFS Zigbee";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.IO.Ports.SerialPort xBee;
		private System.Windows.Forms.ComboBox cbComPorts;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnFrontNode;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnRearNode;
	}
}

