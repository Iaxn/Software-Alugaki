using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.Xml;
using static Sessao.SessaoGlobal;

namespace PrimeiroApp
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
            var nUsuario = txtUser.Text;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            new PaginaCadastro().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=IAN;Initial Catalog=registrarapp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();


            string query = "SELECT fname,username FROM register WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SessaoUsuario.NomeUsuario = reader["fname"].ToString();
                SessaoUsuario.IdUsuario = reader["username"].ToString();
                

                PaginaLogada pagLogada = new PaginaLogada();
                pagLogada.NomeUsuario = txtUser.Text;



                pagLogada.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falha no login, verifique seu usu�rio ou senha e tente novamente.", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}


