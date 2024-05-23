using BLL_PizzaHut;
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
    public partial class frmWarehouse : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        DataTable dt = new DataTable();
        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            dt = bll.GetWarehouseProduct();
            dgvProductList.DataSource = dt;
            dgvProductList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductList.Columns[0].Width = 40;
            dgvProductList.Columns[0].HeaderText = "Mã mặt hàng";
            dgvProductList.Columns[1].Width = 100;
            dgvProductList.Columns[1].HeaderText = "Tên mặt hàng";
            dgvProductList.Columns[2].Width = 100;
            dgvProductList.Columns[2].HeaderText = "Ngày hết hạn";
            dgvProductList.Columns[3].Width = 50;
            dgvProductList.Columns[3].HeaderText = "Số lượng";
            dgvProductList.Columns[4].Width = 60;
            dgvProductList.Columns[4].HeaderText = "Đơn giá";
            dgvProductList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductList.Columns[5].Width = 50;
            dgvProductList.Columns[5].HeaderText = "Nhà cung cấp";
            dgvProductList.Columns[6].Width = 150;
            dgvProductList.Columns[6].HeaderText = "Cập nhật lần cuối";

            dgvProductList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvProductList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvProductList.GridColor = Color.FromArgb(255, 229, 202);
            dgvProductList.ClearSelection();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int id;
            if(dgvProductList.SelectedRows.Count == 1)
            {
                id = int.Parse(dgvProductList.CurrentRow.Cells[0].Value.ToString());
                frmEXImportWH frm = new frmEXImportWH(id);
                frm.ShowDialog();
            }
            else
            {
                id = 0;
                frmEXImportWH frm = new frmEXImportWH(id);
                frm.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmEXExportWH frm = new frmEXExportWH(0);
            
        }
    }
}
