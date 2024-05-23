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
    public partial class frmEXTableDetails : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public int id;

        public int currentid;
        public int quantity;
        public int sizeid;
        frmTableList originalform;
        DataTable dt = new DataTable();
        public frmEXTableDetails(object incomingform, int id)
        {
            originalform = (frmTableList)incomingform;
            this.id = id;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(dgvView.RowCount == 0)
            {
                bll.UpdatePeopleStatus(id, 0);
            }
            else bll.UpdatePeopleStatus(id, 1);
            this.Close();
        }
        public void DataReload()
        {
            dt = bll.GetTable_Orders(id);
            dgvView.DataSource = dt;
            dgvView.ClearSelection();
        }
        private void frmEXTableDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = bll.GetTableName(id);
            dt = bll.GetTable_Orders(id);
            dgvView.DataSource = dt;
            dgvView.Columns[0].Width = 50;
            dgvView.Columns[0].HeaderText = "Mã đơn đặt";
            dgvView.Columns[1].Width = 200;
            dgvView.Columns[1].HeaderText = "Tên sản phẩm";
            dgvView.Columns[2].Width = 80;
            dgvView.Columns[2].HeaderText = "Số lượng";
            dgvView.Columns[3].Width = 60;
            dgvView.Columns[3].HeaderText = "Kích thước";
            dgvView.Columns[4].Width = 100;
            dgvView.Columns[4].HeaderText = "Đơn giá";
            dgvView.Columns[5].Width = 100;
            dgvView.Columns[5].HeaderText = "Tổng giá";
            dgvView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
            dgvView.BackgroundColor = Color.FromArgb(255, 229, 202);
            dgvView.GridColor = Color.FromArgb(255, 229, 202);
            dgvView.ClearSelection();
            int subtotal = 0;
            foreach (DataGridViewRow dr in dgvView.Rows)
            {
                subtotal += int.Parse(dr.Cells[5].Value.ToString());
            }
            lblSubTotal.Text = subtotal.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEXAddFoods frm = new frmEXAddFoods(this, 0);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int subtotal = 0;
            foreach (DataGridViewRow dr in dgvView.Rows)
            {
                subtotal += int.Parse(dr.Cells[5].Value.ToString());
            }
            lblSubTotal.Text = subtotal.ToString();
            if (dgvView.RowCount == 0)
            {
                bll.UpdatePeopleStatus(id, 0);
            }
            else bll.UpdatePeopleStatus(id, 1);
            int num = (int)numPNum.Value;
            bll.UpdatePeopleNum(id, num);
            if(num > 0) bll.UpdatePeopleStatus(id, 1);
            if (dgvView.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgvView.SelectedRows[0].Index;
                if (bll.UpdateFoodQuantity((int)dgvView.Rows[selectedRowIndex].Cells[0].Value, (int)numQuantity.Value))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    DataReload();
                    originalform.DataReload();
                };
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvView.SelectedRows[0].Index;
                    if (bll.UpdateFoodQuantity((int)dgvView.Rows[selectedRowIndex].Cells[0].Value, 0))
                    {
                        MessageBox.Show("Xóa thành công!");
                        DataReload();
                    };
                }
            }
        }

        private void dgvView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgvView.SelectedRows[0].Index;
                int value = (int)dgvView.Rows[selectedRowIndex].Cells[0].Value;//OrderID
                Image image = Image.FromFile("C:\\VisualStudio\\Winform C#\\PizzaHut\\PizzaHutManagement\\Resources\\Images\\" + bll.GetFoodImage_fromOrder(value));
                pboFood.Image = image;
                pboFood.SizeMode = PictureBoxSizeMode.StretchImage;
                int quantity = (int)dgvView.Rows[selectedRowIndex].Cells[2].Value;
                numQuantity.Value = (int)dgvView.Rows[selectedRowIndex].Cells[2].Value;
                lblFoodName.Text = dgvView.Rows[selectedRowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnExBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xuất hóa đơn bàn này?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bll.UpdatePeopleNum(id, 0);
                bll.UpdatePeopleStatus(id, 0);
                originalform.DataReload();
                frmEXBill frm = new frmEXBill(id);
                frm.ShowDialog();
            }
            return;
        }

        private void dgvView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int subtotal = 0;
            foreach (DataGridViewRow dr in dgvView.Rows)
            {
                subtotal += int.Parse(dr.Cells[5].Value.ToString());
            }
            lblSubTotal.Text = subtotal.ToString();
            if (dgvView.RowCount == 0)
            {
                bll.UpdatePeopleStatus(id, 0);
            }
        }
    }
}
