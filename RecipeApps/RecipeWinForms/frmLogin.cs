using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            //try
            //{

                dbManager.SetConnectionString(ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString,true);
                this.Close();
            //}
            //catch
            //{
                //MessageBox.Show("Invalid login. Try again.", Application.ProductName);
            //}
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
