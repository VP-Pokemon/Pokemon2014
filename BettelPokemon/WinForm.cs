using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BettelPokemon
{
    public partial class WinForm : Form
    {
        public WinForm(Image img,int coins,bool prvpat)
        {
            InitializeComponent();
            if (prvpat == false)
            {
                textBox1.Text = "You won  " + Convert.ToString(coins) + " coins";
                pictureBox1.Image = img;
                this.BackColor = Color.White;
                textBox2.Text = "and this badge :";
            }
            else {
                this.BackColor = Color.White;
                textBox1.Text = "You won  " + Convert.ToString(coins) + " coins";
            }
        }
        private bool okButton = false;

        public bool OKButtonClicked
        {
            get { return okButton; }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            okButton = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okButton = false;
            this.Close();
        }




    }
}
