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
    public partial class PaginaRemover : Form
    {

        string connectionString = @"Server=IAN; Database=registrarapp; Trusted_Connection=True; TrustServerCertificate=True;";

        public PaginaRemover()
        {
            InitializeComponent();
            CarregarAlugueis();
        }

        private void CarregarAlugueis()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT NomeCliente, TelefoneCliente, Conteudo, TempoConteudo, Preco FROM Alugueis";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string registro = $"{reader["NomeCliente"]} ; {reader["TelefoneCliente"]} ; {reader["Conteudo"]} ; {reader["TempoConteudo"]} ; {reader["Preco"]}";
                            cbAlugueis.Items.Add(registro); 
                        }
                    }
                }
            }
        }

        private void PaginaRemover_Load(object sender, EventArgs e)
        {


        }


        private void btexcluircad_Click(object sender, EventArgs e)
        {

            
        }


        private void btexcluircad_Click_1(object sender, EventArgs e)
        {
            if (cbAlugueis.SelectedItem != null)
            {

                string selectedAluguel = cbAlugueis.SelectedItem.ToString();

                string[] dados = selectedAluguel.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string nomeCliente = dados[0].Trim();


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Alugueis WHERE NomeCliente = @NomeCliente", connection);
                    command.Parameters.AddWithValue("@NomeCliente", nomeCliente);


                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro excluído com sucesso!");

                        cbAlugueis.Items.Remove(selectedAluguel);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum cadastro encontrado para excluir.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cadastro para excluir.");
            }
        }
    }
}
