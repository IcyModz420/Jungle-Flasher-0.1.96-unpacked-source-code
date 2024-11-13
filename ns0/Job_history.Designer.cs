namespace ns0
{
	// Token: 0x0200006E RID: 110
	public partial class Job_history : global::System.Windows.Forms.Form
	{
		// Token: 0x06000135 RID: 309 RVA: 0x0034E01F File Offset: 0x0029601F
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003F30 File Offset: 0x00003F30
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.Job_history));
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			base.SuspendLayout();
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(16, 16);
			this.listBox1.Location = location;
			this.listBox1.Name = "listBox1";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(264, 173);
			this.listBox1.Size = size;
			this.listBox1.TabIndex = 0;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(298, 216);
			base.ClientSize = clientSize;
			base.Controls.Add(this.listBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Job_history";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Job History";
			base.Load += new global::System.EventHandler(this.Job_history_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x040002A0 RID: 672
		private global::System.ComponentModel.Container container_0;
	}
}
