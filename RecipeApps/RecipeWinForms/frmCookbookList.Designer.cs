namespace RecipeWinForms
{
    partial class frmCookbookList
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
            tblMain = new TableLayoutPanel();
            gCookBookList = new DataGridView();
            btnNewCookbook = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.FromArgb(255, 255, 192);
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(gCookBookList, 0, 1);
            tblMain.Controls.Add(btnNewCookbook, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // gCookBookList
            // 
            gCookBookList.BackgroundColor = Color.FromArgb(255, 255, 192);
            gCookBookList.BorderStyle = BorderStyle.None;
            gCookBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookBookList.Dock = DockStyle.Fill;
            gCookBookList.Location = new Point(10, 73);
            gCookBookList.Margin = new Padding(10);
            gCookBookList.Name = "gCookBookList";
            gCookBookList.RowHeadersWidth = 51;
            gCookBookList.Size = new Size(780, 367);
            gCookBookList.TabIndex = 1;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.AutoSize = true;
            btnNewCookbook.BackColor = Color.FromArgb(255, 255, 128);
            btnNewCookbook.FlatStyle = FlatStyle.Flat;
            btnNewCookbook.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCookbook.Location = new Point(10, 10);
            btnNewCookbook.Margin = new Padding(10);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(180, 43);
            btnNewCookbook.TabIndex = 2;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = false;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gCookBookList;
        private Button btnNewCookbook;
    }
}