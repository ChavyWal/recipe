namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            lblConcatCurrentStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDraftedCaption = new Label();
            lblPublishedCaption = new Label();
            lblArchivedCaption = new Label();
            lblDateDraft = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tblStatusButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublished = new Button();
            btnArchived = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblStatusButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblConcatCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(tblStatusButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(760, 379);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 28);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(754, 38);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblConcatCurrentStatus
            // 
            lblConcatCurrentStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblConcatCurrentStatus.AutoSize = true;
            lblConcatCurrentStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConcatCurrentStatus.Location = new Point(3, 125);
            lblConcatCurrentStatus.Name = "lblConcatCurrentStatus";
            lblConcatCurrentStatus.Size = new Size(754, 31);
            lblConcatCurrentStatus.TabIndex = 1;
            lblConcatCurrentStatus.Text = "Current Status:";
            lblConcatCurrentStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblDates
            // 
            tblDates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblDates.ColumnCount = 4;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(lblDraftedCaption, 1, 0);
            tblDates.Controls.Add(lblPublishedCaption, 2, 0);
            tblDates.Controls.Add(lblArchivedCaption, 3, 0);
            tblDates.Controls.Add(lblDateDraft, 1, 1);
            tblDates.Controls.Add(lblDatePublished, 2, 1);
            tblDates.Controls.Add(lblDateArchived, 3, 1);
            tblDates.Location = new Point(3, 191);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(754, 88);
            tblDates.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 44);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(182, 44);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDraftedCaption
            // 
            lblDraftedCaption.AutoSize = true;
            lblDraftedCaption.Dock = DockStyle.Fill;
            lblDraftedCaption.Location = new Point(191, 0);
            lblDraftedCaption.Name = "lblDraftedCaption";
            lblDraftedCaption.Size = new Size(182, 44);
            lblDraftedCaption.TabIndex = 1;
            lblDraftedCaption.Text = "Drafted";
            lblDraftedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPublishedCaption
            // 
            lblPublishedCaption.AutoSize = true;
            lblPublishedCaption.Dock = DockStyle.Fill;
            lblPublishedCaption.Location = new Point(379, 0);
            lblPublishedCaption.Name = "lblPublishedCaption";
            lblPublishedCaption.Size = new Size(182, 44);
            lblPublishedCaption.TabIndex = 2;
            lblPublishedCaption.Text = "Published";
            lblPublishedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblArchivedCaption
            // 
            lblArchivedCaption.AutoSize = true;
            lblArchivedCaption.Dock = DockStyle.Fill;
            lblArchivedCaption.Location = new Point(567, 0);
            lblArchivedCaption.Name = "lblArchivedCaption";
            lblArchivedCaption.Size = new Size(184, 44);
            lblArchivedCaption.TabIndex = 3;
            lblArchivedCaption.Text = "Archived";
            lblArchivedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDateDraft
            // 
            lblDateDraft.AutoSize = true;
            lblDateDraft.BackColor = SystemColors.ControlDark;
            lblDateDraft.Dock = DockStyle.Fill;
            lblDateDraft.Location = new Point(191, 44);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(182, 44);
            lblDateDraft.TabIndex = 4;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = SystemColors.ControlDark;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(379, 44);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(182, 44);
            lblDatePublished.TabIndex = 5;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = SystemColors.ControlDark;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(567, 44);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(184, 44);
            lblDateArchived.TabIndex = 6;
            // 
            // tblStatusButtons
            // 
            tblStatusButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblStatusButtons.ColumnCount = 3;
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusButtons.Controls.Add(btnDraft, 0, 0);
            tblStatusButtons.Controls.Add(btnPublished, 1, 0);
            tblStatusButtons.Controls.Add(btnArchived, 2, 0);
            tblStatusButtons.Location = new Point(3, 285);
            tblStatusButtons.Name = "tblStatusButtons";
            tblStatusButtons.RowCount = 1;
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusButtons.Size = new Size(754, 91);
            tblStatusButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(20, 20);
            btnDraft.Margin = new Padding(20);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(211, 51);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublished
            // 
            btnPublished.Dock = DockStyle.Fill;
            btnPublished.Location = new Point(271, 20);
            btnPublished.Margin = new Padding(20);
            btnPublished.Name = "btnPublished";
            btnPublished.Size = new Size(211, 51);
            btnPublished.TabIndex = 1;
            btnPublished.Text = "Published";
            btnPublished.UseVisualStyleBackColor = true;
            // 
            // btnArchived
            // 
            btnArchived.Dock = DockStyle.Fill;
            btnArchived.Location = new Point(522, 20);
            btnArchived.Margin = new Padding(20);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(212, 51);
            btnArchived.TabIndex = 2;
            btnArchived.Text = "Archived";
            btnArchived.UseVisualStyleBackColor = true;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 379);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblStatusButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblConcatCurrentStatus;
        private TableLayoutPanel tblDates;
        private TableLayoutPanel tblStatusButtons;
        private Label lblStatusDates;
        private Label lblDraftedCaption;
        private Label lblPublishedCaption;
        private Label lblArchivedCaption;
        private Label lblDateDraft;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnDraft;
        private Button btnPublished;
        private Button btnArchived;
    }
}