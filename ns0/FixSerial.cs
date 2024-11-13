using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200008B RID: 139
	public partial class FixSerial : Form
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00015498 File Offset: 0x00015498
		public FixSerial()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00016240 File Offset: 0x00016240
		public unsafe string method_0(byte* pByte_2, uint uint_3)
		{
			string text = null;
			for (uint num = 0U; num < uint_3; num += 1U)
			{
				if (pByte_2[num] >= 32 && pByte_2[num] <= 126)
				{
					if (pByte_2[num] >= 97 && pByte_2[num] <= 122)
					{
						pByte_2[num] = pByte_2[num] - 32;
					}
					Struct20 @struct;
					<Module>.sprintf((sbyte*)(&@struct), (sbyte*)(&<Module>.struct18_0), pByte_2[num]);
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

		// Token: 0x06000161 RID: 353 RVA: 0x000162D0 File Offset: 0x000162D0
		public unsafe int method_1(byte* pByte_2, uint uint_3)
		{
			for (uint num = 0U; num < uint_3; num += 1U)
			{
				if (pByte_2[num] != 32)
				{
					if ((pByte_2[num] < 48 || pByte_2[num] > 57) && (pByte_2[num] < 97 || pByte_2[num] > 122) && (pByte_2[num] < 65 || pByte_2[num] > 90))
					{
						return 1;
					}
				}
			}
			return 0;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00016330 File Offset: 0x00016330
		private unsafe void FixSerial_Load(object sender, EventArgs e)
		{
			Struct41 @struct = 255;
			*(ref @struct + 1) = byte.MaxValue;
			*(ref @struct + 2) = byte.MaxValue;
			*(ref @struct + 3) = byte.MaxValue;
			*(ref @struct + 4) = byte.MaxValue;
			*(ref @struct + 5) = byte.MaxValue;
			*(ref @struct + 6) = byte.MaxValue;
			*(ref @struct + 7) = byte.MaxValue;
			*(ref @struct + 8) = byte.MaxValue;
			*(ref @struct + 9) = byte.MaxValue;
			*(ref @struct + 10) = byte.MaxValue;
			*(ref @struct + 11) = byte.MaxValue;
			*(ref @struct + 12) = byte.MaxValue;
			*(ref @struct + 13) = byte.MaxValue;
			*(ref @struct + 14) = byte.MaxValue;
			*(ref @struct + 15) = byte.MaxValue;
			*(ref @struct + 16) = byte.MaxValue;
			*(ref @struct + 17) = byte.MaxValue;
			if (this.uint_1 == 5U && this.uint_2 == 1U)
			{
				<Module>.memset((void*)(this.pByte_0 + 17), 32, 3U);
				<Module>.memset((void*)(this.pByte_1 + 130833), 32, 3U);
			}
			this.textBox3.Text = this.method_0(this.pByte_0, 20U);
			this.bool_0 = true;
			this.textBox1.Text = this.method_0(this.pByte_0 + 24, 16U);
			if (<Module>.memcmp((void*)(this.pByte_0 + 24), (void*)(&@struct), 18U) != null)
			{
				this.bool_1 = true;
			}
			else
			{
				this.bool_1 = false;
			}
			this.textBox2.Text = this.method_0(this.pByte_0 + 44, 10U);
			if (<Module>.memcmp((void*)(this.pByte_0 + 24), (void*)(&@struct), 10U) != null)
			{
				this.bool_2 = true;
			}
			else
			{
				this.bool_2 = false;
			}
			this.textBox4.Text = this.method_0(this.pByte_0 + 54, 8U);
			if (<Module>.memcmp((void*)(this.pByte_0 + 54), (void*)(&@struct), 8U) != null)
			{
				this.bool_3 = true;
			}
			else
			{
				this.bool_3 = false;
			}
			this.textBox5.Text = this.method_0(this.pByte_0 + 40, 2U) + this.method_0(this.pByte_0 + 76, 2U);
			this.bool_4 = true;
			this.method_7();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001654C File Offset: 0x0001654C
		private unsafe void method_2()
		{
			this.bool_0 = false;
			string s = Convert.ToString(this.textBox3.Text);
			if (this.textBox3.TextLength != 20)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("Cover Barcode must be 20 chars ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				Struct42 @struct;
				<Module>.memset((void*)(&@struct), 0, 20U);
				if (this.method_1(ptr, 20U) != 0)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Cover Barcode must be 20 chars.. ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.memcpy((void*)this.pByte_0, (void*)ptr, 20U);
					<Module>.memcpy((void*)(this.pByte_1 + 130816), (void*)ptr, 20U);
					if (this.uint_0 == 41008U)
					{
						<Module>.memcpy((void*)(this.pByte_1 + 11818), (void*)ptr, 20U);
						<Module>.memcpy((void*)(this.pByte_1 + 11284), (void*)ptr, 20U);
					}
					this.button1.Enabled = false;
					this.textBox3.Clear();
					this.textBox3.Text = this.method_0(this.pByte_0, 20U);
					this.bool_0 = true;
					this.method_7();
				}
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000166D0 File Offset: 0x000166D0
		private unsafe void method_3()
		{
			this.bool_4 = false;
			string s = Convert.ToString(this.textBox5.Text);
			if (this.textBox5.TextLength != 4)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				if (this.method_1(ptr, 4U) != 0)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.memcpy((void*)(this.pByte_0 + 40), (void*)ptr, 2U);
					<Module>.memcpy((void*)(this.pByte_0 + 76), (void*)(ptr + 2), 2U);
					<Module>.memcpy((void*)(this.pByte_1 + 130856), (void*)ptr, 2U);
					<Module>.memcpy((void*)(this.pByte_1 + 130892), (void*)(ptr + 2), 2U);
					if (this.uint_0 == 41008U)
					{
						<Module>.memcpy((void*)(this.pByte_1 + 11814), (void*)ptr, 2U);
						<Module>.memcpy((void*)(this.pByte_1 + 11816), (void*)(ptr + 2), 2U);
					}
					this.button1.Enabled = false;
					this.textBox5.Clear();
					this.textBox5.Text = this.method_0(this.pByte_0 + 40, 2U) + this.method_0(this.pByte_0 + 76, 2U);
					this.bool_4 = true;
					this.method_7();
				}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00016888 File Offset: 0x00016888
		private unsafe void method_4()
		{
			this.bool_1 = false;
			string s = Convert.ToString(this.textBox1.Text);
			if (this.textBox1.TextLength != 16)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				if (this.method_1(ptr, 16U) != 0)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.memcpy((void*)(this.pByte_0 + 24), (void*)ptr, 16U);
					<Module>.memcpy((void*)(this.pByte_1 + 130840), (void*)ptr, 16U);
					this.button1.Enabled = false;
					this.textBox1.Clear();
					this.textBox1.Text = this.method_0(this.pByte_0 + 24, 16U);
					this.bool_1 = true;
					this.method_7();
				}
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000169D0 File Offset: 0x000169D0
		private unsafe void method_5()
		{
			this.bool_2 = false;
			string s = Convert.ToString(this.textBox2.Text);
			if (this.textBox2.TextLength != 10)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				if (this.method_1(ptr, 10U) != 0)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.memcpy((void*)(this.pByte_0 + 44), (void*)ptr, 10U);
					<Module>.memcpy((void*)(this.pByte_1 + 130860), (void*)ptr, 10U);
					this.button1.Enabled = false;
					this.textBox2.Clear();
					this.textBox2.Text = this.method_0(this.pByte_0 + 44, 10U);
					this.bool_2 = true;
					this.method_7();
				}
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00016B18 File Offset: 0x00016B18
		private unsafe void method_6()
		{
			this.bool_3 = false;
			string s = Convert.ToString(this.textBox4.Text);
			if (this.textBox4.TextLength != 8)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
			else
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
				IntPtr value = intPtr;
				byte* ptr = (byte*)((void*)value);
				if (this.method_1(ptr, 8U) != 0)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.memcpy((void*)(this.pByte_0 + 54), (void*)ptr, 8U);
					this.pByte_0[62] = 0;
					this.pByte_0[63] = 0;
					<Module>.memcpy((void*)(this.pByte_1 + 130870), (void*)ptr, 8U);
					this.pByte_1[130878] = 0;
					this.pByte_1[130879] = 0;
					this.button1.Enabled = false;
					this.textBox4.Clear();
					this.textBox4.Text = this.method_0(this.pByte_0 + 54, 8U);
					this.bool_3 = true;
					this.method_7();
				}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00016C90 File Offset: 0x00016C90
		private void method_7()
		{
			if (this.bool_0 & this.bool_1 & this.bool_2 & this.bool_3 & this.bool_4)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00016CDC File Offset: 0x00016CDC
		private void method_8(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00016CF0 File Offset: 0x00016CF0
		private void textBox1_Leave(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00016D04 File Offset: 0x00016D04
		private void textBox2_Leave(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00016D18 File Offset: 0x00016D18
		private void textBox4_Leave(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00016D2C File Offset: 0x00016D2C
		private void textBox5_Leave(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00016D40 File Offset: 0x00016D40
		private unsafe void button1_Click(object sender, EventArgs e)
		{
			this.method_2();
			this.method_3();
			this.method_4();
			this.method_5();
			this.method_6();
			if (this.uint_1 == 5U && this.uint_2 == 1U)
			{
				<Module>.memset((void*)(this.pByte_0 + 17), 0, 3U);
				<Module>.memset((void*)(this.pByte_1 + 130833), 0, 3U);
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Firmware Images (*.bin)|*.bin|All Files (*.*)|*.*";
			saveFileDialog.DefaultExt = ".bin";
			saveFileDialog.FileName = "dummy_fixed.bin";
			saveFileDialog.RestoreDirectory = false;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(saveFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				this.string_0 = saveFileDialog.FileName;
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_5));
				if (ptr == null)
				{
					<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(saveFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
				}
				else
				{
					<Module>.fwrite((void*)this.pByte_1, 262144U, 1U, ptr);
					<Module>.fclose(ptr);
				}
			}
			else
			{
				base.DialogResult = DialogResult.Cancel;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00016E78 File Offset: 0x00016E78
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00016E94 File Offset: 0x00016E94
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00016EB0 File Offset: 0x00016EB0
		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00016ECC File Offset: 0x00016ECC
		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00016EE8 File Offset: 0x00016EE8
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00016F04 File Offset: 0x00016F04
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("http://www.jungleflasher.net/files/IMAGE_095.jpg");
			}
			catch (Exception ex)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00016F78 File Offset: 0x00016F78
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("http://www.jungleflasher.net/files/IMAGE_094.jpg");
			}
			catch (Exception ex)
			{
				<Module>.pGstruct14_7 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_6, null, <Module>.GetCurrentThreadId());
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_7);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00016FEC File Offset: 0x00016FEC
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00017004 File Offset: 0x00017004
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001701C File Offset: 0x0001701C
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00017034 File Offset: 0x00017034
		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x04000309 RID: 777
		public unsafe byte* pByte_0;

		// Token: 0x0400030A RID: 778
		public unsafe byte* pByte_1;

		// Token: 0x0400030B RID: 779
		public uint uint_0;

		// Token: 0x0400030C RID: 780
		public uint uint_1;

		// Token: 0x0400030D RID: 781
		public uint uint_2;

		// Token: 0x0400030E RID: 782
		public bool bool_0;

		// Token: 0x0400030F RID: 783
		public bool bool_1;

		// Token: 0x04000310 RID: 784
		public bool bool_2;

		// Token: 0x04000311 RID: 785
		public bool bool_3;

		// Token: 0x04000312 RID: 786
		public bool bool_4;

		// Token: 0x04000313 RID: 787
		public string string_0;
	}
}
