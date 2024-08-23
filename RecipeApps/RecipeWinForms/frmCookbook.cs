using CPUFramework;
using CPUWindowsFormFrameWork;
using RecipeSystem;
using System.Data;
using System.Diagnostics;

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
            btnSave.Click += BtnSave_Click;
        }

        public void LoadCookbookForm(int cookbookid)
        {
            id = cookbookid;
            this.Tag = cookbookid;
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
            this.Text = GetCookbookDesc();
            EnableDisable();
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

        private void EnableDisable()
        {
            btnDelete.Enabled = id > 0 ? true : false;
            btnCookbookRecipeSave.Enabled = id > 0 ? true : false;
            gCookbookRecipes.Enabled = id > 0 ? true : false;
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetvalueFromFirstRowAsInt(dtcookbook, "Cookbookid");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetvalueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void Save()
        {
            try
            {
                DataMaintenance.Save(dtcookbook);
                bindsource.ResetBindings(false);
                id = SQLUtility.GetvalueFromFirstRowAsInt(dtcookbook, "Cookbookid");
                this.Tag = id;
                this.Text = GetCookbookDesc();
                EnableDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var results = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (results == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    DataMaintenance.CookbookDelete(id);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Record Keeper");
                }
            }
                
        }
    }
}
