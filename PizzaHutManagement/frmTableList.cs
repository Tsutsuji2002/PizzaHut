using BLL_PizzaHut;
using Guna.UI.WinForms;
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
    public partial class frmTableList : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        DataTable dt = new DataTable();
        public frmTableList()
        {
            InitializeComponent();
        }

        private void frmTableList_Load(object sender, EventArgs e)
        {
            //Load Date Area
            DateTime dtNow = DateTime.Now;
            dtpick.Value = dtNow;
            dtpick.Enabled = false;

            //Load Tables Area
            DataTable data = new DataTable();
            data = bll.getTableWidget();
            int id;
            string name;
            int status;
            int NoofMem;
            int locationX = 10;
            int locationY = 10;
            int count = 1;
            pnlTableListView.Controls.Clear();
            foreach (DataRow row in data.Rows)
            {
                TableWidget tableWidget = new TableWidget
                (
                    this,
                    id = int.Parse(row[0].ToString()),
                    name = row[1].ToString(),
                    status = int.Parse(row[2].ToString()),
                    NoofMem = int.Parse(row[3].ToString())
                );
                
                if (count <= 16)
                {
                    tableWidget.Location = new Point(locationX, locationY);
                    if (count == 4)
                    {
                        locationX = 10;
                        locationY += 160;
                        count = 0;
                    }
                    else
                    locationX += 180;
                }
                count++;
                pnlTableListView.Controls.Add(tableWidget);

                //DGV load
                dt = bll.GetOrderList();
                dgvTableDetails.DataSource = dt;
                dgvTableDetails.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTableDetails.Columns[0].Width = 40;
                dgvTableDetails.Columns[0].HeaderText = "Mã đặt hàng";
                dgvTableDetails.Columns[1].Width = 60;
                dgvTableDetails.Columns[1].HeaderText = "Tên bàn/Mã giao";
                dgvTableDetails.Columns[2].Width = 200;
                dgvTableDetails.Columns[2].HeaderText = "Tên món";
                dgvTableDetails.Columns[3].Width = 50;
                dgvTableDetails.Columns[3].HeaderText = "Số lượng";
                dgvTableDetails.Columns[4].Width = 50;
                dgvTableDetails.Columns[4].HeaderText = "Kích cỡ";
                dgvTableDetails.Columns[5].Width = 60;
                dgvTableDetails.Columns[5].HeaderText = "Đơn giá";
                dgvTableDetails.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTableDetails.Columns[6].Width = 60;
                dgvTableDetails.Columns[6].HeaderText = "Tổng giá";
                dgvTableDetails.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTableDetails.Columns[7].Width = 150;
                dgvTableDetails.Columns[7].HeaderText = "Thời gian đặt";

                dgvTableDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 70, 70);
                dgvTableDetails.BackgroundColor = Color.FromArgb(255, 229, 202);
                dgvTableDetails.GridColor = Color.FromArgb(255, 229, 202);
                dgvTableDetails.ClearSelection();
            }
        }
        public void DataReload()
        {
            this.Refresh();
        }
    }
}
