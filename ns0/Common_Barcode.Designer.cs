namespace ns0
{
	// Token: 0x0200004B RID: 75
	public partial class Common_Barcode : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0034E000 File Offset: 0x00296000
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002C50 File Offset: 0x00002C50
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.Common_Barcode));
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.pictureBox3);
			this.groupBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(16, 16);
			this.groupBox3.Location = location;
			this.groupBox3.Name = "groupBox3";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(288, 104);
			this.groupBox3.Size = size;
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Cover";
			this.textBox3.Font = new global::System.Drawing.Font("Courier New", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(53, 24);
			this.textBox3.Location = location2;
			this.textBox3.MaxLength = 17;
			this.textBox3.Name = "textBox3";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(183, 26);
			this.textBox3.Size = size2;
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "D608CG73880800348   ";
			this.toolTip_0.SetToolTip(this.textBox3, "Enter 17 digit barcode from drive lid");
			this.pictureBox3.Image = (global::System.Drawing.Image)resourceManager.GetObject("pictureBox3.Image");
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(14, 56);
			this.pictureBox3.Location = location3;
			this.pictureBox3.Name = "pictureBox3";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(260, 40);
			this.pictureBox3.Size = size3;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(56, 136);
			this.button1.Location = location4;
			this.button1.Name = "button1";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(80, 32);
			this.button1.Size = size4;
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(184, 136);
			this.button2.Location = location5;
			this.button2.Name = "button2";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(80, 32);
			this.button2.Size = size5;
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			base.AcceptButton = this.button1;
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			base.CancelButton = this.button2;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(322, 184);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Common_Barcode";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Barcode Search";
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000298 RID: 664
		public global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x0400029C RID: 668
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
