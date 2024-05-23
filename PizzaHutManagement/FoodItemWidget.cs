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
    public partial class FoodItemWidget : UserControl
    {
        ClsBLLPizzaHut bll = new ClsBLLPizzaHut();
        public FoodItemWidget(int id, string name, string image, string description)
        {
            InitializeComponent();
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
    }
}
