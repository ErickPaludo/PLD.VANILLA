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

        private void enable_true()
        {
            buttonAdd.Visible = false;
            buttonRem.Visible = false;
            buttonRegistro.Enabled = true;
            buttonSai_Ent.Enabled = true;
            buttonConfig.Enabled = true;
            dataTabela.Enabled = true;
            checkBar.Enabled = true;
            checkQuant.Enabled = true;
            buttonPesquisar.Enabled = true;
            buttonCancelarOp.Visible = false;
        }
        private void enable_false()
        {
            buttonAdd.Visible = true;
            buttonRem.Visible = true;
            buttonRegistro.Enabled = false;
            buttonSai_Ent.Enabled = false;
            buttonConfig.Enabled = false;
            dataTabela.Enabled = false;
            checkBar.Enabled = false;
            checkQuant.Enabled = false;
            buttonPesquisar.Enabled = false;
            buttonCancelarOp.Visible = true;
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
            dataTabela.Rows.Clear();
            foreach (Listagem obj in list_tab)
            {

                dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                textPesquisa.Text = string.Empty;
                textPesquisa.Focus();
                buttonRmvF.Visible = false;
                buttonPesquisar.Visible = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
            dataTabela.Rows.Clear();
            foreach (Listagem obj in list_tab)
            {
                dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
            }
            enable_true();
        }
        private void buttonRem_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesq_Click(object sender, EventArgs e)
        {
            dataTabela.Rows.Clear();

            foreach (Listagem obj in list_tab)
            {
                if (textPesquisa.Text == obj.Bars)
                {
                    dataTabela.Rows.Clear();
                    dataTabela.Rows.Add(obj.Bars, obj.Prodct, obj.Color, "Kg " + obj.Peso.ToString("f2", CultureInfo.InvariantCulture), obj.Quant, "R$ " + obj.Preco.ToString("f2", CultureInfo.InvariantCulture), "R$ " + obj.Total.ToString("f2", CultureInfo.InvariantCulture));
                    buttonPesquisar.Visible = false;
                    buttonRmvF.Visible = true;
                }
                else
                {
                    buttonPesquisar.Visible = false;
                    buttonRmvF.Visible = true;
                }
            }
        }

        private void buttonSai_Ent_Click(object sender, EventArgs e)
        {

        }
        private void buttonConfig_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarOp_Click(object sender, EventArgs e)
        {
            enable_true();
        }

     
    }
}
