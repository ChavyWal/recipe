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
            this.Activated += FrmRecipeForm_Activated;
        }

        private void FrmRecipeForm_Activated(object? sender, EventArgs e)
        {
            dtrecipe = Recipe.Load(id);
            bindsource.DataSource = dtrecipe;
        }

        public void LoadRecipeForm(int recipeid)
        {
            id = recipeid;
            dtrecipe = Recipe.Load(id);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
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
            DataRow r = dtrecipe.Rows[0];
            BindData();
        }

        private void BindData()
        {
            gIngredients.DataSource = Recipe.GetIngredientTable(id);
            gSteps.DataSource = Recipe.GetStepsTable(id);
        }

        private void Save()
        {
            try
            {
                Recipe.save(dtrecipe);
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
