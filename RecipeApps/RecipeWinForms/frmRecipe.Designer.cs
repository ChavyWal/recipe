namespace RecipeWinForms
{
    partial class frmRecipe
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
            lblUserCaption = new Label();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            lblRecipePictureCaaption = new Label();
            lblCurrentStatusCaption = new Label();
            lblDateArchived = new Label();
            lblDatePulished = new Label();
            lblDateDraft = new Label();
            lblCaloriesCaption = new Label();
            lblCuisineTypeCaption = new Label();
            lblRecipeNameCaption = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblSaveDelete = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            lstUser = new ComboBox();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lblCurrentStatus = new Label();
            lblRecipePicture = new Label();
            dtpDateDraft = new DateTimePicker();
            lstCuisineType = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tblSaveDelete.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 274);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(38, 20);
            lblUserCaption.TabIndex = 19;
            lblUserCaption.Text = "User";
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.Location = new Point(118, 169);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(425, 27);
            txtDateArchived.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left;
            txtDatePublished.Location = new Point(118, 136);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(425, 27);
            txtDatePublished.TabIndex = 12;
            // 
            // lblRecipePictureCaaption
            // 
            lblRecipePictureCaaption.Anchor = AnchorStyles.Left;
            lblRecipePictureCaaption.AutoSize = true;
            lblRecipePictureCaaption.Location = new Point(3, 246);
            lblRecipePictureCaaption.Name = "lblRecipePictureCaaption";
            lblRecipePictureCaaption.Size = new Size(103, 20);
            lblRecipePictureCaaption.TabIndex = 7;
            lblRecipePictureCaaption.Text = "Recipe Picture";
            // 
            // lblCurrentStatusCaption
            // 
            lblCurrentStatusCaption.Anchor = AnchorStyles.Left;
            lblCurrentStatusCaption.AutoSize = true;
            lblCurrentStatusCaption.Location = new Point(3, 212);
            lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            lblCurrentStatusCaption.Size = new Size(101, 20);
            lblCurrentStatusCaption.TabIndex = 6;
            lblCurrentStatusCaption.Text = "Current Status";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 172);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblDatePulished
            // 
            lblDatePulished.Anchor = AnchorStyles.Left;
            lblDatePulished.AutoSize = true;
            lblDatePulished.Location = new Point(3, 139);
            lblDatePulished.Name = "lblDatePulished";
            lblDatePulished.Size = new Size(109, 20);
            lblDatePulished.TabIndex = 4;
            lblDatePulished.Text = "Date Published";
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Left;
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 106);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(79, 20);
            lblDateDraft.TabIndex = 3;
            lblDateDraft.Text = "Date Draft";
            // 
            // lblCaloriesCaption
            // 
            lblCaloriesCaption.Anchor = AnchorStyles.Left;
            lblCaloriesCaption.AutoSize = true;
            lblCaloriesCaption.Location = new Point(3, 73);
            lblCaloriesCaption.Name = "lblCaloriesCaption";
            lblCaloriesCaption.Size = new Size(62, 20);
            lblCaloriesCaption.TabIndex = 2;
            lblCaloriesCaption.Text = "Calories";
            // 
            // lblCuisineTypeCaption
            // 
            lblCuisineTypeCaption.Anchor = AnchorStyles.Left;
            lblCuisineTypeCaption.AutoSize = true;
            lblCuisineTypeCaption.Location = new Point(3, 40);
            lblCuisineTypeCaption.Name = "lblCuisineTypeCaption";
            lblCuisineTypeCaption.Size = new Size(91, 20);
            lblCuisineTypeCaption.TabIndex = 1;
            lblCuisineTypeCaption.Text = "Cuisine Type";
            // 
            // lblRecipeNameCaption
            // 
            lblRecipeNameCaption.Anchor = AnchorStyles.Left;
            lblRecipeNameCaption.AutoSize = true;
            lblRecipeNameCaption.Location = new Point(3, 6);
            lblRecipeNameCaption.Name = "lblRecipeNameCaption";
            lblRecipeNameCaption.Size = new Size(98, 20);
            lblRecipeNameCaption.TabIndex = 0;
            lblRecipeNameCaption.Text = "Recipe Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblRecipeNameCaption, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCuisineTypeCaption, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCaloriesCaption, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDateDraft, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDatePulished, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDateArchived, 0, 5);
            tableLayoutPanel1.Controls.Add(lblCurrentStatusCaption, 0, 6);
            tableLayoutPanel1.Controls.Add(lblRecipePictureCaaption, 0, 7);
            tableLayoutPanel1.Controls.Add(txtDatePublished, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDateArchived, 1, 5);
            tableLayoutPanel1.Controls.Add(lblUserCaption, 0, 8);
            tableLayoutPanel1.Controls.Add(tblSaveDelete, 1, 9);
            tableLayoutPanel1.Controls.Add(lstUser, 1, 8);
            tableLayoutPanel1.Controls.Add(txtRecipeName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtCalories, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCurrentStatus, 1, 6);
            tableLayoutPanel1.Controls.Add(lblRecipePicture, 1, 7);
            tableLayoutPanel1.Controls.Add(dtpDateDraft, 1, 3);
            tableLayoutPanel1.Controls.Add(lstCuisineType, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.19263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 556F));
            tableLayoutPanel1.Size = new Size(1156, 925);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tblSaveDelete
            // 
            tblSaveDelete.ColumnCount = 2;
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSaveDelete.Controls.Add(btnDelete, 1, 0);
            tblSaveDelete.Controls.Add(btnSave, 0, 0);
            tblSaveDelete.Location = new Point(118, 304);
            tblSaveDelete.Name = "tblSaveDelete";
            tblSaveDelete.RowCount = 1;
            tblSaveDelete.RowStyles.Add(new RowStyle());
            tblSaveDelete.Size = new Size(250, 62);
            tblSaveDelete.TabIndex = 21;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(131, 6);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(6, 6);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lstUser
            // 
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(118, 270);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(192, 28);
            lstUser.TabIndex = 23;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(118, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(1035, 27);
            txtRecipeName.TabIndex = 24;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(118, 70);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(1035, 27);
            txtCalories.TabIndex = 25;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.BackColor = Color.White;
            lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentStatus.Font = new Font("Segoe UI", 9F);
            lblCurrentStatus.Location = new Point(118, 207);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(435, 30);
            lblCurrentStatus.TabIndex = 26;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.BackColor = Color.White;
            lblRecipePicture.BorderStyle = BorderStyle.FixedSingle;
            lblRecipePicture.Dock = DockStyle.Fill;
            lblRecipePicture.Font = new Font("Segoe UI", 9F);
            lblRecipePicture.Location = new Point(118, 245);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(1035, 22);
            lblRecipePicture.TabIndex = 27;
            // 
            // dtpDateDraft
            // 
            dtpDateDraft.Dock = DockStyle.Fill;
            dtpDateDraft.Enabled = false;
            dtpDateDraft.Location = new Point(118, 103);
            dtpDateDraft.Name = "dtpDateDraft";
            dtpDateDraft.Size = new Size(1035, 27);
            dtpDateDraft.TabIndex = 28;
            dtpDateDraft.Value = new DateTime(2024, 7, 18, 12, 35, 40, 0);
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(118, 36);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(192, 28);
            lstCuisineType.TabIndex = 22;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 925);
            Controls.Add(tableLayoutPanel1);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblSaveDelete.ResumeLayout(false);
            tblSaveDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserCaption;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private Label lblRecipePictureCaaption;
        private Label lblCurrentStatusCaption;
        private Label lblDateArchived;
        private Label lblDatePulished;
        private Label lblDateDraft;
        private Label lblCaloriesCaption;
        private Label lblCuisineTypeCaption;
        private Label lblRecipeNameCaption;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblSaveDelete;
        private Button btnDelete;
        private Button btnSave;
        private ComboBox lstCuisineType;
        private ComboBox lstUser;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblCurrentStatus;
        private Label lblRecipePicture;
        private DateTimePicker dtpDateDraft;
    }
}