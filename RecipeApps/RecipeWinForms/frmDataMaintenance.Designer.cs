namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            flpRadioButtons = new FlowLayoutPanel();
            rdbUsers = new RadioButton();
            rdbCuisineType = new RadioButton();
            rdbIngredients = new RadioButton();
            rdbMeasurmentType = new RadioButton();
            rdbCourses = new RadioButton();
            tblData = new TableLayoutPanel();
            gDataMaintenance = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            flpRadioButtons.SuspendLayout();
            tblData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.825882F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.17412F));
            tblMain.Controls.Add(flpRadioButtons, 0, 0);
            tblMain.Controls.Add(tblData, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1051, 630);
            tblMain.TabIndex = 0;
            // 
            // flpRadioButtons
            // 
            flpRadioButtons.Controls.Add(rdbUsers);
            flpRadioButtons.Controls.Add(rdbCuisineType);
            flpRadioButtons.Controls.Add(rdbIngredients);
            flpRadioButtons.Controls.Add(rdbMeasurmentType);
            flpRadioButtons.Controls.Add(rdbCourses);
            flpRadioButtons.Dock = DockStyle.Fill;
            flpRadioButtons.FlowDirection = FlowDirection.TopDown;
            flpRadioButtons.Location = new Point(3, 3);
            flpRadioButtons.Name = "flpRadioButtons";
            flpRadioButtons.Size = new Size(339, 624);
            flpRadioButtons.TabIndex = 0;
            // 
            // rdbUsers
            // 
            rdbUsers.AutoSize = true;
            rdbUsers.Checked = true;
            rdbUsers.Location = new Point(3, 3);
            rdbUsers.Name = "rdbUsers";
            rdbUsers.Size = new Size(80, 32);
            rdbUsers.TabIndex = 0;
            rdbUsers.TabStop = true;
            rdbUsers.Text = "Users";
            rdbUsers.UseVisualStyleBackColor = true;
            // 
            // rdbCuisineType
            // 
            rdbCuisineType.AutoSize = true;
            rdbCuisineType.Location = new Point(3, 41);
            rdbCuisineType.Name = "rdbCuisineType";
            rdbCuisineType.Size = new Size(103, 32);
            rdbCuisineType.TabIndex = 1;
            rdbCuisineType.Text = "Cuisines";
            rdbCuisineType.UseVisualStyleBackColor = true;
            // 
            // rdbIngredients
            // 
            rdbIngredients.AutoSize = true;
            rdbIngredients.Location = new Point(3, 79);
            rdbIngredients.Name = "rdbIngredients";
            rdbIngredients.Size = new Size(131, 32);
            rdbIngredients.TabIndex = 2;
            rdbIngredients.Text = "Ingredients";
            rdbIngredients.UseVisualStyleBackColor = true;
            // 
            // rdbMeasurmentType
            // 
            rdbMeasurmentType.AutoSize = true;
            rdbMeasurmentType.Location = new Point(3, 117);
            rdbMeasurmentType.Name = "rdbMeasurmentType";
            rdbMeasurmentType.Size = new Size(160, 32);
            rdbMeasurmentType.TabIndex = 3;
            rdbMeasurmentType.Text = "Measurements";
            rdbMeasurmentType.UseVisualStyleBackColor = true;
            // 
            // rdbCourses
            // 
            rdbCourses.AutoSize = true;
            rdbCourses.Location = new Point(3, 155);
            rdbCourses.Name = "rdbCourses";
            rdbCourses.Size = new Size(101, 32);
            rdbCourses.TabIndex = 4;
            rdbCourses.Text = "Courses";
            rdbCourses.UseVisualStyleBackColor = true;
            // 
            // tblData
            // 
            tblData.ColumnCount = 1;
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblData.Controls.Add(gDataMaintenance, 0, 0);
            tblData.Controls.Add(btnSave, 0, 1);
            tblData.Dock = DockStyle.Fill;
            tblData.Location = new Point(348, 3);
            tblData.Name = "tblData";
            tblData.RowCount = 2;
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3589745F));
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6410255F));
            tblData.Size = new Size(700, 624);
            tblData.TabIndex = 1;
            // 
            // gDataMaintenance
            // 
            gDataMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataMaintenance.Dock = DockStyle.Fill;
            gDataMaintenance.Location = new Point(3, 3);
            gDataMaintenance.Name = "gDataMaintenance";
            gDataMaintenance.RowHeadersWidth = 51;
            gDataMaintenance.Size = new Size(694, 302);
            gDataMaintenance.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(564, 564);
            btnSave.Margin = new Padding(12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            flpRadioButtons.ResumeLayout(false);
            flpRadioButtons.PerformLayout();
            tblData.ResumeLayout(false);
            tblData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel flpRadioButtons;
        private RadioButton rdbUsers;
        private RadioButton rdbCuisineType;
        private RadioButton rdbIngredients;
        private RadioButton rdbMeasurmentType;
        private RadioButton rdbCourses;
        private TableLayoutPanel tblData;
        private DataGridView gDataMaintenance;
        private Button btnSave;
    }
}