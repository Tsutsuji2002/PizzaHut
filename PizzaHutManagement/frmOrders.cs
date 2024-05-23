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
    public partial class frmOrders : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        DataTable dt = new DataTable();
        string searchValue;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            dt = bll.GetOrderList();
            dgvOrdersList.DataSource = dt;
            dgvOrdersList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[0].Width = 40;
            dgvOrdersList.Columns[0].HeaderText = "Mã đặt hàng";
            dgvOrdersList.Columns[1].Width = 60;
            dgvOrdersList.Columns[1].HeaderText = "Tên bàn/Mã giao";
            dgvOrdersList.Columns[2].Width = 200;
            dgvOrdersList.Columns[2].HeaderText = "Tên món";
            dgvOrdersList.Columns[3].Width = 50;
            dgvOrdersList.Columns[3].HeaderText = "Số lượng";
            dgvOrdersList.Columns[4].Width = 50;
            dgvOrdersList.Columns[4].HeaderText = "Kích cỡ";
            dgvOrdersList.Columns[5].Width = 60;
            dgvOrdersList.Columns[5].HeaderText = "Đơn giá";
            dgvOrdersList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[6].Width = 60;
            dgvOrdersList.Columns[6].HeaderText = "Tổng giá";
            dgvOrdersList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[7].Width = 150;
            dgvOrdersList.Columns[7].HeaderText = "Thời gian đặt";

            dgvOrdersList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvOrdersList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvOrdersList.GridColor = Color.FromArgb(255, 229, 202);
            dgvOrdersList.ClearSelection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvOrdersList.ClearSelection();
            if (txtFind.Text != "")
            {
                searchValue = txtFind.Text.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvOrdersList.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvOrdersList.Rows[rowIndex].Selected = true;
                            break;
                        }
                    }
                }
                if (rowIndex == -1) MessageBox.Show("Không tìm thấy đơn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Vui lòng nhập mã để tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
