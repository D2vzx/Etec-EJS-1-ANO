using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio_certo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstBox2.Items.Add("\n\n \t****** RELÁTORIO DOS PROBLEMAS IDENTIFICADOS ******\n\n \t");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int item;
            item = LstBox2.SelectedIndex;
            LstBox2.Items.RemoveAt(item);

        }

        private void chkbsuco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbsuco.Checked)
            {
                LstBox2.Items.Add("Suco");

            }
            else
            {
                LstBox2.Items.Remove("Suco");
            }
        }

        private void rdbmaoo_CheckedChanged(object sender, EventArgs e)
        {
            LstBox2.Items.Add("Mão");
        }

        private void rdbpee_CheckedChanged(object sender, EventArgs e)
        {
           LstBox2.Items.Add("Pé");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbpeemaoo_CheckedChanged(object sender, EventArgs e)
        {
            LstBox2.Items.Add("Pé e Mão");
        }

        private void chkbcafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbcafe.Checked)
            {
                LstBox2.Items.Add("Café");

            }
            else
            {
                LstBox2.Items.Remove("Café");
            }
        }

        private void chkbchoco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbchoco.Checked)
            {
                LstBox2.Items.Add("Chocolate");

            }
            else
            {
                LstBox2.Items.Remove("Chocolate");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    LstBox2.Items.Add("Escova");
                    break;
                case 1:
                    LstBox2.Items.Add("Tintura");
                    break;
                case 2:
                    LstBox2.Items.Add("Hidratação");
                    break;
                case 3:
                    LstBox2.Items.Add("Penteado");
                    break;
                case 4:
                    LstBox2.Items.Add("Luzes");
                    break;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LstBox2.Items.Clear();
        }

        private void LstBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
