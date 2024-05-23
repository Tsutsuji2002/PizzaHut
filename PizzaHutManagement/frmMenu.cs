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
    public partial class frmMenu : Form
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PizzaHutDataSet.FoodCategories' table. You can move, or remove it, as needed.
            this.foodCategoriesTableAdapter.Fill(this.dB_PizzaHutDataSet.FoodCategories);
            // Create a GunaTrackBar control.
            GunaTrackBar trackBar = new GunaTrackBar();
            trackBar.Minimum = 0;
            trackBar.Maximum = 100;

            trackBar.Value = 50;
            trackBar.Dock = DockStyle.Bottom;
            pnlFill.Controls.Add(trackBar);

            //Load Food Area
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
            pnlMenu.Controls.Clear();
            foreach (DataRow row in data.Rows)
            {
                FoodItemWidget foodItemWidget = new FoodItemWidget
                (
                    id = int.Parse(row[0].ToString()),
                    name = row[2].ToString(),
                    image = row[3].ToString(),
                    description = row[4].ToString()
                );

                if (count <= 20)
                {
                    foodItemWidget.Location = new Point(locationX, locationY);
                    if (count == 5)
                    {
                        locationX = 10;
                        locationY += 205;
                        count = 0;
                    }
                    else
                        locationX += 195;
                }
                count++;
                pnlMenu.Controls.Add(foodItemWidget);
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
                pnlMenu.Controls.Clear();
                foreach (DataRow row in data.Rows)
                {
                    FoodItemWidget foodItemWidget = new FoodItemWidget
                    (
                        id = int.Parse(row[0].ToString()),
                        name = row[2].ToString(),
                        image = row[3].ToString(),
                        description = row[4].ToString()
                    );

                    if (count <= 20)
                    {
                        foodItemWidget.Location = new Point(locationX, locationY);
                        if (count == 5)
                        {
                            locationX = 10;
                            locationY += 205;
                            count = 0;
                        }
                        else
                            locationX += 195;
                    }
                    count++;
                    pnlMenu.Controls.Add(foodItemWidget);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEXAddFoods frm = new frmEXAddFoods(this, 1);
            frm.ShowDialog();
        }
    }
}
