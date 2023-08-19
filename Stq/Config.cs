using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stq
{
    public partial class buttonAplic : Form
    {
        private static int where = 0, Admlenght = 0;
        private static string User_;

        public buttonAplic(string user)
        {
            User_ = user;
            InitializeComponent();
            adml();
            MessageBox.Show(Admlenght.ToString());
            reelist();
        }
        private void reelist()
        {
            reset();
            dataTabelaUser.Rows.Clear();
            var strconexao = "server=localhost;uid=root;database=stq";
            var conexao = new MySqlConnection(strconexao);
            conexao.Open();
            var cmd = new MySqlCommand("SELECT * FROM login", conexao);
            var readr = cmd.ExecuteReader();
            string user;
            string bloq = string.Empty;
            while (readr.Read())
            {

                if (Convert.ToInt32(readr["ver"]) == 0)
                {
                    user = "Admin";
                }
                else
                {
                    user = "Padrão";
                }
                if (Convert.ToInt32(readr["bloq"]) < 5)
                {
                    bloq = "Não";
                }
                else
                {
                    bloq = "Sim";
                }
                dataTabelaUser.Rows.Add(readr["nome"], readr["pass"], user, bloq);

                // Obtém o índice da última linha adicionada ao DataGridView
                int lastRowIndex = dataTabelaUser.Rows.Count - 1;

                // Verificar o valor da variável "bloq" e definir a cor do texto da célula "Blocked" na última linha
                if (bloq == "Sim")
                {
                    dataTabelaUser.Rows[lastRowIndex].Cells["Blocked"].Style.BackColor = Color.IndianRed;
                    dataTabelaUser.Rows[lastRowIndex].Cells["Blocked"].Style.ForeColor = Color.White;
                }


            }
        }
        private void adml()
        {
            dataTabelaUser.Rows.Clear();
            var strconexao = "server=localhost;uid=root;database=stq";
            var conexao = new MySqlConnection(strconexao);
            conexao.Open();
            var cmd = new MySqlCommand("SELECT * FROM login where ver = 0", conexao);
            var readr = cmd.ExecuteReader();
            int cont = 0;
            while (readr.Read())
            {
                cont++;
            }
            Admlenght = cont;
        }


        private void Config_Load(object sender, EventArgs e)
        {

        }
        private void buttonAdduser_Click(object sender, EventArgs e)
        {
            labelB.Visible = true;
            labelP.Visible = true;
            buttonAdduser.Enabled = false;
            buttonRemuser.Enabled = false;
            buttonAlterarSenha.Enabled = false;
            labelName.Visible = true;
            textCamp1.Visible = true;
            textCamp2.Visible = true;
            labelSenha.Visible = true;
            textCamp1.Focus();
            comboTipoUser.Visible = true;
            comboTipoUser.Enabled = true;
            buttonApc.Visible = true;
            buttonCan.Visible = true;
            comboBloq.Visible = true;
            comboBloq.Text = string.Empty;
            where = 1;
        }

        private void buttonRemuser_Click(object sender, EventArgs e)
        {
            textCamp1.Focus();
            buttonAdduser.Enabled = false;
            buttonRemuser.Enabled = false;
            buttonAlterarSenha.Enabled = false;
            labelName.Visible = true;
            textCamp1.Visible = true;
            buttonApc.Visible = true;
            buttonCan.Visible = true;
            comboTipoUser.Enabled = true;
            where = 2;
        }
        private void buttonAlterarSenha_Click(object sender, EventArgs e)
        {
            textCamp1.Focus();
            labelB.Visible = true;
            labelP.Visible = true;
            buttonAdduser.Enabled = false;
            buttonRemuser.Enabled = false;
            buttonAlterarSenha.Enabled = false;
            labelName.Visible = true;
            labelNewName.Visible = true;
            textEdit.Visible = true;
            textCamp1.Visible = true;
            textCamp2.Visible = true;
            labelSenha.Visible = true;
            comboTipoUser.Visible = true;
            comboTipoUser.Enabled = true;
            comboBloq.Visible = true;
            comboBloq.Enabled = true;
            buttonApc.Visible = true;
            buttonCan.Visible = true;
            comboBloq.Visible = true;
            comboBloq.Text = string.Empty;
            where = 3;
        }

        private void reset()
        {
            labelB.Visible = false;
            labelP.Visible = false;
            buttonAdduser.Enabled = true;
            buttonRemuser.Enabled = true;
            buttonAlterarSenha.Enabled = true;
            labelName.Visible = false;
            textCamp1.Visible = false;
            textCamp2.Visible = false;
            textCamp1.Text = string.Empty;
            textCamp2.Text = string.Empty;
            labelNewName.Visible = false;
            labelSenha.Visible = false;
            comboTipoUser.Visible = false;
            comboTipoUser.Enabled = true;
            buttonApc.Visible = false;
            buttonCan.Visible = false;
            textCamp1.Text = string.Empty;
            comboBloq.Visible = false;
            comboBloq.Text = string.Empty;
            textEdit.Visible = false;
            textEdit.Text = string.Empty;

        }
        private void button1_Click(object sender, EventArgs e) //cancelar op
        {
            reset();
            reelist();
        }
        private int Tipouser(string tipo)
        {
            if (tipo == "Admin")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void buttonApc_Click(object sender, EventArgs e)
        {
            if (where == 1) //adduser
            {
                if (textCamp1.Text != string.Empty && textCamp2.Text != string.Empty && comboTipoUser.Text != string.Empty && (textCamp2.Text).Length <= 8 && (textCamp2.Text).Length >= 6 && (textCamp1.Text).Length <= 10 && (textCamp1.Text).Length >= 3)
                {
                    int ver = Tipouser(comboTipoUser.Text);

                    var strConexao = "server=localhost;uid=root;database=stq";
                    using (var conexao = new MySqlConnection(strConexao))
                    {

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            conexao.Open();
                            int verificador = 0;
                            cmd.Connection = conexao;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * FROM login where nome = @n";
                            cmd.Parameters.AddWithValue("@n", textCamp1.Text);
                            var readr = cmd.ExecuteReader();
                            int bloq = 0;
                            while (readr.Read())
                            {
                                if (readr["nome"].ToString() == textCamp1.Text)
                                {
                                    verificador = 1;
                                    break;
                                }
                            }
                            if (comboBloq.Text == "Sim")
                            {
                                bloq = 9;
                            }
                            else
                            {
                                bloq = 0;
                            }

                            conexao.Close();
                            if (verificador == 0)
                            {
                                conexao.Open();
                                cmd.Connection = conexao;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "INSERT INTO login (nome,pass,ver,bloq) VALUES (@n,@p,@v,@b)";
                                cmd.Parameters.AddWithValue("@p", textCamp2.Text);
                                cmd.Parameters.AddWithValue("@v", ver);
                                cmd.Parameters.AddWithValue("@b", bloq);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Já existe um usuário com esse nome cadastrado!");
                                textCamp1.Text = string.Empty;
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos estão preenchidos, a senha deve conter de 6 a 8 caractres e o User deve conter de 3 a 10 caracteres!");
                }
                adml();
                reelist();
            }
            else if (where == 2)//remuser
            {
                int verificador = 0;
                if (textCamp1.Text != string.Empty)
                {
                    var strConexao = "server=localhost;uid=root;database=stq"; // loga banco
                    var conexao = new MySqlConnection(strConexao);
                    conexao.Open(); // abre banco
                    var cmd = new MySqlCommand("SELECT * FROM login where nome = @n", conexao);
                    cmd.Parameters.AddWithValue("@n", textCamp1.Text);
                    var readr = cmd.ExecuteReader();
                    string tipo = string.Empty;
                    while (readr.Read())
                    {
                        if (readr["nome"].ToString() == User_)
                        {
                            verificador = 2;
                            break;
                        }
                        else if (readr["nome"].ToString() == textCamp1.Text)
                        {
                            verificador = 1;
                            tipo = readr["ver"].ToString();
                            if (tipo == "0")
                            {
                                tipo = "Admin";
                            }
                            else
                            {
                                tipo = "Padrão";
                            }

                            break;
                        }

                    }
                    conexao.Close();
                    conexao.Open();
                    if (verificador == 1)
                    {
                        cmd = new MySqlCommand("DELETE FROM login where nome = @n", conexao);
                        cmd.Parameters.Add("@n", MySqlDbType.String).Value = textCamp1.Text;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário " + textCamp1.Text + ", tipo " + tipo + ", foi removido com sucesso!");
                    }
                    else if (verificador == 2)
                    {
                        MessageBox.Show("Usuário em operação!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado!");
                    }

                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos estão preenchidos, a senha deve conter de 6 a 8 caractres e o User deve conter de 3 a 10 caracteres!");
                }
                adml();
                reelist();
            }
            else if (where == 3)//confguser
            {

                if (textEdit.Text != string.Empty && textCamp2.Text != string.Empty && comboTipoUser.Text != string.Empty && (textCamp2.Text).Length <= 8 && (textCamp2.Text).Length >= 4 && (textCamp1.Text).Length <= 10 && (textCamp1.Text).Length >= 3)
                {
                    int ver = Tipouser(comboTipoUser.Text);
                    var strConexao = "server=localhost;uid=root;database=stq";
                    using (var conexao = new MySqlConnection(strConexao))
                    {

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            int verificador = 0;

                            int bloq = 0;
                            if (comboBloq.Text == "Sim")
                            {
                                bloq = 9;
                            }
                            else
                            {
                                bloq = 0;
                            }

                            if (textCamp1.Text == User_)
                            {
                                verificador = 1;
                            }


                            if (verificador == 0)
                            {
                                conexao.Open();
                                cmd.Connection = conexao;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "Update login set nome = @nome,pass = @p, ver = @v, bloq = @b where nome = @n";
                                cmd.Parameters.AddWithValue("@n", textCamp1.Text);
                                cmd.Parameters.AddWithValue("@nome", textEdit.Text);
                                cmd.Parameters.AddWithValue("@p", textCamp2.Text);
                                cmd.Parameters.AddWithValue("@v", ver);
                                cmd.Parameters.AddWithValue("@b", bloq);
                                cmd.ExecuteNonQuery();
                                reelist();
                                conexao.Close();
                            }
                            else
                            {

                                conexao.Open();
                                cmd.Connection = conexao;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "Update login set nome = @nome,pass = @p, ver = @v where nome = @n";
                                cmd.Parameters.AddWithValue("@n", textCamp1.Text);
                                cmd.Parameters.AddWithValue("@nome", textEdit.Text);
                                cmd.Parameters.AddWithValue("@p", textCamp2.Text);
                                cmd.Parameters.AddWithValue("@v", ver);

                                cmd.ExecuteNonQuery();
                                conexao.Close();
                                MessageBox.Show("Alterações realizadas, estamos encerrando a sessão para " +
                                    "que as alterações sejam feitas!");

                                System.Windows.Forms.Application.Exit();
                            }
                            textEdit.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos estão preenchidos, a senha deve conter de 4 a 8 caractres!");
                }
                adml();
                reelist();
            }
        } //todos botões


        private void textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textEdit_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCamp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCamp1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textCamp1_KeyUp(object sender, KeyEventArgs e)
        {
            textEdit.Text = textCamp1.Text;
            dataTabelaUser.Rows.Clear();
            var strconexao = "server=localhost;uid=root;database=stq";
            var conexao = new MySqlConnection(strconexao);
            conexao.Open();
            var cmd = new MySqlCommand("SELECT * FROM login where nome = @n", conexao);
            cmd.Parameters.AddWithValue("@n", textCamp1.Text);
            var readr = cmd.ExecuteReader();
            string user;
            string bloq = string.Empty;
            while (readr.Read())
            {
                if (Convert.ToInt32(readr["ver"]) == 0)
                {
                    user = "Admin";
                }
                else
                {
                    user = "Padrão";
                }
                if (Convert.ToInt32(readr["bloq"]) < 5)
                {
                    bloq = "Não";
                }
                else
                {
                    bloq = "Sim";
                }
                dataTabelaUser.Rows.Add(readr["nome"], readr["pass"], user, bloq);

                if (bloq == "Sim")
                {
                    int lastRowIndex = dataTabelaUser.Rows.Count - 1;
                    dataTabelaUser.Rows[lastRowIndex].Cells["Blocked"].Style.BackColor = Color.IndianRed;
                    dataTabelaUser.Rows[lastRowIndex].Cells["Blocked"].Style.ForeColor = Color.White;
                }

                textCamp2.Text = (readr["pass"]).ToString();
                if (user == "Admin" && Admlenght == 1)
                {
                    comboTipoUser.Text = user;
                    comboTipoUser.Enabled = false;
                    comboBloq.Text = "Não";
                    comboBloq.Enabled = false;
                }
                else
                {
                    comboTipoUser.Text = user;
                }

                if (textCamp1.Text == User_)
                {
                    comboBloq.Text = bloq;
                    comboBloq.Enabled = false;
                    comboTipoUser.Text = user;
                    comboTipoUser.Enabled = false;
                }
                else
                {
                    comboTipoUser.Text = user;
                    comboTipoUser.Enabled = true;
                    comboBloq.Text = bloq;
                    comboBloq.Enabled = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textCamp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
