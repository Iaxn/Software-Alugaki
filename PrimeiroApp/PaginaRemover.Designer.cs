namespace PrimeiroApp
{
    partial class PaginaRemover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaRemover));
            cbAlugueis = new ComboBox();
            btexcluircad = new Button();
            pictureBox1 = new PictureBox();
            btrevisaraluguel = new Button();
            button3 = new Button();
            btcadastrarAluguel = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbAlugueis
            // 
            cbAlugueis.FormattingEnabled = true;
            cbAlugueis.Location = new Point(446, 258);
            cbAlugueis.Name = "cbAlugueis";
            cbAlugueis.Size = new Size(380, 23);
            cbAlugueis.TabIndex = 0;
            // 
            // btexcluircad
            // 
            btexcluircad.BackColor = Color.FromArgb(6, 30, 74);
            btexcluircad.Cursor = Cursors.Hand;
            btexcluircad.FlatAppearance.BorderSize = 0;
            btexcluircad.FlatStyle = FlatStyle.Flat;
            btexcluircad.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btexcluircad.ForeColor = Color.White;
            btexcluircad.Location = new Point(502, 383);
            btexcluircad.Name = "btexcluircad";
            btexcluircad.Size = new Size(267, 53);
            btexcluircad.TabIndex = 1;
            btexcluircad.Text = "Excluir cadastro";
            btexcluircad.UseVisualStyleBackColor = false;
            btexcluircad.Click += btexcluircad_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1049, 555);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btrevisaraluguel
            // 
            btrevisaraluguel.BackColor = Color.FromArgb(5, 27, 60);
            btrevisaraluguel.Cursor = Cursors.Hand;
            btrevisaraluguel.FlatAppearance.BorderSize = 0;
            btrevisaraluguel.FlatStyle = FlatStyle.Flat;
            btrevisaraluguel.Font = new Font("Poppins Light", 9F);
            btrevisaraluguel.ForeColor = Color.White;
            btrevisaraluguel.Location = new Point(-5, 255);
            btrevisaraluguel.Name = "btrevisaraluguel";
            btrevisaraluguel.Size = new Size(155, 31);
            btrevisaraluguel.TabIndex = 29;
            btrevisaraluguel.Text = "Revisar Aluguéis";
            btrevisaraluguel.UseVisualStyleBackColor = false;
            btrevisaraluguel.Click += btrevisaraluguel_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 27, 60);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poppins Light", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-5, 183);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 28;
            button3.Text = "Página Inicial";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btcadastrarAluguel
            // 
            btcadastrarAluguel.BackColor = Color.FromArgb(5, 27, 60);
            btcadastrarAluguel.Cursor = Cursors.Hand;
            btcadastrarAluguel.FlatAppearance.BorderSize = 0;
            btcadastrarAluguel.FlatStyle = FlatStyle.Flat;
            btcadastrarAluguel.Font = new Font("Poppins Light", 9F);
            btcadastrarAluguel.ForeColor = Color.White;
            btcadastrarAluguel.Location = new Point(-5, 330);
            btcadastrarAluguel.Name = "btcadastrarAluguel";
            btcadastrarAluguel.Size = new Size(155, 31);
            btcadastrarAluguel.TabIndex = 30;
            btcadastrarAluguel.Text = "Cadastrar Aluguéis";
            btcadastrarAluguel.UseVisualStyleBackColor = false;
            btcadastrarAluguel.Click += btcadastrarAluguel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(89, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PaginaRemover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 549);
            Controls.Add(pictureBox2);
            Controls.Add(btcadastrarAluguel);
            Controls.Add(btrevisaraluguel);
            Controls.Add(button3);
            Controls.Add(btexcluircad);
            Controls.Add(cbAlugueis);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "PaginaRemover";
            Text = "PaginaRemover";
            Load += PaginaRemover_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbAlugueis;
        private Button btexcluircad;
        private PictureBox pictureBox1;
        private Button btrevisaraluguel;
        private Button button3;
        private Button btcadastrarAluguel;
        private PictureBox pictureBox2;
    }
}