using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200004B RID: 75
	public partial class Common_Barcode : Form
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00002C08 File Offset: 0x00002C08
		public Common_Barcode()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000030CC File Offset: 0x000030CC
		public unsafe void method_0()
		{
			this.bool_0 = false;
			string s = Convert.ToString(this.textBox3.Text);
			if (this.textBox3.TextLength != 17)
			{
				<Module>.pGstruct14_5 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_1, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_5);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				Struct17 @struct;
				<Module>.memset((void*)(&@struct), 0, 17U);
				if (this.method_3(ptr, 17U) != 0)
				{
					<Module>.pGstruct14_5 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_1, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_5);
				}
				else
				{
					<Module>.memcpy((void*)this.pByte_0, (void*)ptr, 17U);
					this.button1.Enabled = false;
					this.textBox3.Clear();
					this.textBox3.Text = this.method_2(this.pByte_0, 20U);
					this.bool_0 = true;
					this.method_1();
				}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003204 File Offset: 0x00003204
		public void method_1()
		{
			if (this.bool_0)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003234 File Offset: 0x00003234
		public unsafe string method_2(byte* pByte_1, uint uint_0)
		{
			string text = null;
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				if (pByte_1[num] >= 32 && pByte_1[num] <= 126)
				{
					if (pByte_1[num] >= 97 && pByte_1[num] <= 122)
					{
						pByte_1[num] = pByte_1[num] - 32;
					}
					Struct20 @struct;
					<Module>.sprintf((sbyte*)(&@struct), (sbyte*)(&<Module>.struct18_0), pByte_1[num]);
					string text2 = new string((sbyte*)(&<Module>.struct19_0));
					text2 += new string((sbyte*)(&@struct));
					text += text2;
				}
				else
				{
					text += "?";
				}
			}
			return text;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000032C4 File Offset: 0x000032C4
		public unsafe int method_3(byte* pByte_1, uint uint_0)
		{
			for (uint num = 0U; num < uint_0; num += 1U)
			{
				if (pByte_1[num] != 32)
				{
					if ((pByte_1[num] < 48 || pByte_1[num] > 57) && (pByte_1[num] < 97 || pByte_1[num] > 122) && (pByte_1[num] < 65 || pByte_1[num] > 90))
					{
						return 1;
					}
				}
			}
			return 0;
		}

		// Token: 0x0400029D RID: 669
		public unsafe byte* pByte_0;

		// Token: 0x0400029E RID: 670
		public bool bool_0;
	}
}
