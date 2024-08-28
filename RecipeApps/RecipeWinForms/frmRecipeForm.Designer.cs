﻿namespace RecipeWinForms
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
            tcRecipeTabs = new TabControl();
            tbIngredients = new TabPage();
            tblIngredient = new TableLayoutPanel();
            gIngredients = new DataGridView();
            btnSaveIngredients = new Button();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            gSteps = new DataGridView();
            btnSaveSteps = new Button();
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
            lblCurrentStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblDateDraftedCaption = new Label();
            lblDatePublishedCaption = new Label();
            lblDateArchivedCaption = new Label();
            lblDateDraft = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tcRecipeTabs.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tblRecipeInfo.SuspendLayout();
            tblStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(tcRecipeTabs, 0, 2);
            tblMain.Controls.Add(tblRecipeInfo, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1186, 690);
            tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
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
            tblButtons.Size = new Size(1184, 60);
            tblButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(7, 7);
            btnSave.Margin = new Padding(7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(423, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(444, 7);
            btnDelete.Margin = new Padding(7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(457, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(1031, 7);
            btnChangeStatus.Margin = new Padding(7);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(146, 46);
            btnChangeStatus.TabIndex = 3;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tcRecipeTabs
            // 
            tcRecipeTabs.Controls.Add(tbIngredients);
            tcRecipeTabs.Controls.Add(tbSteps);
            tcRecipeTabs.Dock = DockStyle.Fill;
            tcRecipeTabs.Location = new Point(4, 372);
            tcRecipeTabs.Margin = new Padding(4);
            tcRecipeTabs.Name = "tcRecipeTabs";
            tcRecipeTabs.SelectedIndex = 0;
            tcRecipeTabs.Size = new Size(1184, 317);
            tcRecipeTabs.TabIndex = 2;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredient);
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Margin = new Padding(4);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(4);
            tbIngredients.Size = new Size(1176, 276);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredient
            // 
            tblIngredient.AutoSize = true;
            tblIngredient.ColumnCount = 1;
            tblIngredient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredient.Controls.Add(gIngredients, 0, 1);
            tblIngredient.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredient.Dock = DockStyle.Fill;
            tblIngredient.Location = new Point(4, 4);
            tblIngredient.Name = "tblIngredient";
            tblIngredient.RowCount = 2;
            tblIngredient.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8936167F));
            tblIngredient.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1063843F));
            tblIngredient.Size = new Size(1168, 268);
            tblIngredient.TabIndex = 1;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(4, 43);
            gIngredients.Margin = new Padding(4);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(1160, 221);
            gIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveIngredients.AutoSize = true;
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(94, 33);
            btnSaveIngredients.TabIndex = 1;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Margin = new Padding(4);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(4);
            tbSteps.Size = new Size(1176, 394);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(4, 4);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5896654F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 85.41033F));
            tblSteps.Size = new Size(1168, 386);
            tblSteps.TabIndex = 1;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(4, 60);
            gSteps.Margin = new Padding(4);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(1160, 322);
            gSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 50);
            btnSaveSteps.TabIndex = 1;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // tblRecipeInfo
            // 
            tblRecipeInfo.AutoSize = true;
            tblRecipeInfo.ColumnCount = 2;
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle());
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle());
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
            tblRecipeInfo.Controls.Add(lblCurrentStatus, 1, 4);
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
            tblRecipeInfo.Size = new Size(1184, 292);
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
            txtRecipeName.Size = new Size(1033, 34);
            txtRecipeName.TabIndex = 6;
            // 
            // lstUser
            // 
            lstUser.Dock = DockStyle.Fill;
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(147, 46);
            lstUser.Margin = new Padding(4);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(1033, 36);
            lstUser.TabIndex = 7;
            // 
            // lstCuisineType
            // 
            lstCuisineType.Dock = DockStyle.Fill;
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(147, 90);
            lstCuisineType.Margin = new Padding(4);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(1033, 36);
            lstCuisineType.TabIndex = 8;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(147, 134);
            txtCalories.Margin = new Padding(4);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(1033, 34);
            txtCalories.TabIndex = 9;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = Color.LightGray;
            lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentStatus.Location = new Point(149, 178);
            lblCurrentStatus.Margin = new Padding(6);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(1029, 30);
            lblCurrentStatus.TabIndex = 10;
            // 
            // tblStatus
            // 
            tblStatus.AutoSize = true;
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2603951F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4792137F));
            tblStatus.Controls.Add(lblDateDraftedCaption, 0, 0);
            tblStatus.Controls.Add(lblDatePublishedCaption, 1, 0);
            tblStatus.Controls.Add(lblDateArchivedCaption, 2, 0);
            tblStatus.Controls.Add(lblDateDraft, 0, 1);
            tblStatus.Controls.Add(lblDatePublished, 1, 1);
            tblStatus.Controls.Add(lblDateArchived, 2, 1);
            tblStatus.Dock = DockStyle.Top;
            tblStatus.Location = new Point(147, 218);
            tblStatus.Margin = new Padding(4);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 72.9166641F));
            tblStatus.Size = new Size(1033, 70);
            tblStatus.TabIndex = 11;
            // 
            // lblDateDraftedCaption
            // 
            lblDateDraftedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDraftedCaption.AutoSize = true;
            lblDateDraftedCaption.Location = new Point(3, 0);
            lblDateDraftedCaption.Name = "lblDateDraftedCaption";
            lblDateDraftedCaption.Size = new Size(338, 28);
            lblDateDraftedCaption.TabIndex = 0;
            lblDateDraftedCaption.Text = "Drafted";
            lblDateDraftedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDatePublishedCaption
            // 
            lblDatePublishedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublishedCaption.AutoSize = true;
            lblDatePublishedCaption.Location = new Point(347, 0);
            lblDatePublishedCaption.Name = "lblDatePublishedCaption";
            lblDatePublishedCaption.Size = new Size(337, 28);
            lblDatePublishedCaption.TabIndex = 1;
            lblDatePublishedCaption.Text = "Published";
            lblDatePublishedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateArchivedCaption
            // 
            lblDateArchivedCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchivedCaption.AutoSize = true;
            lblDateArchivedCaption.Location = new Point(690, 0);
            lblDateArchivedCaption.Name = "lblDateArchivedCaption";
            lblDateArchivedCaption.Size = new Size(340, 28);
            lblDateArchivedCaption.TabIndex = 2;
            lblDateArchivedCaption.Text = "Archived";
            lblDateArchivedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateDraft.AutoSize = true;
            lblDateDraft.BackColor = Color.Silver;
            lblDateDraft.BorderStyle = BorderStyle.FixedSingle;
            lblDateDraft.Location = new Point(6, 34);
            lblDateDraft.Margin = new Padding(6);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(332, 30);
            lblDateDraft.TabIndex = 3;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.Silver;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Location = new Point(350, 34);
            lblDatePublished.Margin = new Padding(6);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(331, 30);
            lblDatePublished.TabIndex = 4;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.Silver;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Location = new Point(693, 34);
            lblDateArchived.Margin = new Padding(6);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(334, 30);
            lblDateArchived.TabIndex = 5;
            // 
            // frmRecipeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 690);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeForm";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tcRecipeTabs.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tbIngredients.PerformLayout();
            tblIngredient.ResumeLayout(false);
            tblIngredient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tblRecipeInfo.ResumeLayout(false);
            tblRecipeInfo.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
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
        private TextBox txtRecipeName;
        private ComboBox lstUser;
        private ComboBox lstCuisineType;
        private TextBox txtCalories;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblIngredient;
        private Button btnSaveIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private Label lblStatusDatesCaption;
        private TableLayoutPanel tblStatus;
        private Label lblDateDraftedCaption;
        private Label lblDatePublishedCaption;
        private Label lblDateArchivedCaption;
        private Label lblDateDraft;
        private Label lblDatePublished;
        private Label lblDateArchived;
    }
}