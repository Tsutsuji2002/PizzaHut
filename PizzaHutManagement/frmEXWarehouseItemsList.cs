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
    public partial class frmEXWarehouseItemsList : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        frmEXImportWH importform;
        public frmEXWarehouseItemsList(object incomingform)
        {
            InitializeComponent();
            this.importform = (frmEXImportWH)incomingform;
        }

        private void frmEXWarehouseItemsList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.GetWarehouseProduct();
            dgvItemsList.DataSource = dt;
            dgvItemsList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItemsList.Columns[0].Width = 40;
            dgvItemsList.Columns[0].HeaderText = "Mã mặt hàng";
            dgvItemsList.Columns[1].Width = 100;
            dgvItemsList.Columns[1].HeaderText = "Tên mặt hàng";
            dgvItemsList.Columns[2].Width = 100;
            dgvItemsList.Columns[2].HeaderText = "Ngày hết hạn";
            dgvItemsList.Columns[3].Width = 50;
            dgvItemsList.Columns[3].HeaderText = "Số lượng";
            dgvItemsList.Columns[4].Width = 60;
            dgvItemsList.Columns[4].HeaderText = "Đơn giá";
            dgvItemsList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItemsList.Columns[5].Width = 50;
            dgvItemsList.Columns[5].HeaderText = "Nhà cung cấp";
            dgvItemsList.Columns[6].Width = 150;
            dgvItemsList.Columns[6].HeaderText = "Cập nhật lần cuối";

            dgvItemsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvItemsList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvItemsList.GridColor = Color.FromArgb(255, 229, 202);
            dgvItemsList.ClearSelection();
        }
    }
}
