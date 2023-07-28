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
            var strconexao = "server=localhost;uid=root;database=stq";
            var conexao = new MySqlConnection(strconexao);
            conexao.Open();
            var cmd = new MySqlCommand("SELECT * FROM login where nome = @n AND pass = @p",conexao);
            cmd.Parameters.AddWithValue("@n", textUser.Text);
            cmd.Parameters.AddWithValue("@p", textPass.Text);
            var readr = cmd.ExecuteReader();

            string user = string.Empty;
            string pass = string.Empty;
            int ver = 1;
            while (readr.Read())
            {
                user = readr["nome"].ToString();
                pass = readr["pass"].ToString();
                ver = Convert.ToInt32(readr["ver"]);
                MessageBox.Show(ver.ToString());
            }

           
            if (textUser.Text == user && textPass.Text == pass)
            {
                Home home = new Home(ver,user);
                home.Show();
                this.Hide();
            }
            else { login_inc(); }
            
        }
        private void checkPass_Click(object sender, EventArgs e)
        {

            if (checkPass.Checked)
            {
                textPass.UseSystemPasswordChar = false;
            }
            else { textPass.UseSystemPasswordChar = true; }


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

