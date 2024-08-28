using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUWindowsFormFrameWork;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        private object frmRecipeForm;

        public frmMain()
        {
            InitializeComponent();
            this.Shown += FrmMain_Shown;
            mnuFileDashboard.Click += FrmMain_Shown;
            mnuCascade.Click += MnuCascade_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuEditData.Click += MnuDataMaintenance_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuCookbookAutoCreate.Click += MnuCookbookAutoCreate_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype, pkvalue);

            if(b == false)
            {
                Form? newfrm = null;
                if(frmtype == typeof(frmDashBoard))
                {
                    frmDashBoard f = new frmDashBoard();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new frmCookbookList();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new frmRecipeList();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmCookbookAutoCreate))
                {
                    frmCookbookAutoCreate f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                    
                }
                else if (frmtype == typeof(frmRecipeForm))
                {
                    frmRecipeForm f = new();
                    newfrm = f;
                    f.LoadRecipeForm(pkvalue);

                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.LoadCookbookForm(pkvalue);
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadRecipeChangeStatus(pkvalue);
                }
                if (newfrm != null)
                {
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.Show();
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.TextChanged += Newfrm_TextChanged;
                }
                WindowsFormUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashBoard));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDataMaintenance_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuCookbookAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookAutoCreate));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeForm));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }
    }
}
