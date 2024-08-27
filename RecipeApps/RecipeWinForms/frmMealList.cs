using CPUWindowsFormFrameWork;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            WindowsFormUtility.FormatGridforsearchresults(gMeal, "Meal");
            gMeal.DataSource = Recipe.MealGet();
        }
    }
}
