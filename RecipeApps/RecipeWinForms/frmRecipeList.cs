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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            this.Activated += FrmRecipeList_Activated;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            WindowsFormUtility.FormatGridforsearchresults(gRecipeList, "Recipe");
            gRecipeList.DataSource = Recipe.SearchRecipe();
            WindowsFormUtility.HideColumn(gRecipeList, "UsersID");
            WindowsFormUtility.HideColumn(gRecipeList, "CuisineTypeID");
            WindowsFormUtility.HideColumn(gRecipeList, "CuisineType");
            WindowsFormUtility.HideColumn(gRecipeList, "DateDraft");
            WindowsFormUtility.HideColumn(gRecipeList, "ConcatCurrentStatus");
            WindowsFormUtility.HideColumn(gRecipeList, "RecipePicture");
            WindowsFormUtility.HideColumn(gRecipeList, "DateArchived");
            WindowsFormUtility.HideColumn(gRecipeList, "DatePublished");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetidFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeForm), id);
            }
        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeList.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipeList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
