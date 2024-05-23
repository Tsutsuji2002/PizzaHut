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
using static PizzaHutManagement.frmEXAddFoods;

namespace PizzaHutManagement
{
    public partial class FoodItemEXWidget : UserControl
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public int foodid;

        frmEXAddFoods parent;
        public FoodItemEXWidget(frmEXAddFoods parent, int id, string name, string image, string description)
        {
            InitializeComponent();

            this.parent = parent;
            this.foodid = id;

            btnFoodName.Text = name;
            Image fimage = Image.FromFile("C:\\VisualStudio\\Winform C#\\PizzaHut\\PizzaHutManagement\\Resources\\Images\\" + image);
            pboFItem.Image = fimage;
            pboFItem.SizeMode = PictureBoxSizeMode.StretchImage;
            btnFoodName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            List<Tuple<string, float>> list = new List<Tuple<string, float>>();
            list = bll.getPricebySize(id);
            foreach (Tuple<string, float> tuple in list)
            {
                cboSizePrice.Items.Add(tuple.Item1 + ":  " + tuple.Item2);
            }
            cboSizePrice.SelectedIndex = 0;
        }

        private void btnFoodName_Click(object sender, EventArgs e)
        {
            string selectedValue = cboSizePrice.SelectedItem.ToString();

            bool contains1 = selectedValue.Contains("Nhỏ");
            if (contains1) parent.sizeid = 1;
            bool contains2 = selectedValue.Contains("Vừa");
            if (contains2) parent.sizeid = 2;
            bool contains3 = selectedValue.Contains("Lớn");
            if (contains3) parent.sizeid = 3;
            bool contains0 = selectedValue.Contains("None");
            if (contains0) parent.sizeid = 0;
            parent.currentid = this.foodid;;
        }

        private void FoodItemEXWidget_Load(object sender, EventArgs e)
        {

        }
    }
}
