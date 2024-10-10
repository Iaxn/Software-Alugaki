using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PrimeiroApp
{
    public partial class PaginaCadastro : Form
    {
        public PaginaCadastro()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("Um ou mais campos estão vazios, por favor verifique e tente novamente =)");
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=IAN;Initial Catalog=registrarapp;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "INSERT INTO register VALUES (@fname, @lastname, @gender, @email, @username, @password, @phone)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrado com sucesso!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new PaginaLogin().Show();
                this.Hide();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PaginaLogin().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
