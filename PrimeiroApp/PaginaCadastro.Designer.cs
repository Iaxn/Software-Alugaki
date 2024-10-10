namespace PrimeiroApp
{
    partial class PaginaCadastro
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
            txtFname = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            txtPhone = new TextBox();
            cmbGender = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFname
            // 
            txtFname.BackColor = Color.White;
            txtFname.Cursor = Cursors.IBeam;
            txtFname.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(195, 161);
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = " Seu primeiro nome";
            txtFname.Size = new Size(164, 25);
            txtFname.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(153, 256);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " @ Seu email completo";
            txtEmail.Size = new Size(206, 25);
            txtEmail.TabIndex = 18;
            // 
            // txtLname
            // 
            txtLname.BackColor = Color.White;
            txtLname.Cursor = Cursors.IBeam;
            txtLname.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(195, 208);
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = " Seu ultimo nome";
            txtLname.Size = new Size(164, 25);
            txtLname.TabIndex = 19;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(547, 224);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = " Sua senha";
            txtPass.Size = new Size(141, 25);
            txtPass.TabIndex = 20;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.Cursor = Cursors.IBeam;
            txtUser.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(547, 159);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = " Seu usuário";
            txtUser.Size = new Size(141, 25);
            txtUser.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Cursor = Cursors.IBeam;
            txtPhone.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(547, 289);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = " Telefone";
            txtPhone.Size = new Size(141, 25);
            txtPhone.TabIndex = 22;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.Cursor = Cursors.Hand;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro não listado", "Prefiro não dizer" });
            cmbGender.Location = new Point(153, 311);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(206, 30);
            cmbGender.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(12, 36, 73);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 378);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 25;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 36, 73);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(656, 378);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(123, 33);
            button2.TabIndex = 25;
            button2.Text = "Concluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(11, 40, 77);
            label4.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 166);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 26;
            label4.Text = "Primeiro nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(11, 40, 77);
            label5.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(86, 208);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 26;
            label5.Text = "Ultimo nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(8, 36, 75);
            label6.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(88, 255);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 26;
            label6.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(7, 34, 74);
            label10.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(86, 311);
            label10.Name = "label10";
            label10.Size = new Size(59, 23);
            label10.TabIndex = 26;
            label10.Text = "Genêro:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.FromArgb(12, 36, 73);
            checkBox1.BackgroundImageLayout = ImageLayout.None;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 6F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(697, 230);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 15);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Tornar Vísivel";
            checkBox1.TextImageRelation = TextImageRelation.ImageAboveText;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cadastro_tela;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 450);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // PaginaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(checkBox1);
            Controls.Add(txtPhone);
            Controls.Add(txtFname);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbGender);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(txtLname);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PaginaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alugaki - Cadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFname;
        private TextBox txtEmail;
        private TextBox txtLname;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtPhone;
        private ComboBox cmbGender;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}