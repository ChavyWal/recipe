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
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindRecipeList();
            btnClone.Click += BtnClone_Click;
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            int recipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
            Recipe.CloneRecipe(recipeid);
        }

        private void BindRecipeList()
        {
            DataTable dtRecipes = Recipe.SearchRecipe(true);
            lstRecipeName.DataSource = dtRecipes;
            lstRecipeName.ValueMember = "Recipeid";
            lstRecipeName.DisplayMember = "RecipeName";
        }
    }
}
