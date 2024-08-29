using CPUFramework;
using CPUWindowsFormFrameWork;
using RecipeSystem;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        int id = 0;
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();

        public frmCookbook()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnCookbookRecipeSave.Click += BtnCookbookRecipeSave_Click;
            gCookbookRecipes.CellContentClick += GCookbookRecipes_CellContentClick;
            gCookbookRecipes.DataError += GCookbookRecipes_DataError;
            this.Activated += FrmCookbook_Activated;
            this.FormClosing += FrmCookbook_FormClosing;
        }

        private void FrmCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
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
            
        }

        private void BindData()
        {
            dtcookbookrecipe = DataMaintenance.CookbookRecipeGet(id);
            gCookbookRecipes.Columns.Clear();
            gCookbookRecipes.DataSource = dtcookbookrecipe;
            WindowsFormUtility.AddComboBoxToGrid(gCookbookRecipes, Recipe.SearchRecipe(), "Recipe", "RecipeName");
            WindowsFormUtility.HideColumn(gCookbookRecipes, "RecipeName");
            WindowsFormUtility.FormatGridForEdit(gCookbookRecipes, "Cookbook");
            WindowsFormUtility.FormatGridForEdit(gCookbookRecipes, "CookbookRecipe");
            WindowsFormUtility.FormatGridForEdit(gCookbookRecipes, "Recipe");
            WindowsFormUtility.DeleteButtonToGrid(gCookbookRecipes, "Delete");
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

        private bool Save()
        {
            bool b = false;
            try
            {
                DataMaintenance.Save(dtcookbook);
                bindsource.ResetBindings(false);
                b = true;
                id = SQLUtility.GetvalueFromFirstRowAsInt(dtcookbook, "Cookbookid");
                this.Tag = id;
                this.Text = GetCookbookDesc();
                EnableDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
            return b;
        }

        private void Delete()
        {
            var results = MessageBox.Show("Are you sure you want to delete this Cookbook?", "Cookbook", MessageBoxButtons.YesNo);
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

        private void DeleteCookookRecipe(int rowindex)
        {
            int crid = WindowsFormUtility.GetidFromGrid(gCookbookRecipes, rowindex, "Cookbookrecipeid");
            if(crid > 0)
            {
                try
                {
                    DataMaintenance.CookbookRecipeDelete(crid);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
        }

        private void BtnCookbookRecipeSave_Click(object? sender, EventArgs e)
        {
            try
            {
                DataMaintenance.CookbookRecipeSave(dtcookbookrecipe, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void GCookbookRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookookRecipe(e.RowIndex);
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void GCookbookRecipes_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error Happened: Something is wrong with the data you entered.");
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
    }
}
