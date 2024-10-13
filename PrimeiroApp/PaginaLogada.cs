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
using Sessao;
using static Sessao.SessaoGlobal;

namespace PrimeiroApp
{
    public partial class PaginaLogada : Form
    {

        bool sideBarExpand;





        public PaginaLogada()
        {
            InitializeComponent();

            lbmenu.Visible = false;
            btcadastraraluguel.Visible = false;
            button1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button3.Visible = false;




        }

        public string NomeUsuario { get; set; }




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

        private void btRevisarAluguel(object sender, EventArgs e)
        {
            new PaginaRevisar().Show();
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {

                sidebar.Width -= 20;
                lbmenu.Visible = false;
                btcadastraraluguel.Visible = false;
                button1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                button3.Visible = false;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {


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
                    button1.Visible = true;
                    btcadastraraluguel.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    button3.Visible = true;

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

        private void PaginaLogada_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Bem Vindo(a), " + SessaoUsuario.NomeUsuario;
            lbidentificador.Text = "ID: " + SessaoUsuario.IdUsuario;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PaginaRevisar previstar = new PaginaRevisar();
            previstar.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PaginaRemover premover = new PaginaRemover();
            premover.Show();
            this.Hide();
        }
    }
}

