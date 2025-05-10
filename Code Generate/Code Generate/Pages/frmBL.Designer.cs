namespace Code_Generate.Pages
{
    partial class FrmBL
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbColumns = new ComboBox();
            cmbTables = new ComboBox();
            cmbDatabases = new ComboBox();
            txtGeneratorCode = new TextBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(609, 12);
            label4.Name = "label4";
            label4.Size = new Size(237, 63);
            label4.TabIndex = 17;
            label4.Text = "BL Generator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(810, 153);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 16;
            label3.Text = "Columns";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 152);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Tables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 150);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 14;
            label1.Text = "Databases";
            // 
            // cmbColumns
            // 
            cmbColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColumns.FormattingEnabled = true;
            cmbColumns.Location = new Point(810, 171);
            cmbColumns.Name = "cmbColumns";
            cmbColumns.Size = new Size(121, 23);
            cmbColumns.TabIndex = 13;
            // 
            // cmbTables
            // 
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(654, 170);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 23);
            cmbTables.TabIndex = 12;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // cmbDatabases
            // 
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(482, 168);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 23);
            cmbDatabases.TabIndex = 11;
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // txtGeneratorCode
            // 
            txtGeneratorCode.Location = new Point(12, 12);
            txtGeneratorCode.Multiline = true;
            txtGeneratorCode.Name = "txtGeneratorCode";
            txtGeneratorCode.ScrollBars = ScrollBars.Both;
            txtGeneratorCode.Size = new Size(464, 640);
            txtGeneratorCode.TabIndex = 10;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(673, 365);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(99, 35);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // FrmBL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 659);
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
            Name = "FrmBL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBL";
            Load += frmBL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbColumns;
        private ComboBox cmbTables;
        private ComboBox cmbDatabases;
        private TextBox txtGeneratorCode;
        private Button btnGenerate;
    }
}