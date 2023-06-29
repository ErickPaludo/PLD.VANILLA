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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassR.Text == "tRuE.75*/")
            {
                MessageBox.Show("Senha Aceita!");
                Home rem = new Home(textRemovedor_Reg.Text);
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Senha Incorreta!");
                
                textPassR.Text = string.Empty;
                textRemovedor_Reg.Text = string.Empty;
                textRemovedor_Reg.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
