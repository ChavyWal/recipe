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
using System.Diagnostics;
using CPUWindowsFormFrameWork;

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
            string sql = "select r.RecipeID, r.RecipeName, c.CuisineType, r.Cuisinetypeid, r.usersid, r.Calories, r.DateDraft, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture, u.UserName from recipe r join CuisineType c on c.CuisineTypeID = r.CuisineTypeID join users u on u.UsersID = r.UsersID where r.recipeid = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            Debug.Print(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtCuisineType = SQLUtility.GetDataTable("select c.CuisineTypeid, c.CuisineType from CuisineType c");
            DataTable dtusers = SQLUtility.GetDataTable("Select usersID, username from users u");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetListBinding(lstCuisineType, dtCuisineType, dtrecipe, "CuisineType");
            WindowsFormUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateDraft, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblRecipePicture, dtrecipe);
            lstUser.DataSource = dtusers;
            lstUser.ValueMember = "usersid";
            lstUser.DisplayMember = "userName";
            lstUser.DataBindings.Add("SelectedValue", dtrecipe, lstUser.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            this.Show();
        }

        private void Save()
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["recipeid"];
            string statetement = "";
            if (id > 0)
            {
                statetement = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"CuisineTypeid = '{r["CuisineTypeid"]}',",
                    $"DateDraft = '{r["DateDraft"]}',",
                    $"UsersId = '{r["usersID"]}'",
                    $"where recipeid = '{r["recipeid"]}'"
                    );
            }
            else
            {
                statetement = "insert recipe(RecipeName, calories, CuisineTypeID, DateDraft, UsersID)";
                statetement += $"select '{r["RecipeName"]}', '{r["Calories"]}', '{r["CuisineTypeid"]}', '{r["DateDraft"]}', '{r["usersID"]}'";
            }
            Debug.Print(statetement);
            SQLUtility.ExecuteSQL(statetement);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["recipeid"];
            string sql = "delete recipe where recipeid = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
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
