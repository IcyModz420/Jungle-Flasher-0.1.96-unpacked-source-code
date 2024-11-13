namespace ns0
{
	// Token: 0x02000078 RID: 120
	public partial class DumpFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0034E07C File Offset: 0x0029607C
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000075AC File Offset: 0x000075AC
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.DumpFile));
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.textBox8 = new global::System.Windows.Forms.TextBox();
			this.button7 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(64, 72);
			this.textBox5.Location = location;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(424, 20);
			this.textBox5.Size = size;
			this.textBox5.TabIndex = 23;
			this.textBox5.Text = "";
			this.textBox5.TextChanged += new global::System.EventHandler(this.textBox5_TextChanged);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(16, 72);
			this.button5.Location = location2;
			this.button5.Name = "button5";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(36, 20);
			this.button5.Size = size2;
			this.button5.TabIndex = 24;
			this.button5.Text = "...";
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(16, 24);
			this.button4.Location = location3;
			this.button4.Name = "button4";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(36, 20);
			this.button4.Size = size3;
			this.button4.TabIndex = 25;
			this.button4.Text = "...";
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(64, 24);
			this.textBox8.Location = location4;
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(424, 20);
			this.textBox8.Size = size4;
			this.textBox8.TabIndex = 26;
			this.textBox8.Text = "";
			this.textBox8.TextChanged += new global::System.EventHandler(this.textBox8_TextChanged);
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(16, 120);
			this.button7.Location = location5;
			this.button7.Name = "button7";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(36, 20);
			this.button7.Size = size5;
			this.button7.TabIndex = 27;
			this.button7.Text = "...";
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(64, 120);
			this.textBox1.Location = location6;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(424, 20);
			this.textBox1.Size = size6;
			this.textBox1.TabIndex = 28;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.Enabled = false;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(288, 200);
			this.button1.Location = location7;
			this.button1.Name = "button1";
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(80, 24);
			this.button1.Size = size7;
			this.button1.TabIndex = 30;
			this.button1.Text = "OK";
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(136, 200);
			this.button3.Location = location8;
			this.button3.Name = "button3";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(80, 24);
			this.button3.Size = size8;
			this.button3.TabIndex = 32;
			this.button3.Text = "Cancel";
			global::System.Drawing.Point location9 = default(global::System.Drawing.Point);
			location9 = new global::System.Drawing.Point(64, 8);
			this.label15.Location = location9;
			this.label15.Name = "label15";
			global::System.Drawing.Size size9 = default(global::System.Drawing.Size);
			size9 = new global::System.Drawing.Size(88, 16);
			this.label15.Size = size9;
			this.label15.TabIndex = 33;
			this.label15.Text = "Key.bin";
			global::System.Drawing.Point location10 = default(global::System.Drawing.Point);
			location10 = new global::System.Drawing.Point(64, 56);
			this.label1.Location = location10;
			this.label1.Name = "label1";
			global::System.Drawing.Size size10 = default(global::System.Drawing.Size);
			size10 = new global::System.Drawing.Size(88, 16);
			this.label1.Size = size10;
			this.label1.TabIndex = 34;
			this.label1.Text = "Inquiry.bin";
			global::System.Drawing.Point location11 = default(global::System.Drawing.Point);
			location11 = new global::System.Drawing.Point(64, 104);
			this.label2.Location = location11;
			this.label2.Name = "label2";
			global::System.Drawing.Size size11 = default(global::System.Drawing.Size);
			size11 = new global::System.Drawing.Size(88, 16);
			this.label2.Size = size11;
			this.label2.TabIndex = 35;
			this.label2.Text = "Identify.bin";
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location12 = default(global::System.Drawing.Point);
			location12 = new global::System.Drawing.Point(16, 168);
			this.button2.Location = location12;
			this.button2.Name = "button2";
			global::System.Drawing.Size size12 = default(global::System.Drawing.Size);
			size12 = new global::System.Drawing.Size(36, 20);
			this.button2.Size = size12;
			this.button2.TabIndex = 36;
			this.button2.Text = "...";
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			global::System.Drawing.Point location13 = default(global::System.Drawing.Point);
			location13 = new global::System.Drawing.Point(64, 168);
			this.textBox2.Location = location13;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			global::System.Drawing.Size size13 = default(global::System.Drawing.Size);
			size13 = new global::System.Drawing.Size(424, 20);
			this.textBox2.Size = size13;
			this.textBox2.TabIndex = 37;
			this.textBox2.Text = "";
			global::System.Drawing.Point location14 = default(global::System.Drawing.Point);
			location14 = new global::System.Drawing.Point(64, 152);
			this.label3.Location = location14;
			this.label3.Name = "label3";
			global::System.Drawing.Size size14 = default(global::System.Drawing.Size);
			size14 = new global::System.Drawing.Size(88, 16);
			this.label3.Size = size14;
			this.label3.TabIndex = 38;
			this.label3.Text = "Serial.bin";
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(506, 240);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.textBox8);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button5);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			global::System.Drawing.Point location15 = default(global::System.Drawing.Point);
			location15 = new global::System.Drawing.Point(150, 150);
			base.Location = location15;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DumpFile";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Load DVDKey Extracts";
			base.Load += new global::System.EventHandler(this.DumpFile_Load);
			base.Closed += new global::System.EventHandler(this.DumpFile_Closed);
			base.ResumeLayout(false);
		}

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.Button button7;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002EC RID: 748
		private global::System.ComponentModel.Container container_0;
	}
}
