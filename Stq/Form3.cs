﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Stq
{
    public partial class Form3 : Form
    {
        static List<string> code_bars = new List<string>();
        static string User;

        public Form3(string user)
        {
            InitializeComponent();
            User = user;
        }
        private void verificado()
        {
            var strc = "server=localhost;uid=root;database=stq";
            var conexao = new MySqlConnection(strc);
            var cmd = new MySqlCommand(("SELECT * FROM dados"), conexao);
            conexao.Open();
            var read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read["nome"].ToString() == textProd.Text)
                {
                    {
                        MessageBox.Show("Falha na operação! Nome já cadastrado!");
                        textProd.Text = string.Empty;
                        textProd.Focus();
                        break;
                    }
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private int null_error()
        {
            verificado();
            if (comboPesoName.Text == string.Empty || textProd.Text == string.Empty || textPreco.Text == string.Empty || textPeso.Text == string.Empty || textQuant.Text == string.Empty)
            {
                textProd.Focus();
                MessageBox.Show("Preencha todos os campos! ");
                return 0;
            }
            else { return 1; }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int ver = null_error();
            if (ver == 1)
            {
                int v = 1;
                string cod;
                do
                {
                    Random numAleatorio = new Random();
                    int cod_1 = numAleatorio.Next(100000000, 999999999);
                    int cod_2 = numAleatorio.Next(1000, 9999);
                    cod = cod_1.ToString() + cod_2.ToString();
                    code_bars.Add(cod);
                    foreach (string obj in code_bars)
                    {
                        if (obj != cod)
                        {
                            v = 0;
                        }
                    }

                } while (v != 0);
                var strConexao = "server=localhost;uid=root;database=stq";
                using (var conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = conexao;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO dados (cod, nome, color,peso, peso_kg, quant, preco, us,dt) " +
                                          "VALUES (@cod, @nome, @color, @peso, @peso_kg, @quant, @preco,@us,@dt)";
                        cmd.Parameters.AddWithValue("@cod", cod); 
                        cmd.Parameters.AddWithValue("@nome", textProd.Text);
                        cmd.Parameters.AddWithValue("@color", comboColor.Text);
                        cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(textPeso.Text));
                        cmd.Parameters.AddWithValue("@peso_kg", comboPesoName.Text);
                        cmd.Parameters.AddWithValue("@quant", textQuant.Text);
                        cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(textPreco.Text));
                        DateTime data = DateTime.Now;
                        cmd.Parameters.AddWithValue("@us", User);
                        cmd.Parameters.AddWithValue("@dt", data);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto " + textProd.Text + " adicionado com sucesso!");
                this.Close();
                MessageBox.Show(textPreco.Text);
            }
        }



        private bool commaEntered = false;
        private bool tru = false;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textPreco_KeyPress(object sender, KeyPressEventArgs f)
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

        private void textQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPeso_KeyPress(object sender, KeyPressEventArgs e)
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



        private void comboColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboPesoName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboPesoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textProd_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
