using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stq
{
    public partial class EditReg : Form
    {
        static bool tru = false;
        private bool commaEntered = false;
        private static List<Listagem> list_tab = new List<Listagem>();
        static string Bars, User;
        public EditReg()
        {
            InitializeComponent();
        }
        public EditReg(string bars, string user)
        {
            InitializeComponent();
            Bars = bars;
            User = user;
            var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
            var conexao = new MySqlConnection(strConexao);
            conexao.Open(); // abre banco
            var cmd = new MySqlCommand("SELECT * FROM dados where cod = @cod", conexao);
            cmd.Parameters.AddWithValue("@cod", bars);
            var readr = cmd.ExecuteReader();

            decimal Tsystem = 0;
            while (readr.Read())
            {
                int quant = Convert.ToInt32(readr["quant"]);
                decimal peso = Convert.ToDecimal(readr["peso"]);
                decimal preco = Convert.ToDecimal(readr["preco"]);

                textProduto.Text = readr["nome"].ToString();
                comboColor.Text = readr["color"].ToString();
                textNewPeso.Text = peso.ToString("n2", CultureInfo.GetCultureInfo("pt-br"));
                comboPesoN.Text = readr["peso_kg"].ToString();
                textNewValue.Text = preco.ToString("n2", CultureInfo.GetCultureInfo("pt-br"));
            }


            readr.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (comboPesoN.Text != string.Empty || textProduto.Text != string.Empty && textNewPeso.Text != string.Empty && textNewValue.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd = new MySqlCommand("SELECT * FROM dados where cod = @cod", conexao);
                cmd.Parameters.AddWithValue("@cod", Bars);

                int old_quant = 0;
                var leitor = cmd.ExecuteReader();
                string cod = string.Empty;
                string prod = string.Empty;
                string color = string.Empty;
                decimal peso = 0;
                string peso_kg = string.Empty;
                decimal preco = 0;
                string us = string.Empty;
                DateTime dta = DateTime.Now;

                while (leitor.Read())
                {
                    prod = leitor["nome"].ToString();
                    old_quant = Convert.ToInt32(leitor["quant"]);
                    color = leitor["color"].ToString();
                    peso = Convert.ToDecimal(leitor["peso"]);
                    peso_kg = leitor["peso_kg"].ToString();
                    preco = Convert.ToDecimal(leitor["preco"]);
                    us = leitor["us"].ToString();
                    dta = Convert.ToDateTime(leitor["dt"]);
                }
                conexao.Close();


                conexao.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO historico (cod, nome, color,peso, peso_kg, quant, preco, us,dt) " +
                         "VALUES (@cod, @nome, @color, @peso, @peso_kg, @quant, @preco,@us1,@dt1)";
                cmd.Parameters.AddWithValue("@nome", prod);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@peso_kg", peso_kg);
                cmd.Parameters.AddWithValue("@quant", old_quant);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@us1", us);
                cmd.Parameters.AddWithValue("@dt1", dta);
                cmd.ExecuteNonQuery();
                conexao.Close();

                conexao.Open();

                cmd.Connection = conexao;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update dados Set nome = @no , color = @co,peso = @pe," +
                    " peso_kg = @kg, preco = @pre, us = @us, dt =@dt where cod = @cod";

                cmd.Parameters.AddWithValue("@no", textProduto.Text);
                cmd.Parameters.AddWithValue("@co", comboColor.Text);
                cmd.Parameters.AddWithValue("@pe", textNewPeso.Text);
                cmd.Parameters.AddWithValue("@kg", comboPesoN.Text);
                cmd.Parameters.AddWithValue("@pre", textNewValue.Text); 
                DateTime data = DateTime.Now;
                cmd.Parameters.AddWithValue("@us", User);
                cmd.Parameters.AddWithValue("@dt", data);
                cmd.ExecuteNonQuery();

                conexao.Close();


                this.Close();

            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
                textProduto.Text = string.Empty;
                comboColor.Text = string.Empty;
                textNewPeso.Text = string.Empty;
                textNewValue.Text = string.Empty;
                textProduto.Focus();

            }
        }




        private void textProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textNewPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if (tru)
                {
                    e.Handled = true; // Impede a entrada adicional de vírgula
                }
                else
                {
                    tru = true; // Marca a vírgula como já digitada
                }
            }
        }

        private void textNewValue_KeyPress(object sender, KeyPressEventArgs f)
        {
            if (!char.IsControl(f.KeyChar) && !char.IsDigit(f.KeyChar) && f.KeyChar != ',')
            {
                f.Handled = true;
            }
            else if (f.KeyChar == ',')
            {
                if (commaEntered)
                {
                    f.Handled = true; // Impede a entrada adicional de vírgula
                }
                else
                {
                    commaEntered = true; // Marca a vírgula como já digitada
                }
            }
        }

        private void comboPesoN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
