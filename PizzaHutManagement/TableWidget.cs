using Guna.UI.WinForms;
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
    public partial class TableWidget : UserControl
    {
        int id;
        frmTableList parent;
        public TableWidget(frmTableList parent, int id, string name, int status, int NoofMem)
        {
            this.parent = parent;
            this.id = id;
            string Tstatus;
            switch(status)
            {
                case 0: Tstatus = "Trống"; break;
                case 1: Tstatus = "Đang sử dụng"; break;
                case 2: Tstatus = "Đã đặt trước"; break;
                default: Tstatus = "Trống"; break;
            }
            InitializeComponent();
            lblTableName.Text = name;
            lblStatus.Text = Tstatus;
            lblPPnum.Text = NoofMem.ToString();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmEXTableDetails frm = new frmEXTableDetails(parent, id);
            frm.ShowDialog();
        }
    }
}
