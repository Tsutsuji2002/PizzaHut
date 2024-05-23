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
    public partial class frmLogin : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public static int RoleID = -1;
        public static string Username = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            RoleID = bll.getRole(txtUsername.Text, txtPassword.Text);
            if (RoleID != -1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmMainUI main = new frmMainUI(RoleID, Username);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, sai tên tài khoản hoặc mật khẩu!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void chkReveal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReveal.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
