namespace ns0
{
	// Token: 0x020000A6 RID: 166
	public partial class WorkingFolder : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0034E117 File Offset: 0x00296117
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000F5D08 File Offset: 0x000F5D08
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.WorkingFolder));
			this.button3 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox8 = new global::System.Windows.Forms.TextBox();
			this.button4 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(101, 56);
			this.button3.Location = location;
			this.button3.Name = "button3";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(80, 24);
			this.button3.Size = size;
			this.button3.TabIndex = 6;
			this.button3.Text = "Cancel";
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(205, 56);
			this.button1.Location = location2;
			this.button1.Name = "button1";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(80, 24);
			this.button1.Size = size2;
			this.button1.TabIndex = 5;
			this.button1.Text = "OK";
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(64, 16);
			this.textBox8.Location = location3;
			this.textBox8.Name = "textBox8";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(304, 20);
			this.textBox8.Size = size3;
			this.textBox8.TabIndex = 28;
			this.textBox8.Text = "";
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(16, 16);
			this.button4.Location = location4;
			this.button4.Name = "button4";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(36, 20);
			this.button4.Size = size4;
			this.button4.TabIndex = 27;
			this.button4.Text = "...";
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(386, 94);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.textBox8);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.Name = "WorkingFolder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set Working Folder";
			base.Load += new global::System.EventHandler(this.WorkingFolder_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000347 RID: 839
		public global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000349 RID: 841
		private global::System.ComponentModel.Container container_0;
	}
}
