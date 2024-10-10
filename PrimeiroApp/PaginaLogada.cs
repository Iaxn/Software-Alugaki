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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PrimeiroApp;

namespace PrimeiroApp
{
    public partial class PaginaLogada : Form
    {
        bool sideBarExpand;
       


        private string username; // Campo para armazenar o username

        public PaginaLogada(string ndusuario)
        {
            InitializeComponent();

            

            lbmenu.Visible = false;
            btcadastraraluguel.Visible = false;
            btrevisaraluguel.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            this.username = ndusuario; // Armazena o username

            SqlConnection con = new SqlConnection("Data Source=IAN;Initial Catalog=registrarapp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string insertQuery = "SELECT fname FROM register WHERE username = @username";
            SqlCommand cmd = new SqlCommand(insertQuery, con);

            cmd.Parameters.AddWithValue("@username", username);

            SqlDataReader reader = cmd.ExecuteReader();

            // Se houver resultado, definir o valor na label
            if (reader.Read())
            {
                string fname = reader["fname"].ToString();
                lbWelcome.Text = "Bem Vindo(a), " + fname;
                lbidentificador.Text = username;
            }
        }




        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PaginaCadastrarAluguel().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            new PaginaLogin().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {

                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    lbmenu.Visible = false;
                    btcadastraraluguel.Visible = false;
                    btrevisaraluguel.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                    sideBarExpand = false;
                    sideBarTimer.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    lbmenu.Visible = true;
                    btrevisaraluguel.Visible = true;
                    btcadastraraluguel.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;

                    sideBarExpand = true;
                    sideBarTimer.Stop();

                }

            }


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alugueistimer_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
