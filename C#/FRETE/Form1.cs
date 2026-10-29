using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRETE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpar os resultados do cálculo anterior 
            lblfrete.Text = string.Empty;
            lblcalcular.Text = string.Empty;

            //Consistir os Dados
            if (txtCliente.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome é obrigatório", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCliente.Focus();
                return;

            }            
            else if (txtValor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Valor da compra é obrigatório", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCliente.Focus();
                return;
            }
            else if (ufcombobox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione um estado na lista", "Alerta",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ufcombobox.Focus();
                return;









            }
            
        
        
        
                    
        
        
        
        }   


    }
}
