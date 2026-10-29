using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num, quadrado;
            // double variaves com casa decimal 
            //convertendo o conteudo da cx de texto para variavel
            num = Convert.ToDouble(txtnum.Text);
            quadrado = Math.Pow(num, 2); //função POW calcul ao quadrado 
            //label recebendo conjunto de string
            lbl.Text = "o quadrado de" + num.ToString() +
                " eh =" + quadrado.ToString("N0");
            // Tostring é porque a label não aceita valores númericos, e o número tem que voltar a ter valor de "string"
            //reposiciona o foco 
            txtnum.Focus();
            //selecionar o conteúdo
            txtnum.SelectAll();


        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0' || e.KeyChar> '9')
            if (e.KeyChar != '\b' && e.KeyChar != '\r'
                    && e.KeyChar != 44 && e.KeyChar !=46)
                // \r enter \b backspace
                {
                    e.KeyChar = '\0'; //trava o teclado 
                }
        }
    }
}
