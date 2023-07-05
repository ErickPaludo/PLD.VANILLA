using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public EditReg()
        {
            InitializeComponent();
        }


        private void EditReg_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEnvCodBars.Text != string.Empty && textProduto.Text != string.Empty && comboColor.Text != string.Empty && textNewPeso.Text != string.Empty && textNewValue.Text != string.Empty)
            {
                Home env = new Home(textBoxEnvCodBars.Text, textProduto.Text, comboColor.Text, Convert.ToDecimal(textNewPeso.Text), Convert.ToDecimal(textNewValue.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
                textBoxEnvCodBars.Text = string.Empty;
                textProduto.Text = string.Empty;
                comboColor.Text = string.Empty;
                textNewPeso.Text = string.Empty;
                textNewValue.Text = string.Empty;
                textBoxEnvCodBars.Focus();

            }
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnvCodBars_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnvCodBars_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
