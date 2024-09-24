namespace RecipeWinForms
{
    partial class frmLogin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUserid = new Label();
            lblPassword = new Label();
            txtUserid = new TextBox();
            txtPassword = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnLogin = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUserid, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUserid, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(609, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserid
            // 
            lblUserid.AutoSize = true;
            lblUserid.Font = new Font("Segoe UI", 12F);
            lblUserid.Location = new Point(3, 0);
            lblUserid.Name = "lblUserid";
            lblUserid.Size = new Size(108, 28);
            lblUserid.TabIndex = 0;
            lblUserid.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(3, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUserid
            // 
            txtUserid.Dock = DockStyle.Fill;
            txtUserid.Font = new Font("Segoe UI", 12F);
            txtUserid.Location = new Point(117, 3);
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(489, 34);
            txtUserid.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(117, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(489, 34);
            txtPassword.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(406, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(200, 44);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(103, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 200);
            Controls.Add(tableLayoutPanel1);
            Name = "frmLogin";
            Text = "Login RecipeApp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUserid;
        private Label lblPassword;
        private TextBox txtUserid;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnLogin;
        private Button btnCancel;
    }
}