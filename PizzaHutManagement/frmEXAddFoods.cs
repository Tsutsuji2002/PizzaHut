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
    public partial class frmEXAddFoods : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public int currentid;
        public int sizeid;
        frmEXTableDetails originalform;
        frmEXAddFoods parent;
        frmDelieveries originalform1;
        int check;

        public frmEXAddFoods(object incomingform, int check)
        {
            InitializeComponent();
            if (check == 0) originalform = (frmEXTableDetails)incomingform;
            else originalform1 = (frmDelieveries)incomingform;
            this.check = check;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEXAddFoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PizzaHutDataSet.FoodCategories' table. You can move, or remove it, as needed.
            this.foodCategoriesTableAdapter.Fill(this.dB_PizzaHutDataSet.FoodCategories);
            int categoryID = int.Parse(cboCategory.SelectedValue.ToString());
            DataTable data = new DataTable();
            data = bll.getFoodWidget(categoryID);
            int id;
            string name;
            string image;
            string description;
            int locationX = 10;
            int locationY = 10;
            int count = 1;
            
            pnlView.Controls.Clear();
            foreach (DataRow row in data.Rows)
            {
                FoodItemEXWidget FoodItemEXWidget = new FoodItemEXWidget
                (
                    parent = this,
                    id = int.Parse(row[0].ToString()),
                    name = row[2].ToString(),
                    image = row[3].ToString(),
                    description = row[4].ToString()
                );

                if (count <= 20)
                {
                    FoodItemEXWidget.Location = new Point(locationX, locationY);
                    if (count == 4)
                    {
                        locationX = 10;
                        locationY += 195;
                        count = 0;
                    }
                    else
                        locationX += 200;
                }
                count++;
                pnlView.Controls.Add(FoodItemEXWidget);
            }

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryID;
            //Load Food Area
            if (cboCategory.SelectedValue != null)
            {
                categoryID = int.Parse(cboCategory.SelectedValue.ToString());
                DataTable data = new DataTable();
                data = bll.getFoodWidget(categoryID);
                int id;
                string name;
                string image;
                string description;
                int locationX = 10;
                int locationY = 10;
                int count = 1;
                pnlView.Controls.Clear();
                foreach (DataRow row in data.Rows)
                {
                    FoodItemEXWidget FoodItemEXWidget = new FoodItemEXWidget
                    (
                        parent = this,
                        id = int.Parse(row[0].ToString()),
                        name = row[2].ToString(),
                        image = row[3].ToString(),
                        description = row[4].ToString()
                    );;

                    if (count <= 20)
                    {
                        FoodItemEXWidget.Location = new Point(locationX, locationY);
                        if (count == 4)
                        {
                            locationX = 10;
                            locationY += 195;
                            count = 0;
                        }
                        else
                            locationX += 205;
                    }
                    count++;
                    pnlView.Controls.Add(FoodItemEXWidget);

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                if ((int)numQuantity.Value > 0)
                {
                    originalform.currentid = this.currentid;
                    originalform.quantity = (int)numQuantity.Value;
                    originalform.sizeid = this.sizeid;
                    if (bll.AddFoodOrder(this.currentid, this.sizeid, originalform.id, (int)numQuantity.Value))
                    {
                        MessageBox.Show("Thêm món thành công!");
                    }
                    else MessageBox.Show("Thêm món thất bại!");
                    this.Close();
                }
                else MessageBox.Show("Chọn số lượng >= 1!");
                originalform.DataReload();
            }
            else if (check == 1)
            {
                if ((int)numQuantity.Value > 0)
                {
                    originalform1.currentid = this.currentid;
                    originalform1.quantity = (int)numQuantity.Value;
                    originalform1.sizeid = this.sizeid;
                    if (bll.AddDelieveryFoodOrder(this.currentid, this.sizeid, originalform1.customerid, (int)numQuantity.Value))
                    {
                        MessageBox.Show("Thêm món thành công!");
                    }
                    else MessageBox.Show("Thêm món thất bại!");
                    this.Close();
                }
                else MessageBox.Show("Chọn số lượng >= 1!");
                originalform1.DataReload();
            }
        }
    }
}
