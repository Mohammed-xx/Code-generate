namespace Code_Generate
{
    partial class Main
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
            btnSql = new Button();
            btnDataAccess = new Button();
            btnBussines = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSql
            // 
            btnSql.BackColor = Color.AliceBlue;
            btnSql.Location = new Point(76, 217);
            btnSql.Name = "btnSql";
            btnSql.Size = new Size(139, 41);
            btnSql.TabIndex = 0;
            btnSql.Text = "SQL";
            btnSql.UseVisualStyleBackColor = false;
            btnSql.Click += btnSql_Click;
            // 
            // btnDataAccess
            // 
            btnDataAccess.BackColor = Color.AliceBlue;
            btnDataAccess.ForeColor = SystemColors.ActiveCaptionText;
            btnDataAccess.Location = new Point(320, 217);
            btnDataAccess.Name = "btnDataAccess";
            btnDataAccess.Size = new Size(139, 41);
            btnDataAccess.TabIndex = 1;
            btnDataAccess.Text = "DATA ACCESS";
            btnDataAccess.UseVisualStyleBackColor = false;
            btnDataAccess.Click += btnDataAccess_Click;
            // 
            // btnBussines
            // 
            btnBussines.BackColor = Color.AliceBlue;
            btnBussines.Location = new Point(561, 217);
            btnBussines.Name = "btnBussines";
            btnBussines.Size = new Size(139, 41);
            btnBussines.TabIndex = 2;
            btnBussines.Text = "BUSSINES";
            btnBussines.UseVisualStyleBackColor = false;
            btnBussines.Click += btnBussines_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = Properties.Resources._0cdec195_1810_4ba0_bbbd_6975c65c964b;
            pictureBox1.Location = new Point(300, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnBussines);
            Controls.Add(btnDataAccess);
            Controls.Add(btnSql);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSql;
        private Button btnDataAccess;
        private Button btnBussines;
        private PictureBox pictureBox1;
    }
}