namespace PrimeiroApp
{
    partial class PaginaRevisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaRevisar));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btcadastraraluguel = new Button();
            button3 = new Button();
            tabelaClientes = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.lista_dos_alugueis;
            pictureBox1.Location = new Point(-3, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1045, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(5, 27, 60);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(91, 425);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // btcadastraraluguel
            // 
            btcadastraraluguel.BackColor = Color.FromArgb(5, 27, 60);
            btcadastraraluguel.Cursor = Cursors.Hand;
            btcadastraraluguel.FlatAppearance.BorderSize = 0;
            btcadastraraluguel.FlatStyle = FlatStyle.Flat;
            btcadastraraluguel.Font = new Font("Poppins Light", 9F);
            btcadastraraluguel.ForeColor = Color.White;
            btcadastraraluguel.Location = new Point(-3, 208);
            btcadastraraluguel.Name = "btcadastraraluguel";
            btcadastraraluguel.Size = new Size(155, 31);
            btcadastraraluguel.TabIndex = 32;
            btcadastraraluguel.Text = "Cadastrar Aluguel";
            btcadastraraluguel.UseVisualStyleBackColor = false;
            btcadastraraluguel.Click += btcadastraraluguel_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(5, 27, 60);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poppins Light", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 134);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 31;
            button3.Text = "Página Inicial";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tabelaClientes
            // 
            tabelaClientes.AccessibleRole = AccessibleRole.MenuBar;
            tabelaClientes.AllowUserToAddRows = false;
            tabelaClientes.AllowUserToDeleteRows = false;
            tabelaClientes.AllowUserToResizeColumns = false;
            tabelaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(5, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            tabelaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabelaClientes.BackgroundColor = Color.FromArgb(5, 27, 60);
            tabelaClientes.BorderStyle = BorderStyle.None;
            tabelaClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tabelaClientes.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            tabelaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle2.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(5, 40, 60);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabelaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabelaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle3.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabelaClientes.DefaultCellStyle = dataGridViewCellStyle3;
            tabelaClientes.GridColor = Color.FromArgb(5, 27, 60);
            tabelaClientes.Location = new Point(261, 156);
            tabelaClientes.Name = "tabelaClientes";
            tabelaClientes.ReadOnly = true;
            tabelaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tabelaClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tabelaClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle5.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(5, 27, 60);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            tabelaClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tabelaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaClientes.Size = new Size(705, 295);
            tabelaClientes.TabIndex = 36;
            tabelaClientes.CellContentClick += tabelaClientes_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(5, 27, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-3, 278);
            button1.Name = "button1";
            button1.Size = new Size(155, 41);
            button1.TabIndex = 37;
            button1.Text = "Excluir Aluguel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PaginaRevisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 549);
            Controls.Add(button1);
            Controls.Add(tabelaClientes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(btcadastraraluguel);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaginaRevisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaginaRevisar";
            Load += PaginaRevisar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btcadastraraluguel;
        private Button button3;
        private DataGridView tabelaClientes;
        private Button button1;
    }
}