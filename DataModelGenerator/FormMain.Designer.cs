namespace DataModelGenerator
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchTxt = new System.Windows.Forms.TextBox();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvTableColSchema = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExportAsExcel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportCS = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDbType = new System.Windows.Forms.ComboBox();
            this.txtDBConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnExportCSSqlSugar = new System.Windows.Forms.Button();
            this.btnCopySqlSugar = new System.Windows.Forms.Button();
            this.txtCodeSqlSugar = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColSchema)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeSqlSugar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(938, 536);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 469);
            this.panel5.TabIndex = 1;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.Size = new System.Drawing.Size(310, 469);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dgvTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtSearchTxt);
            this.panel4.Controls.Add(this.btnRefreshTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 65);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // txtSearchTxt
            // 
            this.txtSearchTxt.Location = new System.Drawing.Point(57, 32);
            this.txtSearchTxt.Name = "txtSearchTxt";
            this.txtSearchTxt.Size = new System.Drawing.Size(238, 20);
            this.txtSearchTxt.TabIndex = 1;
            this.txtSearchTxt.TextChanged += new System.EventHandler(this.txtSearchTxt_TextChanged);
            this.txtSearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchTxt_KeyDown);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(11, 3);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(284, 23);
            this.btnRefreshTable.TabIndex = 0;
            this.btnRefreshTable.Text = "Get Table List";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 499);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tabControl1);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(620, 499);
            this.panel8.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 470);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table Schema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvTableColSchema);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(606, 400);
            this.panel7.TabIndex = 3;
            // 
            // dgvTableColSchema
            // 
            this.dgvTableColSchema.AllowUserToAddRows = false;
            this.dgvTableColSchema.AllowUserToDeleteRows = false;
            this.dgvTableColSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableColSchema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column7,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column11});
            this.dgvTableColSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableColSchema.Location = new System.Drawing.Point(0, 0);
            this.dgvTableColSchema.Name = "dgvTableColSchema";
            this.dgvTableColSchema.Size = new System.Drawing.Size(606, 400);
            this.dgvTableColSchema.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TableName";
            this.Column2.HeaderText = "TableName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DbColumnName";
            this.Column3.HeaderText = "DbColumnName";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ColumnDescription";
            this.Column8.HeaderText = "ColumnDescription";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DataType";
            this.Column7.HeaderText = "DataType";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Length";
            this.Column9.HeaderText = "Length";
            this.Column9.Name = "Column9";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IsPrimarykey";
            this.Column4.HeaderText = "IsPrimarykey";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsIdentity";
            this.Column5.HeaderText = "IsIdentity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IsNullable";
            this.Column6.HeaderText = "IsNullable";
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Scale";
            this.Column10.HeaderText = "Scale";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DefaultValue";
            this.Column11.HeaderText = "DefaultValue";
            this.Column11.Name = "Column11";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnExportAsExcel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(606, 38);
            this.panel6.TabIndex = 2;
            // 
            // btnExportAsExcel
            // 
            this.btnExportAsExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAsExcel.Location = new System.Drawing.Point(438, 5);
            this.btnExportAsExcel.Name = "btnExportAsExcel";
            this.btnExportAsExcel.Size = new System.Drawing.Size(163, 23);
            this.btnExportAsExcel.TabIndex = 4;
            this.btnExportAsExcel.Text = "Export As Excel";
            this.btnExportAsExcel.UseVisualStyleBackColor = true;
            this.btnExportAsExcel.Click += new System.EventHandler(this.btnExportAsExcel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCode);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Class Model";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtCode.BackBrush = null;
            this.txtCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtCode.CharHeight = 14;
            this.txtCode.CharWidth = 8;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtCode.IsReplaceMode = false;
            this.txtCode.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtCode.LeftBracket = '(';
            this.txtCode.LeftBracket2 = '{';
            this.txtCode.Location = new System.Drawing.Point(3, 41);
            this.txtCode.Name = "txtCode";
            this.txtCode.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCode.RightBracket = ')';
            this.txtCode.RightBracket2 = '}';
            this.txtCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCode.ServiceColors")));
            this.txtCode.Size = new System.Drawing.Size(606, 400);
            this.txtCode.TabIndex = 0;
            this.txtCode.Zoom = 100;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExportCS);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnExportCS
            // 
            this.btnExportCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCS.Location = new System.Drawing.Point(438, 8);
            this.btnExportCS.Name = "btnExportCS";
            this.btnExportCS.Size = new System.Drawing.Size(163, 23);
            this.btnExportCS.TabIndex = 4;
            this.btnExportCS.Text = "Export CS File";
            this.btnExportCS.UseVisualStyleBackColor = true;
            this.btnExportCS.Click += new System.EventHandler(this.btnExportCS_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(271, 8);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(163, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.txtTableName);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(620, 29);
            this.panel9.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(122, 3);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(319, 20);
            this.txtTableName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboDbType);
            this.panel1.Controls.Add(this.txtDBConnString);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 35);
            this.panel1.TabIndex = 0;
            // 
            // cboDbType
            // 
            this.cboDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbType.FormattingEnabled = true;
            this.cboDbType.Items.AddRange(new object[] {
            "MSSQL",
            "MYSQL"});
            this.cboDbType.Location = new System.Drawing.Point(121, 6);
            this.cboDbType.Name = "cboDbType";
            this.cboDbType.Size = new System.Drawing.Size(121, 21);
            this.cboDbType.TabIndex = 2;
            // 
            // txtDBConnString
            // 
            this.txtDBConnString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDBConnString.Location = new System.Drawing.Point(248, 6);
            this.txtDBConnString.Name = "txtDBConnString";
            this.txtDBConnString.Size = new System.Drawing.Size(360, 20);
            this.txtDBConnString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCodeSqlSugar);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SqlSugar Class Model";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btnExportCSSqlSugar);
            this.panel10.Controls.Add(this.btnCopySqlSugar);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(606, 38);
            this.panel10.TabIndex = 2;
            // 
            // btnExportCSSqlSugar
            // 
            this.btnExportCSSqlSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSSqlSugar.Location = new System.Drawing.Point(438, 8);
            this.btnExportCSSqlSugar.Name = "btnExportCSSqlSugar";
            this.btnExportCSSqlSugar.Size = new System.Drawing.Size(163, 23);
            this.btnExportCSSqlSugar.TabIndex = 4;
            this.btnExportCSSqlSugar.Text = "Export CS File";
            this.btnExportCSSqlSugar.UseVisualStyleBackColor = true;
            this.btnExportCSSqlSugar.Click += new System.EventHandler(this.btnExportCSSqlSugar_Click);
            // 
            // btnCopySqlSugar
            // 
            this.btnCopySqlSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySqlSugar.Location = new System.Drawing.Point(271, 8);
            this.btnCopySqlSugar.Name = "btnCopySqlSugar";
            this.btnCopySqlSugar.Size = new System.Drawing.Size(163, 23);
            this.btnCopySqlSugar.TabIndex = 1;
            this.btnCopySqlSugar.Text = "Copy to Clipboard";
            this.btnCopySqlSugar.UseVisualStyleBackColor = true;
            this.btnCopySqlSugar.Click += new System.EventHandler(this.btnCopySqlSugar_Click);
            // 
            // txtCodeSqlSugar
            // 
            this.txtCodeSqlSugar.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCodeSqlSugar.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtCodeSqlSugar.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtCodeSqlSugar.BackBrush = null;
            this.txtCodeSqlSugar.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtCodeSqlSugar.CharHeight = 14;
            this.txtCodeSqlSugar.CharWidth = 8;
            this.txtCodeSqlSugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodeSqlSugar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCodeSqlSugar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeSqlSugar.IsReplaceMode = false;
            this.txtCodeSqlSugar.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtCodeSqlSugar.LeftBracket = '(';
            this.txtCodeSqlSugar.LeftBracket2 = '{';
            this.txtCodeSqlSugar.Location = new System.Drawing.Point(3, 41);
            this.txtCodeSqlSugar.Name = "txtCodeSqlSugar";
            this.txtCodeSqlSugar.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCodeSqlSugar.RightBracket = ')';
            this.txtCodeSqlSugar.RightBracket2 = '}';
            this.txtCodeSqlSugar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCodeSqlSugar.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCodeSqlSugar.ServiceColors")));
            this.txtCodeSqlSugar.Size = new System.Drawing.Size(606, 400);
            this.txtCodeSqlSugar.TabIndex = 3;
            this.txtCodeSqlSugar.Zoom = 100;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Model Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColSchema)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeSqlSugar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDBConnString;
        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox txtCode;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchTxt;
        private System.Windows.Forms.Button btnExportCS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvTableColSchema;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExportAsExcel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TabPage tabPage3;
        private FastColoredTextBoxNS.FastColoredTextBox txtCodeSqlSugar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnExportCSSqlSugar;
        private System.Windows.Forms.Button btnCopySqlSugar;
    }
}

