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
        private static int lim = 50;
        private static List<Listagem> list_tab = new List<Listagem>();
        private static string code;
        public Home()
        {
            InitializeComponent();
            buttonRemProd.Visible = false;
        } //construtor padrão
        public Home(string cod, string prod, string color, decimal peso, int quant, decimal preco, decimal total)
        {
            InitializeComponent();
            Listagem lista = new Listagem(cod, prod, color, peso, quant, preco, total);
            list_tab.Add(lista);
        } // sobrecarga para adicionar registro
        public Home(string cod)
        {
            code = cod;
        }

        public Home(string bars, string prod, string color, decimal peso, decimal value)
        {
            InitializeComponent();
            int ver = 0;
            foreach (Listagem obj in list_tab)
            {
                if (bars == obj.Bars)
                {
                    dataTabela.Rows.Clear();
                    if (obj.Quant < 50)
                    {
                        obj.Total = obj.Quant * value;
                        obj.Color = color;
                        obj.Prodct = prod;
                        obj.Peso = peso;
                        obj.Preco = value;
                        ver = 1;
                        reelist();
                    }
                    else
                    {
                        obj.Total = obj.Quant * value;
                        obj.Color = color;
                        obj.Prodct = prod;
                        obj.Peso = peso;
                        obj.Preco = value;
                        ver = 1;
                        reelist();
                    }
                }
            }
            if (ver == 0)
            {
                MessageBox.Show("Item não encontrado");
            }
            else
            {
                MessageBox.Show("Registros editados com sucesso");
            }
        }
        public Home(int value)
        {
            lim = value;
        }
        private void reelist()
        {
            decimal Tsystem = 0;
            dataTabela.Rows.Clear();
            foreach (Listagem obj in list_tab)
            {
                if (obj.Quant <= lim)
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    Tsystem = Tsystem + obj.Total;
                }
                else
                {
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    Tsystem = Tsystem + obj.Total;
                }
                labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("f2", CultureInfo.InvariantCulture);

            }
        } // vai listar tudo que está no estoque
        private void enable_true()
        {
            buttonAdd.Visible = false;
            buttonRem.Visible = false;
            buttonRegistro.Enabled = true;
            buttonConfig.Enabled = true;
            dataTabela.Enabled = true;
            buttonPesquisar.Enabled = true;
            buttonCancelarOp.Visible = false;
            buttonAddProd.Enabled = true;

        } //faz com que alguns elementos apareçam
        private void enable_false()
        {
            buttonAdd.Visible = true;
            buttonRem.Visible = true;
            buttonRegistro.Enabled = false;
            buttonConfig.Enabled = false;
            dataTabela.Enabled = false;
            buttonPesquisar.Enabled = false;
            buttonCancelarOp.Visible = true;
            buttonAddProd.Enabled = false;
        } //faz com que alguns elementos desapareçam
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } //fecha sistema
        private void buttonRegistro_Click(object sender, EventArgs e)
        {

            enable_false();
            if (list_tab.Count != 0)
            {
                buttonRem.Enabled = true;
            }
            else
            {
                buttonRem.Enabled = false;
            }
        } // mostra as opções de registros
        private void buttonRmvF_Click(object sender, EventArgs e)
        {
            reelist();
            buttonRmvF.Visible = false;
            buttonPesquisar.Visible = true;
            textPesquisa.Text = string.Empty;
            buttonRegistro.Focus();
        } //remove o filtro
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
            dataTabela.Rows.Clear();

            reelist();
            enable_true();
            if (list_tab.Count != 0)
            {
                buttonRemProd.Visible = true;
                buttonAddProd.Visible = true;
                buttonAlterarReg.Visible = true;
            }
            else
            {

                buttonRemProd.Visible = false;
                buttonAddProd.Visible = false;
                buttonAlterarReg.Visible = false;
            }
        } //adiciona registro
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
                    enable_true();
                }
            }
            reelist();
            if (list_tab.Count == 0)
            {
                labelTotalestoque.Text = "Valor total em estoque: R$0.00";
            }


            if (list_tab.Count == 0)
            {
                buttonAddProd.Visible = false;
                buttonRemProd.Visible = false;
            }
            else
            {
                buttonAddProd.Visible = true;
                buttonRemProd.Visible = true;
            }

        }// remove registro
        private void buttonPesq_Click(object sender, EventArgs e)
        {
            dataTabela.Rows.Clear();

            foreach (Listagem obj in list_tab)
            {
                if (textPesquisa.Text == obj.Bars || textPesquisa.Text == obj.Prodct || textPesquisa.Text == obj.Color)
                {
                    if (obj.Quant < 50)
                    {

                        dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                        buttonPesquisar.Visible = false;
                        buttonRmvF.Visible = true;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    }
                    else
                    {

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
        }//pesquisa registro
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Config env = new Config(lim);
            env.ShowDialog();
            reelist();
        }//configurações
        private void buttonCancelarOp_Click(object sender, EventArgs e)
        {
            enable_true();
            labelAddQ.Visible = false;
            textCodAddQ.Visible = false;
            labelAddQ2.Visible = false;
            textAddQ.Visible = false;
            buttonAddQ.Visible = false;
            buttonRmvQuant.Visible = false;
            labelRemover.Visible = false;
            textCodAddQ.Text = string.Empty;
            textAddQ.Text = string.Empty;
            dataTabela.Rows.Clear();
            reelist();
        } //Cancela Operações
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            buttonCancelarOp.Visible = true;
            labelAddQ.Visible = true;
            textCodAddQ.Visible = true;
            labelAddQ2.Visible = true;
            textAddQ.Visible = true;
            buttonAddQ.Visible = true;

            enable_false();
            buttonAdd.Visible = false;
            buttonRem.Visible = false;


        } //ativa os elementos de adição de quant
        private void button1_Click(object sender, EventArgs e) // adiciona produto
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
                        obj.Total = obj.Preco * obj.Quant;
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
                        enable_true();
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
        } //Filtra o item que deve ser add ou rem
        private void label1_Click(object sender, EventArgs e)
        {

        } //~Sem função (remover)
        private void buttonRemProd_Click(object sender, EventArgs e)
        {
            enable_false();
            buttonRem.Visible = false;
            buttonAdd.Visible = false;
            labelAddQ.Visible = true;
            labelRemover.Visible = true;
            buttonRmvQuant.Visible = true;
            textAddQ.Visible = true;
            textCodAddQ.Visible = true;
        } //Ativa Removedor de Item
        private void buttonRmvQuant_Click(object sender, EventArgs e) // Remove Item
        {
            foreach (Listagem obj in list_tab)
            {
                if (textCodAddQ.Text == obj.Bars)
                {
                    if (textCodAddQ.Text != string.Empty && textAddQ.Text != string.Empty)
                    {
                        if (int.Parse(textAddQ.Text) <= obj.Quant)
                        {

                            int quant = int.Parse(textAddQ.Text);
                            obj.Quant = obj.Quant - quant;
                            obj.Total = obj.Preco * obj.Quant;
                            dataTabela.Rows.Clear();
                            dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                            buttonPesquisar.Visible = false;
                            buttonRmvF.Visible = true;
                            MessageBox.Show("Foram removidos " + quant + " itens dentro do produto " + obj.Prodct);
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
                            enable_true();
                            reelist();
                            buttonRmvQuant.Visible = false;
                            labelRemover.Visible = false;
                            buttonCancelarOp.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Não é possivel removar mais itens do que o estoque possue");
                            textAddQ.Text = string.Empty;
                            textAddQ.Focus();
                        }
                    }
                }
            }
        }

        private void buttonEditReg_Click(object sender, EventArgs e)
        {
            EditReg env = new EditReg();
            env.ShowDialog();
            reelist();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textCodAddQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}



