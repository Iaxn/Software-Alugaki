namespace PrimeiroApp
{
    partial class PaginaCadastrarAluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaCadastrarAluguel));
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btrevisaraluguel = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtNomeCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            txtCPF = new TextBox();
            txtPreco = new TextBox();
            txtTempoConteudo = new TextBox();
            txtConteudo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(836, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 27, 60);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poppins Light", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-4, 151);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 26;
            button3.Text = "Página Inicial";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // btrevisaraluguel
            // 
            btrevisaraluguel.BackColor = Color.FromArgb(5, 27, 60);
            btrevisaraluguel.Cursor = Cursors.Hand;
            btrevisaraluguel.FlatAppearance.BorderSize = 0;
            btrevisaraluguel.FlatStyle = FlatStyle.Flat;
            btrevisaraluguel.Font = new Font("Poppins Light", 9F);
            btrevisaraluguel.ForeColor = Color.White;
            btrevisaraluguel.Location = new Point(-4, 211);
            btrevisaraluguel.Name = "btrevisaraluguel";
            btrevisaraluguel.Size = new Size(115, 31);
            btrevisaraluguel.TabIndex = 27;
            btrevisaraluguel.Text = "Revisar Aluguéis";
            btrevisaraluguel.UseVisualStyleBackColor = false;
            btrevisaraluguel.Click += btrevisaraluguel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(104, 329);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BorderStyle = BorderStyle.None;
            txtNomeCliente.Font = new Font("Poppins Light", 11F);
            txtNomeCliente.Location = new Point(286, 145);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(205, 22);
            txtNomeCliente.TabIndex = 31;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.BorderStyle = BorderStyle.None;
            txtTelefoneCliente.Font = new Font("Poppins Light", 11F);
            txtTelefoneCliente.Location = new Point(286, 208);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(205, 22);
            txtTelefoneCliente.TabIndex = 31;
            // 
            // txtCPF
            // 
            txtCPF.BorderStyle = BorderStyle.None;
            txtCPF.Font = new Font("Poppins Light", 11F);
            txtCPF.Location = new Point(558, 271);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(205, 22);
            txtCPF.TabIndex = 31;
            txtCPF.TextChanged += textBox3_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Font = new Font("Poppins Light", 11F);
            txtPreco.Location = new Point(559, 208);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(205, 22);
            txtPreco.TabIndex = 31;
            txtPreco.TextChanged += textBox3_TextChanged;
            // 
            // txtTempoConteudo
            // 
            txtTempoConteudo.BorderStyle = BorderStyle.None;
            txtTempoConteudo.Font = new Font("Poppins Light", 11F);
            txtTempoConteudo.Location = new Point(558, 145);
            txtTempoConteudo.Name = "txtTempoConteudo";
            txtTempoConteudo.Size = new Size(205, 22);
            txtTempoConteudo.TabIndex = 31;
            txtTempoConteudo.TextChanged += textBox3_TextChanged;
            // 
            // txtConteudo
            // 
            txtConteudo.BorderStyle = BorderStyle.None;
            txtConteudo.Font = new Font("Poppins Light", 11F);
            txtConteudo.Location = new Point(285, 272);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(205, 22);
            txtConteudo.TabIndex = 31;
            txtConteudo.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(11, 40, 77);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Poppins Light", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(632, 346);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 32;
            label1.Text = "Concluir cadastro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(11, 40, 77);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Poppins Light", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(293, 344);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 32;
            label2.Text = "          Voltar         ";
            label2.Click += label2_Click;
            // 
            // PaginaCadastrarAluguel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTempoConteudo);
            Controls.Add(txtPreco);
            Controls.Add(txtConteudo);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btrevisaraluguel);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaginaCadastrarAluguel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaginaCadastrarAluguel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private Button btrevisaraluguel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtNomeCliente;
        private TextBox txtTelefoneCliente;
        private TextBox txtCPF;
        private TextBox txtPreco;
        private TextBox txtTempoConteudo;
        private TextBox txtConteudo;
        private Label label1;
        private Label label2;
    }
}