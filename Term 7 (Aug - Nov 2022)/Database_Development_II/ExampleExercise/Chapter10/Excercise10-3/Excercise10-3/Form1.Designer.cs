
namespace Excercise10_3
{
    partial class frmWeather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeather));
            this.tabWeather = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.btnExitData = new System.Windows.Forms.Button();
            this.btnHelpData = new System.Windows.Forms.Button();
            this.btnPrintData = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.grdWeather = new System.Windows.Forms.DataGridView();
            this.tabPageTemp = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTempAutumn = new System.Windows.Forms.RadioButton();
            this.rdoTempSummer = new System.Windows.Forms.RadioButton();
            this.rdoTempSpring = new System.Windows.Forms.RadioButton();
            this.rdoTempWinter = new System.Windows.Forms.RadioButton();
            this.rdoTempYear = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHelpTemp = new System.Windows.Forms.Button();
            this.btnPrintTemp = new System.Windows.Forms.Button();
            this.lblTLT = new System.Windows.Forms.Label();
            this.lblTLL = new System.Windows.Forms.Label();
            this.lblTLA = new System.Windows.Forms.Label();
            this.lblTHT = new System.Windows.Forms.Label();
            this.lblTHL = new System.Windows.Forms.Label();
            this.lblTHA = new System.Windows.Forms.Label();
            this.lblTLH = new System.Windows.Forms.Label();
            this.lblTHH = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTempPlot = new System.Windows.Forms.Panel();
            this.tabPagePrecip = new System.Windows.Forms.TabPage();
            this.pnlPrecipPlot = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPrecipAutumn = new System.Windows.Forms.RadioButton();
            this.rdoPrecipSummer = new System.Windows.Forms.RadioButton();
            this.rdoPrecipSpring = new System.Windows.Forms.RadioButton();
            this.rdoPrecipWinter = new System.Windows.Forms.RadioButton();
            this.rdoPrecipYear = new System.Windows.Forms.RadioButton();
            this.btnExitPrecip = new System.Windows.Forms.Button();
            this.btnHelpPrecip = new System.Windows.Forms.Button();
            this.btnPrintPrecip = new System.Windows.Forms.Button();
            this.lblPT = new System.Windows.Forms.Label();
            this.lblPH = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.hlpWeather = new System.Windows.Forms.HelpProvider();
            this.tabWeather.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather)).BeginInit();
            this.tabPageTemp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagePrecip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWeather
            // 
            this.tabWeather.Controls.Add(this.tabPageData);
            this.tabWeather.Controls.Add(this.tabPageTemp);
            this.tabWeather.Controls.Add(this.tabPagePrecip);
            this.tabWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWeather.Location = new System.Drawing.Point(0, 0);
            this.tabWeather.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.SelectedIndex = 0;
            this.tabWeather.Size = new System.Drawing.Size(569, 394);
            this.tabWeather.TabIndex = 0;
            this.tabWeather.SelectedIndexChanged += new System.EventHandler(this.tabWeather_SelectedIndexChanged);
            this.tabWeather.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.pnlFiles);
            this.tabPageData.Controls.Add(this.pnlNew);
            this.tabPageData.Controls.Add(this.calDate);
            this.tabPageData.Controls.Add(this.grdWeather);
            this.tabPageData.Location = new System.Drawing.Point(4, 25);
            this.tabPageData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageData.Size = new System.Drawing.Size(561, 365);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Record Weather Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // pnlFiles
            // 
            this.pnlFiles.BackColor = System.Drawing.Color.LightGray;
            this.pnlFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiles.Controls.Add(this.btnExitData);
            this.pnlFiles.Controls.Add(this.btnHelpData);
            this.pnlFiles.Controls.Add(this.btnPrintData);
            this.pnlFiles.Controls.Add(this.btnOpen);
            this.pnlFiles.Location = new System.Drawing.Point(331, 263);
            this.pnlFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(205, 102);
            this.pnlFiles.TabIndex = 3;
            // 
            // btnExitData
            // 
            this.btnExitData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitData.Location = new System.Drawing.Point(114, 64);
            this.btnExitData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExitData.Name = "btnExitData";
            this.btnExitData.Size = new System.Drawing.Size(75, 28);
            this.btnExitData.TabIndex = 3;
            this.btnExitData.Text = "Exit";
            this.btnExitData.UseVisualStyleBackColor = true;
            // 
            // btnHelpData
            // 
            this.btnHelpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpData.Location = new System.Drawing.Point(13, 65);
            this.btnHelpData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelpData.Name = "btnHelpData";
            this.btnHelpData.Size = new System.Drawing.Size(75, 28);
            this.btnHelpData.TabIndex = 2;
            this.btnHelpData.Text = "Help";
            this.btnHelpData.UseVisualStyleBackColor = true;
            this.btnHelpData.Click += new System.EventHandler(this.btnHelpData_Click);
            // 
            // btnPrintData
            // 
            this.btnPrintData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintData.Location = new System.Drawing.Point(114, 17);
            this.btnPrintData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintData.Name = "btnPrintData";
            this.btnPrintData.Size = new System.Drawing.Size(75, 28);
            this.btnPrintData.TabIndex = 1;
            this.btnPrintData.Text = "Print Data";
            this.btnPrintData.UseVisualStyleBackColor = true;
            this.btnPrintData.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(13, 17);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 28);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlNew
            // 
            this.pnlNew.BackColor = System.Drawing.Color.LightGray;
            this.pnlNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNew.Controls.Add(this.cboYear);
            this.pnlNew.Controls.Add(this.btnNew);
            this.pnlNew.Location = new System.Drawing.Point(331, 195);
            this.pnlNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(205, 60);
            this.pnlNew.TabIndex = 2;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(94, 15);
            this.cboYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(95, 21);
            this.cboYear.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(13, 15);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New File";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(44, 195);
            this.calDate.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 1;
            // 
            // grdWeather
            // 
            this.grdWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWeather.Location = new System.Drawing.Point(8, 7);
            this.grdWeather.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdWeather.Name = "grdWeather";
            this.grdWeather.Size = new System.Drawing.Size(550, 186);
            this.grdWeather.TabIndex = 0;
            this.grdWeather.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdWeather_CellClick);
            this.grdWeather.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdWeather_EditingControlShowing);
            this.grdWeather.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdWeather_KeyPress);
            // 
            // tabPageTemp
            // 
            this.tabPageTemp.Controls.Add(this.panel2);
            this.tabPageTemp.Controls.Add(this.pnlTempPlot);
            this.tabPageTemp.Location = new System.Drawing.Point(4, 25);
            this.tabPageTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageTemp.Name = "tabPageTemp";
            this.tabPageTemp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageTemp.Size = new System.Drawing.Size(561, 365);
            this.tabPageTemp.TabIndex = 1;
            this.tabPageTemp.Text = "View Temperature Data";
            this.tabPageTemp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnHelpTemp);
            this.panel2.Controls.Add(this.btnPrintTemp);
            this.panel2.Controls.Add(this.lblTLT);
            this.panel2.Controls.Add(this.lblTLL);
            this.panel2.Controls.Add(this.lblTLA);
            this.panel2.Controls.Add(this.lblTHT);
            this.panel2.Controls.Add(this.lblTHL);
            this.panel2.Controls.Add(this.lblTHA);
            this.panel2.Controls.Add(this.lblTLH);
            this.panel2.Controls.Add(this.lblTHH);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(326, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 358);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.rdoTempAutumn);
            this.groupBox1.Controls.Add(this.rdoTempSummer);
            this.groupBox1.Controls.Add(this.rdoTempSpring);
            this.groupBox1.Controls.Add(this.rdoTempWinter);
            this.groupBox1.Controls.Add(this.rdoTempYear);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(6, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 147);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pot Options";
            // 
            // rdoTempAutumn
            // 
            this.rdoTempAutumn.AutoSize = true;
            this.rdoTempAutumn.ForeColor = System.Drawing.Color.White;
            this.rdoTempAutumn.Location = new System.Drawing.Point(45, 125);
            this.rdoTempAutumn.Name = "rdoTempAutumn";
            this.rdoTempAutumn.Size = new System.Drawing.Size(131, 20);
            this.rdoTempAutumn.TabIndex = 4;
            this.rdoTempAutumn.Text = "Autumn (Oct-Dec)\r\n";
            this.rdoTempAutumn.UseVisualStyleBackColor = true;
            this.rdoTempAutumn.CheckedChanged += new System.EventHandler(this.rdoTempPlot_CheckedChanged);
            // 
            // rdoTempSummer
            // 
            this.rdoTempSummer.AutoSize = true;
            this.rdoTempSummer.ForeColor = System.Drawing.Color.White;
            this.rdoTempSummer.Location = new System.Drawing.Point(45, 99);
            this.rdoTempSummer.Name = "rdoTempSummer";
            this.rdoTempSummer.Size = new System.Drawing.Size(130, 20);
            this.rdoTempSummer.TabIndex = 3;
            this.rdoTempSummer.Text = "Summer (Jul-Sep)";
            this.rdoTempSummer.UseVisualStyleBackColor = true;
            this.rdoTempSummer.CheckedChanged += new System.EventHandler(this.rdoTempPlot_CheckedChanged);
            // 
            // rdoTempSpring
            // 
            this.rdoTempSpring.AutoSize = true;
            this.rdoTempSpring.ForeColor = System.Drawing.Color.White;
            this.rdoTempSpring.Location = new System.Drawing.Point(45, 73);
            this.rdoTempSpring.Name = "rdoTempSpring";
            this.rdoTempSpring.Size = new System.Drawing.Size(119, 20);
            this.rdoTempSpring.TabIndex = 2;
            this.rdoTempSpring.Text = "Spring (Apr-Jun)";
            this.rdoTempSpring.UseVisualStyleBackColor = true;
            this.rdoTempSpring.CheckedChanged += new System.EventHandler(this.rdoTempPlot_CheckedChanged);
            // 
            // rdoTempWinter
            // 
            this.rdoTempWinter.AutoSize = true;
            this.rdoTempWinter.ForeColor = System.Drawing.Color.White;
            this.rdoTempWinter.Location = new System.Drawing.Point(45, 47);
            this.rdoTempWinter.Name = "rdoTempWinter";
            this.rdoTempWinter.Size = new System.Drawing.Size(122, 20);
            this.rdoTempWinter.TabIndex = 1;
            this.rdoTempWinter.Text = "Winter (Jan-Mar)\r\n";
            this.rdoTempWinter.UseVisualStyleBackColor = true;
            this.rdoTempWinter.CheckedChanged += new System.EventHandler(this.rdoTempPlot_CheckedChanged);
            // 
            // rdoTempYear
            // 
            this.rdoTempYear.AutoSize = true;
            this.rdoTempYear.Checked = true;
            this.rdoTempYear.ForeColor = System.Drawing.Color.White;
            this.rdoTempYear.Location = new System.Drawing.Point(45, 21);
            this.rdoTempYear.Name = "rdoTempYear";
            this.rdoTempYear.Size = new System.Drawing.Size(90, 20);
            this.rdoTempYear.TabIndex = 0;
            this.rdoTempYear.TabStop = true;
            this.rdoTempYear.Text = "Entire Year";
            this.rdoTempYear.UseVisualStyleBackColor = true;
            this.rdoTempYear.CheckedChanged += new System.EventHandler(this.rdoTempPlot_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(71, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnHelpTemp
            // 
            this.btnHelpTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpTemp.Location = new System.Drawing.Point(121, 297);
            this.btnHelpTemp.Name = "btnHelpTemp";
            this.btnHelpTemp.Size = new System.Drawing.Size(75, 23);
            this.btnHelpTemp.TabIndex = 20;
            this.btnHelpTemp.Text = "Help\r\n";
            this.btnHelpTemp.UseVisualStyleBackColor = true;
            // 
            // btnPrintTemp
            // 
            this.btnPrintTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTemp.Location = new System.Drawing.Point(27, 297);
            this.btnPrintTemp.Name = "btnPrintTemp";
            this.btnPrintTemp.Size = new System.Drawing.Size(75, 23);
            this.btnPrintTemp.TabIndex = 19;
            this.btnPrintTemp.Text = "Print Data";
            this.btnPrintTemp.UseVisualStyleBackColor = true;
            this.btnPrintTemp.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTLT
            // 
            this.lblTLT.BackColor = System.Drawing.Color.White;
            this.lblTLT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTLT.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLT.ForeColor = System.Drawing.Color.Blue;
            this.lblTLT.Location = new System.Drawing.Point(164, 122);
            this.lblTLT.Name = "lblTLT";
            this.lblTLT.Size = new System.Drawing.Size(54, 17);
            this.lblTLT.TabIndex = 18;
            this.lblTLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTLL
            // 
            this.lblTLL.BackColor = System.Drawing.Color.White;
            this.lblTLL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTLL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLL.ForeColor = System.Drawing.Color.Blue;
            this.lblTLL.Location = new System.Drawing.Point(164, 106);
            this.lblTLL.Name = "lblTLL";
            this.lblTLL.Size = new System.Drawing.Size(54, 17);
            this.lblTLL.TabIndex = 17;
            this.lblTLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTLA
            // 
            this.lblTLA.BackColor = System.Drawing.Color.White;
            this.lblTLA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTLA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLA.ForeColor = System.Drawing.Color.Blue;
            this.lblTLA.Location = new System.Drawing.Point(164, 90);
            this.lblTLA.Name = "lblTLA";
            this.lblTLA.Size = new System.Drawing.Size(54, 17);
            this.lblTLA.TabIndex = 16;
            this.lblTLA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTHT
            // 
            this.lblTHT.BackColor = System.Drawing.Color.White;
            this.lblTHT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTHT.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHT.ForeColor = System.Drawing.Color.Blue;
            this.lblTHT.Location = new System.Drawing.Point(48, 121);
            this.lblTHT.Name = "lblTHT";
            this.lblTHT.Size = new System.Drawing.Size(54, 17);
            this.lblTHT.TabIndex = 15;
            this.lblTHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTHL
            // 
            this.lblTHL.BackColor = System.Drawing.Color.White;
            this.lblTHL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTHL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHL.ForeColor = System.Drawing.Color.Blue;
            this.lblTHL.Location = new System.Drawing.Point(48, 107);
            this.lblTHL.Name = "lblTHL";
            this.lblTHL.Size = new System.Drawing.Size(54, 17);
            this.lblTHL.TabIndex = 14;
            this.lblTHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTHA
            // 
            this.lblTHA.BackColor = System.Drawing.Color.White;
            this.lblTHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTHA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHA.ForeColor = System.Drawing.Color.Blue;
            this.lblTHA.Location = new System.Drawing.Point(48, 89);
            this.lblTHA.Name = "lblTHA";
            this.lblTHA.Size = new System.Drawing.Size(54, 17);
            this.lblTHA.TabIndex = 13;
            this.lblTHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTLH
            // 
            this.lblTLH.BackColor = System.Drawing.Color.White;
            this.lblTLH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTLH.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLH.ForeColor = System.Drawing.Color.Blue;
            this.lblTLH.Location = new System.Drawing.Point(164, 72);
            this.lblTLH.Name = "lblTLH";
            this.lblTLH.Size = new System.Drawing.Size(54, 17);
            this.lblTLH.TabIndex = 12;
            this.lblTLH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTHH
            // 
            this.lblTHH.BackColor = System.Drawing.Color.White;
            this.lblTHH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTHH.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHH.ForeColor = System.Drawing.Color.Blue;
            this.lblTHH.Location = new System.Drawing.Point(48, 72);
            this.lblTHH.Name = "lblTHH";
            this.lblTHH.Size = new System.Drawing.Size(54, 17);
            this.lblTHH.TabIndex = 11;
            this.lblTHH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Trend";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Low";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "High\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trend";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "High";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Summary";
            // 
            // pnlTempPlot
            // 
            this.pnlTempPlot.BackColor = System.Drawing.Color.White;
            this.pnlTempPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTempPlot.Location = new System.Drawing.Point(8, 4);
            this.pnlTempPlot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTempPlot.Name = "pnlTempPlot";
            this.pnlTempPlot.Size = new System.Drawing.Size(312, 357);
            this.pnlTempPlot.TabIndex = 0;
            // 
            // tabPagePrecip
            // 
            this.tabPagePrecip.Controls.Add(this.pnlPrecipPlot);
            this.tabPagePrecip.Controls.Add(this.panel1);
            this.tabPagePrecip.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrecip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPagePrecip.Name = "tabPagePrecip";
            this.tabPagePrecip.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPagePrecip.Size = new System.Drawing.Size(561, 365);
            this.tabPagePrecip.TabIndex = 2;
            this.tabPagePrecip.Text = "View Preciptiation Data";
            this.tabPagePrecip.UseVisualStyleBackColor = true;
            // 
            // pnlPrecipPlot
            // 
            this.pnlPrecipPlot.BackColor = System.Drawing.Color.White;
            this.pnlPrecipPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrecipPlot.Location = new System.Drawing.Point(8, 7);
            this.pnlPrecipPlot.Name = "pnlPrecipPlot";
            this.pnlPrecipPlot.Size = new System.Drawing.Size(358, 351);
            this.pnlPrecipPlot.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnExitPrecip);
            this.panel1.Controls.Add(this.btnHelpPrecip);
            this.panel1.Controls.Add(this.btnPrintPrecip);
            this.panel1.Controls.Add(this.lblPT);
            this.panel1.Controls.Add(this.lblPH);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label30);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(372, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 295);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.rdoPrecipAutumn);
            this.groupBox2.Controls.Add(this.rdoPrecipSummer);
            this.groupBox2.Controls.Add(this.rdoPrecipSpring);
            this.groupBox2.Controls.Add(this.rdoPrecipWinter);
            this.groupBox2.Controls.Add(this.rdoPrecipYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 152);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plot Options";
            // 
            // rdoPrecipAutumn
            // 
            this.rdoPrecipAutumn.AutoSize = true;
            this.rdoPrecipAutumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrecipAutumn.ForeColor = System.Drawing.Color.White;
            this.rdoPrecipAutumn.Location = new System.Drawing.Point(14, 125);
            this.rdoPrecipAutumn.Name = "rdoPrecipAutumn";
            this.rdoPrecipAutumn.Size = new System.Drawing.Size(130, 20);
            this.rdoPrecipAutumn.TabIndex = 4;
            this.rdoPrecipAutumn.Text = "Autumn (Oct-Dec)";
            this.rdoPrecipAutumn.UseVisualStyleBackColor = true;
            this.rdoPrecipAutumn.CheckedChanged += new System.EventHandler(this.rdoPrecipPlot_CheckedChanged);
            // 
            // rdoPrecipSummer
            // 
            this.rdoPrecipSummer.AutoSize = true;
            this.rdoPrecipSummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrecipSummer.ForeColor = System.Drawing.Color.White;
            this.rdoPrecipSummer.Location = new System.Drawing.Point(14, 99);
            this.rdoPrecipSummer.Name = "rdoPrecipSummer";
            this.rdoPrecipSummer.Size = new System.Drawing.Size(133, 20);
            this.rdoPrecipSummer.TabIndex = 3;
            this.rdoPrecipSummer.Text = "Summer (Jul-Sep)";
            this.rdoPrecipSummer.UseVisualStyleBackColor = true;
            this.rdoPrecipSummer.CheckedChanged += new System.EventHandler(this.rdoPrecipPlot_CheckedChanged);
            // 
            // rdoPrecipSpring
            // 
            this.rdoPrecipSpring.AutoSize = true;
            this.rdoPrecipSpring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrecipSpring.ForeColor = System.Drawing.Color.White;
            this.rdoPrecipSpring.Location = new System.Drawing.Point(14, 73);
            this.rdoPrecipSpring.Name = "rdoPrecipSpring";
            this.rdoPrecipSpring.Size = new System.Drawing.Size(122, 20);
            this.rdoPrecipSpring.TabIndex = 2;
            this.rdoPrecipSpring.Text = "Spring (Apr-Jun)";
            this.rdoPrecipSpring.UseVisualStyleBackColor = true;
            this.rdoPrecipSpring.CheckedChanged += new System.EventHandler(this.rdoPrecipPlot_CheckedChanged);
            // 
            // rdoPrecipWinter
            // 
            this.rdoPrecipWinter.AutoSize = true;
            this.rdoPrecipWinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrecipWinter.ForeColor = System.Drawing.Color.White;
            this.rdoPrecipWinter.Location = new System.Drawing.Point(14, 47);
            this.rdoPrecipWinter.Name = "rdoPrecipWinter";
            this.rdoPrecipWinter.Size = new System.Drawing.Size(124, 20);
            this.rdoPrecipWinter.TabIndex = 1;
            this.rdoPrecipWinter.Text = "Winter (Jan-Mar)";
            this.rdoPrecipWinter.UseVisualStyleBackColor = true;
            this.rdoPrecipWinter.CheckedChanged += new System.EventHandler(this.rdoPrecipPlot_CheckedChanged);
            // 
            // rdoPrecipYear
            // 
            this.rdoPrecipYear.AutoSize = true;
            this.rdoPrecipYear.Checked = true;
            this.rdoPrecipYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrecipYear.ForeColor = System.Drawing.Color.White;
            this.rdoPrecipYear.Location = new System.Drawing.Point(14, 21);
            this.rdoPrecipYear.Name = "rdoPrecipYear";
            this.rdoPrecipYear.Size = new System.Drawing.Size(92, 20);
            this.rdoPrecipYear.TabIndex = 0;
            this.rdoPrecipYear.TabStop = true;
            this.rdoPrecipYear.Text = "Entire Year";
            this.rdoPrecipYear.UseVisualStyleBackColor = true;
            this.rdoPrecipYear.CheckedChanged += new System.EventHandler(this.rdoPrecipPlot_CheckedChanged);
            // 
            // btnExitPrecip
            // 
            this.btnExitPrecip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPrecip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExitPrecip.Location = new System.Drawing.Point(54, 261);
            this.btnExitPrecip.Name = "btnExitPrecip";
            this.btnExitPrecip.Size = new System.Drawing.Size(75, 23);
            this.btnExitPrecip.TabIndex = 21;
            this.btnExitPrecip.Text = "Exit";
            this.btnExitPrecip.UseVisualStyleBackColor = true;
            // 
            // btnHelpPrecip
            // 
            this.btnHelpPrecip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpPrecip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelpPrecip.Location = new System.Drawing.Point(93, 232);
            this.btnHelpPrecip.Name = "btnHelpPrecip";
            this.btnHelpPrecip.Size = new System.Drawing.Size(75, 23);
            this.btnHelpPrecip.TabIndex = 20;
            this.btnHelpPrecip.Text = "Help";
            this.btnHelpPrecip.UseVisualStyleBackColor = true;
            // 
            // btnPrintPrecip
            // 
            this.btnPrintPrecip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPrecip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrintPrecip.Location = new System.Drawing.Point(13, 232);
            this.btnPrintPrecip.Name = "btnPrintPrecip";
            this.btnPrintPrecip.Size = new System.Drawing.Size(75, 23);
            this.btnPrintPrecip.TabIndex = 19;
            this.btnPrintPrecip.Text = "Print Data";
            this.btnPrintPrecip.UseVisualStyleBackColor = true;
            this.btnPrintPrecip.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblPT
            // 
            this.lblPT.BackColor = System.Drawing.Color.White;
            this.lblPT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPT.Location = new System.Drawing.Point(130, 35);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(49, 20);
            this.lblPT.TabIndex = 12;
            this.lblPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPH
            // 
            this.lblPH.BackColor = System.Drawing.Color.White;
            this.lblPH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPH.Location = new System.Drawing.Point(42, 35);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(49, 20);
            this.lblPH.TabIndex = 11;
            this.lblPH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(93, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 16);
            this.label26.TabIndex = 4;
            this.label26.Text = "Total";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(3, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 16);
            this.label27.TabIndex = 3;
            this.label27.Text = "High";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(13, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(154, 16);
            this.label30.TabIndex = 0;
            this.label30.Text = "Precipitation Summary";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "mdf";
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.Filter = "SQL Server Files (*.mdf)|*.mdf";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "mdf";
            this.dlgSave.Filter = "SQL Server Files (*.mdf)|*.mdf";
            // 
            // dlgPreview
            // 
            this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPreview.Enabled = true;
            this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
            this.dlgPreview.Name = "dlgPreview";
            this.dlgPreview.Visible = false;
            // 
            // frmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 394);
            this.Controls.Add(this.tabWeather);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWeather_FormClosed);
            this.Load += new System.EventHandler(this.frmWeather_Load);
            this.tabWeather.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.pnlFiles.ResumeLayout(false);
            this.pnlNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather)).EndInit();
            this.tabPageTemp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePrecip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWeather;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TabPage tabPageTemp;
        private System.Windows.Forms.TabPage tabPagePrecip;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Button btnExitData;
        private System.Windows.Forms.Button btnHelpData;
        private System.Windows.Forms.Button btnPrintData;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.DataGridView grdWeather;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTempPlot;
        private System.Windows.Forms.Label lblTLT;
        private System.Windows.Forms.Label lblTLL;
        private System.Windows.Forms.Label lblTLA;
        private System.Windows.Forms.Label lblTHT;
        private System.Windows.Forms.Label lblTHL;
        private System.Windows.Forms.Label lblTHA;
        private System.Windows.Forms.Label lblTLH;
        private System.Windows.Forms.Label lblTHH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTempAutumn;
        private System.Windows.Forms.RadioButton rdoTempSummer;
        private System.Windows.Forms.RadioButton rdoTempSpring;
        private System.Windows.Forms.RadioButton rdoTempWinter;
        private System.Windows.Forms.RadioButton rdoTempYear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHelpTemp;
        private System.Windows.Forms.Button btnPrintTemp;
        private System.Windows.Forms.Panel pnlPrecipPlot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoPrecipAutumn;
        private System.Windows.Forms.RadioButton rdoPrecipSummer;
        private System.Windows.Forms.RadioButton rdoPrecipSpring;
        private System.Windows.Forms.RadioButton rdoPrecipWinter;
        private System.Windows.Forms.RadioButton rdoPrecipYear;
        private System.Windows.Forms.Button btnExitPrecip;
        private System.Windows.Forms.Button btnHelpPrecip;
        private System.Windows.Forms.Button btnPrintPrecip;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PrintPreviewDialog dlgPreview;
        private System.Windows.Forms.HelpProvider hlpWeather;
    }
}

