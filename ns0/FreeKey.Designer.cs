namespace ns0
{
	// Token: 0x0200008F RID: 143
	public partial class FreeKey : global::System.Windows.Forms.Form
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0034E0D9 File Offset: 0x002960D9
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000175BC File Offset: 0x000175BC
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.FreeKey));
			this.textBox8 = new global::System.Windows.Forms.TextBox();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button5 = new global::System.Windows.Forms.Button();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.button6 = new global::System.Windows.Forms.Button();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(16, 64);
			this.textBox8.Location = location;
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(432, 20);
			this.textBox8.Size = size;
			this.textBox8.TabIndex = 35;
			this.textBox8.Text = "";
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(16, 24);
			this.button4.Location = location2;
			this.button4.Name = "button4";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(80, 24);
			this.button4.Size = size2;
			this.button4.TabIndex = 34;
			this.button4.Text = "Load key.bin";
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(376, 288);
			this.button3.Location = location3;
			this.button3.Name = "button3";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(104, 40);
			this.button3.Size = size3;
			this.button3.TabIndex = 38;
			this.button3.Text = "Cancel";
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(376, 232);
			this.button1.Location = location4;
			this.button1.Name = "button1";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(104, 40);
			this.button1.Size = size4;
			this.button1.TabIndex = 37;
			this.button1.Text = "OK";
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(112, 24);
			this.textBox1.Location = location5;
			this.textBox1.MaxLength = 32;
			this.textBox1.Name = "textBox1";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(264, 22);
			this.textBox1.Size = size5;
			this.textBox1.TabIndex = 39;
			this.textBox1.Text = "55AA55AA55AA55AA55AA55AA55AA55AA";
			this.textBox1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Leave += new global::System.EventHandler(this.textBox1_Leave);
			this.button2.Enabled = false;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(392, 24);
			this.button2.Location = location6;
			this.button2.Name = "button2";
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(56, 22);
			this.button2.Size = size6;
			this.button2.TabIndex = 41;
			this.button2.Text = "Check";
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.comboBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(87, 72);
			this.comboBox1.Location = location7;
			this.comboBox1.Name = "comboBox1";
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(248, 24);
			this.comboBox1.Size = size7;
			this.comboBox1.TabIndex = 42;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label2.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(88, 46);
			this.label2.Location = location8;
			this.label2.Name = "label2";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(240, 16);
			this.label2.Size = size8;
			this.label2.TabIndex = 43;
			this.label3.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location9 = default(global::System.Drawing.Point);
			location9 = new global::System.Drawing.Point(88, 22);
			this.label3.Location = location9;
			this.label3.Name = "label3";
			global::System.Drawing.Size size9 = default(global::System.Drawing.Size);
			size9 = new global::System.Drawing.Size(240, 16);
			this.label3.Size = size9;
			this.label3.TabIndex = 44;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location10 = default(global::System.Drawing.Point);
			location10 = new global::System.Drawing.Point(16, 224);
			this.groupBox1.Location = location10;
			this.groupBox1.Name = "groupBox1";
			global::System.Drawing.Size size10 = default(global::System.Drawing.Size);
			size10 = new global::System.Drawing.Size(344, 112);
			this.groupBox1.Size = size10;
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "OSIG:";
			this.toolTip_0.SetToolTip(this.groupBox1, "Select the desired drive type to Spoof as");
			global::System.Drawing.Point location11 = default(global::System.Drawing.Point);
			location11 = new global::System.Drawing.Point(16, 46);
			this.label5.Location = location11;
			this.label5.Name = "label5";
			global::System.Drawing.Size size11 = default(global::System.Drawing.Size);
			size11 = new global::System.Drawing.Size(72, 16);
			this.label5.Size = size11;
			this.label5.TabIndex = 46;
			this.label5.Text = "Spoofed As:";
			global::System.Drawing.Point location12 = default(global::System.Drawing.Point);
			location12 = new global::System.Drawing.Point(16, 22);
			this.label4.Location = location12;
			this.label4.Name = "label4";
			global::System.Drawing.Size size12 = default(global::System.Drawing.Size);
			size12 = new global::System.Drawing.Size(56, 16);
			this.label4.Size = size12;
			this.label4.TabIndex = 45;
			this.label4.Text = "Current:";
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.textBox8);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location13 = default(global::System.Drawing.Point);
			location13 = new global::System.Drawing.Point(16, 8);
			this.groupBox2.Location = location13;
			this.groupBox2.Name = "groupBox2";
			global::System.Drawing.Size size13 = default(global::System.Drawing.Size);
			size13 = new global::System.Drawing.Size(464, 96);
			this.groupBox2.Size = size13;
			this.groupBox2.TabIndex = 47;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Drive Key";
			this.toolTip_0.SetToolTip(this.groupBox2, "Enter 16 bytes DVD key");
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Enabled = false;
			this.groupBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location14 = default(global::System.Drawing.Point);
			location14 = new global::System.Drawing.Point(16, 112);
			this.groupBox3.Location = location14;
			this.groupBox3.Name = "groupBox3";
			global::System.Drawing.Size size14 = default(global::System.Drawing.Size);
			size14 = new global::System.Drawing.Size(464, 104);
			this.groupBox3.Size = size14;
			this.groupBox3.TabIndex = 48;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Lite-On Barcode";
			this.toolTip_0.SetToolTip(this.groupBox3, "Enter 17 digit Drive Barcode from Lite-On drive Lid");
			this.textBox4.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location15 = default(global::System.Drawing.Point);
			location15 = new global::System.Drawing.Point(336, 24);
			this.textBox4.Location = location15;
			this.textBox4.MaxLength = 4;
			this.textBox4.Name = "textBox4";
			global::System.Drawing.Size size15 = default(global::System.Drawing.Size);
			size15 = new global::System.Drawing.Size(44, 22);
			this.textBox4.Size = size15;
			this.textBox4.TabIndex = 42;
			this.textBox4.Text = "A0A1";
			this.textBox4.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			this.textBox4.Leave += new global::System.EventHandler(this.textBox4_Leave);
			this.textBox2.Font = new global::System.Drawing.Font("Courier New", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location16 = default(global::System.Drawing.Point);
			location16 = new global::System.Drawing.Point(148, 24);
			this.textBox2.Location = location16;
			this.textBox2.MaxLength = 20;
			this.textBox2.Name = "textBox2";
			global::System.Drawing.Size size16 = default(global::System.Drawing.Size);
			size16 = new global::System.Drawing.Size(168, 22);
			this.textBox2.Size = size16;
			this.textBox2.TabIndex = 39;
			this.textBox2.Text = "D608CG833907010F0   ";
			this.toolTip_0.SetToolTip(this.textBox2, "Lite-On Barcode");
			this.textBox2.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			this.textBox2.Leave += new global::System.EventHandler(this.textBox2_Leave);
			this.button5.Enabled = false;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location17 = default(global::System.Drawing.Point);
			location17 = new global::System.Drawing.Point(392, 24);
			this.button5.Location = location17;
			this.button5.Name = "button5";
			global::System.Drawing.Size size17 = default(global::System.Drawing.Size);
			size17 = new global::System.Drawing.Size(56, 22);
			this.button5.Size = size17;
			this.button5.TabIndex = 41;
			this.button5.Text = "Check";
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			global::System.Drawing.Point location18 = default(global::System.Drawing.Point);
			location18 = new global::System.Drawing.Point(16, 64);
			this.textBox3.Location = location18;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			global::System.Drawing.Size size18 = default(global::System.Drawing.Size);
			size18 = new global::System.Drawing.Size(432, 20);
			this.textBox3.Size = size18;
			this.textBox3.TabIndex = 35;
			this.textBox3.Text = "";
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location19 = default(global::System.Drawing.Point);
			location19 = new global::System.Drawing.Point(16, 24);
			this.button6.Location = location19;
			this.button6.Name = "button6";
			global::System.Drawing.Size size19 = default(global::System.Drawing.Size);
			size19 = new global::System.Drawing.Size(104, 24);
			this.button6.Size = size19;
			this.button6.TabIndex = 34;
			this.button6.Text = "Load bin file";
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			base.AcceptButton = this.button1;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			base.CancelButton = this.button3;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(498, 352);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			global::System.Drawing.Point location20 = default(global::System.Drawing.Point);
			location20 = new global::System.Drawing.Point(150, 150);
			base.Location = location20;
			base.Name = "FreeKey";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Manual Spoof";
			base.Load += new global::System.EventHandler(this.FreeKey_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400031E RID: 798
		public global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000321 RID: 801
		public global::System.Windows.Forms.Label label2;

		// Token: 0x04000322 RID: 802
		public global::System.Windows.Forms.Label label3;

		// Token: 0x04000323 RID: 803
		public global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000324 RID: 804
		public global::System.Windows.Forms.Label label4;

		// Token: 0x04000325 RID: 805
		public global::System.Windows.Forms.Label label5;

		// Token: 0x04000326 RID: 806
		public global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000327 RID: 807
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000328 RID: 808
		public global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000329 RID: 809
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400032A RID: 810
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400032B RID: 811
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x0400032D RID: 813
		public global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400032E RID: 814
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
