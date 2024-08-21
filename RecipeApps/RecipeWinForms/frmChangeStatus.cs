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
    public partial class frmChangeStatus : Form
    {
        int id = 0;
        DataTable dtrecipe;
        DataTable dtrecipeaferchange;
        BindingSource bindsource = new();
        private enum CurrentStatusEnum{Draft, Published, Archived}
        CurrentStatusEnum currentstatus;

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
            WindowsFormUtility.SetControlBinding(lblConcatCurrentStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDraft, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            string s = dtrecipe.Rows[0]["CurrentStatus"].ToString();
            switch (s)
            {
                case "Archived":
                    currentstatus = CurrentStatusEnum.Archived;
                    break;
                case "Published":
                    currentstatus = CurrentStatusEnum.Published;
                    break;
                case "Draft":
                    currentstatus = CurrentStatusEnum.Draft;
                    break;
            }
            EnableDisable();
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

        private void ChangeStatusPrompt(string status)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe to " + status, Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            else
            {
                switch (currentstatus)
                {
                    case CurrentStatusEnum.Archived:
                        lblDateArchived.Text = DateTime.Now.ToString();
                        break;
                    case CurrentStatusEnum.Published:
                        lblDateArchived.CausesValidation = true;
                        lblDateArchived.DataBindings["Text"].NullValue = "";
                        lblDateArchived.Text = "";
                        lblDatePublished.Text = DateTime.Now.ToString();
                        break;
                    case CurrentStatusEnum.Draft:
                        lblDateArchived.CausesValidation = true;
                        lblDateArchived.DataBindings["Text"].NullValue = "";
                        lblDateArchived.Text = "";
                        lblDatePublished.CausesValidation = true;
                        lblDatePublished.DataBindings["Text"].NullValue = "";
                        lblDatePublished.Text = "";
                        lblDateDraft.Text = DateTime.Now.ToString();
                        break;
                }
                Save();
                dtrecipe = Recipe.Load(id);
                bindsource.DataSource = dtrecipe;
                EnableDisable();
            }
        }

        private void EnableDisable()
        {
            btnDraft.Enabled = currentstatus == CurrentStatusEnum.Draft ? false : true;
            btnArchived.Enabled = currentstatus == CurrentStatusEnum.Archived ? false : true;
            btnPublished.Enabled = currentstatus == CurrentStatusEnum.Published ? false : true;
        }

        private void BtnArchived_Click(object? sender, EventArgs e)
        {
            currentstatus = CurrentStatusEnum.Archived;
            ChangeStatusPrompt("Archived");
        }
        
        private void BtnPublished_Click(object? sender, EventArgs e)
        {
            currentstatus = CurrentStatusEnum.Published;
            ChangeStatusPrompt("Published");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            currentstatus = CurrentStatusEnum.Draft;
            ChangeStatusPrompt("Draft");
        }
    }
}
