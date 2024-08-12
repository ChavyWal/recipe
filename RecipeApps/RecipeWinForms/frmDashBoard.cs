using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            gDashboard.DefaultCellStyle.SelectionBackColor = Color.White;
            gDashboard.DefaultCellStyle.SelectionForeColor = Color.Black;
            gDashboard.DataSource = Recipe.RecipeMealandCookbookCount();
        }
    }
}
