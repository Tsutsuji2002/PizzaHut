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
    public partial class frmEXBill : Form
    {
        public int id;
        public frmEXBill(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmEXBill_Load(object sender, EventArgs e)
        {
            cboPayment.Items.Add("Tiền mặt");
            cboPayment.Items.Add("Trả thẻ");
            cboPayment.SelectedIndex = 0;
        }
    }
}
