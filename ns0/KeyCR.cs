using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020000A7 RID: 167
	public partial class KeyCR : Form
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x000F60D0 File Offset: 0x000F60D0
		public KeyCR()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000F67C0 File Offset: 0x000F67C0
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000F67D0 File Offset: 0x000F67D0
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
				openFileDialog.InitialDirectory = this.string_0;
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
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
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
						<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
						<Module>.fclose(ptr);
						this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_0 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 16U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
						<Module>.fclose(ptr);
						this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_0 = false;
					}
					else
					{
						this.bool_0 = true;
						this.textBox8.Text = openFileDialog.FileName;
						<Module>.memcpy((void*)(this.pByte_0 + 126960), (void*)(&@struct), 16U);
						<Module>.fclose(ptr);
					}
				}
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000F69E0 File Offset: 0x000F69E0
		private unsafe void button5_Click(object sender, EventArgs e)
		{
			this.bool_1 = false;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "CR File (*.bin)|*.bin|All Files (*.*)|*.*";
			openFileDialog.FileName = "C-R.bin";
			openFileDialog.DefaultExt = ".bin";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (this.bool_4)
			{
				openFileDialog.InitialDirectory = this.string_0;
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
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
					this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_1 = false;
				}
				else
				{
					<Module>.fseek(ptr, 0, 2);
					int num = <Module>.ftell(ptr);
					<Module>.rewind(ptr);
					Struct64 @struct;
					if (num != 9538)
					{
						<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
						<Module>.fclose(ptr);
						this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_1 = false;
					}
					else if (<Module>.fread((void*)(&@struct), 9538U, 1U, ptr) != 1)
					{
						<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
						MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
						<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
						<Module>.fclose(ptr);
						this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
						this.bool_1 = false;
					}
					else
					{
						this.bool_1 = true;
						this.textBox5.Text = openFileDialog.FileName;
						<Module>.memcpy((void*)(this.pByte_0 + 186624), (void*)(&@struct), 9538U);
						<Module>.fclose(ptr);
					}
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000F6BF8 File Offset: 0x000F6BF8
		private void textBox8_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000F6C30 File Offset: 0x000F6C30
		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_0 && this.bool_1)
			{
				this.button1.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000F6C68 File Offset: 0x000F6C68
		private unsafe void KeyCR_Load(object sender, EventArgs e)
		{
			if (this.pByte_0 != null)
			{
				<Module>.free((void*)this.pByte_0);
			}
			this.pByte_0 = <Module>.malloc(262144U);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000F6C98 File Offset: 0x000F6C98
		private void textBox8_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (array.Length > 1)
			{
				e.Effect = DragDropEffects.None;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000F6CF0 File Offset: 0x000F6CF0
		private void textBox5_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (array.Length > 1)
			{
				e.Effect = DragDropEffects.None;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000F6D48 File Offset: 0x000F6D48
		private unsafe void textBox8_DragDrop(object sender, DragEventArgs e)
		{
			this.bool_0 = false;
			this.textBox8.Clear();
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			string s = array[0];
			s = Path.GetFullPath(array[0]);
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
			IntPtr value = intPtr;
			sbyte* pSbyte_ = (sbyte*)((void*)value);
			GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
			if (ptr == null)
			{
				<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
				MessageBox.Show(array[0], "Can't open file", MessageBoxButtons.OK);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
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
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
					<Module>.fclose(ptr);
					this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_0 = false;
				}
				else if (<Module>.fread((void*)(&@struct), 16U, 1U, ptr) != 1)
				{
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
					<Module>.fclose(ptr);
					this.textBox8.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_0 = false;
				}
				else
				{
					this.bool_0 = true;
					this.textBox8.Text = array[0];
					<Module>.memcpy((void*)(this.pByte_0 + 126960), (void*)(&@struct), 16U);
					<Module>.fclose(ptr);
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000F6F10 File Offset: 0x000F6F10
		private unsafe void textBox5_DragDrop(object sender, DragEventArgs e)
		{
			this.bool_1 = false;
			this.textBox5.Clear();
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			string s = array[0];
			s = Path.GetFullPath(array[0]);
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(s);
			IntPtr value = intPtr;
			sbyte* pSbyte_ = (sbyte*)((void*)value);
			GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_4));
			if (ptr == null)
			{
				<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
				MessageBox.Show(array[0], "Can't open file", MessageBoxButtons.OK);
				<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
				this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
				this.bool_1 = false;
			}
			else
			{
				<Module>.fseek(ptr, 0, 2);
				int num = <Module>.ftell(ptr);
				<Module>.rewind(ptr);
				Struct64 @struct;
				if (num != 9538)
				{
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
					<Module>.fclose(ptr);
					this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_1 = false;
				}
				else if (<Module>.fread((void*)(&@struct), 9538U, 1U, ptr) != 1)
				{
					<Module>.pGstruct14_11 = <Module>.SetWindowsHookExA(5, <Module>.ppInt_11, null, <Module>.GetCurrentThreadId());
					MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
					<Module>.UnhookWindowsHookEx(<Module>.pGstruct14_11);
					<Module>.fclose(ptr);
					this.textBox5.Text = new string((sbyte*)(&<Module>.struct19_0));
					this.bool_1 = false;
				}
				else
				{
					this.bool_1 = true;
					this.textBox5.Text = array[0];
					<Module>.memcpy((void*)(this.pByte_0 + 186624), (void*)(&@struct), 9538U);
					<Module>.fclose(ptr);
				}
			}
		}

		// Token: 0x04000353 RID: 851
		public unsafe byte* pByte_0;

		// Token: 0x04000354 RID: 852
		public unsafe byte* pByte_1;

		// Token: 0x04000355 RID: 853
		public bool bool_0;

		// Token: 0x04000356 RID: 854
		public bool bool_1;

		// Token: 0x04000357 RID: 855
		public bool bool_2;

		// Token: 0x04000358 RID: 856
		public bool bool_3;

		// Token: 0x04000359 RID: 857
		public bool bool_4;

		// Token: 0x0400035A RID: 858
		public string string_0;
	}
}
