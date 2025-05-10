using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Generate.Pages;

namespace Code_Generate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            var frm = new frmSql();
            frm.ShowDialog();
        }

        private void btnDataAccess_Click(object sender, EventArgs e)
        {
            var frm = new frmDA();
            frm.ShowDialog();
        }

        private void btnBussines_Click(object sender, EventArgs e)
        {
            var frm = new FrmBL();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
