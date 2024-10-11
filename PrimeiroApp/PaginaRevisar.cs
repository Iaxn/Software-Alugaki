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
using Sessao;

namespace PrimeiroApp
{
    public partial class PaginaRevisar : Form
    {
        public PaginaRevisar()
        {
            InitializeComponent();
        }
        private void PaginaRevisar_Load(object sender, EventArgs e)
        {
            CarregarAlugueis();
            EstilizarTabelaClientes();
        }

        private void CarregarAlugueis()
        {

            string connectionString = "Data Source=IAN;Initial Catalog=registrarapp;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT NomeCliente, TelefoneCliente, Conteudo, TempoConteudo, Preco, CPF FROM Alugueis WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", SessaoUsuario.IdUsuario);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    tabelaClientes.DataSource = dt; // Atualiza o DataGridView
                }
            }
        }

        private void EstilizarTabelaClientes()
        {

            tabelaClientes.EnableHeadersVisualStyles = false;
            tabelaClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 27, 60);
            tabelaClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            tabelaClientes.Columns["NomeCliente"].HeaderText = "Cliente";
            tabelaClientes.Columns["TelefoneCliente"].HeaderText = "Telefone";
            tabelaClientes.Columns["Conteudo"].HeaderText = "Conteúdo";
            tabelaClientes.Columns["TempoConteudo"].HeaderText = "Dias";
            tabelaClientes.Columns["Preco"].HeaderText = "Preço";
            tabelaClientes.Columns["CPF"].HeaderText = "CPF";
        }

        private void tabelaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaginaLogada paglog = new PaginaLogada();
            paglog.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SessaoUsuario.LimparSessao();
            new PaginaLogin().Show();
            this.Hide();
        }

        private void btcadastraraluguel_Click(object sender, EventArgs e)
        {
            new PaginaCadastrarAluguel().Show();
            this.Hide();
        }

        private void lbeditar_Click(object sender, EventArgs e)
        {

        }

        private void lbremover_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaginaRemover pagre = new PaginaRemover();
            pagre.Show();
            this.Hide();
        }
    }
}

