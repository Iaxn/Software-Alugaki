namespace PrimeiroApp
{
    partial class PaginaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaLogin));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Cursor = Cursors.IBeam;
            txtUser.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ImeMode = ImeMode.NoControl;
            txtUser.Location = new Point(115, 177);
            txtUser.Margin = new Padding(0);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "  Insira seu usuário ";
            txtUser.Size = new Size(191, 25);
            txtUser.TabIndex = 9;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Poppins Light", 8F);
            txtPassword.Location = new Point(115, 235);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "   Insira sua senha";
            txtPassword.Size = new Size(191, 23);
            txtPassword.TabIndex = 9;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(12, 36, 78);
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Poppins Light", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 365);
            label1.Name = "label1";
            label1.Size = new Size(172, 22);
            label1.TabIndex = 14;
            label1.Text = "Cadastrar uma nova conta";
            label1.Click += label1_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Tela_login;
            pictureBox1.Location = new Point(-2, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(862, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(11, 40, 77);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(84, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(11, 40, 77);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(84, 356);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(222, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(12, 36, 78);
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 283);
            label2.Name = "label2";
            label2.Size = new Size(44, 22);
            label2.TabIndex = 17;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PaginaLogin";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alugaki - Cadastro de aluguéis";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        public TextBox txtUser;
    }
}
