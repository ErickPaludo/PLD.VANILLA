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
        private static int lim = -1;
        private static List<Listagem> list_tab = new List<Listagem>();
        private static string code, User = "Gh0st";
        private static int Ver = 0;

        public Home(int ver,string user)
        {
            Ver = ver;
            User = user;
            InitializeComponent();
            reelist();
        }
        public Home()
        {
            InitializeComponent();
            reelist();
        } //construtor padrão

        public Home(string cod)
        {
            code = cod;
        }

        private void reelist()
        {

            dataTabela.Rows.Clear(); // limpa tabela

            var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
            var conexao = new MySqlConnection(strConexao);
            conexao.Open(); // abre banco
            var cmd = new MySqlCommand("SELECT * FROM dados where visibl = 0", conexao); //mostrar
            var readr = cmd.ExecuteReader();
            int cont = 0;
            decimal Tsystem = 0;
            while (readr.Read())
            {
                int quant = Convert.ToInt32(readr["quant"]);
                cont = cont + 1;
                decimal preco = Convert.ToDecimal(readr["preco"]);

                decimal total = quant * preco;
                if (quant <= lim)
                {
                    dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                    Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                    dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                    Tsystem = Tsystem + total;
                }
                else
                {
                    dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                    Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                    Tsystem = Tsystem + total;
                }
            }

            labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));
            labelQuantR.Text = "Registros no estoque: " + cont;
            readr.Close();
            var cmd_ = new MySqlCommand("SELECT COUNT(*) FROM dados", conexao);
            if (Ver == 0)
            {
                buttonConfig.Visible = true;
                if (Convert.ToInt32(cmd_.ExecuteScalar()) > 0)
                {
                    buttonRegistro.Visible = true;
                    buttonRemProd.Visible = true;
                    buttonAddProd.Visible = true;
                    buttonAlterarReg.Visible = true;
                    

                }
                else
                {
                    buttonRegistro.Visible = true;
                    buttonRem.Enabled = false;
                    buttonRemProd.Visible = false;
                    buttonAddProd.Visible = false;
                    buttonAlterarReg.Visible = false;
                }
            }
            else
            {
                buttonConfig.Visible = false;
                if (Convert.ToInt32(cmd_.ExecuteScalar()) > 0)
                {

                    buttonRemProd.Visible = true;
                    buttonAddProd.Visible = true;

                }
                else
                {

                    buttonRem.Enabled = false;
                    buttonRemProd.Visible = false;
                    buttonAddProd.Visible = false;
                }
                cmd.Connection.Close();
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
            System.Windows.Forms.Application.Exit();
        } //fecha sistema
        private void buttonRegistro_Click(object sender, EventArgs e)
        {

            enable_false();
            buttonAdd.Enabled = true;
            buttonRem.Enabled = true;
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

            Form3 add = new Form3(User);
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
                int cont = 0;
                while (readr.Read())
                {
                    cont++;

                    int quant = Convert.ToInt32(readr["quant"]);

                    decimal preco = Convert.ToDecimal(readr["preco"]);
                   
                    decimal total = quant * preco;
                    if (quant <= lim)
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                        Tsystem = Tsystem + total;
                    }
                    else
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
   Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                        Tsystem = Tsystem + total;
                    }
                }

                labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));
                labelQuantR.Text = "Registros no estoque: " + cont;
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
            buttonAplic env = new buttonAplic(User);
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
            if (textCodAddQ.Text != string.Empty && textAddQ.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd_ = new MySqlCommand("SELECT * FROM dados where cod = @cod", conexao);
                cmd_.Parameters.AddWithValue("@cod", textCodAddQ.Text);

                int old_quant = 0;
                var leitor = cmd_.ExecuteReader();
                string prod = string.Empty;

                while (leitor.Read())
                {
                    old_quant = Convert.ToInt32(leitor["quant"]);
                    prod = leitor["nome"].ToString();
                }
                conexao.Close();

                int quant = int.Parse(textAddQ.Text) + old_quant;
                textCodAddQ.Text = quant.ToString();


                conexao.Open();
                cmd_.CommandType = CommandType.Text;
                cmd_.CommandText = "UPDATE dados set quant = @quant, us = @us, dt = @dt  where cod =@cod";
                cmd_.Parameters.AddWithValue("@quant", quant);
                DateTime data = DateTime.Now;
                cmd_.Parameters.AddWithValue("@us", User);
                cmd_.Parameters.AddWithValue("@dt", data);

                cmd_.ExecuteNonQuery();
                conexao.Close();
                reelist();
                MessageBox.Show("Foram adicionados " + textAddQ.Text + " itens dentro do registro " + prod + "!");
                textCodAddQ.Text = string.Empty;
                textAddQ.Text = string.Empty;

                cancop();
            }

        }
        private void textCodAddQ_TextChanged(object sender, EventArgs e)
        {


            //Filtra o item que deve ser add ou rem
        }
        private void label1_Click(object sender, EventArgs e)
        {

        } //~Sem função (remover)
        private void buttonRemProd_Click(object sender, EventArgs e)
        {
            enable_false();
            buttonRemProd.Enabled = false;
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
            if (textCodAddQ.Text != string.Empty && textAddQ.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd_ = new MySqlCommand("SELECT * FROM dados where cod = @cod", conexao);
                cmd_.Parameters.AddWithValue("@cod", textCodAddQ.Text);

                int old_quant = 0;
                var leitor = cmd_.ExecuteReader();
                string prod = string.Empty;

                while (leitor.Read())
                {
                    old_quant = Convert.ToInt32(leitor["quant"]);
                    prod = leitor["nome"].ToString();
                }
                conexao.Close();

                if (int.Parse(textAddQ.Text) <= old_quant)
                {

                    int quant = old_quant - int.Parse(textAddQ.Text);
                    textCodAddQ.Text = quant.ToString();


                    conexao.Open();
                    cmd_.CommandType = CommandType.Text;
                    cmd_.CommandText = "UPDATE dados set quant = @quant,us = @us, dt = @dt where cod =@cod";
                    cmd_.Parameters.AddWithValue("@quant", quant);
                    DateTime data = DateTime.Now;
                    cmd_.Parameters.AddWithValue("@us", User);
                    cmd_.Parameters.AddWithValue("@dt", data);
                    cmd_.ExecuteNonQuery();
                    conexao.Close();
                    reelist();
                    MessageBox.Show("Foram removidos " + textAddQ.Text + " itens do registro " + prod + "!");
                    textCodAddQ.Text = string.Empty;
                    textAddQ.Text = string.Empty;

                    cancop();
                }
                else
                {
                    MessageBox.Show("Impossível comcluir operação!");
                    textAddQ.Text = string.Empty;
                }
            }
        }

        private void buttonEditReg_Click(object sender, EventArgs e)
        {
            buttonAddProd.Enabled = false;
            labelAddQ.Visible = true;
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

            dataTabela.Rows.Clear(); // limpa tabela

            if (textCodAddQ.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd = new MySqlCommand("SELECT * FROM dados where  cod = @cod ", conexao); //mostrar
                cmd.Parameters.AddWithValue("@cod", textCodAddQ.Text);
                var readr = cmd.ExecuteReader();

                decimal Tsystem = 0;
                while (readr.Read())
                {

                    int quant = Convert.ToInt32(readr["quant"]);
                    decimal total = quant * Convert.ToDecimal(readr["preco"]);
                    if (quant <= lim)
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                   Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString());

                       dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                        Tsystem = Tsystem + total;
                    }
                    else
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                   Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString());

                       Tsystem = Tsystem + total;
                    }
                    EditReg env = new EditReg(textCodAddQ.Text,User);
                    env.ShowDialog();
                    cancop();
                }

                labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));

                readr.Close();
            }
            else
            {
                MessageBox.Show("Código inválido");
                textCodAddQ.Text = string.Empty;
                textCodAddQ.Focus();
            }
        }

        private void dataTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pesq_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodAddQ_KeyUp(object sender, KeyEventArgs e)
        {
            dataTabela.Rows.Clear(); // limpa tabela

            if (textCodAddQ.Text != string.Empty)
            {
                var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                var conexao = new MySqlConnection(strConexao);
                conexao.Open(); // abre banco
                var cmd = new MySqlCommand("SELECT * FROM dados where cod = @cod", conexao); //mostrar
                cmd.Parameters.AddWithValue("@cod", textCodAddQ.Text);
                var readr = cmd.ExecuteReader();

                decimal Tsystem = 0;
                int cont = 0;
                while (readr.Read())
                {
                    cont++;
                    int quant = Convert.ToInt32(readr["quant"]);

                    decimal preco = Convert.ToDecimal(readr["preco"]);

                    decimal total = quant * preco;
                    if (quant <= lim)
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                   Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.BackColor = Color.Red;
                        dataTabela.Rows[dataTabela.Rows.Count - 2].Cells["QUANTIDADE"].Style.ForeColor = Color.White;
                        Tsystem = Tsystem + total;
                    }
                    else
                    {
                        dataTabela.Rows.Add(readr["cod"], readr["nome"], readr["color"], Convert.ToDecimal(readr["peso"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")) + " " + readr["peso_kg"], quant, "R$ " +
                 Convert.ToDecimal(readr["preco"]).ToString("n2", CultureInfo.GetCultureInfo("pt-br")), "R$ " + total.ToString("n2", CultureInfo.GetCultureInfo("pt-br")), readr["us"].ToString(), readr["dt"].ToString());
                        Tsystem = Tsystem + total;
                    }
                }

                labelTotalestoque.Text = "Valor total em estoque: R$" + Tsystem.ToString("N2", CultureInfo.GetCultureInfo("pt-br"));
                labelQuantR.Text = "Registros no estoque: " + cont;
                readr.Close();
            }
        }
    }

}



