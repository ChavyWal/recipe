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
            lblUser = new Label();
            lblUserCaption = new Label();
            lblCalories = new Label();
            lblCuisineType = new Label();
            lblRecipeName = new Label();
            txtRecipePicture = new TextBox();
            txtCurrentStatus = new TextBox();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDraft = new TextBox();
            lblRecipePicture = new Label();
            lblCurrentStatus = new Label();
            lblDateArchived = new Label();
            lblDatePulished = new Label();
            lblDateDraft = new Label();
            lblCaloriesCaption = new Label();
            lblCuisineTypeCaption = new Label();
            lblRecipeNameCaption = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.White;
            lblUser.BorderStyle = BorderStyle.FixedSingle;
            lblUser.Location = new Point(158, 354);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(267, 22);
            lblUser.TabIndex = 20;
            lblUser.Tag = " ";
            lblUser.Text = "                                                                ";
            // 
            // lblUserCaption
            // 
            lblUserCaption.Anchor = AnchorStyles.Left;
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 355);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(38, 20);
            lblUserCaption.TabIndex = 19;
            lblUserCaption.Text = "User";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Left;
            lblCalories.AutoSize = true;
            lblCalories.BackColor = Color.White;
            lblCalories.BorderStyle = BorderStyle.FixedSingle;
            lblCalories.Location = new Point(158, 96);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(283, 22);
            lblCalories.TabIndex = 18;
            lblCalories.Text = "                                                                    ";
            // 
            // lblCuisineType
            // 
            lblCuisineType.Anchor = AnchorStyles.Left;
            lblCuisineType.AutoSize = true;
            lblCuisineType.BackColor = Color.White;
            lblCuisineType.BorderStyle = BorderStyle.FixedSingle;
            lblCuisineType.Location = new Point(158, 53);
            lblCuisineType.Name = "lblCuisineType";
            lblCuisineType.Size = new Size(283, 22);
            lblCuisineType.TabIndex = 17;
            lblCuisineType.Text = "                                                                    ";
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.White;
            lblRecipeName.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeName.Location = new Point(158, 10);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(283, 22);
            lblRecipeName.TabIndex = 16;
            lblRecipeName.Text = "                                                                    ";
            // 
            // txtRecipePicture
            // 
            txtRecipePicture.Anchor = AnchorStyles.Left;
            txtRecipePicture.Location = new Point(158, 309);
            txtRecipePicture.Name = "txtRecipePicture";
            txtRecipePicture.Size = new Size(425, 27);
            txtRecipePicture.TabIndex = 15;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Anchor = AnchorStyles.Left;
            txtCurrentStatus.Location = new Point(158, 266);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(425, 27);
            txtCurrentStatus.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.Location = new Point(158, 223);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(425, 27);
            txtDateArchived.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left;
            txtDatePublished.Location = new Point(158, 180);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(425, 27);
            txtDatePublished.TabIndex = 12;
            // 
            // txtDateDraft
            // 
            txtDateDraft.Anchor = AnchorStyles.Left;
            txtDateDraft.Location = new Point(158, 137);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(425, 27);
            txtDateDraft.TabIndex = 11;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.Anchor = AnchorStyles.Left;
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.Location = new Point(3, 312);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(103, 20);
            lblRecipePicture.TabIndex = 7;
            lblRecipePicture.Text = "Recipe Picture";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 269);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(101, 20);
            lblCurrentStatus.TabIndex = 6;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 226);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblDatePulished
            // 
            lblDatePulished.Anchor = AnchorStyles.Left;
            lblDatePulished.AutoSize = true;
            lblDatePulished.Location = new Point(3, 183);
            lblDatePulished.Name = "lblDatePulished";
            lblDatePulished.Size = new Size(109, 20);
            lblDatePulished.TabIndex = 4;
            lblDatePulished.Text = "Date Published";
            // 
            // lblDateDraft
            // 
            lblDateDraft.Anchor = AnchorStyles.Left;
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 140);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(79, 20);
            lblDateDraft.TabIndex = 3;
            lblDateDraft.Text = "Date Draft";
            // 
            // lblCaloriesCaption
            // 
            lblCaloriesCaption.Anchor = AnchorStyles.Left;
            lblCaloriesCaption.AutoSize = true;
            lblCaloriesCaption.Location = new Point(3, 97);
            lblCaloriesCaption.Name = "lblCaloriesCaption";
            lblCaloriesCaption.Size = new Size(62, 20);
            lblCaloriesCaption.TabIndex = 2;
            lblCaloriesCaption.Text = "Calories";
            // 
            // lblCuisineTypeCaption
            // 
            lblCuisineTypeCaption.Anchor = AnchorStyles.Left;
            lblCuisineTypeCaption.AutoSize = true;
            lblCuisineTypeCaption.Location = new Point(3, 54);
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
            tableLayoutPanel1.Controls.Add(lblCurrentStatus, 0, 6);
            tableLayoutPanel1.Controls.Add(lblRecipePicture, 0, 7);
            tableLayoutPanel1.Controls.Add(txtDateDraft, 1, 3);
            tableLayoutPanel1.Controls.Add(txtDatePublished, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDateArchived, 1, 5);
            tableLayoutPanel1.Controls.Add(txtCurrentStatus, 1, 6);
            tableLayoutPanel1.Controls.Add(txtRecipePicture, 1, 7);
            tableLayoutPanel1.Controls.Add(lblCuisineType, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCalories, 1, 2);
            tableLayoutPanel1.Controls.Add(lblUserCaption, 0, 8);
            tableLayoutPanel1.Controls.Add(lblUser, 1, 8);
            tableLayoutPanel1.Controls.Add(lblRecipeName, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1112347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1101236F));
            tableLayoutPanel1.Size = new Size(586, 387);
            tableLayoutPanel1.TabIndex = 0;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblUserCaption;
        private Label lblCalories;
        private Label lblCuisineType;
        private Label lblRecipeName;
        private TextBox txtRecipePicture;
        private TextBox txtCurrentStatus;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDraft;
        private Label lblRecipePicture;
        private Label lblCurrentStatus;
        private Label lblDateArchived;
        private Label lblDatePulished;
        private Label lblDateDraft;
        private Label lblCaloriesCaption;
        private Label lblCuisineTypeCaption;
        private Label lblRecipeNameCaption;
        private TableLayoutPanel tableLayoutPanel1;
    }
}