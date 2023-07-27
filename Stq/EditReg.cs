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
        static string Bars;
        public EditReg()
        {
            InitializeComponent();
        }
        public EditReg(string bars)
        {
            InitializeComponent();
            Bars = bars;
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
                Home env = new Home(Bars, textProduto.Text, comboColor.Text, Convert.ToDecimal(textNewPeso.Text), comboPesoN.Text, Convert.ToDecimal(textNewValue.Text));
                var strConexao = "server=localhost;uid=root;database=stq";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexao;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update dados SET nome = @nome , color = @color,peso = @peso," +
                            " peso_kg = @peso_kg, preco = @preco where cod = @cod";
                       
                        cmd.Parameters.AddWithValue("@nome", textProduto.Text);
                        cmd.Parameters.AddWithValue("@color", comboColor.Text);
                        cmd.Parameters.AddWithValue("@peso", textNewPeso.Text);
                        cmd.Parameters.AddWithValue("@peso_kg", comboPesoN.Text);
                        cmd.Parameters.AddWithValue("@preco", textNewValue.Text);
                        cmd.Parameters.AddWithValue("@cod",Bars);
                        cmd.ExecuteNonQuery();
                    }

                    this.Close();
                }
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
