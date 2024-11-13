using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x02000071 RID: 113
	public partial class DataBaseView : Form
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00004228 File Offset: 0x00004228
		public DataBaseView()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005B10 File Offset: 0x00005B10
		private unsafe void method_0()
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
			int num;
			if (registryKey.GetValue("Index") != null)
			{
				string value = registryKey.GetValue("Index").ToString();
				num = Convert.ToInt32(value) + 1;
			}
			registryKey.Close();
			for (int i = 1; i < num; i++)
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + Convert.ToString(i));
				if (registryKey2.GetValue("Key") != null && registryKey2.GetValue("Deleted") == null)
				{
					string value2 = registryKey2.GetValue("Key").ToString();
					string value3 = registryKey2.GetValue("KeyLoc").ToString();
					string value4 = registryKey2.GetValue("Vendor").ToString();
					string value5 = registryKey2.GetValue(new string((sbyte*)(&<Module>.struct23_0))).ToString();
					string value6 = registryKey2.GetValue("Rev").ToString();
					string value7 = registryKey2.GetValue("Type").ToString();
					string value8 = registryKey2.GetValue("JobName").ToString();
					string value9 = registryKey2.GetValue(new string((sbyte*)(&<Module>.struct22_0))).ToString();
					string value10;
					if (registryKey2.GetValue("Spoof") != null)
					{
						value10 = registryKey2.GetValue("Spoof").ToString();
					}
					else
					{
						value10 = "";
					}
					string value11;
					if (registryKey2.GetValue("Updated") != null)
					{
						value11 = registryKey2.GetValue("Updated").ToString();
					}
					else
					{
						value11 = "";
					}
					string value12 = registryKey2.GetValue("Osig").ToString();
					string value13;
					if (registryKey2.GetValue("LastFile") != null)
					{
						value13 = registryKey2.GetValue("LastFile").ToString();
					}
					else
					{
						value13 = registryKey2.GetValue("WorkingDir").ToString() + "\\";
					}
					registryKey2.Close();
					DataRow dataRow = this.dataTable_0.NewRow();
					dataRow["ID"] = Convert.ToString(i);
					dataRow["Job_Name"] = value8;
					dataRow["Key"] = value2;
					dataRow["Model"] = value5;
					dataRow["Rev"] = value6;
					dataRow["Vendor"] = value4;
					dataRow["FileLoc"] = value13;
					dataRow["KeyLoc"] = value3;
					dataRow["Type"] = value7;
					dataRow["Spoof"] = value10;
					dataRow["Osig"] = value12;
					dataRow["Created"] = value9;
					dataRow["Updated"] = value11;
					this.dataTable_0.Rows.Add(dataRow);
				}
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005DE4 File Offset: 0x00005DE4
		private unsafe void DataBaseView_Load(object sender, EventArgs e)
		{
			this.method_0();
			this.dataGrid1.DataSource = this.dataSet_0.Tables["Table1"];
			DataGridTableStyle dataGridTableStyle = new DataGridTableStyle();
			dataGridTableStyle.MappingName = "Table1";
			DataGridColumnStyle dataGridColumnStyle = new DataGridTextBoxColumn();
			DataGridColumnStyle dataGridColumnStyle2 = new DataGridTextBoxColumn();
			DataGridColumnStyle dataGridColumnStyle3 = new DataGridTextBoxColumn();
			DataGridColumnStyle dataGridColumnStyle4 = new DataGridTextBoxColumn();
			DataGridColumnStyle dataGridColumnStyle5 = new DataGridTextBoxColumn();
			DataGridColumnStyle dataGridColumnStyle6 = new DataGridTextBoxColumn();
			dataGridColumnStyle.MappingName = new string((sbyte*)(&<Module>.struct18_1));
			dataGridColumnStyle.HeaderText = new string((sbyte*)(&<Module>.struct18_1));
			dataGridColumnStyle.Width = 30;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle);
			dataGridColumnStyle2.MappingName = new string((sbyte*)(&<Module>.struct24_0));
			dataGridColumnStyle2.HeaderText = "Job Name";
			dataGridColumnStyle2.Width = 65;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle2);
			dataGridColumnStyle3.MappingName = new string((sbyte*)(&<Module>.struct25_0));
			dataGridColumnStyle3.HeaderText = new string((sbyte*)(&<Module>.struct25_0));
			dataGridColumnStyle3.Width = 235;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle3);
			dataGridColumnStyle4.MappingName = new string((sbyte*)(&<Module>.struct10_1));
			dataGridColumnStyle4.HeaderText = new string((sbyte*)(&<Module>.struct10_1));
			dataGridColumnStyle4.Width = 65;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle4);
			dataGridColumnStyle5.MappingName = new string((sbyte*)(&<Module>.struct23_0));
			dataGridColumnStyle5.HeaderText = new string((sbyte*)(&<Module>.struct23_0));
			dataGridColumnStyle5.Width = 60;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle5);
			dataGridColumnStyle6.MappingName = new string((sbyte*)(&<Module>.struct25_1));
			dataGridColumnStyle6.HeaderText = new string((sbyte*)(&<Module>.struct25_1));
			dataGridColumnStyle6.Width = 44;
			dataGridTableStyle.RowHeadersVisible = false;
			dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle6);
			this.dataGrid1.TableStyles.Add(dataGridTableStyle);
			this.label6.DataBindings.Add("Text", this.dataTable_0, "Vendor");
			this.label7.DataBindings.Add("Text", this.dataTable_0, "Model");
			this.label8.DataBindings.Add("Text", this.dataTable_0, "Rev");
			this.label9.DataBindings.Add("Text", this.dataTable_0, "Created");
			this.label10.DataBindings.Add("Text", this.dataTable_0, "Updated");
			this.label11.DataBindings.Add("Text", this.dataTable_0, "ID");
			this.label16.DataBindings.Add("Text", this.dataTable_0, "Type");
			this.label37.DataBindings.Add("Text", this.dataTable_0, "KeyLoc");
			this.label40.DataBindings.Add("Text", this.dataTable_0, "Spoof");
			this.label44.DataBindings.Add("Text", this.dataTable_0, "Osig");
			this.textBox2.DataBindings.Add("Text", this.dataTable_0, "Job_Name");
			this.textBox9.DataBindings.Add("Text", this.dataTable_0, "Key");
			this.textBox15.DataBindings.Add("Text", this.dataTable_0, "FileLoc");
			if (this.int_0 > 0)
			{
				this.method_3(this.int_0);
				this.dataGrid1.CurrentRowIndex = 0;
				this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000061A8 File Offset: 0x000061A8
		private void button1_Click(object sender, EventArgs e)
		{
			new Job_history
			{
				int_0 = Convert.ToInt32(this.label11.Text)
			}.ShowDialog(this);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000061DC File Offset: 0x000061DC
		private void menuItem_0_Click(object sender, EventArgs e)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + this.label11.Text);
			registryKey.SetValue("Deleted", "1");
			registryKey.Close();
			this.dataTable_0.Clear();
			this.method_0();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006234 File Offset: 0x00006234
		private void dataGrid1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006264 File Offset: 0x00006264
		private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
		{
			this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006288 File Offset: 0x00006288
		private void dataGrid1_MouseDown(object sender, MouseEventArgs e)
		{
			DataGridCell currentCell = default(DataGridCell);
			if (e.Button == MouseButtons.Right)
			{
				this.dataGrid1.UnSelect(this.dataGrid1.CurrentRowIndex);
				DataGrid.HitTestInfo hitTestInfo = this.dataGrid1.HitTest(e.X, e.Y);
				currentCell.RowNumber = hitTestInfo.Row;
				currentCell.ColumnNumber = hitTestInfo.Column;
				this.dataGrid1.CurrentCell = currentCell;
				this.dataGrid1.CurrentRowIndex = hitTestInfo.Row;
				this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006330 File Offset: 0x00006330
		private void method_1(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006344 File Offset: 0x00006344
		private void method_2()
		{
			this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = string.Format("Job_Name like '{0}%'", this.textBox1.Text);
			if (this.dataSet_0.Tables["Table1"].DefaultView.Count == 0)
			{
				MessageBox.Show("No matching Jobs Found", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = "";
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000063E0 File Offset: 0x000063E0
		private void method_3(int int_1)
		{
			this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = string.Format("ID = {0}", Convert.ToString(int_1));
			if (this.dataSet_0.Tables["Table1"].DefaultView.Count == 0)
			{
				MessageBox.Show("No matching Jobs Found", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = "";
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006474 File Offset: 0x00006474
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.method_2();
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006494 File Offset: 0x00006494
		private void dataGrid1_DoubleClick(object sender, EventArgs e)
		{
			new Job_history
			{
				int_0 = Convert.ToInt32(this.label11.Text)
			}.ShowDialog(this);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000064C8 File Offset: 0x000064C8
		private unsafe void button2_Click(object sender, EventArgs e)
		{
			GStruct11* ptr = <Module>.FindWindowA(null, (sbyte*)(&<Module>.struct12_5));
			if (ptr == null)
			{
				ptr = <Module>.FindWindowA((sbyte*)(&<Module>.struct9_1), null);
				if (ptr == null)
				{
					ptr = <Module>.FindWindowA((sbyte*)(&<Module>.struct26_0), null);
				}
			}
			GStruct11* pGstruct11_ = <Module>.FindWindowExA(ptr, null, null, (sbyte*)(&<Module>.struct16_1));
			if (File.Exists(this.textBox15.Text))
			{
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(this.textBox15.Text);
				IntPtr value = intPtr;
				<Module>.SendMessageA(pGstruct11_, 12U, 0U, (void*)value);
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			else if (Directory.Exists(Path.GetDirectoryName(this.textBox15.Text)))
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Firmware file (*.bin)|*.bin|All Files (*.*)|*.*";
				openFileDialog.FileName = "Orig.bin";
				openFileDialog.DefaultExt = ".bin";
				openFileDialog.CheckFileExists = true;
				openFileDialog.CheckPathExists = true;
				openFileDialog.RestoreDirectory = false;
				openFileDialog.InitialDirectory = this.textBox15.Text;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					IntPtr intPtr2 = Marshal.StringToHGlobalAnsi(openFileDialog.FileName);
					IntPtr value2 = intPtr2;
					<Module>.SendMessageA(pGstruct11_, 12U, 0U, (void*)value2);
					base.DialogResult = DialogResult.OK;
					base.Close();
				}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000065F8 File Offset: 0x000065F8
		private unsafe void method_4()
		{
			string text = null;
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
			int num;
			if (registryKey.GetValue("Index") != null)
			{
				text = registryKey.GetValue("Index").ToString();
				num = Convert.ToInt32(text) + 1;
			}
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\SerList");
			string value = registryKey2.ValueCount.ToString();
			string[] valueNames = registryKey2.GetValueNames();
			string text2 = ",,JungleFlasher Key Database,";
			int num2;
			<Module>.time((int*)(&num2));
			GStruct85* pGstruct85_ = <Module>.localtime((int*)(&num2));
			text2 += Convert.ToString(new string(<Module>.asctime((GStruct85*)pGstruct85_))).Substring(0, 24);
			text2 = text2 + "," + text + " keys present!" + "\n";
			for (int i = 1; i < num; i++)
			{
				RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + Convert.ToString(i));
				if (registryKey3.GetValue("Key") != null)
				{
					string str = registryKey3.GetValue("Key").ToString();
					string str2 = registryKey3.GetValue("KeyLoc").ToString();
					string str3 = registryKey3.GetValue("Vendor").ToString();
					string str4 = registryKey3.GetValue(new string((sbyte*)(&<Module>.struct23_0))).ToString();
					string str5 = registryKey3.GetValue("Rev").ToString();
					string str6 = registryKey3.GetValue("Type").ToString();
					string str7 = registryKey3.GetValue("JobName").ToString();
					string str8 = registryKey3.GetValue(new string((sbyte*)(&<Module>.struct22_0))).ToString();
					string text3;
					if (registryKey3.GetValue("Spoof") != null)
					{
						text3 = registryKey3.GetValue("Spoof").ToString();
					}
					else
					{
						text3 = "";
					}
					string text4;
					if (registryKey3.GetValue("Updated") != null)
					{
						text4 = registryKey3.GetValue("Updated").ToString();
					}
					else
					{
						text4 = "";
					}
					string str9 = registryKey3.GetValue("Osig").ToString();
					string str10 = registryKey3.GetValue("WorkingDir").ToString();
					string text5;
					if (registryKey3.GetValue("LastFile") != null)
					{
						text5 = registryKey3.GetValue("LastFile").ToString();
					}
					else
					{
						text5 = "";
					}
					registryKey3.Close();
					string text6 = "";
					for (int j = 0; j < Convert.ToInt32(value); j++)
					{
						if (string.Compare(registryKey2.GetValue(valueNames[j]).ToString(), Convert.ToString(i)) == 0)
						{
							text6 = valueNames[j];
							break;
						}
					}
					text2 = text2 + Convert.ToString(i) + ",";
					text2 = text2 + str7 + ",";
					text2 = text2 + str8 + ",";
					text2 = text2 + str10 + ",";
					text2 = text2 + str9 + ",";
					if (string.Compare(text3, "") != 0)
					{
						text2 = text2 + text3 + ",";
					}
					else
					{
						text2 += ",";
					}
					text2 = text2 + str3 + ",";
					text2 = text2 + str4 + ",";
					text2 = text2 + str5 + ",";
					text2 = text2 + str6 + ",";
					text2 = text2 + str + ",";
					text2 = text2 + str2 + ",";
					if (string.Compare(text4, "") != 0)
					{
						text2 = text2 + text4 + ",";
					}
					else
					{
						text2 += "n/a,";
					}
					if (string.Compare(text5, "") != 0)
					{
						text2 = text2 + text5 + ",";
					}
					else
					{
						text2 += "n/a,";
					}
					if (string.Compare(text6, "") != 0)
					{
						text2 = text2 + text6 + "\n";
					}
					else
					{
						text2 += "n/a\n";
					}
				}
			}
			registryKey2.Close();
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "KeyDb Backup file (*.csv)|*.csv|All Files (*.*)|*.*";
			saveFileDialog.DefaultExt = ".csv";
			saveFileDialog.FileName = "KeyDB.csv";
			saveFileDialog.OverwritePrompt = false;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fullPath = Path.GetFullPath(saveFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value2 = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value2);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct18_2));
				if (ptr == null)
				{
					MessageBox.Show(saveFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
				}
				else
				{
					IntPtr intPtr2 = Marshal.StringToHGlobalAnsi(text2);
					IntPtr value3 = intPtr2;
					sbyte* pSbyte_2 = (sbyte*)((void*)value3);
					<Module>.fputs((sbyte*)pSbyte_2, ptr);
					<Module>.fclose(ptr);
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006AC4 File Offset: 0x00006AC4
		private unsafe void method_5()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "KeyDB Backup file (*.csv)|*.csv|All Files (*.*)|*.*";
			openFileDialog.FileName = "KeyDB.csv";
			openFileDialog.DefaultExt = ".csv";
			openFileDialog.CheckFileExists = true;
			openFileDialog.CheckPathExists = true;
			openFileDialog.RestoreDirectory = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.Cursor = Cursors.AppStarting;
				string fullPath = Path.GetFullPath(openFileDialog.FileName);
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(fullPath);
				IntPtr value = intPtr;
				sbyte* pSbyte_ = (sbyte*)((void*)value);
				GStruct5* ptr = <Module>.fopen((sbyte*)pSbyte_, (sbyte*)(&<Module>.struct6_3));
				if (ptr == null)
				{
					MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
				}
				else
				{
					Struct27 @struct;
					<Module>.fgets((sbyte*)(&@struct), 1024, ptr);
					sbyte* ptr2 = <Module>.strtok((sbyte*)(&@struct), (sbyte*)(&<Module>.struct6_4));
					ptr2 = <Module>.strtok(null, (sbyte*)(&<Module>.struct6_4));
					ptr2 = <Module>.strtok(null, (sbyte*)(&<Module>.struct6_4));
					sbyte* value2 = <Module>.strtok(ptr2, (sbyte*)(&<Module>.struct6_5));
					string value3 = "" + new string((sbyte*)value2);
					string[,] array = new string[Convert.ToInt32(value3), 15];
					for (int i = 0; i < Convert.ToInt32(value3); i++)
					{
						<Module>.fgets((sbyte*)(&@struct), 1024, ptr);
						ptr2 = <Module>.strtok((sbyte*)(&@struct), (sbyte*)(&<Module>.struct6_4));
						string text = "" + new string((sbyte*)ptr2);
						array[i, 0] = text;
						for (int j = 1; j < 15; j++)
						{
							ptr2 = <Module>.strtok(null, (sbyte*)(&<Module>.struct18_3));
							text = "" + new string((sbyte*)ptr2);
							array[i, j] = text;
						}
					}
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
					string value4;
					if (registryKey.GetValue("Index") != null)
					{
						value4 = registryKey.GetValue("Index").ToString();
					}
					else
					{
						value4 = new string((sbyte*)(&<Module>.struct6_6));
					}
					string value5 = Convert.ToString(Convert.ToInt32(value3) + Convert.ToInt32(value4));
					registryKey.SetValue("Index", Convert.ToString(value5));
					registryKey.Close();
					for (int i = 0; i < Convert.ToInt32(value3); i++)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(new string((sbyte*)(&<Module>.struct7_1)) + Convert.ToString(i + 1 + Convert.ToInt32(value4)));
						registryKey.SetValue("Index", Convert.ToString(i + 1 + Convert.ToInt32(value4)));
						registryKey.SetValue("JobName", array[i, 1]);
						registryKey.SetValue("Created", array[i, 2]);
						registryKey.SetValue("WorkingDir", array[i, 3]);
						registryKey.SetValue("Osig", array[i, 4]);
						registryKey.SetValue("Spoof", array[i, 5]);
						registryKey.SetValue("Vendor", array[i, 6]);
						registryKey.SetValue("Model", array[i, 7]);
						registryKey.SetValue("Rev", array[i, 8]);
						registryKey.SetValue("Type", array[i, 9]);
						registryKey.SetValue("Key", array[i, 10]);
						registryKey.SetValue("KeyLoc", array[i, 11]);
						registryKey.SetValue("Updated", array[i, 12]);
						registryKey.SetValue("Lastfile", array[i, 13]);
						registryKey.Close();
					}
					for (int i = 0; i < Convert.ToInt32(value3); i++)
					{
						registryKey = Registry.CurrentUser.CreateSubKey(new string((sbyte*)(&<Module>.struct16_2)));
						registryKey.SetValue(array[i, 10], Convert.ToString(i + 1 + Convert.ToInt32(value4)));
						registryKey.Close();
					}
					for (int i = 0; i < Convert.ToInt32(value3); i++)
					{
						if (string.Compare(array[i, 14], "n/a") != 0)
						{
							registryKey = Registry.CurrentUser.CreateSubKey(new string((sbyte*)(&<Module>.struct16_3)));
							registryKey.SetValue(array[i, 14], Convert.ToString(i + 1 + Convert.ToInt32(value4)));
							registryKey.Close();
						}
					}
					this.Cursor = Cursors.Arrow;
				}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006F0C File Offset: 0x00006F0C
		private void button4_Click(object sender, EventArgs e)
		{
			this.method_5();
			this.dataTable_0.Clear();
			this.method_0();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006F30 File Offset: 0x00006F30
		private void button3_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006F44 File Offset: 0x00006F44
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040002D4 RID: 724
		public int int_0;
	}
}
