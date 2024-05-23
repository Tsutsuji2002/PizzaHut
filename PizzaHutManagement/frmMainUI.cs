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
    public partial class frmMainUI : Form
    {
        private int childFormNumber = 0;
        private int roleID;
        private string username;
        public frmMainUI(int roleID, string username)
        {
            this.roleID = roleID;
            this.username = username;
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFill.Controls.Add(childForm);
            pnlFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnTableList_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmTableList());
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmMenu());
        }

        private void btnDelieveries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDelieveries());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrders());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBillList());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomers());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmWarehouse());
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
            switch(roleID)
            {
                case 1:
                    {
                        btnBills.Enabled = false;
                        btnCustomers.Enabled = false;
                        btnDelieveries.Enabled = false;
                        btnMenu.Enabled = false;
                        btnOrders.Enabled = false;
                        btnTableList.Enabled = false;
                        btnWarehouse.Enabled = false;
                        btnIncome.Enabled = false;
                    }break;
                case 2:
                    {
                        btnAdmin.Enabled = false;
                    }break;
                case 3:
                    {
                        btnAdmin.Enabled = false;
                        btnIncome.Enabled = false;
                    }break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Bạn chắc chắn muốn đăng xuất?";
            string title = "Xác nhận đăng xuất";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if(roleID == 1)
            {
                OpenChildForm(new frmAdmin());
            }
        }
    }
}
