using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000078 RID: 120
	public partial class DumpFile : Form
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00007564 File Offset: 0x00007564
		public DumpFile()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000803C File Offset: 0x0000803C
		private unsafe void DumpFile_Load(object sender, EventArgs e)
		{
			string text = "You are about to generate a Dummy.bin from previously     " + "\n";
			text = text + "dumped files. This is intended for Legacy support only " + "\n";
			text = text + "and creating a Dummy.bin in this way will mean " + "\n";
			text = text + "certain drive specific info will be missing!" + "\n";
			text = text + "Only use this method if the drive is no longer available." + "\n\n";
			text = text + "If possible you should re-extract your drive info with the" + "\n";
			text = text + "latest tools.." + new string((sbyte*)(&<Module>.struct6_7));
			text = text + "        1. JungleFlasher, this tool - DVDKey32 Tab" + "\n";
			text = text + "        2. Dosflash 1.7+" + "\n";
			text = text + "        3. DVDKey32 0.7+" + "\n";
			text = text + "Do you wish to proceed anyway ?" + "\n";
			<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
			int num = (int)MessageBox.Show(text, "Load from dump files", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
			<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
			if (num == 7)
			{
				base.Close();
			}
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008168 File Offset: 0x00008168
		private unsafe void button4_Click(object sender, EventArgs e)
		{
			this.bool_0 = false;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Key file (*.bin)|*.bin|All Files (*.*)|*.*";
			openFileDialog.FileName = "Key.bin";
			openFileDialog.DefaultExt = ".bin";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (this.bool_4)
			{
				openFileDialog.InitialDirectory = this.string_1;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(openFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
				if (ptr == null)
				{
					<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
					this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_0 = false;
				}
				else
				{
					<Module>.fseek(ptr, 0, 2);
					int num = <Module>.ftell(ptr);
					<Module>.rewind(ptr);
					Struct28 @struct;
					if (num != 16)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_0 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 16U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_0 = false;
					}
					else
					{
						this.bool_0 = true;
						this.textBox8.Text = openFileDialog.FileName;
						if (this.pByte_2 == null)
						{
							this.pByte_2 = <Module>.malloc(16U);
						}
						<Module>.memcpy((void*)this.pByte_2, (void*)(&@struct), 16U);
						<Module>.fclose(ptr);
					}
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008384 File Offset: 0x00008384
		private unsafe void button5_Click(object sender, EventArgs e)
		{
			this.bool_1 = false;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Inquiry file (*.bin)|*.bin|All Files (*.*)|*.*";
			openFileDialog.FileName = "Inquiry.bin";
			openFileDialog.DefaultExt = ".bin";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (this.bool_4)
			{
				openFileDialog.InitialDirectory = this.string_1;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(openFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
				if (ptr == null)
				{
					<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
					this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_1 = false;
				}
				else
				{
					<Module>.fseek(ptr, 0, 2);
					int num = <Module>.ftell(ptr);
					<Module>.rewind(ptr);
					Struct29 @struct;
					if (num != 96)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show(this, "Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_1 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 96U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_1 = false;
					}
					else if (@struct == 5 && *(ref @struct + 1) == 128 && *(ref @struct + 2) == 0 && *(ref @struct + 3) == 50 && *(ref @struct + 5) == 0 && *(ref @struct + 6) == 0)
					{
						this.bool_1 = true;
						this.textBox5.Text = openFileDialog.FileName;
						if (this.pByte_1 == null)
						{
							this.pByte_1 = <Module>.malloc(96U);
						}
						<Module>.memcpy((void*)this.pByte_1, (void*)(&@struct), 96U);
						<Module>.fclose(ptr);
					}
					else
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Inquiry file is invalid!", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_1 = false;
					}
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000862C File Offset: 0x0000862C
		private unsafe void button7_Click(object sender, EventArgs e)
		{
			this.bool_2 = false;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Identify file (*.bin)|*.bin|All Files (*.*)|*.*";
			openFileDialog.FileName = "Identify.bin";
			openFileDialog.DefaultExt = ".bin";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (this.bool_4)
			{
				openFileDialog.InitialDirectory = this.string_1;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(openFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
				if (ptr == null)
				{
					<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
					this.textBox1.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_2 = false;
				}
				else
				{
					<Module>.fseek(ptr, 0, 2);
					int num = <Module>.ftell(ptr);
					<Module>.rewind(ptr);
					Struct30 @struct;
					if (num != 512)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox1.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_2 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 512U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox1.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_2 = false;
					}
					else if (@struct == 192 && *(ref @struct + 1) == 133 && *(ref @struct + 2) == 0 && *(ref @struct + 3) == 0 && *(ref @struct + 4) == 0 && *(ref @struct + 5) == 0)
					{
						this.bool_2 = true;
						this.textBox1.Text = openFileDialog.FileName;
						if (this.pByte_0 == null)
						{
							this.pByte_0 = <Module>.malloc(512U);
						}
						<Module>.memcpy((void*)this.pByte_0, (void*)(&@struct), 512U);
					}
					else
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Identify file is invalid!", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox1.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_2 = false;
					}
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000088DC File Offset: 0x000088DC
		private unsafe void button2_Click(object sender, EventArgs e)
		{
			this.bool_3 = false;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Serial file (*.bin)|*.bin|All Files (*.*)|*.*";
			openFileDialog.FileName = "Serial.bin";
			openFileDialog.DefaultExt = ".bin";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (this.bool_4)
			{
				openFileDialog.InitialDirectory = this.string_1;
			}
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(openFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
				if (ptr == null)
				{
					<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
					this.textBox2.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_3 = false;
				}
				else
				{
					<Module>.fseek(ptr, 0, 2);
					int num = <Module>.ftell(ptr);
					<Module>.rewind(ptr);
					Struct31 @struct;
					if (num != 80)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show(this, "Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox2.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_3 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 80U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_6 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_4, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_6);
						<Module>.fclose(ptr);
						this.textBox2.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_3 = false;
					}
					else
					{
						this.bool_3 = true;
						this.textBox2.Text = openFileDialog.FileName;
						if (this.pByte_3 == null)
						{
							this.pByte_3 = <Module>.malloc(80U);
						}
						<Module>.memcpy((void*)this.pByte_3, (void*)(&@struct), 80U);
						<Module>.fclose(ptr);
					}
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008AFC File Offset: 0x00008AFC
		private void textBox8_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1 && this.bool_2)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008B3C File Offset: 0x00008B3C
		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1 && this.bool_2)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008B7C File Offset: 0x00008B7C
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1 && this.bool_2)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00008BBC File Offset: 0x00008BBC
		private unsafe void button1_Click(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1 && this.bool_2)
			{
				Struct34 @struct = 127;
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
				*(ref @struct + 18) = byte.MaxValue;
				*(ref @struct + 19) = byte.MaxValue;
				*(ref @struct + 20) = byte.MaxValue;
				*(ref @struct + 21) = byte.MaxValue;
				*(ref @struct + 22) = byte.MaxValue;
				*(ref @struct + 23) = byte.MaxValue;
				*(ref @struct + 24) = byte.MaxValue;
				*(ref @struct + 25) = byte.MaxValue;
				*(ref @struct + 26) = byte.MaxValue;
				*(ref @struct + 27) = byte.MaxValue;
				*(ref @struct + 28) = byte.MaxValue;
				*(ref @struct + 29) = byte.MaxValue;
				*(ref @struct + 30) = byte.MaxValue;
				*(ref @struct + 31) = byte.MaxValue;
				*(ref @struct + 32) = 0;
				*(ref @struct + 33) = 17;
				*(ref @struct + 34) = 34;
				*(ref @struct + 35) = 51;
				*(ref @struct + 36) = 68;
				*(ref @struct + 37) = 85;
				*(ref @struct + 38) = 102;
				*(ref @struct + 39) = 119;
				*(ref @struct + 40) = 136;
				*(ref @struct + 41) = 153;
				*(ref @struct + 42) = 170;
				*(ref @struct + 43) = 187;
				*(ref @struct + 44) = 204;
				*(ref @struct + 45) = 221;
				*(ref @struct + 46) = 238;
				*(ref @struct + 47) = 250;
				Struct28 struct2 = 68;
				*(ref struct2 + 1) = 86;
				*(ref struct2 + 2) = 68;
				*(ref struct2 + 3) = 75;
				*(ref struct2 + 4) = 101;
				*(ref struct2 + 5) = 121;
				*(ref struct2 + 6) = 51;
				*(ref struct2 + 7) = 50;
				*(ref struct2 + 8) = 32;
				*(ref struct2 + 9) = 101;
				*(ref struct2 + 10) = 120;
				*(ref struct2 + 11) = 116;
				*(ref struct2 + 12) = 114;
				*(ref struct2 + 13) = 97;
				*(ref struct2 + 14) = 99;
				*(ref struct2 + 15) = 116;
				Struct30 struct3;
				<Module>.memcpy((void*)(&struct3), (void*)this.pByte_0, 512U);
				for (int i = 46; i < 93; i += 2)
				{
					*(ref struct3 + i) = this.pByte_0[i + 1];
					*(ref struct3 + (i + 1)) = this.pByte_0[i];
				}
				Struct32 struct4;
				<Module>.memset((void*)(&struct4), 0, 262144U);
				Struct33 struct5;
				<Module>.memset((void*)(&struct5), 255, 4096U);
				byte* pVoid_ = ref struct4 + 11264;
				<Module>.memcpy((void*)pVoid_, (void*)(&struct3), 512U);
				pVoid_ = ref struct4 + 11776;
				<Module>.memcpy((void*)pVoid_, (void*)this.pByte_1, 96U);
				pVoid_ = ref struct4 + 24512;
				<Module>.memcpy((void*)pVoid_, (void*)(&struct2), 16U);
				pVoid_ = ref struct4 + 40960;
				<Module>.memcpy((void*)pVoid_, (void*)(&struct5), 4096U);
				pVoid_ = ref struct4 + 40960;
				<Module>.memcpy((void*)pVoid_, (void*)(&@struct), 48U);
				pVoid_ = ref struct4 + 41008;
				<Module>.memcpy((void*)pVoid_, (void*)this.pByte_2, 16U);
				pVoid_ = ref struct4 + 130816;
				<Module>.memset((void*)pVoid_, 255, 80U);
				pVoid_ = ref struct4 + 130816;
				byte* pVoid_2 = this.pByte_1 + 42;
				<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 20U);
				pVoid_ = ref struct4 + 130856;
				pVoid_2 = this.pByte_1 + 38;
				<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 2U);
				pVoid_ = ref struct4 + 130892;
				pVoid_2 = this.pByte_1 + 40;
				<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 2U);
				if (this.bool_3)
				{
					pVoid_ = ref struct4 + 130816;
					pVoid_2 = this.pByte_3;
					<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 80U);
					pVoid_ = ref struct4 + 11284;
					<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 20U);
					pVoid_ = ref struct4 + 11818;
					<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 20U);
					pVoid_ = ref struct4 + 11814;
					pVoid_2 = this.pByte_3 + 40;
					<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 2U);
					pVoid_ = ref struct4 + 11816;
					pVoid_2 = this.pByte_3 + 76;
					<Module>.memcpy((void*)pVoid_, (void*)pVoid_2, 2U);
				}
				if (this.pByte_4 != null)
				{
					<Module>.free((void*)this.pByte_4);
				}
				this.pByte_4 = <Module>.malloc(262144U);
				<Module>.memcpy((void*)this.pByte_4, (void*)(&struct4), 262144U);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009058 File Offset: 0x00009058
		private unsafe void DumpFile_Closed(object sender, EventArgs e)
		{
			if (this.pByte_0 != null)
			{
				<Module>.free((void*)this.pByte_0);
			}
			if (this.pByte_1 != null)
			{
				<Module>.free((void*)this.pByte_1);
			}
			if (this.pByte_1 != null)
			{
				<Module>.free((void*)this.pByte_2);
			}
		}

		// Token: 0x040002ED RID: 749
		private unsafe byte* pByte_0;

		// Token: 0x040002EE RID: 750
		private unsafe byte* pByte_1;

		// Token: 0x040002EF RID: 751
		private unsafe byte* pByte_2;

		// Token: 0x040002F0 RID: 752
		private unsafe byte* pByte_3;

		// Token: 0x040002F1 RID: 753
		public unsafe byte* pByte_4;

		// Token: 0x040002F2 RID: 754
		public bool bool_0;

		// Token: 0x040002F3 RID: 755
		public bool bool_1;

		// Token: 0x040002F4 RID: 756
		public bool bool_2;

		// Token: 0x040002F5 RID: 757
		public bool bool_3;

		// Token: 0x040002F6 RID: 758
		public string string_0;

		// Token: 0x040002F7 RID: 759
		public bool bool_4;

		// Token: 0x040002F8 RID: 760
		public string string_1;
	}
}
