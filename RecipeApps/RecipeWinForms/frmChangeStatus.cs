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
    public partial class frmChangeStatus : Form
    {
        int id = 0;
        DataTable dtrecipe;
        DataTable dtrecipeaferchange;
        BindingSource bindsource = new();

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublished.Click += BtnPublished_Click;
            btnArchived.Click += BtnArchived_Click;
        }

        

        public void LoadRecipeChangeStatus(int recipeid)
        {
            id = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                lblRecipeName.Text = "New Recipe";
            }
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
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

        private void BtnArchived_Click(object? sender, EventArgs e)
        {
            lblDateArchived.Text = DateTime.Now.ToString();
            Save();
            dtrecipe = Recipe.Load(id);
            bindsource.DataSource = dtrecipe;
        }

        private void EnableDisable()
        {
            lblDateDraft.Enabled = false;
            lblDateArchived.Enabled = false;
            lblDatePublished.Enabled = false;
        }

        private void RefreshChangeStatus(DataTable trecipe, int idr)
        {
            Recipe.save(trecipe);
            trecipe = Recipe.Load(idr);
            bindsource.DataSource = trecipe;
        }

        private void BtnPublished_Click(object? sender, EventArgs e)
        {
            //DateTime? date = null;
            //lblDateArchived.Text = date.ToString();
            ////dtrecipe.AcceptChanges();
            //Save();
            //dtrecipe = Recipe.Load(id);
            ////bindsource.DataSource = dtrecipe;
            //;

            //lblDatePublished.Text = DateTime.Now.ToString();
            //Recipe.save(dtrecipe);
            //dtrecipe = Recipe.Load(id);
            //bindsource.DataSource = dtrecipe;
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            //lblDateArchived.Text = "";
            //lblDatePublished.Text = "";
            //Recipe.save(dtrecipe);
            //dtrecipe = Recipe.Load(id);
            //bindsource.DataSource = dtrecipe;

            //lblDateDraft.Text = DateTime.Now.ToString();
            //Recipe.save(dtrecipe);
            //dtrecipe = Recipe.Load(id);
            //bindsource.DataSource = dtrecipe;

        }
    }
}
