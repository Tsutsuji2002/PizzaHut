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
    public partial class frmDelieveries : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        DataTable dt = new DataTable();
        public int id;
        //food paras
        public int currentid;
        public int quantity;
        public int sizeid;
        //cus paras
        public int customerid;
        public string customername;
        public string address;
        public string phone;
        public frmDelieveries()
        {
            InitializeComponent();
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            frmEXAddFoods frm = new frmEXAddFoods(this, 1);
            frm.ShowDialog();
        }

        private void frmDelieveries_Load(object sender, EventArgs e)
        {
            dt = bll.GetDeliveryOrderList();
            dgvOrdersList.DataSource = dt;
            dgvOrdersList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[0].Width = 60;
            dgvOrdersList.Columns[0].HeaderText = "Mã đặt hàng";
            dgvOrdersList.Columns[1].Width = 300;
            dgvOrdersList.Columns[1].HeaderText = "Tên khách hàng";
            dgvOrdersList.Columns[2].Width = 300;
            dgvOrdersList.Columns[2].HeaderText = "Tên món";
            dgvOrdersList.Columns[3].Width = 60;
            dgvOrdersList.Columns[3].HeaderText = "Số lượng";
            dgvOrdersList.Columns[4].Width = 60;
            dgvOrdersList.Columns[4].HeaderText = "Kích cỡ";
            dgvOrdersList.Columns[5].Width = 60;
            dgvOrdersList.Columns[5].HeaderText = "Đơn giá";
            dgvOrdersList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[6].Width = 60;
            dgvOrdersList.Columns[6].HeaderText = "Tổng giá";
            dgvOrdersList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrdersList.Columns[7].Width = 100;
            dgvOrdersList.Columns[7].HeaderText = "Thời gian đặt";

            dgvOrdersList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvOrdersList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvOrdersList.GridColor = Color.FromArgb(255, 229, 202);
            dgvOrdersList.ClearSelection();
        }

        public void LoadFoodOrderbyCustomer()
        {
            int customerID = this.customerid;
            dt = bll.GetDelivery_Orders(customerID);
            dgvD_Foods.DataSource = dt;
            dgvD_Foods.Columns[0].Width = 50;
            dgvD_Foods.Columns[0].HeaderText = "Mã đơn đặt";
            dgvD_Foods.Columns[1].Width = 200;
            dgvD_Foods.Columns[1].HeaderText = "Tên sản phẩm";
            dgvD_Foods.Columns[2].Width = 80;
            dgvD_Foods.Columns[2].HeaderText = "Số lượng";
            dgvD_Foods.Columns[3].Width = 60;
            dgvD_Foods.Columns[3].HeaderText = "Kích thước";
            dgvD_Foods.Columns[4].Width = 100;
            dgvD_Foods.Columns[4].HeaderText = "Đơn giá";
            dgvD_Foods.Columns[5].Width = 100;
            dgvD_Foods.Columns[5].HeaderText = "Tổng giá";
            dgvD_Foods.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvD_Foods.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvD_Foods.GridColor = Color.FromArgb(255, 229, 202);
            if (dt != null)
            {
                int subtotal = 0;
                foreach (DataGridViewRow dr in dgvD_Foods.Rows)
                {
                    if (dr.Cells[5].Value != null)
                    {
                        subtotal += int.Parse(dr.Cells[5].Value.ToString());
                    }

                }
                lblSubTotal.Text = subtotal.ToString();
            }

            dgvD_Foods.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEXCustomer frm = new frmEXCustomer(this);
            frm.ShowDialog();
        }
        public void AddCustomerInfo()
        {
            txtName.Text = this.customername;
            txtAddress.Text = this.address;
            txtPhone.Text = this.phone;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
            dgvD_Foods.DataSource = null;
        }

        public void DataReload()
        {
            int customerID = this.customerid;
            dt = bll.GetDelivery_Orders(customerID);
            dgvD_Foods.DataSource = dt;
            this.Refresh();
        }

        private void btnDelF_Click(object sender, EventArgs e)
        {
            if (dgvD_Foods.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvD_Foods.SelectedRows[0].Index;
                    if (bll.UpdateDeliveryFoodQuantity((int)dgvD_Foods.Rows[selectedRowIndex].Cells[0].Value, 0))
                    {
                        MessageBox.Show("Xóa thành công!");
                        DataReload();
                    };
                }
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            //if (dgvD_Foods.SelectedRows.Count == 1)
            //{
            //    int selectedRowIndex = dgvD_Foods.SelectedRows[0].Index;
            //    if (bll.UpdateDeliveryFoodQuantity((int)dgvD_Foods.Rows[selectedRowIndex].Cells[0].Value, int.Parse(numQuantity.Value.ToString())))
            //    {
            //        DataReload();
            //    };
            //}
        }

        private void dgvD_Foods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvD_Foods.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgvD_Foods.SelectedRows[0].Index;
                if (dgvD_Foods.Rows[selectedRowIndex].Cells[3].Value != null)
                {
                    numQuantity.Value = (int)dgvD_Foods.Rows[selectedRowIndex].Cells[2].Value;
                }

            }
        }
    }
}
