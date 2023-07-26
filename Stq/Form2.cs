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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassR.Text == string.Empty)
            {
                MessageBox.Show("Senha Aceita!");
                Home rem = new Home(textRemovedor_Reg.Text);

                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                MySqlCommand cmd = new MySqlCommand("DELETE FROM dados WHERE cod = @cod",conexao); //deletar
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@cod",MySqlDbType.String).Value = textRemovedor_Reg.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                
            }
            else
            {
                
                MessageBox.Show("Senha Incorreta!");
                
                textPassR.Text = string.Empty;
                textRemovedor_Reg.Text = string.Empty;
                textRemovedor_Reg.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
