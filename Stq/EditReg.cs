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
        public EditReg()
        {
            InitializeComponent();
        }


        private void EditReg_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Home env = new Home(textBoxEnvCodBars.Text, textProduto.Text, comboColor.Text, Convert.ToDecimal(textNewPeso.Text),Convert.ToDecimal(textNewValue.Text));
            this.Close();
        }
    }
}
