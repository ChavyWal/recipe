using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
            lblRecipeName.BackColor = Color.White;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.RecipeID, r.RecipeName, c.CuisineType, r.Calories, r.DateDraft, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture, u.UserName from recipe r join CuisineType c on c.CuisineTypeID = r.CuisineTypeID join users u on u.UsersID = r.UsersID where r.recipeid = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblCuisineType.DataBindings.Add("Text", dt, "CuisineType");
            lblCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDraft.DataBindings.Add("Text", dt, "DateDraft");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtCurrentStatus.DataBindings.Add("Text", dt, "CurrentStatus");
            txtRecipePicture.DataBindings.Add("Text", dt, "RecipePicture");
            lblUser.DataBindings.Add("Text", dt, "username");
            this.Show();
        }
    }
}
