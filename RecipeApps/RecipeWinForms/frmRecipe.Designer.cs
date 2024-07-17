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
            txtDateDraft = new TextBox();
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
            lstCuisineType = new ComboBox();
            lstUser = new ComboBox();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lblCurrentStatus = new Label();
            lblRecipePicture = new Label();
            tableLayoutPanel1.SuspendLayout();
            tblSaveDelete.SuspendLayout();
            SuspendLayout();
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 347);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(38, 20);
            lblUserCaption.TabIndex = 19;
            lblUserCaption.Text = "User";
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.Location = new Point(158, 217);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(425, 27);
            txtDateArchived.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left;
            txtDatePublished.Location = new Point(158, 175);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(425, 27);
            txtDatePublished.TabIndex = 12;
            // 
            // txtDateDraft
            // 
            txtDateDraft.Anchor = AnchorStyles.Left;
            txtDateDraft.Location = new Point(158, 133);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(425, 27);
            txtDateDraft.TabIndex = 11;
            // 
            // lblRecipePictureCaaption
            // 
            lblRecipePictureCaaption.Anchor = AnchorStyles.Left;
            lblRecipePictureCaaption.AutoSize = true;
            lblRecipePictureCaaption.Location = new Point(3, 305);
            lblRecipePictureCaaption.Name = "lblRecipePictureCaaption";
            lblRecipePictureCaaption.Size = new Size(103, 20);
            lblRecipePictureCaaption.TabIndex = 7;
            lblRecipePictureCaaption.Text = "Recipe Picture";
            // 
            // lblCurrentStatusCaption
            // 
            lblCurrentStatusCaption.Anchor = AnchorStyles.Left;
            lblCurrentStatusCaption.AutoSize = true;
            lblCurrentStatusCaption.Location = new Point(3, 263);
            lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            lblCurrentStatusCaption.Size = new Size(101, 20);
            lblCurrentStatusCaption.TabIndex = 6;
            lblCurrentStatusCaption.Text = "Current Status";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 221);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblDatePulished
            // 
            lblDatePulished.Anchor = AnchorStyles.Left;
            lblDatePulished.AutoSize = true;
            lblDatePulished.Location = new Point(3, 179);
            lblDatePulished.Name = "lblDatePulished";
            lblDatePulished.Size = new Size(109, 20);
            lblDatePulished.TabIndex = 4;
            lblDatePulished.Text = "Date Published";
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Left;
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 137);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(79, 20);
            lblDateDraft.TabIndex = 3;
            lblDateDraft.Text = "Date Draft";
            // 
            // lblCaloriesCaption
            // 
            lblCaloriesCaption.Anchor = AnchorStyles.Left;
            lblCaloriesCaption.AutoSize = true;
            lblCaloriesCaption.Location = new Point(3, 95);
            lblCaloriesCaption.Name = "lblCaloriesCaption";
            lblCaloriesCaption.Size = new Size(62, 20);
            lblCaloriesCaption.TabIndex = 2;
            lblCaloriesCaption.Text = "Calories";
            // 
            // lblCuisineTypeCaption
            // 
            lblCuisineTypeCaption.Anchor = AnchorStyles.Left;
            lblCuisineTypeCaption.AutoSize = true;
            lblCuisineTypeCaption.Location = new Point(3, 53);
            lblCuisineTypeCaption.Name = "lblCuisineTypeCaption";
            lblCuisineTypeCaption.Size = new Size(91, 20);
            lblCuisineTypeCaption.TabIndex = 1;
            lblCuisineTypeCaption.Text = "Cuisine Type";
            // 
            // lblRecipeNameCaption
            // 
            lblRecipeNameCaption.Anchor = AnchorStyles.Left;
            lblRecipeNameCaption.AutoSize = true;
            lblRecipeNameCaption.Location = new Point(3, 11);
            lblRecipeNameCaption.Name = "lblRecipeNameCaption";
            lblRecipeNameCaption.Size = new Size(98, 20);
            lblRecipeNameCaption.TabIndex = 0;
            lblRecipeNameCaption.Text = "Recipe Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4957256F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.50427F));
            tableLayoutPanel1.Controls.Add(lblRecipeNameCaption, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCuisineTypeCaption, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCaloriesCaption, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDateDraft, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDatePulished, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDateArchived, 0, 5);
            tableLayoutPanel1.Controls.Add(lblCurrentStatusCaption, 0, 6);
            tableLayoutPanel1.Controls.Add(lblRecipePictureCaaption, 0, 7);
            tableLayoutPanel1.Controls.Add(txtDateDraft, 1, 3);
            tableLayoutPanel1.Controls.Add(txtDatePublished, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDateArchived, 1, 5);
            tableLayoutPanel1.Controls.Add(lblUserCaption, 0, 8);
            tableLayoutPanel1.Controls.Add(tblSaveDelete, 1, 9);
            tableLayoutPanel1.Controls.Add(lstCuisineType, 1, 1);
            tableLayoutPanel1.Controls.Add(lstUser, 1, 8);
            tableLayoutPanel1.Controls.Add(txtRecipeName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtCalories, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCurrentStatus, 1, 6);
            tableLayoutPanel1.Controls.Add(lblRecipePicture, 1, 7);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1101236F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(586, 456);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tblSaveDelete
            // 
            tblSaveDelete.ColumnCount = 2;
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSaveDelete.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSaveDelete.Controls.Add(btnDelete, 1, 0);
            tblSaveDelete.Controls.Add(btnSave, 0, 0);
            tblSaveDelete.Location = new Point(158, 381);
            tblSaveDelete.Name = "tblSaveDelete";
            tblSaveDelete.RowCount = 1;
            tblSaveDelete.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSaveDelete.Size = new Size(250, 72);
            tblSaveDelete.TabIndex = 21;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(128, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(158, 45);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(192, 28);
            lstCuisineType.TabIndex = 22;
            // 
            // lstUser
            // 
            lstUser.FormattingEnabled = true;
            lstUser.Location = new Point(158, 339);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(192, 28);
            lstUser.TabIndex = 23;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(158, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(425, 27);
            txtRecipeName.TabIndex = 24;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(158, 87);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(425, 27);
            txtCalories.TabIndex = 25;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = Color.White;
            lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Font = new Font("Segoe UI", 9F);
            lblCurrentStatus.Location = new Point(158, 252);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(425, 42);
            lblCurrentStatus.TabIndex = 26;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.BackColor = Color.White;
            lblRecipePicture.BorderStyle = BorderStyle.FixedSingle;
            lblRecipePicture.Dock = DockStyle.Fill;
            lblRecipePicture.Font = new Font("Segoe UI", 9F);
            lblRecipePicture.Location = new Point(158, 294);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(425, 42);
            lblRecipePicture.TabIndex = 27;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 452);
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
        private TextBox txtDateDraft;
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
    }
}