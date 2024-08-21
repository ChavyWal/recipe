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
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, CuisineType, Ingredient, MeasurmentType, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttable = TableTypeEnum.Users;
        string deletecoolumnname = "deletecol";

        public frmDataMaintenance()
        {
            InitializeComponent();
            gDataMaintenance.CellContentClick += GDataMaintenance_CellContentClick;
            SetUpRadioButtons();
            BindData(TableTypeEnum.Users);
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttable = tabletype;
            gDataMaintenance.Columns.Clear();
            switch (tabletype)
            {
                case TableTypeEnum.Users:
                    gDataMaintenance.DataSource = Recipe.GetUserslist();
                    break;
                case TableTypeEnum.CuisineType:
                    gDataMaintenance.DataSource = Recipe.GetCuisineTypelist();
                    break;
                case TableTypeEnum.Ingredient:
                    gDataMaintenance.DataSource = Recipe.GetIngredients();
                    break;
                case TableTypeEnum.MeasurmentType:
                    gDataMaintenance.DataSource = DataMaintenance.MeasurmentsGet();
                    break;
                case TableTypeEnum.Course:
                    gDataMaintenance.DataSource = DataMaintenance.CoursesGet();
                    break;
            }
            WindowsFormUtility.FormatGridForEdit(gDataMaintenance, currenttable.ToString());
            WindowsFormUtility.DeleteButtonToGrid(gDataMaintenance, deletecoolumnname);
        }

        private void SetUpRadioButtons()
        {
            foreach (Control c in flpRadioButtons.Controls)
            {
                if(c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            rdbUsers.Tag = TableTypeEnum.Users;
            rdbCourses.Tag = TableTypeEnum.Course;
            rdbCuisineType.Tag = TableTypeEnum.CuisineType;
            rdbIngredients.Tag = TableTypeEnum.Ingredient;
            rdbMeasurmentType.Tag = TableTypeEnum.MeasurmentType;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableTypeEnum){
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void GDataMaintenance_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
