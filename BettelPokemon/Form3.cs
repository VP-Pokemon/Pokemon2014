using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace BettelPokemon
{
    public partial class Form3 : Form
    {
        Graphics g;
        Graphics scG;
        Bitmap btm;
        public List<Pokemon> lista { get; set; }
        public   Trainer Mykarakter { get; set; }
        public Form3(List<Pokemon> l,Trainer tvojkarakter)
        {
            InitializeComponent();
            Mykarakter = tvojkarakter;
            lista = new List<Pokemon>();
            lista = l;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.violet_button_thumb;
        }
        public void Form3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           e.Graphics.DrawImage(Properties.Resources.prod, 0, 0, 672, 512);
            e.Graphics.DrawImage(Properties.Resources.Colorasss, 300, 80, 200, 350);
            e.Graphics.DrawImage(Properties.Resources.deskkk, 400, 250, 230, 230);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox2.Paint += new PaintEventHandler(pictureBox2_Paint);
            g = this.CreateGraphics();
            btm = new Bitmap(this.Width, this.Height);
            scG = Graphics.FromImage(btm);
            lista = lista.OrderBy(x => x.CenaPokemon).ToList();
            timer1.Start();
            for (int i = 0; i < lista.Count; i++)
            {
                Pokemon p = lista[i];
                listBox1.Items.Add(p);
            }
            g = this.CreateGraphics();
            btm = new Bitmap(this.Width, this.Height);
            scG = Graphics.FromImage(btm);
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form3_Paint);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                scG.Clear(Color.White);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                scG.DrawImage(Properties.Resources.prod, 0, 0, 672, 512);
                scG.DrawImage(Properties.Resources.Colorasss, 300, 80, 200, 350);
                scG.DrawImage(Properties.Resources.deskkk, 400, 250, 230, 230);
                scG.DrawImage(Properties.Resources.talk1, 340, 0, 220, 200);
                scG.DrawString("Wellcome to the", new Font("COMIC SANS MS", 10), drawBrush, new Point(398,35));
                scG.DrawString("Pokemon Shop, please", new Font("COMIC SANS MS", 10), drawBrush, new Point(395, 50));
                scG.DrawString("feel free to look for the", new Font("COMIC SANS MS", 10), drawBrush, new Point(395, 65));
                scG.DrawString("best pokemon for you", new Font("COMIC SANS MS", 10), drawBrush, new Point(395, 80));
                scG.DrawImage(Properties.Resources.violet_button_thumb, 0,0, 130, 90);
                Image img = Mykarakter.MalaSlika;
                scG.DrawImage(img, 15, 10, 30, 30);
                scG.DrawString("Your money: ", new Font("COMIC SANS MS", 10), new SolidBrush(Color.LightSkyBlue), new Point(15, 38));
                scG.DrawString( Convert.ToString(Mykarakter.Money), new Font("COMIC SANS MS", 10),new SolidBrush(Color.LightSkyBlue), new Point(15, 50));
                g.DrawImage(btm, new Point(0, 0));
            }
            if (listBox1.SelectedIndex != -1)
            {
                scG.Clear(Color.White);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                scG.DrawImage(Properties.Resources.prod, 0, 0, 672, 512);
                scG.DrawImage(Properties.Resources.Colorasss, 300, 80, 200, 350);
                scG.DrawImage(Properties.Resources.deskkk, 400, 250, 230, 230);
                Pokemon tvoj = listBox1.SelectedItem as Pokemon;
                Animations animacijaMoj = tvoj.AnimacijaPokemon;
                scG.DrawImage(Properties.Resources.talk2, 100, 0, 259, 270);
                scG.DrawString("This pokemon is :", new Font("COMIC SANS MS", 10), drawBrush, new Point(140, 13));
                scG.DrawString(tvoj.Name +"  Type: ", new Font("COMIC SANS MS", 10), drawBrush, new Point(130, 30));
                ResourceManager rm = Properties.Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(tvoj.Type);
                scG.DrawImage(myImage, 240,35, 30,12);
                scG.DrawString("LPs:"+Convert.ToString(tvoj.LifePoints), new Font("COMIC SANS MS", 10), drawBrush, new Point(275, 30));
                scG.DrawString("Attacks :", new Font("COMIC SANS MS", 8), drawBrush, new Point(130, 50));
                scG.DrawString(tvoj.Atacks[0].Name, new Font("COMIC SANS MS", 8), drawBrush, new Point(170,60));
                Bitmap att1 = (Bitmap)rm.GetObject(tvoj.Atacks[0].Type);
                scG.DrawImage(att1, 248, 60, 25, 12);
                scG.DrawString("Dmg: "+Convert.ToString(tvoj.Atacks[0].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(281, 60));
                scG.DrawString(tvoj.Atacks[1].Name, new Font("COMIC SANS MS", 8), drawBrush, new Point(170, 75));
                Bitmap att2 = (Bitmap)rm.GetObject(tvoj.Atacks[1].Type);
                scG.DrawImage(att2, 248, 75, 25, 12);
                scG.DrawString("Dmg: " + Convert.ToString(tvoj.Atacks[1].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(281, 75));
                scG.DrawString(tvoj.Atacks[2].Name, new Font("COMIC SANS MS", 8), drawBrush, new Point(170,90));
                Bitmap att3 = (Bitmap)rm.GetObject(tvoj.Atacks[2].Type);
                scG.DrawImage(att3, 248, 90, 25, 12);
                scG.DrawString("Dmg: " + Convert.ToString(tvoj.Atacks[2].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(281, 90));
                scG.DrawString(tvoj.Atacks[3].Name, new Font("COMIC SANS MS", 8), drawBrush, new Point(170, 105));
                Bitmap att4 = (Bitmap)rm.GetObject(tvoj.Atacks[3].Type);
                scG.DrawImage(att4, 248,105, 25, 12);
                scG.DrawString("Dmg: " + Convert.ToString(tvoj.Atacks[3].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(281, 105));
                scG.DrawString("PRICE: " + Convert.ToString(tvoj.CenaPokemon), new Font("COMIC SANS MS", 8), drawBrush, new Point(170, 125));
                scG.DrawImage(animacijaMoj.GiveNextImage(),430, 80,220, 220);
                scG.DrawImage(Properties.Resources.violet_button_thumb, 0, 0, 130, 90);
                Image img = Mykarakter.MalaSlika;
                scG.DrawImage(img, 15, 10, 30, 30);
                scG.DrawString("Your money: ", new Font("COMIC SANS MS", 10), new SolidBrush(Color.LightSkyBlue), new Point(15, 38));
                scG.DrawString(Convert.ToString(Mykarakter.Money), new Font("COMIC SANS MS", 10), new SolidBrush(Color.LightSkyBlue), new Point(15, 50));
                g.DrawImage(btm, new Point(0, 0));
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(lista.Count));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.violet_button_thumb;
            pictureBox1.Paint+=new PaintEventHandler(pictureBox1_Paint);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("COMIC SANS MS", 10))
            {
                e.Graphics.DrawString("BUY !", myFont, Brushes.LightSkyBlue, new Point(10, 2));
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("COMIC SANS MS", 13))
            {
                e.Graphics.DrawString("BACK", myFont, Brushes.White, new Point(16, 2));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Pokemon pok = listBox1.SelectedItem as Pokemon;
                if (pok.CenaPokemon > Mykarakter.Money)
                {
                    MessageBox.Show("Немате доволно пари !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Дал исакате да го купите овој Pokemon ?", "Buy this Pokemon",
                   MessageBoxButtons.YesNo, 
                   MessageBoxIcon.Question); 
                    if (result == DialogResult.Yes)
                    {
                        Mykarakter.AddMyPokemon(pok);
                        Mykarakter.Money = Mykarakter.Money - pok.CenaPokemon;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
