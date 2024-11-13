namespace ns0
{
	// Token: 0x02000071 RID: 113
	public partial class DataBaseView : global::System.Windows.Forms.Form
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0034E03E File Offset: 0x0029603E
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004270 File Offset: 0x00004270
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::ns0.DataBaseView));
			this.dataGrid1 = new global::System.Windows.Forms.DataGrid();
			this.contextMenu_0 = new global::System.Windows.Forms.ContextMenu();
			this.menuItem_0 = new global::System.Windows.Forms.MenuItem();
			this.dataTable_0 = new global::System.Data.DataTable();
			this.dataColumn_0 = new global::System.Data.DataColumn();
			this.dataColumn_1 = new global::System.Data.DataColumn();
			this.dataColumn_2 = new global::System.Data.DataColumn();
			this.dataColumn_3 = new global::System.Data.DataColumn();
			this.dataColumn_4 = new global::System.Data.DataColumn();
			this.dataColumn_5 = new global::System.Data.DataColumn();
			this.dataColumn_6 = new global::System.Data.DataColumn();
			this.dataColumn_7 = new global::System.Data.DataColumn();
			this.dataColumn_8 = new global::System.Data.DataColumn();
			this.dataColumn_9 = new global::System.Data.DataColumn();
			this.dataColumn_10 = new global::System.Data.DataColumn();
			this.dataColumn_11 = new global::System.Data.DataColumn();
			this.dataColumn_12 = new global::System.Data.DataColumn();
			this.dataSet_0 = new global::System.Data.DataSet();
			this.dataTable_1 = new global::System.Data.DataTable();
			this.dataColumn_13 = new global::System.Data.DataColumn();
			this.label40 = new global::System.Windows.Forms.Label();
			this.label44 = new global::System.Windows.Forms.Label();
			this.label43 = new global::System.Windows.Forms.Label();
			this.label41 = new global::System.Windows.Forms.Label();
			this.label37 = new global::System.Windows.Forms.Label();
			this.textBox15 = new global::System.Windows.Forms.TextBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.textBox9 = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label11 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.dataGrid1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.ContextMenu = this.contextMenu_0;
			this.dataGrid1.DataMember = "";
			global::System.Drawing.Color controlText = global::System.Drawing.SystemColors.ControlText;
			global::System.Drawing.Color color = controlText;
			global::System.Drawing.Color headerForeColor = color;
			this.dataGrid1.HeaderForeColor = headerForeColor;
			global::System.Drawing.Point location = default(global::System.Drawing.Point);
			location = new global::System.Drawing.Point(16, 48);
			this.dataGrid1.Location = location;
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsVisible = false;
			this.dataGrid1.ReadOnly = true;
			global::System.Drawing.Size size = default(global::System.Drawing.Size);
			size = new global::System.Drawing.Size(520, 278);
			this.dataGrid1.Size = size;
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
			this.dataGrid1.DoubleClick += new global::System.EventHandler(this.dataGrid1_DoubleClick);
			this.dataGrid1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
			this.dataGrid1.CurrentCellChanged += new global::System.EventHandler(this.dataGrid1_CurrentCellChanged);
			global::System.Windows.Forms.MenuItem[] items = new global::System.Windows.Forms.MenuItem[]
			{
				this.menuItem_0
			};
			this.contextMenu_0.MenuItems.AddRange(items);
			this.menuItem_0.Index = 0;
			this.menuItem_0.Text = "Delete";
			this.menuItem_0.Click += new global::System.EventHandler(this.menuItem_0_Click);
			global::System.Data.DataColumn[] columns = new global::System.Data.DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12
			};
			this.dataTable_0.Columns.AddRange(columns);
			this.dataTable_0.TableName = "Table1";
			this.dataColumn_0.ColumnName = "ID";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "Job_Name";
			this.dataColumn_2.ColumnName = "Key";
			this.dataColumn_3.ColumnName = "Vendor";
			this.dataColumn_4.ColumnName = "Model";
			this.dataColumn_5.ColumnName = "Rev";
			this.dataColumn_6.ColumnName = "FileLoc";
			this.dataColumn_7.ColumnName = "KeyLoc";
			this.dataColumn_8.ColumnName = "Type";
			this.dataColumn_9.ColumnName = "Spoof";
			this.dataColumn_10.ColumnName = "Osig";
			this.dataColumn_11.ColumnName = "Created";
			this.dataColumn_12.ColumnName = "Updated";
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Locale = new global::System.Globalization.CultureInfo("en-IE");
			global::System.Data.DataTable[] tables = new global::System.Data.DataTable[]
			{
				this.dataTable_0,
				this.dataTable_1
			};
			this.dataSet_0.Tables.AddRange(tables);
			global::System.Data.DataColumn[] columns2 = new global::System.Data.DataColumn[]
			{
				this.dataColumn_13
			};
			this.dataTable_1.Columns.AddRange(columns2);
			this.dataTable_1.TableName = "Table2";
			this.dataColumn_13.ColumnName = "Vendor";
			this.label40.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location2 = default(global::System.Drawing.Point);
			location2 = new global::System.Drawing.Point(312, 64);
			this.label40.Location = location2;
			this.label40.Name = "label40";
			global::System.Drawing.Size size2 = default(global::System.Drawing.Size);
			size2 = new global::System.Drawing.Size(208, 16);
			this.label40.Size = size2;
			this.label40.TabIndex = 49;
			this.label44.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location3 = default(global::System.Drawing.Point);
			location3 = new global::System.Drawing.Point(40, 64);
			this.label44.Location = location3;
			this.label44.Name = "label44";
			global::System.Drawing.Size size3 = default(global::System.Drawing.Size);
			size3 = new global::System.Drawing.Size(208, 16);
			this.label44.Size = size3;
			this.label44.TabIndex = 52;
			global::System.Drawing.Point location4 = default(global::System.Drawing.Point);
			location4 = new global::System.Drawing.Point(8, 64);
			this.label43.Location = location4;
			this.label43.Name = "label43";
			global::System.Drawing.Size size4 = default(global::System.Drawing.Size);
			size4 = new global::System.Drawing.Size(40, 16);
			this.label43.Size = size4;
			this.label43.TabIndex = 51;
			this.label43.Text = "OSIG:";
			global::System.Drawing.Point location5 = default(global::System.Drawing.Point);
			location5 = new global::System.Drawing.Point(248, 64);
			this.label41.Location = location5;
			this.label41.Name = "label41";
			global::System.Drawing.Size size5 = default(global::System.Drawing.Size);
			size5 = new global::System.Drawing.Size(88, 16);
			this.label41.Size = size5;
			this.label41.TabIndex = 50;
			this.label41.Text = "Spoofed As:";
			global::System.Drawing.Point location6 = default(global::System.Drawing.Point);
			location6 = new global::System.Drawing.Point(384, 16);
			this.label37.Location = location6;
			this.label37.Name = "label37";
			global::System.Drawing.Size size6 = default(global::System.Drawing.Size);
			size6 = new global::System.Drawing.Size(60, 16);
			this.label37.Size = size6;
			this.label37.TabIndex = 48;
			global::System.Drawing.Color window = global::System.Drawing.SystemColors.Window;
			global::System.Drawing.Color color2 = window;
			global::System.Drawing.Color backColor = color2;
			this.textBox15.BackColor = backColor;
			global::System.Drawing.Point location7 = default(global::System.Drawing.Point);
			location7 = new global::System.Drawing.Point(8, 120);
			this.textBox15.Location = location7;
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			global::System.Drawing.Size size7 = default(global::System.Drawing.Size);
			size7 = new global::System.Drawing.Size(488, 20);
			this.textBox15.Size = size7;
			this.textBox15.TabIndex = 47;
			this.textBox15.Text = "";
			global::System.Drawing.Point location8 = default(global::System.Drawing.Point);
			location8 = new global::System.Drawing.Point(312, 16);
			this.label19.Location = location8;
			this.label19.Name = "label19";
			global::System.Drawing.Size size8 = default(global::System.Drawing.Size);
			size8 = new global::System.Drawing.Size(72, 16);
			this.label19.Size = size8;
			this.label19.TabIndex = 46;
			this.label19.Text = "DVD Key @";
			global::System.Drawing.Color window2 = global::System.Drawing.SystemColors.Window;
			global::System.Drawing.Color color3 = window2;
			global::System.Drawing.Color backColor2 = color3;
			this.textBox9.BackColor = backColor2;
			global::System.Drawing.Point location9 = default(global::System.Drawing.Point);
			location9 = new global::System.Drawing.Point(304, 40);
			this.textBox9.Location = location9;
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			global::System.Drawing.Size size9 = default(global::System.Drawing.Size);
			size9 = new global::System.Drawing.Size(224, 20);
			this.textBox9.Size = size9;
			this.textBox9.TabIndex = 45;
			this.textBox9.Text = "";
			global::System.Drawing.Point location10 = default(global::System.Drawing.Point);
			location10 = new global::System.Drawing.Point(160, 16);
			this.label15.Location = location10;
			this.label15.Name = "label15";
			global::System.Drawing.Size size10 = default(global::System.Drawing.Size);
			size10 = new global::System.Drawing.Size(120, 16);
			this.label15.Size = size10;
			this.label15.TabIndex = 43;
			this.label15.Text = "Firmware Type";
			global::System.Drawing.Point location11 = default(global::System.Drawing.Point);
			location11 = new global::System.Drawing.Point(56, 40);
			this.label7.Location = location11;
			this.label7.Name = "label7";
			global::System.Drawing.Size size11 = default(global::System.Drawing.Size);
			size11 = new global::System.Drawing.Size(64, 16);
			this.label7.Size = size11;
			this.label7.TabIndex = 41;
			global::System.Drawing.Point location12 = default(global::System.Drawing.Point);
			location12 = new global::System.Drawing.Point(8, 40);
			this.label6.Location = location12;
			this.label6.Name = "label6";
			global::System.Drawing.Size size12 = default(global::System.Drawing.Size);
			size12 = new global::System.Drawing.Size(72, 16);
			this.label6.Size = size12;
			this.label6.TabIndex = 40;
			global::System.Drawing.Point location13 = default(global::System.Drawing.Point);
			location13 = new global::System.Drawing.Point(120, 16);
			this.label5.Location = location13;
			this.label5.Name = "label5";
			global::System.Drawing.Size size13 = default(global::System.Drawing.Size);
			size13 = new global::System.Drawing.Size(32, 16);
			this.label5.Size = size13;
			this.label5.TabIndex = 39;
			this.label5.Text = "Rev";
			global::System.Drawing.Point location14 = default(global::System.Drawing.Point);
			location14 = new global::System.Drawing.Point(56, 16);
			this.label4.Location = location14;
			this.label4.Name = "label4";
			global::System.Drawing.Size size14 = default(global::System.Drawing.Size);
			size14 = new global::System.Drawing.Size(56, 16);
			this.label4.Size = size14;
			this.label4.TabIndex = 38;
			this.label4.Text = "Model ";
			global::System.Drawing.Point location15 = default(global::System.Drawing.Point);
			location15 = new global::System.Drawing.Point(8, 16);
			this.label3.Location = location15;
			this.label3.Name = "label3";
			global::System.Drawing.Size size15 = default(global::System.Drawing.Size);
			size15 = new global::System.Drawing.Size(48, 16);
			this.label3.Size = size15;
			this.label3.TabIndex = 37;
			this.label3.Text = "Vendor";
			global::System.Drawing.Point location16 = default(global::System.Drawing.Point);
			location16 = new global::System.Drawing.Point(160, 40);
			this.label16.Location = location16;
			this.label16.Name = "label16";
			global::System.Drawing.Size size16 = default(global::System.Drawing.Size);
			size16 = new global::System.Drawing.Size(152, 24);
			this.label16.Size = size16;
			this.label16.TabIndex = 44;
			global::System.Drawing.Point location17 = default(global::System.Drawing.Point);
			location17 = new global::System.Drawing.Point(120, 40);
			this.label8.Location = location17;
			this.label8.Name = "label8";
			global::System.Drawing.Size size17 = default(global::System.Drawing.Size);
			size17 = new global::System.Drawing.Size(72, 16);
			this.label8.Size = size17;
			this.label8.TabIndex = 42;
			global::System.Drawing.Point location18 = default(global::System.Drawing.Point);
			location18 = new global::System.Drawing.Point(8, 88);
			this.label1.Location = location18;
			this.label1.Name = "label1";
			global::System.Drawing.Size size18 = default(global::System.Drawing.Size);
			size18 = new global::System.Drawing.Size(48, 16);
			this.label1.Size = size18;
			this.label1.TabIndex = 54;
			this.label1.Text = "Created:";
			global::System.Drawing.Point location19 = default(global::System.Drawing.Point);
			location19 = new global::System.Drawing.Point(248, 88);
			this.label2.Location = location19;
			this.label2.Name = "label2";
			global::System.Drawing.Size size19 = default(global::System.Drawing.Size);
			size19 = new global::System.Drawing.Size(88, 16);
			this.label2.Size = size19;
			this.label2.TabIndex = 55;
			this.label2.Text = "Last Updated:";
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location20 = default(global::System.Drawing.Point);
			location20 = new global::System.Drawing.Point(56, 88);
			this.label9.Location = location20;
			this.label9.Name = "label9";
			global::System.Drawing.Size size20 = default(global::System.Drawing.Size);
			size20 = new global::System.Drawing.Size(200, 16);
			this.label9.Size = size20;
			this.label9.TabIndex = 56;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location21 = default(global::System.Drawing.Point);
			location21 = new global::System.Drawing.Point(336, 88);
			this.label10.Location = location21;
			this.label10.Name = "label10";
			global::System.Drawing.Size size21 = default(global::System.Drawing.Size);
			size21 = new global::System.Drawing.Size(168, 16);
			this.label10.Size = size21;
			this.label10.TabIndex = 57;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location22 = default(global::System.Drawing.Point);
			location22 = new global::System.Drawing.Point(504, 88);
			this.button1.Location = location22;
			this.button1.Name = "button1";
			global::System.Drawing.Size size22 = default(global::System.Drawing.Size);
			size22 = new global::System.Drawing.Size(24, 16);
			this.button1.Size = size22;
			this.button1.TabIndex = 58;
			this.button1.Text = "...";
			this.toolTip_0.SetToolTip(this.button1, "Click to view all date info");
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label40);
			this.groupBox1.Controls.Add(this.label41);
			this.groupBox1.Controls.Add(this.label44);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.textBox9);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.textBox15);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.label43);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location23 = default(global::System.Drawing.Point);
			location23 = new global::System.Drawing.Point(8, 328);
			this.groupBox1.Location = location23;
			this.groupBox1.Name = "groupBox1";
			global::System.Drawing.Size size23 = default(global::System.Drawing.Size);
			size23 = new global::System.Drawing.Size(536, 184);
			this.groupBox1.Size = size23;
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Properties";
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location24 = default(global::System.Drawing.Point);
			location24 = new global::System.Drawing.Point(312, 152);
			this.button4.Location = location24;
			this.button4.Name = "button4";
			global::System.Drawing.Size size24 = default(global::System.Drawing.Size);
			size24 = new global::System.Drawing.Size(80, 24);
			this.button4.Size = size24;
			this.button4.TabIndex = 62;
			this.button4.Text = "Import";
			this.toolTip_0.SetToolTip(this.button4, "Import KeyDB from CSV File");
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location25 = default(global::System.Drawing.Point);
			location25 = new global::System.Drawing.Point(160, 152);
			this.button3.Location = location25;
			this.button3.Name = "button3";
			global::System.Drawing.Size size25 = default(global::System.Drawing.Size);
			size25 = new global::System.Drawing.Size(80, 24);
			this.button3.Size = size25;
			this.button3.TabIndex = 61;
			this.button3.Text = "Export";
			this.toolTip_0.SetToolTip(this.button3, "Export KeyDB to CSV file");
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			global::System.Drawing.Point location26 = default(global::System.Drawing.Point);
			location26 = new global::System.Drawing.Point(504, 120);
			this.button2.Location = location26;
			this.button2.Name = "button2";
			global::System.Drawing.Size size26 = default(global::System.Drawing.Size);
			size26 = new global::System.Drawing.Size(24, 20);
			this.button2.Size = size26;
			this.button2.TabIndex = 60;
			this.button2.Text = "...";
			this.toolTip_0.SetToolTip(this.button2, "Open Job File");
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			global::System.Drawing.Point location27 = default(global::System.Drawing.Point);
			location27 = new global::System.Drawing.Point(464, 16);
			this.label11.Location = location27;
			this.label11.Name = "label11";
			global::System.Drawing.Size size27 = default(global::System.Drawing.Size);
			size27 = new global::System.Drawing.Size(64, 16);
			this.label11.Size = size27;
			this.label11.TabIndex = 59;
			this.label11.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			global::System.Drawing.Color window3 = global::System.Drawing.SystemColors.Window;
			global::System.Drawing.Color color4 = window3;
			global::System.Drawing.Color backColor3 = color4;
			this.textBox2.BackColor = backColor3;
			global::System.Drawing.Point location28 = default(global::System.Drawing.Point);
			location28 = new global::System.Drawing.Point(272, 272);
			this.textBox2.Location = location28;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			global::System.Drawing.Size size28 = default(global::System.Drawing.Size);
			size28 = new global::System.Drawing.Size(88, 20);
			this.textBox2.Size = size28;
			this.textBox2.TabIndex = 62;
			this.textBox2.Text = "Jobname";
			global::System.Drawing.Color window4 = global::System.Drawing.SystemColors.Window;
			global::System.Drawing.Color color5 = window4;
			global::System.Drawing.Color backColor4 = color5;
			this.textBox1.BackColor = backColor4;
			global::System.Drawing.Point location29 = default(global::System.Drawing.Point);
			location29 = new global::System.Drawing.Point(48, 16);
			this.textBox1.Location = location29;
			this.textBox1.Name = "textBox1";
			global::System.Drawing.Size size29 = default(global::System.Drawing.Size);
			size29 = new global::System.Drawing.Size(72, 20);
			this.textBox1.Size = size29;
			this.textBox1.TabIndex = 61;
			this.textBox1.Text = "";
			this.toolTip_0.SetToolTip(this.textBox1, "Type Job Name search string and press enter");
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			global::System.Drawing.Size autoScaleBaseSize = default(global::System.Drawing.Size);
			autoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			this.AutoScaleBaseSize = autoScaleBaseSize;
			global::System.Drawing.Size clientSize = default(global::System.Drawing.Size);
			clientSize = new global::System.Drawing.Size(554, 520);
			base.ClientSize = clientSize;
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.dataGrid1);
			base.Controls.Add(this.textBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DataBaseView";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Key DataBase Viewer";
			base.Load += new global::System.EventHandler(this.DataBaseView_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGrid1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.DataGrid dataGrid1;

		// Token: 0x040002A3 RID: 675
		private global::System.Data.DataSet dataSet_0;

		// Token: 0x040002A4 RID: 676
		private global::System.Data.DataTable dataTable_0;

		// Token: 0x040002A5 RID: 677
		public global::System.Data.DataColumn dataColumn_0;

		// Token: 0x040002A6 RID: 678
		private global::System.Data.DataColumn dataColumn_1;

		// Token: 0x040002A7 RID: 679
		private global::System.Data.DataColumn dataColumn_2;

		// Token: 0x040002A8 RID: 680
		private global::System.Data.DataColumn dataColumn_3;

		// Token: 0x040002A9 RID: 681
		private global::System.Data.DataColumn dataColumn_4;

		// Token: 0x040002AA RID: 682
		private global::System.Data.DataColumn dataColumn_5;

		// Token: 0x040002AB RID: 683
		private global::System.Data.DataColumn dataColumn_6;

		// Token: 0x040002AC RID: 684
		private global::System.Data.DataColumn dataColumn_7;

		// Token: 0x040002AD RID: 685
		private global::System.Data.DataColumn dataColumn_8;

		// Token: 0x040002AE RID: 686
		private global::System.Data.DataColumn dataColumn_9;

		// Token: 0x040002AF RID: 687
		private global::System.Data.DataColumn dataColumn_10;

		// Token: 0x040002B0 RID: 688
		private global::System.Data.DataColumn dataColumn_11;

		// Token: 0x040002B1 RID: 689
		private global::System.Data.DataColumn dataColumn_12;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.Label label40;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.Label label44;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.Label label43;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.Label label41;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040002B7 RID: 695
		public global::System.Windows.Forms.TextBox textBox15;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.TextBox textBox9;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.ContextMenu contextMenu_0;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.MenuItem menuItem_0;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040002CC RID: 716
		private global::System.Data.DataTable dataTable_1;

		// Token: 0x040002CD RID: 717
		private global::System.Data.DataColumn dataColumn_13;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x040002CF RID: 719
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040002D0 RID: 720
		public global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040002D3 RID: 723
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
