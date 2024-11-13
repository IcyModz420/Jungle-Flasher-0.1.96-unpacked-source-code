using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200008E RID: 142
	public partial class Welcome : Form
	{
		// Token: 0x0600017A RID: 378 RVA: 0x0001704C File Offset: 0x0001704C
		public Welcome()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000174C8 File Offset: 0x000174C8
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.method_0();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000174DC File Offset: 0x000174DC
		private void method_0()
		{
			this.linkLabel2.LinkVisited = true;
			Process.Start("irc://irc.efnet.org/JungleFlasher");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00017500 File Offset: 0x00017500
		private void Welcome_Load(object sender, EventArgs e)
		{
			Welcome.timer_0.Tick += this.method_1;
			Welcome.timer_0.Interval = 4000;
			Welcome.timer_0.Start();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001753C File Offset: 0x0001753C
		private void method_1(object sender, EventArgs e)
		{
			Welcome.timer_0.Stop();
			base.Close();
		}

		// Token: 0x04000316 RID: 790
		private static Timer timer_0 = new Timer();
	}
}
