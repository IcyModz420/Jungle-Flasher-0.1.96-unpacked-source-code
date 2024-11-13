namespace ns0
{
	// Token: 0x020000A5 RID: 165
	public partial class ProjectName : global::System.Windows.Forms.Form
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0034E0F8 File Offset: 0x002960F8
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000F59E8 File Offset: 0x000F59E8
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.ProjectName));
			this.button3 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(32, 48);
			this.button3.Location = location;
			this.button3.Name = "button3";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(80, 24);
			this.button3.Size = size;
			this.button3.TabIndex = 3;
			this.button3.Text = "Cancel";
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(128, 48);
			this.button1.Location = location2;
			this.button1.Name = "button1";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(80, 24);
			this.button1.Size = size2;
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(24, 16);
			this.textBox1.Location = location3;
			this.textBox1.Name = "textBox1";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(192, 20);
			this.textBox1.Size = size3;
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			base.AcceptButton = this.button1;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			base.CancelButton = this.button3;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(242, 88);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.Name = "ProjectName";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Enter Job Name";
			base.Load += new global::System.EventHandler(this.ProjectName_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000343 RID: 835
		public global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000344 RID: 836
		private global::System.ComponentModel.Container container_0;
	}
}
