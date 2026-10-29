using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_virtual
{
    public partial class Lanchoneteform : Form
    {
        public Lanchoneteform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioxsalada_CheckedChanged(object sender, EventArgs e)
        {
            picbox1.Image = Properties.Resources.xsalada;
        }

        private void radioxbacon_CheckedChanged(object sender, EventArgs e)
        {
            picbox1.Image = Properties.Resources.xbacon;

        }

        private void radioxalli_CheckedChanged(object sender, EventArgs e)
        {
            picbox1.Image = Properties.Resources.mohamed_alli;

        }

        private void checksprite_CheckedChanged(object sender, EventArgs e)
        {
            if (checksprite.Checked == true)
            {
                picbox2.Visible = true;
                picbox2.Image = Properties.Resources.sprite;
            }
            else
            {
                picbox2.Visible = false;
            }
        }

        private void checkbatata_CheckedChanged(object sender, EventArgs e)
        {

            if (checkbatata.Checked == true)
            {
                picbox3.Visible = true;
                picbox3.Image = Properties.Resources.batatafrita;
            }
            else
            {
                picbox3.Visible = false;
            }


        }

        private void checkmilk_CheckedChanged(object sender, EventArgs e)
        {

            if (checkmilk.Checked == true)
            {
                picbox4.Visible = true;
                picbox4.Image = Properties.Resources.milkshake;
            }
            else
            {
                picbox4.Visible = false;
            }
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listbox.SelectedIndex)
            {
                case 0: picbox5.Image = Properties.Resources.acai; break;
                case 1: picbox5.Image = Properties.Resources.baunilha; break;
                case 2: picbox5.Image = Properties.Resources.chocolate; ; break;

            }
        }

        private void cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbox.SelectedIndex)
            { case 0: picbox6.Image = Properties.Resources.cartão; break;
                case 1: picbox6.Image = Properties.Resources.pix; break;
                case 2: picbox6.Image = Properties.Resources.dinheiro; break;
            }
            
             
            
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
