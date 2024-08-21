using CPUFramework;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeWinForms
{
    public partial class frmRecipeForm : Form
    {
        int id = 0;
        DataTable dtrecipe = new();
        BindingSource bindsource = new();

        public frmRecipeForm()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            
                this.Activated += FrmRecipeForm_Activated;
            
        }

         private void FrmRecipeForm_Activated(object? sender, EventArgs e)
         {
             if (id > 0)
             {
                 dtrecipe = Recipe.Load(id);
                 bindsource.DataSource = dtrecipe;
             }
         }

        public void LoadRecipeForm(int recipeid)
        {
            id = recipeid;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            bindsource.DataSource = dtrecipe;
            DataTable dtCuisineType = Recipe.GetCuisineTypelist();
            DataTable dtusers = Recipe.GetUserslist();
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetListBinding(lstCuisineType, dtCuisineType, dtrecipe, "CuisineType");
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            lstUser.DataSource = dtusers;
            lstUser.ValueMember = "usersid";
            lstUser.DisplayMember = "userName";
            lstUser.DataBindings.Add("SelectedValue", dtrecipe, lstUser.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = GetRecipeDesc();
            enableDisable();
            BindData();
        }

        private void enableDisable()
        {
            btnChangeStatus.Enabled = id > 0 ? true : false;
            btnSaveIngredients.Enabled = id > 0 ? true : false;
            btnSaveSteps.Enabled = id > 0 ? true : false;
            gIngredients.Enabled = id > 0 ? true : false;
            gSteps.Enabled = id > 0 ? true : false;
            btnDelete.Enabled = id > 0 ? true : false;
        }

        private void BindData()
        {
            WindowsFormUtility.FormatGridForEdit(gIngredients, "ingredient");
            gIngredients.DataSource = Recipe.GetIngredientTable(id);
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, Recipe.GetIngredients(), "Ingredient", "ingredientname");
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, Recipe.GetIngredients(), "Ingredient", "MeasurmentType");
            foreach (DataGridViewColumn col in gIngredients.Columns)
            {
                if (col.Name.StartsWith("ingredientname")  || col.Name.StartsWith("MeasurmentType"))
                {
                    col.Visible = false;
                }
            }
            WindowsFormUtility.DeleteButtonToGrid(gIngredients, "Delete");
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
            gSteps.DataSource = Recipe.GetStepsTable(id);
            WindowsFormUtility.DeleteButtonToGrid(gSteps, "Delete");
        }


        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetvalueFromFirstRowAsInt(dtrecipe, "Recipeid");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetvalueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void Save()
        {
            
            try
            {
                Recipe.save(dtrecipe);
                bindsource.ResetBindings(false);
                id = SQLUtility.GetvalueFromFirstRowAsInt(dtrecipe, "Recipeid");
                this.Tag = id;
                this.Text = GetRecipeDesc();
                enableDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
            
        }

        private void Delete()
        {
            var results = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (results == DialogResult.No)
            {
                return;
            }
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), id);
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            int recipeingredientid = WindowsFormUtility.GetidFromGrid(gIngredients, e.RowIndex, "RecipeIngredient");
            Recipe.DeleteRecipeIngredient(recipeingredientid);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
