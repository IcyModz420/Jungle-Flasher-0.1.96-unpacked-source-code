namespace ns0
{
	// Token: 0x02000077 RID: 119
	public partial class Donate : global::System.Windows.Forms.Form
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0034E05D File Offset: 0x0029605D
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006F9C File Offset: 0x00006F9C
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.Donate));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox1.Image");
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(16, 16);
			this.pictureBox1.Location = location;
			this.pictureBox1.Name = "pictureBox1";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(60, 38);
			this.pictureBox1.Size = size;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(136, 104);
			this.button1.Location = location2;
			this.button1.Name = "button1";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(72, 24);
			this.button1.Size = size2;
			this.button1.TabIndex = 1;
			this.button1.Text = "Yes";
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(224, 104);
			this.button2.Location = location3;
			this.button2.Name = "button2";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(72, 24);
			this.button2.Size = size3;
			this.button2.TabIndex = 2;
			this.button2.Text = "No";
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(104, 16);
			this.label10.Location = location4;
			this.label10.Name = "label10";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(320, 16);
			this.label10.Size = size4;
			this.label10.TabIndex = 5;
			this.label10.Text = "As a heavy user of JungleFlasher, Maybe you would";
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(104, 32);
			this.label11.Location = location5;
			this.label11.Name = "label11";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(320, 16);
			this.label11.Size = size5;
			this.label11.TabIndex = 6;
			this.label11.Text = "consider a donation to the dev Team, as a sign of";
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(104, 48);
			this.label1.Location = location6;
			this.label1.Name = "label1";
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(320, 16);
			this.label1.Size = size6;
			this.label1.TabIndex = 7;
			this.label1.Text = "appreciation and recognition of all the hard work and";
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(104, 64);
			this.label2.Location = location7;
			this.label2.Name = "label2";
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(320, 16);
			this.label2.Size = size7;
			this.label2.TabIndex = 8;
			this.label2.Text = "dedication that goes into developing such a full";
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(104, 80);
			this.label3.Location = location8;
			this.label3.Name = "label3";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(320, 16);
			this.label3.Size = size8;
			this.label3.TabIndex = 9;
			this.label3.Text = "featured application.";
			base.AcceptButton = this.button1;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			base.CancelButton = this.button2;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(434, 144);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label11);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Donate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Donate";
			base.ResumeLayout(false);
		}

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002DD RID: 733
		private global::System.ComponentModel.Container container_0;
	}
}
