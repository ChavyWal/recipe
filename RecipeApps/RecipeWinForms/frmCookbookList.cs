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
using CPUWindowsFormFrameWork;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        int id = 0;
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            gCookBookList.CellDoubleClick += GCookBookList_CellDoubleClick;
        }

        private void BindData()
        {
            WindowsFormUtility.FormatGridforsearchresults(gCookBookList, "CookBook");
            gCookBookList.DataSource = DataMaintenance.CookbookGet();
            foreach (DataGridViewColumn col in gCookBookList.Columns)
            {
                if (col.Name.StartsWith("CookBookDate") || col.Name.StartsWith("Active"))
                {
                    col.Visible = false;
                }
            }
        }

        private void ShowCookbook(int rowindex)
        {
            int id = rowindex;
            if (id > -1)
            {
                id = WindowsFormUtility.GetidFromGrid(gCookBookList, rowindex, "CookBookid");
            }
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void GCookBookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbook(e.RowIndex);
        }
    }
}
