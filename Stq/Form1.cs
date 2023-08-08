using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Stq
{
    public partial class Form1 : Form
    {
        public int Bloq = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_inc()
        {
            textUser.Text = string.Empty;
            textPass.Text = string.Empty;
            labelPass.Visible = true;
            labelPass.Enabled = false;
            labelUser.Visible = true;
            labelUser.Enabled = false;
            textUser.Focus();
            MessageBox.Show("User ou Senha Invalidos!");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textPass.Text.Length >= 4)
            {

                var strconexao = "server=localhost;uid=root;database=stq";
                var conexao = new MySqlConnection(strconexao);
                conexao.Open();
                var cmd = new MySqlCommand("SELECT * FROM login where nome = @n", conexao);
                cmd.Parameters.AddWithValue("@n", textUser.Text);
                var readr = cmd.ExecuteReader();

                string user = string.Empty;
                string pass = string.Empty;
                int ver = 1;
                int tipo = 0;
                while (readr.Read())
                {
                    user = readr["nome"].ToString();
                    pass = readr["pass"].ToString();
                    tipo = Convert.ToInt32(readr["ver"]);
                    ver = Convert.ToInt32(readr["ver"]);
                    Bloq = Convert.ToInt32(readr["bloq"]);
                }

                conexao.Close();
                if (textUser.Text == user)
                {
                    if (textPass.Text == pass)
                    {
                        if (Bloq < 5)
                        {
                            Home home = new Home(ver, user);
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário bloqueado!");

                            textPass.Text = string.Empty;
                            labelPass.Visible = true;
                            labelPass.Enabled = false;
                            textUser.Focus();
                        }
                    }
                    else
                    {
                        if (Bloq >= 5)
                        {
                            MessageBox.Show("Usuário bloqueado!");
                        }
                        else if (tipo != 0)
                        {
                            conexao.Open();
                            Bloq = Bloq + 1;
                            cmd = new MySqlCommand("Update login set bloq = @bloq where nome = @n", conexao);
                            cmd.Parameters.AddWithValue("@bloq", Bloq);
                            cmd.Parameters.AddWithValue("@n", user);
                            cmd.ExecuteNonQuery();
                            conexao.Close();
                            textPass.Text = string.Empty;
                            labelPass.Visible = true;
                            labelPass.Enabled = false;
                            textPass.Focus();
                            MessageBox.Show("Tentativas de acesso: " + Bloq + "/5");
                        }
                        else
                        {
                            login_inc();
                        }
                    }
                }
                else
                {
                    login_inc();
                }
            }
            else
            {
                MessageBox.Show("A senha possuí no mínimo 4 dígitos");
            }

        }
        private void checkPass_Click(object sender, EventArgs e)
        {

            if (checkPass.Checked)
            {
                textPass.UseSystemPasswordChar = false;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
            }


        }
        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {
        }



        private void textUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (textUser.Text != string.Empty)
            {
                labelUser.Visible = false;
            }
            else
            {
                labelUser.Visible = true;
                labelUser.Visible = true;
            }
        }

        private void textPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (textPass.Text != string.Empty)
            {
                labelPass.Visible = false;
            }
            else
            {
                labelPass.Visible = true;
                labelPass.Enabled = false;
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

