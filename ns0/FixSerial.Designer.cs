namespace ns0
{
	// Token: 0x0200008B RID: 139
	public partial class FixSerial : global::System.Windows.Forms.Form
	{
		// Token: 0x0600015E RID: 350 RVA: 0x0034E09B File Offset: 0x0029609B
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000154E0 File Offset: 0x000154E0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.FixSerial));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox1.Image");
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(24, 24);
			this.pictureBox1.Location = location;
			this.pictureBox1.Name = "pictureBox1";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.Size = size;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.toolTip_0.SetToolTip(this.pictureBox1, "Click to see an Example");
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new global::System.EventHandler(this.pictureBox1_MouseEnter);
			this.pictureBox1.MouseLeave += new global::System.EventHandler(this.pictureBox1_MouseLeave);
			this.textBox1.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(16, 72);
			this.textBox1.Location = location2;
			this.textBox1.MaxLength = 16;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(48, 80);
			this.textBox1.Size = size2;
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "8G241076170514XX";
			this.toolTip_0.SetToolTip(this.textBox1, "Enter 16 digit barcode from drive laser, 4 x 4 ends in XX");
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Leave += new global::System.EventHandler(this.textBox1_Leave);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(320, 16);
			this.groupBox1.Location = location3;
			this.groupBox1.Name = "groupBox1";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(80, 168);
			this.groupBox1.Size = size3;
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Laser";
			this.pictureBox2.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox2.Image");
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(136, 32);
			this.pictureBox2.Location = location4;
			this.pictureBox2.Name = "pictureBox2";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(48, 48);
			this.pictureBox2.Size = size4;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.toolTip_0.SetToolTip(this.pictureBox2, "Click to see an Example");
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.pictureBox2.MouseEnter += new global::System.EventHandler(this.pictureBox2_MouseEnter);
			this.pictureBox2.MouseLeave += new global::System.EventHandler(this.pictureBox2_MouseLeave);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(16, 128);
			this.groupBox2.Location = location5;
			this.groupBox2.Name = "groupBox2";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(192, 96);
			this.groupBox2.Size = size5;
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PCB";
			this.textBox4.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(16, 56);
			this.textBox4.Location = location6;
			this.textBox4.MaxLength = 8;
			this.textBox4.Name = "textBox4";
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(88, 26);
			this.textBox4.Size = size6;
			this.textBox4.TabIndex = 6;
			this.textBox4.Text = "00240924";
			this.toolTip_0.SetToolTip(this.textBox4, "Enter 8 digit third row of PCB label");
			this.textBox4.TextChanged += new global::System.EventHandler(this.textBox4_TextChanged);
			this.textBox4.Leave += new global::System.EventHandler(this.textBox4_Leave);
			this.textBox2.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(16, 24);
			this.textBox2.Location = location7;
			this.textBox2.MaxLength = 10;
			this.textBox2.Name = "textBox2";
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(112, 26);
			this.textBox2.Size = size7;
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "S4P8731000";
			this.toolTip_0.SetToolTip(this.textBox2, "Enter 10 digit second row of PCB label");
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.Leave += new global::System.EventHandler(this.textBox2_Leave);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.pictureBox3);
			this.groupBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(16, 16);
			this.groupBox3.Location = location8;
			this.groupBox3.Name = "groupBox3";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(288, 104);
			this.groupBox3.Size = size8;
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Cover";
			this.textBox3.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location9 = default(global::System.Drawing.Point);
			location9 = new global::System.Drawing.Point(41, 24);
			this.textBox3.Location = location9;
			this.textBox3.MaxLength = 20;
			this.textBox3.Name = "textBox3";
			global::System.Drawing.Size size9 = default(global::System.Drawing.Size);
			size9 = new global::System.Drawing.Size(206, 26);
			this.textBox3.Size = size9;
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "D608CG83290200BCZ   ";
			this.toolTip_0.SetToolTip(this.textBox3, "Enter 17 digit barcode from drive lid");
			this.textBox3.TextChanged += new global::System.EventHandler(this.textBox3_TextChanged);
			this.pictureBox3.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox3.Image");
			global::System.Drawing.Point location10 = default(global::System.Drawing.Point);
			location10 = new global::System.Drawing.Point(14, 56);
			this.pictureBox3.Location = location10;
			this.pictureBox3.Name = "pictureBox3";
			global::System.Drawing.Size size10 = default(global::System.Drawing.Size);
			size10 = new global::System.Drawing.Size(260, 40);
			this.pictureBox3.Size = size10;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			this.groupBox4.Controls.Add(this.textBox5);
			this.groupBox4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location11 = default(global::System.Drawing.Point);
			location11 = new global::System.Drawing.Point(224, 128);
			this.groupBox4.Location = location11;
			this.groupBox4.Name = "groupBox4";
			global::System.Drawing.Size size11 = default(global::System.Drawing.Size);
			size11 = new global::System.Drawing.Size(80, 56);
			this.groupBox4.Size = size11;
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "HW Ver";
			this.textBox5.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location12 = default(global::System.Drawing.Point);
			location12 = new global::System.Drawing.Point(16, 16);
			this.textBox5.Location = location12;
			this.textBox5.MaxLength = 4;
			this.textBox5.Name = "textBox5";
			global::System.Drawing.Size size12 = default(global::System.Drawing.Size);
			size12 = new global::System.Drawing.Size(48, 26);
			this.textBox5.Size = size12;
			this.textBox5.TabIndex = 7;
			this.textBox5.Text = "A0A1";
			this.toolTip_0.SetToolTip(this.textBox5, "Enter H/W rev from Lid label");
			this.textBox5.TextChanged += new global::System.EventHandler(this.textBox5_TextChanged);
			this.textBox5.Leave += new global::System.EventHandler(this.textBox5_Leave);
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location13 = default(global::System.Drawing.Point);
			location13 = new global::System.Drawing.Point(224, 192);
			this.button1.Location = location13;
			this.button1.Name = "button1";
			global::System.Drawing.Size size13 = default(global::System.Drawing.Size);
			size13 = new global::System.Drawing.Size(80, 32);
			this.button1.Size = size13;
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location14 = default(global::System.Drawing.Point);
			location14 = new global::System.Drawing.Point(320, 192);
			this.button2.Location = location14;
			this.button2.Name = "button2";
			global::System.Drawing.Size size14 = default(global::System.Drawing.Size);
			size14 = new global::System.Drawing.Size(80, 32);
			this.button2.Size = size14;
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			base.AcceptButton = this.button1;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			base.CancelButton = this.button2;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(418, 240);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.Name = "FixSerial";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Serial Info";
			base.Load += new global::System.EventHandler(this.FixSerial_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000301 RID: 769
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000302 RID: 770
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000306 RID: 774
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000307 RID: 775
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x04000308 RID: 776
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
