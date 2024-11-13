namespace ns0
{
	// Token: 0x020000A7 RID: 167
	public partial class KeyCR : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0034E136 File Offset: 0x00296136
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000F6118 File Offset: 0x000F6118
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox8 = new global::System.Windows.Forms.TextBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(64, 73);
			this.label1.Location = location;
			this.label1.Name = "label1";
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(88, 16);
			this.label1.Size = size;
			this.label1.TabIndex = 48;
			this.label1.Text = "C-R.bin";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(64, 25);
			this.label15.Location = location2;
			this.label15.Name = "label15";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(88, 16);
			this.label15.Size = size2;
			this.label15.TabIndex = 47;
			this.label15.Text = "Key.bin";
			this.button3.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(136, 128);
			this.button3.Location = location3;
			this.button3.Name = "button3";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(80, 24);
			this.button3.Size = size3;
			this.button3.TabIndex = 46;
			this.button3.Text = "Cancel";
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.Enabled = false;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(288, 128);
			this.button1.Location = location4;
			this.button1.Name = "button1";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(80, 24);
			this.button1.Size = size4;
			this.button1.TabIndex = 45;
			this.button1.Text = "OK";
			this.textBox8.AllowDrop = true;
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(64, 41);
			this.textBox8.Location = location5;
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(424, 20);
			this.textBox8.Size = size5;
			this.textBox8.TabIndex = 42;
			this.textBox8.Text = "";
			this.textBox8.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.textBox8_DragDrop);
			this.textBox8.TextChanged += new global::System.EventHandler(this.textBox8_TextChanged);
			this.textBox8.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.textBox8_DragEnter);
			this.textBox5.AllowDrop = true;
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(64, 89);
			this.textBox5.Location = location6;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(424, 20);
			this.textBox5.Size = size6;
			this.textBox5.TabIndex = 39;
			this.textBox5.Text = "";
			this.textBox5.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.textBox5_DragDrop);
			this.textBox5.TextChanged += new global::System.EventHandler(this.textBox5_TextChanged);
			this.textBox5.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.textBox5_DragEnter);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(16, 41);
			this.button4.Location = location7;
			this.button4.Name = "button4";
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(36, 20);
			this.button4.Size = size7;
			this.button4.TabIndex = 41;
			this.button4.Text = "...";
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(16, 89);
			this.button5.Location = location8;
			this.button5.Name = "button5";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(36, 20);
			this.button5.Size = size8;
			this.button5.TabIndex = 40;
			this.button5.Text = "...";
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(504, 166);
			base.ClientSize = clientSize;
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox8);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "KeyCR";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Load RGH Exports";
			base.Load += new global::System.EventHandler(this.KeyCR_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400034B RID: 843
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400034C RID: 844
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400034D RID: 845
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400034E RID: 846
		private global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x0400034F RID: 847
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000350 RID: 848
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000351 RID: 849
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000352 RID: 850
		private global::System.ComponentModel.Container container_0;
	}
}
