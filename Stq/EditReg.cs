using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
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
        public EditReg(string bars,string prod, string color, decimal peso, decimal preco)
        {
            InitializeComponent();
            Bars = bars;
                textProduto.Text = prod;
                comboColor.Text = color;
                textNewPeso.Text = Convert.ToString(peso);
                textNewValue.Text = Convert.ToString(preco);
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
            if (textProduto.Text != string.Empty && textNewPeso.Text != string.Empty && textNewValue.Text != string.Empty)
            {
                Home env = new Home(Bars,textProduto.Text, comboColor.Text, Convert.ToDecimal(textNewPeso.Text), Convert.ToDecimal(textNewValue.Text));
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
    }
}
