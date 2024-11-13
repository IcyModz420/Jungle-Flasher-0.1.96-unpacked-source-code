namespace ns0
{
	// Token: 0x0200008E RID: 142
	public partial class Welcome : global::System.Windows.Forms.Form
	{
		// Token: 0x0600017B RID: 379 RVA: 0x0034E0BA File Offset: 0x002960BA
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00017094 File Offset: 0x00017094
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.Welcome));
			this.label1 = new global::System.Windows.Forms.Label();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			global::System.Drawing.Color control = global::System.Drawing.SystemColors.Control;
			global::System.Drawing.Color color = control;
			global::System.Drawing.Color backColor = color;
			this.label1.BackColor = backColor;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Color controlText = global::System.Drawing.SystemColors.ControlText;
			global::System.Drawing.Color color2 = controlText;
			global::System.Drawing.Color foreColor = color2;
			this.label1.ForeColor = foreColor;
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(69, 24);
			this.label1.Location = location;
			this.label1.Name = "label1";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(242, 40);
			this.label1.Size = size;
			this.label1.TabIndex = 1;
			this.label1.Text = "JungleFlasher 0.1.96 b";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			global::System.Drawing.Color transparent = global::System.Drawing.Color.Transparent;
			global::System.Drawing.Color color3 = transparent;
			global::System.Drawing.Color backColor2 = color3;
			this.linkLabel2.BackColor = backColor2;
			this.linkLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(18, 80);
			this.linkLabel2.Location = location2;
			this.linkLabel2.Name = "linkLabel2";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(344, 16);
			this.linkLabel2.Size = size2;
			this.linkLabel2.TabIndex = 5;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "For Support join #JungleFlasher on EFnet";
			this.linkLabel2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.groupBox1.Controls.Add(this.pictureBox1);
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(3, -2);
			this.groupBox1.Location = location3;
			this.groupBox1.Name = "groupBox1";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(375, 128);
			this.groupBox1.Size = size3;
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.pictureBox1.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox1.Image");
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(320, 32);
			this.pictureBox1.Location = location4;
			this.pictureBox1.Name = "pictureBox1";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(32, 32);
			this.pictureBox1.Size = size4;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Color control2 = global::System.Drawing.SystemColors.Control;
			global::System.Drawing.Color color4 = control2;
			global::System.Drawing.Color backColor3 = color4;
			this.BackColor = backColor3;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(380, 128);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Welcome";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Welcome";
			base.Load += new global::System.EventHandler(this.Welcome_Load);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000319 RID: 793
		private global::System.ComponentModel.Container container_0;
	}
}
