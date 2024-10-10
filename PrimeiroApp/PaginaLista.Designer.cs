namespace PrimeiroApp
{
    partial class PaginaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaLista));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btrevisaraluguel = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lista_dos_alugueis;
            pictureBox1.Location = new Point(-5, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1040, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 421);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(89, 421);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // btrevisaraluguel
            // 
            btrevisaraluguel.BackColor = Color.FromArgb(5, 27, 60);
            btrevisaraluguel.Cursor = Cursors.Hand;
            btrevisaraluguel.FlatAppearance.BorderSize = 0;
            btrevisaraluguel.FlatStyle = FlatStyle.Flat;
            btrevisaraluguel.Font = new Font("Poppins Light", 11F);
            btrevisaraluguel.ForeColor = Color.White;
            btrevisaraluguel.Location = new Point(-8, 205);
            btrevisaraluguel.Name = "btrevisaraluguel";
            btrevisaraluguel.Size = new Size(165, 31);
            btrevisaraluguel.TabIndex = 32;
            btrevisaraluguel.Text = "Cadastrar Aluguéis";
            btrevisaraluguel.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 27, 60);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poppins Light", 11F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-5, 129);
            button3.Name = "button3";
            button3.Size = new Size(145, 29);
            button3.TabIndex = 31;
            button3.Text = "     Página Inicial         ";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(5, 27, 60);
            label1.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(647, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 22);
            label1.TabIndex = 35;
            label1.Text = "Adicionar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(5, 27, 60);
            label2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(772, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 22);
            label2.TabIndex = 35;
            label2.Text = "Editar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(5, 27, 60);
            label3.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(889, 105);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 35;
            label3.Text = "Remover";
            // 
            // PaginaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 541);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btrevisaraluguel);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaginaLista";
            Text = "PaginaLista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btrevisaraluguel;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}