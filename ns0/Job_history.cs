using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200006E RID: 110
	public partial class Job_history : Form
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00003EE8 File Offset: 0x00003EE8
		public Job_history()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004084 File Offset: 0x00004084
		private unsafe void Job_history_Load(object sender, EventArgs e)
		{
			int num = 1;
			string str = Convert.ToString(this.int_0);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + str);
			if (registryKey.GetValue(new string((sbyte*)(&<Module>.struct22_0))) != null)
			{
				this.listBox1.Items.Add("Created" + "\t\t" + registryKey.GetValue(new string((sbyte*)(&<Module>.struct22_0))).ToString());
			}
			while (registryKey.GetValue("Date" + Convert.ToString(num)) != null)
			{
				this.listBox1.Items.Add(Convert.ToString(num) + "\t\t" + registryKey.GetValue("Date" + Convert.ToString(num)).ToString());
				num++;
			}
			string strA;
			if (registryKey.GetValue("Date" + Convert.ToString(num - 1)) != null)
			{
				strA = registryKey.GetValue("Date" + Convert.ToString(num - 1)).ToString();
			}
			else
			{
				strA = "";
			}
			string strB;
			if (registryKey.GetValue("Updated") != null)
			{
				strB = registryKey.GetValue("Updated").ToString();
			}
			else
			{
				strB = "x";
			}
			if (string.Compare(strA, strB) == 0)
			{
				this.listBox1.Items.RemoveAt(num - 1);
			}
			if (registryKey.GetValue("Updated") != null)
			{
				this.listBox1.Items.Add("Last Update" + "\t" + registryKey.GetValue("Updated").ToString());
			}
		}

		// Token: 0x040002A1 RID: 673
		public int int_0;
	}
}
