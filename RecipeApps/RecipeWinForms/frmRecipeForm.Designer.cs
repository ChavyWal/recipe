namespace RecipeWinForms
{
    partial class frmRecipeForm
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
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            tblRecipeInfo = new TableLayoutPanel();
            lblRecipeNameCaption = new Label();
            lblUserCaption = new Label();
            lblCuisineTypeCaption = new Label();
            lblCaloriesCaption = new Label();
            lblCurrentStatusCaption = new Label();
            lblStatusDatesCaption = new Label();
            txtRecipeName = new TextBox();
            lstUser = new ComboBox();
            lstCuisineType = new ComboBox();
            txtCalories = new TextBox();
            label7 = new Label();
            tblStatus = new TableLayoutPanel();
            lblDateDraftedCaption = new Label();
            lblDatePublishedCaption = new Label();
            lblDateArchivedCaption = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tcRecipeTabs = new TabControl();
            tbIngredients = new TabPage();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblRecipeInfo.SuspendLayout();
            tblStatus.SuspendLayout();
            tcRecipeTabs.SuspendLayout();
            tbIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(tblRecipeInfo, 0, 1);
            tblMain.Controls.Add(tcRecipeTabs, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(613, 713);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.09384F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.90616F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(4, 4);
            tblButtons.Margin = new Padding(4);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.Size = new Size(605, 60);
            tblButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(7, 7);
            btnSave.Margin = new Padding(7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(165, 7);
            btnDelete.Margin = new Padding(7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(452, 7);
            btnChangeStatus.Margin = new Padding(7);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(146, 46);
            btnChangeStatus.TabIndex = 3;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tblRecipeInfo
            // 
            tblRecipeInfo.AutoSize = true;
            tblRecipeInfo.ColumnCount = 2;
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle());
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipeInfo.Controls.Add(lblRecipeNameCaption, 0, 0);
            tblRecipeInfo.Controls.Add(lblUserCaption, 0, 1);
            tblRecipeInfo.Controls.Add(lblCuisineTypeCaption, 0, 2);
            tblRecipeInfo.Controls.Add(lblCaloriesCaption, 0, 3);
            tblRecipeInfo.Controls.Add(lblCurrentStatusCaption, 0, 4);
            tblRecipeInfo.Controls.Add(lblStatusDatesCaption, 0, 5);
            tblRecipeInfo.Controls.Add(txtRecipeName, 1, 0);
            tblRecipeInfo.Controls.Add(lstUser, 1, 1);
            tblRecipeInfo.Controls.Add(lstCuisineType, 1, 2);
            tblRecipeInfo.Controls.Add(txtCalories, 1, 3);
            tblRecipeInfo.Controls.Add(label7, 1, 4);
            tblRecipeInfo.Controls.Add(tblStatus, 1, 5);
            tblRecipeInfo.Dock = DockStyle.Fill;
            tblRecipeInfo.Location = new Point(4, 72);
            tblRecipeInfo.Margin = new Padding(4);
            tblRecipeInfo.Name = "tblRecipeInfo";
            tblRecipeInfo.RowCount = 6;
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.Size = new Size(605, 292);
            tblRecipeInfo.TabIndex = 1;
            // 
            // lblRecipeNameCaption
            // 
            lblRecipeNameCaption.Anchor = AnchorStyles.Left;
            lblRecipeNameCaption.AutoSize = true;
            lblRecipeNameCaption.Location = new Point(4, 7);
            lblRecipeNameCaption.Margin = new Padding(4, 0, 4, 0);
            lblRecipeNameCaption.Name = "lblRecipeNameCaption";
            lblRecipeNameCaption.Size = new Size(126, 28);
            lblRecipeNameCaption.TabIndex = 0;
            lblRecipeNameCaption.Text = "Recipe Name";
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(4, 50);
            lblUserCaption.Margin = new Padding(4, 0, 4, 0);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(51, 28);
            lblUserCaption.TabIndex = 1;
            lblUserCaption.Text = "User";
            // 
            // lblCuisineTypeCaption
            // 
            lblCuisineTypeCaption.Anchor = AnchorStyles.Left;
            lblCuisineTypeCaption.AutoSize = true;
            lblCuisineTypeCaption.Location = new Point(4, 94);
            lblCuisineTypeCaption.Margin = new Padding(4, 0, 4, 0);
            lblCuisineTypeCaption.Name = "lblCuisineTypeCaption";
            lblCuisineTypeCaption.Size = new Size(74, 28);
            lblCuisineTypeCaption.TabIndex = 2;
            lblCuisineTypeCaption.Text = "Cuisine";
            // 
            // lblCaloriesCaption
            // 
            lblCaloriesCaption.Anchor = AnchorStyles.Left;
            lblCaloriesCaption.AutoSize = true;
            lblCaloriesCaption.Location = new Point(4, 137);
            lblCaloriesCaption.Margin = new Padding(4, 0, 4, 0);
            lblCaloriesCaption.Name = "lblCaloriesCaption";
            lblCaloriesCaption.Size = new Size(129, 28);
            lblCaloriesCaption.TabIndex = 3;
            lblCaloriesCaption.Text = "Num Calories";
            // 
            // lblCurrentStatusCaption
            // 
            lblCurrentStatusCaption.Anchor = AnchorStyles.Left;
            lblCurrentStatusCaption.AutoSize = true;
            lblCurrentStatusCaption.Location = new Point(4, 179);
            lblCurrentStatusCaption.Margin = new Padding(4, 0, 4, 0);
            lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            lblCurrentStatusCaption.Size = new Size(135, 28);
            lblCurrentStatusCaption.TabIndex = 4;
            lblCurrentStatusCaption.Text = "Current Status";
            // 
            // lblStatusDatesCaption
            // 
            lblStatusDatesCaption.AutoSize = true;
            lblStatusDatesCaption.Location = new Point(4, 214);
            lblStatusDatesCaption.Margin = new Padding(4, 0, 4, 0);
            lblStatusDatesCaption.Name = "lblStatusDatesCaption";
            lblStatusDatesCaption.Size = new Size(119, 28);
            lblStatusDatesCaption.TabIndex = 5;
            lblStatusDatesCaption.Text = "Status Dates";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(147, 4);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(454, 34);
            txtRecipeName.TabIndex = 6;
            // 
            // lstUser
            // 
            lstUser.Dock = DockStyle.Fill;
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(147, 46);
            lstUser.Margin = new Padding(4);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(454, 36);
            lstUser.TabIndex = 7;
            // 
            // lstCuisineType
            // 
            lstCuisineType.Dock = DockStyle.Fill;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(147, 90);
            lstCuisineType.Margin = new Padding(4);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(454, 36);
            lstCuisineType.TabIndex = 8;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(147, 134);
            txtCalories.Margin = new Padding(4);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(454, 34);
            txtCalories.TabIndex = 9;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(149, 178);
            label7.Margin = new Padding(6);
            label7.Name = "label7";
            label7.Size = new Size(450, 30);
            label7.TabIndex = 10;
            // 
            // tblStatus
            // 
            tblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblStatus.AutoSize = true;
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2603951F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4792137F));
            tblStatus.Controls.Add(lblDateDraftedCaption, 0, 0);
            tblStatus.Controls.Add(lblDatePublishedCaption, 1, 0);
            tblStatus.Controls.Add(lblDateArchivedCaption, 2, 0);
            tblStatus.Controls.Add(lblDateDrafted, 0, 1);
            tblStatus.Controls.Add(lblDatePublished, 1, 1);
            tblStatus.Controls.Add(lblDateArchived, 2, 1);
            tblStatus.Location = new Point(147, 218);
            tblStatus.Margin = new Padding(4);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 72.9166641F));
            tblStatus.Size = new Size(454, 70);
            tblStatus.TabIndex = 11;
            // 
            // lblDateDraftedCaption
            // 
            lblDateDraftedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDraftedCaption.AutoSize = true;
            lblDateDraftedCaption.Location = new Point(3, 0);
            lblDateDraftedCaption.Name = "lblDateDraftedCaption";
            lblDateDraftedCaption.Size = new Size(145, 28);
            lblDateDraftedCaption.TabIndex = 0;
            lblDateDraftedCaption.Text = "Drafted";
            lblDateDraftedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDatePublishedCaption
            // 
            lblDatePublishedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublishedCaption.AutoSize = true;
            lblDatePublishedCaption.Location = new Point(154, 0);
            lblDatePublishedCaption.Name = "lblDatePublishedCaption";
            lblDatePublishedCaption.Size = new Size(144, 28);
            lblDatePublishedCaption.TabIndex = 1;
            lblDatePublishedCaption.Text = "Published";
            lblDatePublishedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateArchivedCaption
            // 
            lblDateArchivedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchivedCaption.AutoSize = true;
            lblDateArchivedCaption.Location = new Point(304, 0);
            lblDateArchivedCaption.Name = "lblDateArchivedCaption";
            lblDateArchivedCaption.Size = new Size(147, 28);
            lblDateArchivedCaption.TabIndex = 2;
            lblDateArchivedCaption.Text = "Archived";
            lblDateArchivedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.Silver;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Location = new Point(6, 34);
            lblDateDrafted.Margin = new Padding(6);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(139, 30);
            lblDateDrafted.TabIndex = 3;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.Silver;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Location = new Point(157, 34);
            lblDatePublished.Margin = new Padding(6);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(138, 30);
            lblDatePublished.TabIndex = 4;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.Silver;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Location = new Point(307, 34);
            lblDateArchived.Margin = new Padding(6);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(141, 30);
            lblDateArchived.TabIndex = 5;
            // 
            // tcRecipeTabs
            // 
            tcRecipeTabs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tcRecipeTabs.Controls.Add(tbIngredients);
            tcRecipeTabs.Controls.Add(tbSteps);
            tcRecipeTabs.Location = new Point(4, 372);
            tcRecipeTabs.Margin = new Padding(4);
            tcRecipeTabs.Name = "tcRecipeTabs";
            tcRecipeTabs.SelectedIndex = 0;
            tcRecipeTabs.Size = new Size(605, 346);
            tcRecipeTabs.TabIndex = 2;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(gIngredients);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Margin = new Padding(4);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(4);
            tbIngredients.Size = new Size(597, 305);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(4, 4);
            gIngredients.Margin = new Padding(4);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(589, 297);
            gIngredients.TabIndex = 0;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(gSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Margin = new Padding(4);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(4);
            tbSteps.Size = new Size(1039, 313);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(4, 4);
            gSteps.Margin = new Padding(4);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(1031, 305);
            gSteps.TabIndex = 0;
            // 
            // frmRecipeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 713);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeForm";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblRecipeInfo.ResumeLayout(false);
            tblRecipeInfo.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tcRecipeTabs.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private TableLayoutPanel tblRecipeInfo;
        private TabControl tcRecipeTabs;
        private TabPage tbIngredients;
        private DataGridView gIngredients;
        private TabPage tbSteps;
        private DataGridView gSteps;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
        private Label lblRecipeNameCaption;
        private Label lblUserCaption;
        private Label lblCuisineTypeCaption;
        private Label lblCaloriesCaption;
        private Label lblCurrentStatusCaption;
        private Label lblStatusDatesCaption;
        private TextBox txtRecipeName;
        private ComboBox lstUser;
        private ComboBox lstCuisineType;
        private TextBox txtCalories;
        private Label label7;
        private TableLayoutPanel tblStatus;
        private Label lblDateDraftedCaption;
        private Label lblDatePublishedCaption;
        private Label lblDateArchivedCaption;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
    }
}