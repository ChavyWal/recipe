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
    public partial class frmCookbook : Form
    {
        int id = 0;
        DataTable dtcookbook = new();
        BindingSource bindsource = new();

        public frmCookbook()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
        }

        public void LoadCookbookForm(int cookbookid)
        {
            id = cookbookid;
            dtcookbook = DataMaintenance.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserslist();
            WindowsFormUtility.SetControlBinding(txtCookBookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCookBookprice, bindsource);
            WindowsFormUtility.SetControlBinding(lblCookBookdate, bindsource);
            WindowsFormUtility.SetControlBinding(ckbActive, bindsource);
            lstUser.DataSource = dtusers;
            lstUser.ValueMember = "usersid";
            lstUser.DisplayMember = "userName";
            lstUser.DataBindings.Add("SelectedValue", dtcookbook, lstUser.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            BindData();
        }

        private void BindData()
        {
            gCookbookRecipes.DataSource = DataMaintenance.CookbookRecipeGet(id);
            WindowsFormUtility.FormatGridForEdit(gCookbookRecipes, "Cookbook");
            WindowsFormUtility.DeleteButtonToGrid(gCookbookRecipes, "Delete");
            WindowsFormUtility.AddComboBoxToGrid(gCookbookRecipes, Recipe.SearchRecipe(), "Recipe", "RecipeName");
            foreach (DataGridViewColumn col in gCookbookRecipes.Columns)
            {
                if (col.Name.StartsWith("RecipeName"))
                {
                    col.Visible = false;
                }
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            DataMaintenance.CookbookDelete(id);
        }

        
    }
}
