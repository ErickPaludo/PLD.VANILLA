using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Stq
{


    public partial class Home : Form
    {
        private static List<Listagem> list_tab = new List<Listagem>();
        private static string code;
        private static int quant_;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string cod, string prod, string color, decimal peso, int quant, decimal preco, decimal total)
        {
            InitializeComponent();
            Listagem lista = new Listagem(cod, prod, color, peso, quant, preco, total);
            list_tab.Add(lista);
        }
        public Home(string cod)
        {
            code = cod;
        }
        private void reelist()
        {
            dataTabela.Rows.Clear();
            foreach (Listagem obj in list_tab)
            {
                if (obj.Quant < 50)
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                }
                else
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                }
            }
        }
        private void enable_true()
        {
            buttonAdd.Visible = false;
            buttonRem.Visible = false;
            buttonRegistro.Enabled = true;
            buttonConfig.Enabled = true;
            dataTabela.Enabled = true;
            checkBar.Enabled = true;
            checkQuant.Enabled = true;
            buttonPesquisar.Enabled = true;
            buttonCancelarOp.Visible = false;
            buttonAddProd.Enabled = true;

        }
        private void enable_false()
        {
            buttonAdd.Visible = true;
            buttonRem.Visible = true;
            buttonRegistro.Enabled = false;
            buttonConfig.Enabled = false;
            dataTabela.Enabled = false;
            checkBar.Enabled = false;
            checkQuant.Enabled = false;
            buttonPesquisar.Enabled = false;
            buttonCancelarOp.Visible = true;
            buttonAddProd.Enabled = false;         
            buttonRemProd.Enabled = false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {

            enable_false();
        }


        private void buttonRmvF_Click(object sender, EventArgs e)
        {
            reelist();
            buttonRmvF.Visible = false;
            buttonPesquisar.Visible = true;
            textPesquisa.Text = string.Empty;
            buttonRegistro.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
            dataTabela.Rows.Clear();
            
            foreach (Listagem obj in list_tab)
            {
                buttonAddProd.Visible = true;
                buttonRemProd.Visible = true;
                if (obj.Quant < 50)
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                }
                else
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                }
            }
            enable_true();
        }
        private void buttonRem_Click(object sender, EventArgs e)
        {
            Form2 rem_reg = new Form2();
            MessageBox.Show("Alterações feitas neste campo, não podem ser desfeitas! Se deseja sair, aperte em CANCELAR!");
            rem_reg.ShowDialog();
            dataTabela.Rows.Clear();
            for (int i = 0; i < list_tab.Count; i++)
            {
                if (code == list_tab[i].Bars)
                {
                    list_tab.Remove(list_tab[i]);
                }
            }
            dataTabela.Rows.Clear();
            foreach (Listagem obj in list_tab)
            {
                dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
            }
            enable_true();
            if (list_tab.Count == 0)
            {
                buttonAddProd.Visible = false;
                buttonRemProd.Visible = false;
            }
        }

        private void buttonPesq_Click(object sender, EventArgs e)
        {
            dataTabela.Rows.Clear();

            foreach (Listagem obj in list_tab)
            {
                if (textPesquisa.Text == obj.Bars)
                {
                    if (obj.Quant < 50)
                    {
                        dataTabela.Rows.Clear();
                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                        buttonPesquisar.Visible = false;
                        buttonRmvF.Visible = true;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dataTabela.Rows.Clear();
                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                        buttonPesquisar.Visible = false;
                        buttonRmvF.Visible = true;
                    }
                }
                else
                {
                    buttonPesquisar.Visible = false;
                    buttonRmvF.Visible = true;
                }
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarOp_Click(object sender, EventArgs e)
        {
            enable_true();
            labelAddQ.Visible = false;
            textCodAddQ.Visible = false;
            labelAddQ2.Visible = false;
            textAddQ.Visible = false;
            buttonAddQ.Visible = false;
            textCodAddQ.Text = string.Empty;
            textAddQ.Text = string.Empty;
            dataTabela.Rows.Clear();
            reelist();
        }

        private void dataTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            buttonCancelarOp.Visible = true;
            labelAddQ.Visible = true;
            textCodAddQ.Visible = true;
            labelAddQ2.Visible = true;
            textAddQ.Visible = true;
            buttonAddQ.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTabela.Rows.Clear();

            foreach (Listagem obj in list_tab)
            {
                if (textCodAddQ.Text == obj.Bars)
                {
                    dataTabela.Rows.Clear();
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    if (textCodAddQ.Text != string.Empty && textAddQ.Text != string.Empty)
                    {

                        int quant = int.Parse(textAddQ.Text);
                        obj.Quant = obj.Quant + quant;
                        dataTabela.Rows.Clear();
                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                        buttonPesquisar.Visible = false;
                        buttonRmvF.Visible = true;
                        MessageBox.Show("Foram adicionados " + quant + " itens dentro do produto " + obj.Prodct);
                        labelAddQ.Visible = false;
                        textCodAddQ.Visible = false;
                        labelAddQ2.Visible = false;
                        textAddQ.Visible = false;
                        buttonAddQ.Visible = false;
                        textCodAddQ.Text = string.Empty;
                        textAddQ.Text = string.Empty;
                        buttonRmvF.Visible = false;
                        buttonPesquisar.Visible = true;
                        buttonCancelarOp.Visible = false;
                        reelist();
                    }
                    else
                    {

                        MessageBox.Show("Preencha os campos");
                        textCodAddQ.Text = string.Empty;
                        textAddQ.Text = string.Empty;
                        reelist();
                    }
                }
            }
        }

        private void textCodAddQ_TextChanged(object sender, EventArgs e)
        {
            foreach (Listagem obj in list_tab)
            {
                if (textCodAddQ.Text == obj.Bars)
                {
                    dataTabela.Rows.Clear();
                    if (obj.Quant < 50)
                    {
                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    }                  
                }
            }
        }
    }
}


