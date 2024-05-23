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
    public partial class frmEXCustomer : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        frmDelieveries originalform;
        public frmEXCustomer(frmDelieveries incomingform)
        {
            this.originalform = incomingform;
            InitializeComponent();
        }

        private void frmEXCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = bll.GetCustomersList();
            dgvCustomersList.DataSource = dt;
            dgvCustomersList.Columns[0].Width = 100;
            dgvCustomersList.Columns[0].HeaderText = "Mã khách hàng";
            dgvCustomersList.Columns[1].Width = 200;
            dgvCustomersList.Columns[1].HeaderText = "Tên khách hàng";
            dgvCustomersList.Columns[2].Width = 400;
            dgvCustomersList.Columns[2].HeaderText = "Địa chỉ";
            dgvCustomersList.Columns[3].Width = 100;
            dgvCustomersList.Columns[3].HeaderText = "Số điện thoại";
            dgvCustomersList.Columns[4].Width = 200;
            dgvCustomersList.Columns[4].HeaderText = "Ghi chú";
            dgvCustomersList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvCustomersList.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvCustomersList.GridColor = Color.FromArgb(255, 229, 202);
            dgvCustomersList.ClearSelection();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvCustomersList.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgvCustomersList.SelectedRows[0].Index;
                originalform.customerid = (int)dgvCustomersList.Rows[selectedRowIndex].Cells[0].Value;
                originalform.customername = dgvCustomersList.Rows[selectedRowIndex].Cells[1].Value.ToString();
                originalform.address = dgvCustomersList.Rows[selectedRowIndex].Cells[2].Value.ToString();
                originalform.phone = dgvCustomersList.Rows[selectedRowIndex].Cells[3].Value.ToString();
                originalform.AddCustomerInfo();
                originalform.LoadFoodOrderbyCustomer();
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
