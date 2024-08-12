namespace RecipeWinForms
{
    partial class frmDashBoard
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
            tblLists = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            label1 = new Label();
            label2 = new Label();
            gDashboard = new DataGridView();
            tblMain.SuspendLayout();
            tblLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.625F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.875F));
            tblMain.Controls.Add(tblLists, 1, 3);
            tblMain.Controls.Add(label1, 1, 1);
            tblMain.Controls.Add(label2, 1, 0);
            tblMain.Controls.Add(gDashboard, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(799, 457);
            tblMain.TabIndex = 0;
            // 
            // tblLists
            // 
            tblLists.ColumnCount = 3;
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblLists.Controls.Add(btnRecipeList, 0, 0);
            tblLists.Controls.Add(btnMealList, 1, 0);
            tblLists.Controls.Add(btnCookbookList, 2, 0);
            tblLists.Location = new Point(183, 373);
            tblLists.Name = "tblLists";
            tblLists.RowCount = 1;
            tblLists.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLists.Size = new Size(429, 80);
            tblLists.TabIndex = 0;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 10.8F);
            btnRecipeList.Location = new Point(10, 10);
            btnRecipeList.Margin = new Padding(10);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(122, 60);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Segoe UI", 10.8F);
            btnMealList.Location = new Point(152, 10);
            btnMealList.Margin = new Padding(10);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(122, 60);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Segoe UI", 10.8F);
            btnCookbookList.Location = new Point(294, 10);
            btnCookbookList.Margin = new Padding(10);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(125, 60);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 63);
            label1.Name = "label1";
            label1.Size = new Size(429, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and......................";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 0);
            label2.Name = "label2";
            label2.Size = new Size(411, 48);
            label2.TabIndex = 2;
            label2.Text = "Hearty Hearth Desktop App";
            // 
            // gDashboard
            // 
            gDashboard.AllowUserToAddRows = false;
            gDashboard.AllowUserToDeleteRows = false;
            gDashboard.AllowUserToResizeRows = false;
            gDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gDashboard.BackgroundColor = Color.White;
            gDashboard.CausesValidation = false;
            gDashboard.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDashboard.Dock = DockStyle.Fill;
            gDashboard.EditMode = DataGridViewEditMode.EditProgrammatically;
            gDashboard.Location = new Point(195, 185);
            gDashboard.Margin = new Padding(15, 61, 15, 61);
            gDashboard.Name = "gDashboard";
            gDashboard.ReadOnly = true;
            gDashboard.RowHeadersVisible = false;
            gDashboard.RowHeadersWidth = 51;
            gDashboard.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gDashboard.ShowCellToolTips = false;
            gDashboard.Size = new Size(405, 124);
            gDashboard.StandardTab = true;
            gDashboard.TabIndex = 10;
            // 
            // frmDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 457);
            Controls.Add(tblMain);
            Name = "frmDashBoard";
            Text = "DashBoard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblLists.ResumeLayout(false);
            tblLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLists;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private Label label1;
        private Label label2;
        private DataGridView gDashboard;
    }
}