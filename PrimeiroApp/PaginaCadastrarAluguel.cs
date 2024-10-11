using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sessao.SessaoGlobal;

namespace PrimeiroApp
{
    public partial class PaginaCadastrarAluguel : Form
    {
        public string NomeUsuario { get; set; }
        public PaginaCadastrarAluguel()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            SessaoUsuario.LimparSessao();
            new PaginaLogin().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            PaginaLogada pagLog = new PaginaLogada();
            pagLog.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PaginaLogada pagLog = new PaginaLogada();
            pagLog.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) ||
       string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) ||
       string.IsNullOrWhiteSpace(txtConteudo.Text) ||
       string.IsNullOrWhiteSpace(txtTempoConteudo.Text) ||
       string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            using (SqlConnection con = new SqlConnection("Data Source=IAN;Initial Catalog=registrarapp;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                string insertQuery = "INSERT INTO Alugueis (username, NomeCliente, TelefoneCliente, Conteudo, TempoConteudo, Preco, CPF) " +
                                     "VALUES (@username, @nomeCliente, @telefoneCliente, @conteudo, @tempoConteudo, @preco, @cpf)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@username", SessaoUsuario.IdUsuario); 
                cmd.Parameters.AddWithValue("@nomeCliente", txtNomeCliente.Text);
                cmd.Parameters.AddWithValue("@telefoneCliente", txtTelefoneCliente.Text);
                cmd.Parameters.AddWithValue("@conteudo", txtConteudo.Text);
                cmd.Parameters.AddWithValue("@tempoConteudo", txtTempoConteudo.Text);
                cmd.Parameters.AddWithValue("@preco", decimal.TryParse(txtPreco.Text, out decimal preco) ? preco : 0);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text); 

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluguel cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o aluguel: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
