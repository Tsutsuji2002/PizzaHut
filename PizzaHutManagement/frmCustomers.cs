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
    public partial class frmCustomers : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public frmCustomers()
        {
            InitializeComponent();
            dgvCustomersList.ClearSelection();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
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

        private void dgvCustomersList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvCustomersList.CurrentRow.Cells[0].Value.ToString() != String.Empty)
            {
                txtName.Text = dgvCustomersList.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvCustomersList.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvCustomersList.CurrentRow.Cells[3].Value.ToString();
                txtDescription.Text = dgvCustomersList.CurrentRow.Cells[4].Value.ToString();
            }
        }
        public void DataReload()
        {
            dgvCustomersList.DataSource = bll.GetCustomersList();
            dgvCustomersList.ClearSelection();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DataReload();
            dgvCustomersList.ClearSelection();
            txtName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtDescription.Text = String.Empty;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchValue = "";
            if (txtName.Text != "")
            {
                searchValue = txtName.Text.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvCustomersList.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvCustomersList.Rows[rowIndex].Selected = true;
                            break;
                        }
                    }
                }
                if (rowIndex == -1) MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPhone.Text != "")
            {
                searchValue = txtPhone.Text.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvCustomersList.Rows)
                {
                    if (row.Cells[3].Value != null)
                    {
                        if (row.Cells[3].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvCustomersList.Rows[rowIndex].Selected = true;
                            break;
                        }
                    }
                }
                if (rowIndex == -1) MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Điền một hạng mục(Tên hoặc Số điện thoại để tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvCustomersList.SelectedRows.Count == 1)
                {
                    if (bll.DelCustomer(int.Parse(dgvCustomersList.CurrentRow.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.DataReload();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK);
                        this.DataReload();
                    }
                }
            }
            return;
        }
        bool checkTypingTab()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkTypingTab())
            {
                if (bll.AddCustomer(txtName.Text.ToString(), txtAddress.Text.ToString(), txtPhone.Text.ToString(), txtDescription.Text.ToString()))
                {
                    MessageBox.Show("Thêm khách thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm khách thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
                this.DataReload();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            int id;
            string name, address, phonenum, description;
            if (dgvCustomersList.SelectedRows.Count == 1)
            {
                id = int.Parse(dgvCustomersList.CurrentRow.Cells[0].Value.ToString());
                name = txtName.Text.ToString();
                address = txtAddress.Text.ToString();
                phonenum = txtPhone.Text.ToString();
                description = txtDescription.Text.ToString();
                if (bll.UpdateCustomer(id, name, address, phonenum, description))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Chọn dòng hợp lệ!", "Thông báo", MessageBoxButtons.OK);
            this.DataReload();
        }
    }
}
