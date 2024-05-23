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
    public partial class frmBillList : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        DataTable dt = new DataTable();
        string searchValue;
        public frmBillList()
        {
            InitializeComponent();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            dt = bll.GetBillList();
            dgvBillList.DataSource = dt;
            dgvBillList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBillList.Columns[0].Width = 100;
            dgvBillList.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBillList.Columns[1].Width = 100;
            dgvBillList.Columns[1].HeaderText = "Mã khách hàng";
            dgvBillList.Columns[2].Width = 200;
            dgvBillList.Columns[2].HeaderText = "Tình trạng";
            dgvBillList.Columns[3].Width = 100;
            dgvBillList.Columns[3].HeaderText = "Phương thức thanh toán";
            dgvBillList.Columns[4].Width = 200;
            dgvBillList.Columns[4].HeaderText = "Ngày tạo";

            dgvBillList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvBillList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvBillList.GridColor = Color.FromArgb(255, 229, 202);
            dgvBillList.ClearSelection();
            dtpick.Value = DateTime.Now;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvBillList.ClearSelection();
            if (txtFind.Text != "")
            {
                searchValue = txtFind.Text.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvBillList.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvBillList.Rows[rowIndex].Selected = true;
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
