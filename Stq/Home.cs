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
using MySql.Data.MySqlClient;


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

            reelist();
            buttonRemProd.Visible = false;
        } //construtor padrão

        public Home(string cod)
        {
            code = cod;
        }

        public Home(string bars, string prod, string color, decimal peso, string pesoN, decimal value)
        {
            InitializeComponent();
            buttonRegistro.Visible = false;
            foreach (Listagem obj in list_tab)
            {

                if (bars == obj.Bars)
                {
                    dataTabela.Rows.Clear();

                    obj.Total = obj.Quant * value;
                    obj.Color = color;
                    obj.Prodct = prod;
                    obj.Peso = peso;
                    obj.PesoN = pesoN;
                    obj.Preco = value;
                }

            }

            MessageBox.Show("Registros editados com sucesso");

        }
        public Home(int value)
        {
            lim = value;
        }
        private void reelist()
        {

            dataTabela.Rows.Clear(); // limpa tabela

            var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
            var conexao = new MySqlConnection(strConexao);
            conexao.Open(); // abre banco
            var cmd = new MySqlCommand("SELECT * FROM dados", conexao); //mostrar
            var readr = cmd.ExecuteReader();

            decimal Tsystem = 0;
            while (readr.Read())
            {
                int quant = Convert.ToInt32(readr["quant"]);
                decimal total = Convert.ToDecimal(readr["total"]);
                if (quant <= lim)
                {
                    dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], readr["quant"], "R$ " +
                    Convert.ToDecimal(readr["quant"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + Convert.ToDecimal(readr["total"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")));
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    Tsystem = Tsystem + total;
                }
                else
                {
                    dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], readr["quant"], "R$ " +
                   Convert.ToDecimal(readr["quant"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + Convert.ToDecimal(readr["total"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")));
                    Tsystem = Tsystem + total;
                }
            }

            labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));

            readr.Close();
            var cmd_ = new MySqlCommand("SELECT COUNT(*) FROM dados", conexao);
            if (Convert.ToInt32(cmd_.ExecuteScalar()) > 0)
            {
                buttonRemProd.Visible = true;
                buttonAddProd.Visible = true;
                buttonAlterarReg.Visible = true;
            }
            else
            {
                buttonRem.Enabled = false;
                buttonRemProd.Visible = false;
                buttonAddProd.Visible = false;
                buttonAlterarReg.Visible = false;
            }
            cmd.Connection.Close();

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
            buttonAdd.Enabled = true;
            buttonAlterarReg.Enabled = false;
            buttonRemProd.Enabled = false;
            reelist();
        } // mostra as opções de registros
        private void buttonRmvF_Click(object sender, EventArgs e)
        {
            reelist();
            buttonRmvF.Visible = false;
            buttonPesquisar.Visible = true;
            Pesq.Text = string.Empty;
            buttonRegistro.Focus();
        } //remove o filtro
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Form3 add = new Form3();
            add.ShowDialog();
            buttonAlterarReg.Enabled = true;
            buttonRemProd.Enabled = true;
            dataTabela.Rows.Clear();

            reelist();
            enable_true();

        } //adiciona registro
        private void buttonRem_Click(object sender, EventArgs e)
        {
            Form2 rem_reg = new Form2();

            MessageBox.Show("Alterações feitas neste campo, não podem ser desfeitas! Se deseja sair, aperte em CANCELAR!");
            rem_reg.ShowDialog();
            cancop();
            buttonAlterarReg.Enabled = true;
            buttonRemProd.Enabled = true;


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
                buttonAlterarReg.Visible = false;
                buttonAddProd.Visible = false;
                buttonRemProd.Visible = false;
            }




        }// remove registro
        private void buttonPesq_Click(object sender, EventArgs e)
        {

            dataTabela.Rows.Clear(); // limpa tabela

            if (Pesq.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd = new MySqlCommand("SELECT * FROM dados where nome = @nome OR cod = @cod Or color = @color", conexao); //mostrar
                cmd.Parameters.AddWithValue("@nome", Pesq.Text);
                cmd.Parameters.AddWithValue("@cod", Pesq.Text);
                cmd.Parameters.AddWithValue("@color", Pesq.Text);
                var readr = cmd.ExecuteReader();

                decimal Tsystem = 0;
                while (readr.Read())
                {

                    int quant = Convert.ToInt32(readr["quant"]);
                    decimal total = Convert.ToDecimal(readr["total"]);
                    if (quant <= lim)
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], readr["quant"], "R$ " +
                        Convert.ToDecimal(readr["quant"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + Convert.ToDecimal(readr["total"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")));
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                        Tsystem = Tsystem + total;
                    }
                    else
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], readr["quant"], "R$ " +
                       Convert.ToDecimal(readr["quant"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + Convert.ToDecimal(readr["total"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")));
                        Tsystem = Tsystem + total;
                    }

                }

                labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));

                readr.Close();

                buttonPesquisar.Visible = false;
                buttonRmvF.Visible = true;
            }
            else
            {
                MessageBox.Show("Campo de pesquisa está vazio!");
                Pesq.Focus();
                reelist();
            }
            
        }//pesquisa registro
        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Config env = new Config(lim);
            env.ShowDialog();
            reelist();
        }//configurações
        private void cancop()
        {
            enable_true();
            textCodAddQ.Visible = false;
            buttonEdit.Visible = false;
            labelAddQ.Visible = false;
            textCodAddQ.Visible = false;
            labelAddQ2.Visible = false;
            textAddQ.Visible = false;
            buttonAddQ.Visible = false;
            buttonRmvQuant.Visible = false;
            labelRemover.Visible = false;
            textCodAddQ.Text = string.Empty;
            textAddQ.Text = string.Empty;
            buttonAlterarReg.Enabled = true;
            buttonRemProd.Enabled = true;
            Pesq.Enabled = true;
            dataTabela.Rows.Clear();
            reelist();
        }
        private void buttonCancelarOp_Click(object sender, EventArgs e)
        {
            cancop();
        } //Cancela Operações
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            buttonCancelarOp.Visible = true;
            labelAddQ.Visible = true;
            textCodAddQ.Visible = true;
            labelAddQ2.Visible = true;
            textAddQ.Visible = true;
            buttonAddQ.Visible = true;
            buttonAlterarReg.Enabled = false;
            buttonRemProd.Enabled = false;

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
                        cancop();
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
            buttonAlterarReg.Enabled = false;

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
                            cancop();
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
            enable_false();
            buttonAdd.Enabled = false;
            buttonRemProd.Enabled = false;
            buttonPesquisar.Enabled = false;
            Pesq.Enabled = false;
            buttonCancelarOp.Visible = true;
            textCodAddQ.Visible = true;
            buttonEdit.Visible = true;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int v = 0;
            foreach (Listagem obj in list_tab)
            {
                if (obj.Bars == textCodAddQ.Text)
                {
                    v = 1;
                    EditReg env = new EditReg(obj.Bars, obj.Prodct, obj.Color, obj.Peso, obj.PesoN, obj.Preco);
                    env.ShowDialog();
                    cancop();
                }
            }
            if (v == 0)
            {
                MessageBox.Show("Código inválido");
                textCodAddQ.Text = string.Empty;
                textCodAddQ.Focus();
            }
            else
            {
                reelist();
                textCodAddQ.Text = string.Empty;
                buttonCancelarOp.Visible = false;
                textCodAddQ.Visible = false;
                buttonEdit.Visible = false;
            }

        }

        private void dataTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



