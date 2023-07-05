using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stq
{
    public partial class Config : Form
    {
        private static int limite;
        public Config(int lim)
        {
            InitializeComponent();
            limite = lim;
            labellim.Text = "LIMITE ATUAL: " + limite;
        }

        private void buttonAplic_Click(object sender, EventArgs e)
        {
            if(textValue.Text == string.Empty)
            {
                textValue.Focus();
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                int value = int.Parse(textValue.Text);
                Home env = new Home(value);
                MessageBox.Show("Alterações aplicadas com Sucesso!");
                this.Close();
            }
        }

        private void textValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

           
        }

    }
}
