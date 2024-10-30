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
        DataTable dtRecipeingredients = new();
        DataTable dtRecipeSteps = new();
        BindingSource bindsource = new();

        public frmRecipeForm()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.Activated += FrmRecipeForm_Activated;
            this.FormClosing += FrmRecipeForm_FormClosing;
            gIngredients.DataError += grid_DataError;
            gSteps.DataError += grid_DataError;
        }

        private void FrmRecipeForm_Activated(object? sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            BindData();
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
        }

        private void BindData()
        {
            dtRecipeingredients = Recipe.GetIngredientTable(id);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtRecipeingredients;
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, Recipe.GetIngredients(), "Ingredient", "ingredientname");
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.MeasurmentsGet(), "MeasurmentType", "MeasurmentType");
            WindowsFormUtility.HideColumn(gIngredients, "ingredientname");
            WindowsFormUtility.HideColumn(gIngredients, "MeasurmentType");
            WindowsFormUtility.FormatGridForEdit(gIngredients, "Ingredient");
            WindowsFormUtility.FormatGridForEdit(gIngredients, "Recipe");
            WindowsFormUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            WindowsFormUtility.DeleteButtonToGrid(gIngredients, "Delete");
            dtRecipeSteps = Recipe.GetStepsTable(id);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtRecipeSteps;
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
            WindowsFormUtility.FormatGridForEdit(gSteps, "Recipe");
            WindowsFormUtility.DeleteButtonToGrid(gSteps, "Delete");
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

        private bool Save()
        {
            bool b = false;
            try
            {
                Recipe.save(dtrecipe);
                bindsource.ResetBindings(false);
                b = true;
                id = SQLUtility.GetvalueFromFirstRowAsInt(dtrecipe, "Recipeid");
                this.Tag = id;
                this.Text = GetRecipeDesc();
                RefreshData();
                enableDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe app");
            }
            return b;
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

        private void DeleteRecipIngredient(int rowindex)
        {
            int recipeingredientid = WindowsFormUtility.GetidFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if (recipeingredientid > 0)
            {
                try
                {
                    Recipe.DeleteRecipeIngredient(recipeingredientid);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
        }

        private void DeleteRecipeSteps(int rowindex)
        {
            int rdid = WindowsFormUtility.GetidFromGrid(gSteps, rowindex, "RecipeDirectionid");
            if (rdid > 0)
            {
                try
                {
                    Recipe.DeleteRecipeSteps(rdid);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
        }

        private void grid_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error happened: Something is wrong with the data you entered.");
        }

        private void FrmRecipeForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
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

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            try
            {
                Recipe.RecipeIngredientSave(dtRecipeingredients, id);
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            try
            {
                Recipe.RecipeStepsSave(dtRecipeSteps, id);
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gSteps.CurrentCell.Value is not null && gSteps.CurrentCell.Value.ToString() == "x")
                {
                    DeleteRecipeSteps(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gIngredients.CurrentCell.Value is not null && gIngredients.CurrentCell.Value.ToString() == "x")
                {
                    DeleteRecipIngredient(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
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
