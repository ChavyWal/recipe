namespace RecipeWinForms
{
    partial class frmCookbookAutoCreate
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
            lstUsers = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.31858F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6814156F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tblMain.Controls.Add(lstUsers, 0, 1);
            tblMain.Controls.Add(btnCreateCookbook, 2, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(627, 296);
            tblMain.TabIndex = 0;
            // 
            // lstUsers
            // 
            lstUsers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(3, 129);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(348, 36);
            lstUsers.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateCookbook.Location = new Point(458, 128);
            btnCreateCookbook.Margin = new Padding(6, 3, 6, 3);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(163, 38);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmCookbookAutoCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 296);
            Controls.Add(tblMain);
            Name = "frmCookbookAutoCreate";
            Text = "CookbookAutoCreate";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUsers;
        private Button btnCreateCookbook;
    }
}