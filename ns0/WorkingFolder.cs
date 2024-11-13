using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000A6 RID: 166
	public partial class WorkingFolder : Form
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000F5CC0 File Offset: 0x000F5CC0
		public WorkingFolder()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000F606C File Offset: 0x000F606C
		private void button4_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = this.textBox8.Text;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(folderBrowserDialog.SelectedPath);
				this.textBox8.Text = fullPath + "\\";
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000F60C0 File Offset: 0x000F60C0
		private void WorkingFolder_Load(object sender, EventArgs e)
		{
		}
	}
}
