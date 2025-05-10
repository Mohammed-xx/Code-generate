namespace Code_Generate.Pages
{
    partial class frmSql
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
            btnGenerate = new Button();
            txtGeneratorCode = new TextBox();
            cmbDatabases = new ComboBox();
            cmbTables = new ComboBox();
            cmbColumns = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(662, 352);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(99, 35);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtGeneratorCode
            // 
            txtGeneratorCode.Location = new Point(1, -1);
            txtGeneratorCode.Multiline = true;
            txtGeneratorCode.Name = "txtGeneratorCode";
            txtGeneratorCode.ScrollBars = ScrollBars.Both;
            txtGeneratorCode.Size = new Size(464, 640);
            txtGeneratorCode.TabIndex = 1;
            // 
            // cmbDatabases
            // 
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(471, 155);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 23);
            cmbDatabases.TabIndex = 2;
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // cmbTables
            // 
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(643, 157);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 23);
            cmbTables.TabIndex = 3;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // cmbColumns
            // 
            cmbColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColumns.FormattingEnabled = true;
            cmbColumns.Location = new Point(799, 158);
            cmbColumns.Name = "cmbColumns";
            cmbColumns.Size = new Size(121, 23);
            cmbColumns.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 137);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Databases";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(643, 139);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Tables";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(799, 140);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Columns";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 9);
            label4.Name = "label4";
            label4.Size = new Size(245, 63);
            label4.TabIndex = 8;
            label4.Text = "Sql Generator";
            // 
            // frmSql
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 638);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbColumns);
            Controls.Add(cmbTables);
            Controls.Add(cmbDatabases);
            Controls.Add(txtGeneratorCode);
            Controls.Add(btnGenerate);
            MaximizeBox = false;
            Name = "frmSql";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSql";
            Load += frmSql_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtGeneratorCode;
        private ComboBox cmbDatabases;
        private ComboBox cmbTables;
        private ComboBox cmbColumns;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}