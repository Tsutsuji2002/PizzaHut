using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHutManagement
{
    public partial class frmEXImportWH : Form
    {
        int id;
        public frmEXImportWH(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmEXImportWH_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmEXWarehouseItemsList frm = new frmEXWarehouseItemsList(this);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
