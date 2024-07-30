using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using CPUWindowsFormFrameWork;
using RecipeSystem;
using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            txtRecipeName.BackColor = Color.White;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtCuisineType = Recipe.GetCuisineTypelist();
            DataTable dtusers = Recipe.GetUserslist();
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetListBinding(lstCuisineType, dtCuisineType, dtrecipe, "CuisineType");
            WindowsFormUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(dtpDateDraft, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblRecipePicture, dtrecipe);
            lstUser.DataSource = dtusers;
            lstUser.ValueMember = "usersid";
            lstUser.DisplayMember = "userName";
            lstUser.DataBindings.Add("SelectedValue", dtrecipe, lstUser.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            dtpDateDraft.Text = DateTime.Now.ToString("yyyy, MMMM, dd");
            this.Show();
        }

        private void Save()
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["recipeid"];
            
            try 
            {
                if (id == 0)
                {
                    dtpDateDraft.Text = DateTime.Now.ToString("yyyy, MMMM, dd");
                }
                Recipe.save(dtrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Record Keeper");
            }

            
        }

        private void Delete()
        {
           var results =  MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
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
