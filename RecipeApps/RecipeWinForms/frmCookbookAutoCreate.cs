﻿using RecipeSystem;
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
    public partial class frmCookbookAutoCreate : Form
    {
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            BindUsersList();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
          
        }

        private void BindUsersList()
        {

            DataTable dtusers = Recipe.GetUserslist();
            lstUsers.DataSource = dtusers;
            lstUsers.ValueMember = "usersid";
            lstUsers.DisplayMember = "userName";
        }
    }
}
