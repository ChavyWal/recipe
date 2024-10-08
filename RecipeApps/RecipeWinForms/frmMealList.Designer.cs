﻿namespace RecipeWinForms
{
    partial class frmMealList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tblMain = new TableLayoutPanel();
            gMeal = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gMeal).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.WhiteSmoke;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(gMeal, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // gMeal
            // 
            gMeal.BackgroundColor = Color.WhiteSmoke;
            gMeal.BorderStyle = BorderStyle.None;
            gMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gMeal.DefaultCellStyle = dataGridViewCellStyle1;
            gMeal.Dock = DockStyle.Fill;
            gMeal.Location = new Point(19, 23);
            gMeal.Margin = new Padding(19, 23, 19, 23);
            gMeal.Name = "gMeal";
            gMeal.RowHeadersWidth = 51;
            gMeal.Size = new Size(762, 404);
            gMeal.TabIndex = 0;
            // 
            // frmMealList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmMealList";
            Text = "Meal List";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gMeal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gMeal;
    }
}