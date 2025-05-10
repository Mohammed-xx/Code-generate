using Code_Generate.BL;
using static Code_Generate.DA.DataBaseInfo;

namespace Code_Generate.Pages
{
    public partial class frmSql : Form
    {
        public frmSql()
        {
            InitializeComponent();
        }

        List<DatabaseSchema> databaseSchemas { get; set; }
       
        //"استخراج اسماء الداتا بيزس"
        private void _GetDatabases()
        {
            foreach (var database in databaseSchemas.OrderBy(d => d.DatabaseName))
            {
                cmbDatabases.Items.Add(database.DatabaseName);
            }

            if (cmbDatabases.Items.Count > 0)
                cmbDatabases.SelectedIndex = 0;
        }
       
        //"استخراج اسماء الجداول"
        private void _GetTables(string SelectedDatabase)
        {
            var database = databaseSchemas.Find(d => d.DatabaseName == SelectedDatabase);

            if (database != null)
            {
                foreach (var table in database.Tables.OrderBy(t => t.TableName))
                {
                    cmbTables.Items.Add(table.TableName);
                }
            }
            if (cmbTables.Items.Count > 0)  
                 cmbTables.SelectedIndex = 0;
        }
        
        //"استخراج اسماء الاعمده"
        private void _GetColumns(string selectedDatabase, string tableName)
        {
            var database = databaseSchemas.Find(d => d.DatabaseName == selectedDatabase);

            if (database != null)
            {
                var tables = database.Tables.Find(t => t.TableName == tableName);

                if (tables != null)
                {
                    foreach (var column in tables.Columns)
                    {
                        cmbColumns.Items.Add(column.ColumnName);
                    }
                }
            }

            cmbColumns.SelectedIndex = 0;
        }
        
        //"عند تحميل الصفحه استدعاء جميع الداتا بيز وبجميع معلوماتها"
        private void frmSql_Load(object sender, EventArgs e)
        {
            databaseSchemas = clsDatabaseInfoData.GetAllDatabaseSchemas();

            _GetDatabases();
        }

        //"عند اختيار داتا بيز بالقائمه يتم تغير قائمة الجداول بالجداول الموجوده داخل الداتا بيز المختاره"
        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabases.Items.Count > 0)
            {
                cmbTables.Items.Clear();
                _GetTables(cmbDatabases.Text);
            }
        }

        //"عند تغير الجداول يتم تغيير قائمة الاعمده بالاعمده الموجوده داخل الجدول"
        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.Items.Count > 0)
            {
                cmbColumns.Items.Clear();
                _GetColumns(cmbDatabases.Text, cmbTables.Text);
            }
        }

        //"عند الضغط على زر التنفيذ يتم انشاء الكود الاجراءات المخزنه داخل قاعدة البيانات حسب الجدول المختار"
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var database = databaseSchemas.FirstOrDefault(s => s.DatabaseName == cmbDatabases.Text);
            if (database == null)
            {
                MessageBox.Show("There is no any databases");
                return;
            }
                

            var table = database?.Tables.FirstOrDefault(s => s.TableName == cmbTables.Text);
            if (table == null)
            {
                MessageBox.Show("There is no any tables");
                return;
            }

            txtGeneratorCode.Text = clsGetSQLCode.All(table);
        }
    }
}

