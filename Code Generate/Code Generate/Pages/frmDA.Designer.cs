namespace Code_Generate.Pages
{
    partial class frmDA
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbColumns = new ComboBox();
            cmbTables = new ComboBox();
            cmbDatabases = new ComboBox();
            txtGeneratorCode = new TextBox();
            btnGenerate = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(805, 153);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 15;
            label3.Text = "Columns";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(649, 152);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "Tables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 150);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Databases";
            // 
            // cmbColumns
            // 
            cmbColumns.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColumns.FormattingEnabled = true;
            cmbColumns.Location = new Point(805, 171);
            cmbColumns.Name = "cmbColumns";
            cmbColumns.Size = new Size(121, 23);
            cmbColumns.TabIndex = 12;
            // 
            // cmbTables
            // 
            cmbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(649, 170);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 23);
            cmbTables.TabIndex = 11;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // cmbDatabases
            // 
            cmbDatabases.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(477, 168);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 23);
            cmbDatabases.TabIndex = 10;
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // txtGeneratorCode
            // 
            txtGeneratorCode.Location = new Point(7, 5);
            txtGeneratorCode.Multiline = true;
            txtGeneratorCode.Name = "txtGeneratorCode";
            txtGeneratorCode.ScrollBars = ScrollBars.Both;
            txtGeneratorCode.Size = new Size(464, 640);
            txtGeneratorCode.TabIndex = 9;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(668, 358);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(99, 35);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(649, 9);
            label4.Name = "label4";
            label4.Size = new Size(245, 63);
            label4.TabIndex = 16;
            label4.Text = "DA Generator";
            // 
            // frmDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 651);
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
            Name = "frmDA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDA";
            Load += frmDA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbColumns;
        private ComboBox cmbTables;
        private ComboBox cmbDatabases;
        private TextBox txtGeneratorCode;
        private Button btnGenerate;
        private Label label4;
    }
}