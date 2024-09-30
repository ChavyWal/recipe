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
            gDataMaintenance.DataError += GDataMaintenance_DataError;
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            SetUpRadioButtons();
            BindData(TableTypeEnum.Users);
        }

        private void GDataMaintenance_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error Happened: Something is wrong with the data you entered.");
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {

            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttable = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttable.ToString());
            gDataMaintenance.Columns.Clear();
            gDataMaintenance.DataSource = dtlist;
            WindowsFormUtility.FormatGridForEdit(gDataMaintenance, currenttable.ToString());
            WindowsFormUtility.DeleteButtonToGrid(gDataMaintenance, deletecoolumnname);
        }

        private void SetUpRadioButtons()
        {
            foreach (Control c in flpRadioButtons.Controls)
            {
                if (c is RadioButton)
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

        private void Delete(int rowindex)
        {
            string st = "and all related records?";
            if (currenttable == TableTypeEnum.Users)
            {
                st = "and all related recipes, meals and cookbooks?";
            }
            var results = MessageBox.Show($"Are you sure you want to delete this {currenttable.ToString()} " + st, currenttable.ToString(), MessageBoxButtons.YesNo);
            if (results == DialogResult.No)
            {
                return;
            }
            int id = WindowsFormUtility.GetidFromGrid(gDataMaintenance, rowindex, currenttable.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttable.ToString(), id);
                    BindData(currenttable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gDataMaintenance.Rows.Count)
            {
                gDataMaintenance.Rows.Remove(gDataMaintenance.Rows[rowindex]);
            }

        }

        private bool Save()
        {
            bool b = false;
            try
            {
                b = true;
                Cursor = Cursors.WaitCursor;
                DataMaintenance.SaveDataList(dtlist, currenttable.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GDataMaintenance_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gDataMaintenance.CurrentCell.Value is not null && gDataMaintenance.CurrentCell.Value.ToString() == "x")
                {

                    Delete(e.RowIndex);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }
    }
}
