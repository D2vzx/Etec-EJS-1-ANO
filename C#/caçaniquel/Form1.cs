using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caçaniquel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            Random y = new Random(); //instanciando a variavel do tipo randomica

            int i = y.Next(0, 9); //gerando valores de 0 a 9 na variavel i 
            lblN1.Text = i.ToString();

            int j = y.Next(0, 9);
            lblN2.Text = j.ToString();

            int k = y.Next(0, 9);
            lblN3.Text = k.ToString();

            if (lblN1.Text == lblN2.Text && lblN2.Text == lblN3.Text)
            {
                picdima.Visible = true; //torna a imagem visivel
                btnGirar.Enabled = false;
            }

            else
            {

                picdima.Visible = false;



            }


                            
            

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picdima_Click(object sender, EventArgs e)
        {

        }
    }
}
