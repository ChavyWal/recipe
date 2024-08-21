namespace RecipeWinForms
{
    partial class frmCookbook
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
            tblCookBookInfo = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnCookbookNameCaption = new Label();
            lblUserCaption = new Label();
            lblPriceCaption = new Label();
            lblActiveCaption = new Label();
            txtCookBookName = new TextBox();
            lstUser = new ComboBox();
            tblPrice = new TableLayoutPanel();
            txtCookBookprice = new TextBox();
            lblCookBookdate = new Label();
            lblDateCreatedCaption = new Label();
            ckbActive = new CheckBox();
            tblCookBookrecipe = new TableLayoutPanel();
            btnCookbookRecipeSave = new Button();
            gCookbookRecipes = new DataGridView();
            tblMain.SuspendLayout();
            tblCookBookInfo.SuspendLayout();
            tblPrice.SuspendLayout();
            tblCookBookrecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblCookBookInfo, 0, 0);
            tblMain.Controls.Add(tblCookBookrecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(796, 554);
            tblMain.TabIndex = 0;
            // 
            // tblCookBookInfo
            // 
            tblCookBookInfo.AutoSize = true;
            tblCookBookInfo.ColumnCount = 2;
            tblCookBookInfo.ColumnStyles.Add(new ColumnStyle());
            tblCookBookInfo.ColumnStyles.Add(new ColumnStyle());
            tblCookBookInfo.Controls.Add(btnSave, 0, 0);
            tblCookBookInfo.Controls.Add(btnDelete, 1, 0);
            tblCookBookInfo.Controls.Add(btnCookbookNameCaption, 0, 1);
            tblCookBookInfo.Controls.Add(lblUserCaption, 0, 2);
            tblCookBookInfo.Controls.Add(lblPriceCaption, 0, 4);
            tblCookBookInfo.Controls.Add(lblActiveCaption, 0, 5);
            tblCookBookInfo.Controls.Add(txtCookBookName, 1, 1);
            tblCookBookInfo.Controls.Add(lstUser, 1, 2);
            tblCookBookInfo.Controls.Add(tblPrice, 1, 4);
            tblCookBookInfo.Controls.Add(lblDateCreatedCaption, 1, 3);
            tblCookBookInfo.Controls.Add(ckbActive, 1, 5);
            tblCookBookInfo.Dock = DockStyle.Fill;
            tblCookBookInfo.Location = new Point(3, 3);
            tblCookBookInfo.Name = "tblCookBookInfo";
            tblCookBookInfo.RowCount = 6;
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.RowStyles.Add(new RowStyle());
            tblCookBookInfo.Size = new Size(790, 248);
            tblCookBookInfo.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(6, 6);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(173, 6);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCookbookNameCaption
            // 
            btnCookbookNameCaption.Anchor = AnchorStyles.Left;
            btnCookbookNameCaption.AutoSize = true;
            btnCookbookNameCaption.Location = new Point(3, 56);
            btnCookbookNameCaption.Name = "btnCookbookNameCaption";
            btnCookbookNameCaption.Size = new Size(161, 28);
            btnCookbookNameCaption.TabIndex = 2;
            btnCookbookNameCaption.Text = "Cookbook Name";
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 97);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(51, 28);
            lblUserCaption.TabIndex = 3;
            lblUserCaption.Text = "User";
            // 
            // lblPriceCaption
            // 
            lblPriceCaption.Anchor = AnchorStyles.Left;
            lblPriceCaption.AutoSize = true;
            lblPriceCaption.Location = new Point(3, 182);
            lblPriceCaption.Name = "lblPriceCaption";
            lblPriceCaption.Size = new Size(54, 28);
            lblPriceCaption.TabIndex = 4;
            lblPriceCaption.Text = "Price";
            // 
            // lblActiveCaption
            // 
            lblActiveCaption.Anchor = AnchorStyles.Left;
            lblActiveCaption.AutoSize = true;
            lblActiveCaption.Location = new Point(3, 220);
            lblActiveCaption.Name = "lblActiveCaption";
            lblActiveCaption.Size = new Size(66, 28);
            lblActiveCaption.TabIndex = 5;
            lblActiveCaption.Text = "Active";
            // 
            // txtCookBookName
            // 
            txtCookBookName.Dock = DockStyle.Fill;
            txtCookBookName.Location = new Point(170, 53);
            txtCookBookName.Name = "txtCookBookName";
            txtCookBookName.Size = new Size(617, 34);
            txtCookBookName.TabIndex = 6;
            // 
            // lstUser
            // 
            lstUser.Dock = DockStyle.Fill;
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(170, 93);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(617, 36);
            lstUser.TabIndex = 7;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 2;
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.18421F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.81579F));
            tblPrice.Controls.Add(txtCookBookprice, 0, 0);
            tblPrice.Controls.Add(lblCookBookdate, 1, 0);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(170, 175);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 1;
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.Size = new Size(617, 42);
            tblPrice.TabIndex = 9;
            // 
            // txtCookBookprice
            // 
            txtCookBookprice.Dock = DockStyle.Fill;
            txtCookBookprice.Location = new Point(3, 3);
            txtCookBookprice.Name = "txtCookBookprice";
            txtCookBookprice.Size = new Size(217, 34);
            txtCookBookprice.TabIndex = 0;
            // 
            // lblCookBookdate
            // 
            lblCookBookdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCookBookdate.AutoSize = true;
            lblCookBookdate.BackColor = Color.DarkGray;
            lblCookBookdate.Location = new Point(229, 6);
            lblCookBookdate.Margin = new Padding(6);
            lblCookBookdate.Name = "lblCookBookdate";
            lblCookBookdate.Size = new Size(382, 28);
            lblCookBookdate.TabIndex = 1;
            // 
            // lblDateCreatedCaption
            // 
            lblDateCreatedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDateCreatedCaption.AutoSize = true;
            lblDateCreatedCaption.Location = new Point(654, 138);
            lblDateCreatedCaption.Margin = new Padding(6);
            lblDateCreatedCaption.Name = "lblDateCreatedCaption";
            lblDateCreatedCaption.Size = new Size(130, 28);
            lblDateCreatedCaption.TabIndex = 8;
            lblDateCreatedCaption.Text = "Date Created:";
            // 
            // ckbActive
            // 
            ckbActive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ckbActive.AutoSize = true;
            ckbActive.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbActive.Location = new Point(170, 223);
            ckbActive.Name = "ckbActive";
            ckbActive.Size = new Size(617, 22);
            ckbActive.TabIndex = 10;
            ckbActive.UseVisualStyleBackColor = true;
            // 
            // tblCookBookrecipe
            // 
            tblCookBookrecipe.ColumnCount = 1;
            tblCookBookrecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookBookrecipe.Controls.Add(btnCookbookRecipeSave, 0, 0);
            tblCookBookrecipe.Controls.Add(gCookbookRecipes, 0, 1);
            tblCookBookrecipe.Dock = DockStyle.Fill;
            tblCookBookrecipe.Location = new Point(3, 257);
            tblCookBookrecipe.Name = "tblCookBookrecipe";
            tblCookBookrecipe.RowCount = 2;
            tblCookBookrecipe.RowStyles.Add(new RowStyle());
            tblCookBookrecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 82.21709F));
            tblCookBookrecipe.Size = new Size(790, 635);
            tblCookBookrecipe.TabIndex = 1;
            // 
            // btnCookbookRecipeSave
            // 
            btnCookbookRecipeSave.AutoSize = true;
            btnCookbookRecipeSave.Location = new Point(3, 3);
            btnCookbookRecipeSave.Name = "btnCookbookRecipeSave";
            btnCookbookRecipeSave.Size = new Size(94, 38);
            btnCookbookRecipeSave.TabIndex = 0;
            btnCookbookRecipeSave.Text = "Save";
            btnCookbookRecipeSave.UseVisualStyleBackColor = true;
            // 
            // gCookbookRecipes
            // 
            gCookbookRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookRecipes.Dock = DockStyle.Fill;
            gCookbookRecipes.Location = new Point(3, 47);
            gCookbookRecipes.Name = "gCookbookRecipes";
            gCookbookRecipes.RowHeadersWidth = 51;
            gCookbookRecipes.Size = new Size(784, 585);
            gCookbookRecipes.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 554);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblCookBookInfo.ResumeLayout(false);
            tblCookBookInfo.PerformLayout();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            tblCookBookrecipe.ResumeLayout(false);
            tblCookBookrecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblCookBookInfo;
        private TableLayoutPanel tblCookBookrecipe;
        private Button btnSave;
        private Button btnDelete;
        private Label btnCookbookNameCaption;
        private Label lblUserCaption;
        private Label lblPriceCaption;
        private Label lblActiveCaption;
        private TextBox txtCookBookName;
        private ComboBox lstUser;
        private Label lblDateCreatedCaption;
        private TableLayoutPanel tblPrice;
        private Button btnCookbookRecipeSave;
        private DataGridView gCookbookRecipes;
        private TextBox txtCookBookprice;
        private Label lblCookBookdate;
        private CheckBox ckbActive;
    }
}