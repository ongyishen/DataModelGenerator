using ClosedXML.Excel;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataModelGenerator
{
    public partial class FormMain : Form
    {
        public const string DBCONFIGFILENAME = "DbConfig.json";
        DBConfig myDBConfig { get; set; }
        List<DbTableInfo> tableList { get; set; }
        BindingSource bs { get; set; }
        List<DbColumnInfo> colsInfo { get; set; }

        public FormMain()
        {
            InitializeComponent();

            tableList = new List<DbTableInfo>();
        }

        private SqlSugar.DbType SelectedDbType
        {
            get
            {
                switch (cboDbType.SelectedIndex)
                {
                    case 1:
                        return SqlSugar.DbType.MySql;
                }

                return SqlSugar.DbType.SqlServer;
            }
        }

        private SqlSugarClient GetDBInstance()
        {
            return new SqlSugarClient(new ConnectionConfig()
            {
                DbType = SelectedDbType,
                ConnectionString = myDBConfig.DbConnString,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
                AopEvents = new AopEvents
                {
                    OnLogExecuting = (sql, p) =>
                    {
                        Console.WriteLine(sql);
                        Console.WriteLine(string.Join(",", p?.Select(it => it.ParameterName + ":" + it.Value)));
                    }
                }
            });
        }

        #region DB Config
        public void LoadConfig()
        {
            try
            {
                var jsonString = DBCONFIGFILENAME.ReadAllLine();
                if (jsonString.IsNotEmpty())
                {
                    myDBConfig = jsonString.ToObject<DBConfig>();
                    if (myDBConfig == null)
                    {
                        myDBConfig = new DBConfig();
                    }
                }
                else
                {
                    myDBConfig = new DBConfig();
                }
                txtDBConnString.Text = myDBConfig.DbConnString;
                cboDbType.SelectedIndex = myDBConfig.DbType;
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        public void SaveConfig()
        {
            try
            {
                myDBConfig.DbConnString = txtDBConnString.Text;
                myDBConfig.DbType = cboDbType.SelectedIndex;

                var jsonString = myDBConfig.ToJson();

                DBCONFIGFILENAME.SaveJson(jsonString);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        #endregion

        /// <summary>
        /// Load all db tables
        /// </summary>
        public void LoadAllTables(string tableFilter = "")
        {
            btnRefreshTable.DisableBtn();
            try
            {
                var db = GetDBInstance();
                tableList = db.DbMaintenance.GetTableInfoList();

                if (tableFilter.IsNotEmpty())
                {
                    tableList = tableList.Where(x => x.Name.Contains(tableFilter)).ToList();
                }

                bs = new BindingSource();
                bs.DataSource = tableList;

                dgvTable.AutoGenerateColumns = false;
                dgvTable.DataSource = bs;
                dgvTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
            btnRefreshTable.EnableBtn();
        }

        public string GetColumnDataType(string DataType)
        {
            DataType = DataType.ToLower();

            switch (DataType)
            {
                case "nvarchar":
                case "varchar":
                case "ntext":
                case "char":
                case "nchar":
                    DataType = "string";
                    break;

                case "real":
                case "money":
                    DataType = "decimal";
                    break;
                case "datetime":
                    DataType = "DateTime";
                    break;
                case "smallint":
                    DataType = "int";
                    break;
                case "bit":
                    DataType = "bool";
                    break;
                case "bigint":
                    DataType = "long";
                    break;
                case "image":
                    DataType = "Image";
                    break;
            }

            return DataType;
        }

        /// <summary>
        /// Generate Class Model
        /// </summary>
        public void GenerateModel()
        {
            try
            {
                var db = GetDBInstance();

                colsInfo = db.DbMaintenance.GetColumnInfosByTableName(txtTableName.Text);

                if (colsInfo.Any())
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine($"public class {txtTableName.Text.Replace(" ", "_")} {"{"}");

                    foreach (var col in colsInfo)
                    {
                        sb.AppendLine("");
                        sb.AppendLine($"\t public {GetColumnDataType(col.DataType)} {col.DbColumnName} {"{"} get; set;  {"}"}");

                    }

                    sb.Append("}");


                    txtCode.Text = sb.ToString();
                }
                else
                {
                    txtCode.Clear();
                }
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        /// <summary>
        /// Display Table Column Schema in Grid
        /// </summary>
        public void PopupdateToGrid()
        {
            try
            {
                this.dgvTableColSchema.AutoGenerateColumns = false;
                this.dgvTableColSchema.DataSource = colsInfo;
                this.dgvTableColSchema.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        public DataTable GenerateDataTable()
        {
            //Creating DataTable  
            DataTable dt = new DataTable();
            //Setiing Table Name  
            dt.TableName = txtTableName.Text;
            //Add Columns  
            dt.Columns.Add("TableName", typeof(string));
            dt.Columns.Add("DbColumnName", typeof(string));
            dt.Columns.Add("ColumnDescription", typeof(string));
            dt.Columns.Add("DataType", typeof(string));
            dt.Columns.Add("Length", typeof(int));
            dt.Columns.Add("IsPrimarykey", typeof(bool));
            dt.Columns.Add("IsIdentity", typeof(bool));
            dt.Columns.Add("IsNullable", typeof(bool));
            dt.Columns.Add("DefaultValue", typeof(string));

            foreach (var col in colsInfo)
            {
                DataRow drNew = dt.NewRow();

                drNew["TableName"] = col.TableName;
                drNew["DbColumnName"] = col.DbColumnName;
                drNew["ColumnDescription"] = col.ColumnDescription;
                drNew["DataType"] = col.DataType;
                drNew["Length"] = col.Length;
                drNew["IsPrimarykey"] = col.IsPrimarykey;
                drNew["IsIdentity"] = col.IsIdentity;
                drNew["IsNullable"] = col.IsNullable;
                drNew["DefaultValue"] = col.DefaultValue;


                dt.Rows.Add(drNew);
            }


            dt.AcceptChanges();
            return dt;
        }

        public void ExportAsExcel()
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.FileName = $"{txtTableName.Text.Replace(" ", "_")}.xlsx";
                    dialog.Filter = ".xlsx | *.xlsx ";
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var dt = GenerateDataTable();
                            wb.Worksheets.Add(dt);
                            wb.SaveAs(dialog.FileName);
                        }



                        if (File.Exists(dialog.FileName))
                        {
                            Process.Start(dialog.FileName);
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        /// <summary>
        /// Run All Action
        /// </summary>
        public void PerformAction()
        {
            GenerateModel();
            PopupdateToGrid();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            SaveConfig();
            LoadAllTables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtCode.Text);
            }
            catch //(Exception)
            {

                //throw;
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTable.Rows[e.RowIndex];
                this.txtTableName.Text = row.Cells[0].Value.ToString();

                PerformAction();
            }
        }

        private void txtSearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    LoadAllTables(txtSearchTxt.Text);
                }
            }
            catch //(Exception)
            {

                //throw;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Space)
            //    {
            //        PerformAction();
            //    }
            //}
            //catch //(Exception)
            //{

            //    // throw;
            //}


        }

        private void btnExportCS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.FileName = $"{txtTableName.Text.Replace(" ", "_")}.cs";
                    dialog.Filter = ".cs | *.cs | .txt | *.txt ";
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        dialog.FileName.SaveCS(txtCode.Text);

                        var dir = Path.GetDirectoryName(dialog.FileName);

                        Process.Start(dir);
                    }
                }
            }
            catch (Exception ex)
            {

                ex.AlertError();
            }
        }

        private void btnExportAsExcel_Click(object sender, EventArgs e)
        {
            ExportAsExcel();
        }
    }
}
