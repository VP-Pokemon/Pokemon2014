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

    public partial class Bettel2 : Form
    {
        Animations animacijaMyPok;
        Animations ba;
        Animations anmacijaOpPok;
        Graphics g;
        Graphics scG;
        Bitmap btm;
        public Pokemon Mypok { get; set; }
        public Pokemon OPpok { get; set; }
        public Bitmap myImage { get; set; }
        public Bitmap OpImage { get; set; }
        public Image myPokemonImage { get; set; }
        public Image opPokemonImage { get; set; }
        public Image AttackImage { get; set; }
        int timer22 = 0;
        public Rectangle _myRectangle1;
        public Rectangle _myRectangle2;
        public Rectangle _myRectangle3;
        public Rectangle _myRectangle4;
        public Attack atk { get; set; }
        public Attack atkOppok { get; set; }
        public string TextvoTextBox { get; set; }
        public bool whosturn = true;
        bool myturn = true;
        int kolkuvremecoekkesedi = 0;
        public Image Pozadina { get; set; }
        public  Image slikanamojtrainer { get; set; }
        public   Trainer igrac { get; set; }
        public LevelKlasa currentLevel { get; set; }
        public Bettel2(Pokemon pok, Pokemon Oppok,Image pozadina,Trainer mojtrainer,LevelKlasa level)
        {
            InitializeComponent();
            currentLevel = level;
            igrac = mojtrainer;
            slikanamojtrainer = mojtrainer.BettelSlika;
            Pozadina = pozadina;
            TextvoTextBox = "Bettel START !";
            textBox1.Text = TextvoTextBox;
            timer1.Start();
            OPpok = Oppok;
            Mypok = pok;
            progressBar1.Maximum = Mypok.LifePoints;
            progressBar1.Value = Mypok.LifePoints;
            ResourceManager rm = Properties.Resources.ResourceManager;
            progressBar2.Maximum = Oppok.LifePoints;
            progressBar2.Value = Oppok.LifePoints; 
            pictureBox1.BackColor = Color.Transparent;
        }
       
        private void pictureBox1_Paint(object sender, PaintEventArgs e){    }
        
        private void Bettel2_Load(object sender, EventArgs e)
        {
            _myRectangle1.Height = 40;
            _myRectangle1.Width = 80;
            _myRectangle1.Location = new Point(31,328);
            _myRectangle2.Height = 40;
            _myRectangle2.Width = 80;
            _myRectangle2.Location = new Point(136, 350);
            _myRectangle3.Height = 40;
            _myRectangle3.Width = 80;
            _myRectangle3.Location = new Point(31, 373);
            _myRectangle4.Height = 40;
            _myRectangle4.Width = 80;
            _myRectangle4.Location = new Point(136, 395);
            g = this.CreateGraphics();
            btm = new Bitmap(this.Width, this.Height);
            scG = Graphics.FromImage(btm);
            animacijaMyPok = Mypok.AnimacijaPokemon;
            anmacijaOpPok = OPpok.AnimacijaPokemon;
            timer4.Start();
            timer4.Tick += new EventHandler(timer4_Tick);
        }
        public void Bettel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e){ }

        private void label5_Click(object sender, EventArgs e){ }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listBox1_MouseEnter(object sender, EventArgs e) { }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e) { }

        public void Calculate_Damage(Attack atk)
        {
            int rezultat = progressBar2.Value;
            String typeOpPok = OPpok.Type;
            String weaknessOpPok = OPpok.Weakness;
            if (weaknessOpPok == atk.Type)
            {
                rezultat -= atk.Damage*2;
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(atk.Damage*2) + " damage - SUPER EFFECTIVE";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;
                }
                else
                    progressBar2.Value = rezultat;
            }
            if (OPpok.StrongAgenst== atk.Type)
            {
                rezultat -= Convert.ToInt32(atk.Damage*0.2);
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(10*0.2) + " damage -NOT VERY EFFECTIVE";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;
                }
                else
                    progressBar2.Value = rezultat;
            }
            if ((weaknessOpPok != atk.Type) && OPpok.StrongAgenst != atk.Type)
            {
                rezultat -= atk.Damage;
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(atk.Damage) + " damage";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;

                }
                else
                    progressBar2.Value = rezultat;
            }
        }

        public void Take_Damage(Attack opatk)
        {
            int rezultat = progressBar1.Value;
            String typeOpPok = Mypok.Type;
            String weaknessOpPok = Mypok.Weakness;
            if (weaknessOpPok == opatk.Type)
            {
                rezultat -= opatk.Damage*2;
                string pp = OPpok.Name + " used : " + opatk.Name + "  and dealed " + Convert.ToString(opatk.Damage *2) + " damage - SUPER EFFECTIVE";
                textBox1.Text = pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar1.Value = rezultat;
                }
                else
                    progressBar1.Value = rezultat;
            }
            if (Mypok.StrongAgenst == opatk.Type)
            {
                rezultat -= Convert.ToInt32(opatk.Damage * 0.2); ;
                string pp = OPpok.Name + " used : " + opatk.Name + "  and dealed " + Convert.ToString(opatk.Damage * 0.2) + " damage -NOT VERY EFFECTIVE";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar1.Value = rezultat;
                }
                else
                    progressBar1.Value = rezultat;
            }
            if (weaknessOpPok != opatk.Type && Mypok.StrongAgenst != opatk.Type)
            {
                rezultat -= opatk.Damage;
                string pp = OPpok.Name + " used : " + opatk.Name + "  and dealed " + Convert.ToString(opatk.Damage) + " damage";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar1.Value = rezultat;
                }
                else
                    progressBar1.Value = rezultat;
            }
            myturn = true;
        }
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                timer1.Stop(); MessageBox.Show(" Sorry you lost !"); this.Close();
            }
            if (progressBar2.Value == 0)
            { 
                timer1.Stop();
                WinForm wi = new WinForm(currentLevel.BadgeImg,currentLevel.CoinsRewards,currentLevel.PoinatNePoiminat);
                currentLevel.PoinatNePoiminat = true;
                igrac.Money += currentLevel.CoinsRewards;
                wi.ShowDialog();
                this.Close(); 
            }
        }

        private void timer2_Tick(object sender, EventArgs e) { }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer22 += 1;
            if (timer22 <9)
            {
                scG.Clear(Color.White);
                scG.DrawImage(Pozadina, 0, 0, 578, 273);
                scG.DrawImage(animacijaMyPok.GiveNextImage(), new Point(20, 60));
                scG.DrawImage(anmacijaOpPok.GiveNextImage(), new Point(350, 60));
                scG.DrawImage(Properties.Resources.nova, 0, 273, 578, 200);
                scG.DrawImage(ba.GiveNextImage(), new Point(280, 65));
                SolidBrush myBrush = new SolidBrush(Color.Gainsboro);
                Pen blackPen = new Pen(Color.Black, 3);
                Point point1 = new Point(11, 348);
                Point point2 = new Point(31, 328);
                Point point3 = new Point(111, 328);
                Point point4 = new Point(131, 348);
                Point point5 = new Point(111, 368);
                Point point6 = new Point(31, 368);
                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                SolidBrush myBrush2 = new SolidBrush(Color.Gainsboro);
                scG.DrawPolygon(blackPen, curvePoints);
                scG.FillPolygon(myBrush2, curvePoints);
                scG.FillRectangle(myBrush, _myRectangle1);
                scG.DrawString(Mypok.Atacks[0].Name, new Font("Consolas", 10), drawBrush, new Point(31, 328));
                
                ResourceManager rm = Properties.Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(Mypok.Atacks[0].Type);
                Bitmap myImageTypePok = (Bitmap)rm.GetObject(Mypok.Type);
                scG.DrawImage(myImageTypePok, 180, 283, 30, 12);
                Bitmap myImageTypeOpPok = (Bitmap)rm.GetObject(OPpok.Type);
                scG.DrawImage(myImageTypeOpPok, 535, 283, 30, 12);
                scG.DrawImage(myImage, 81, 355, 30, 12);

                Point point7 = new Point(116, 370);
                Point point8 = new Point(136, 350);
                Point point9 = new Point(216, 350);
                Point point10 = new Point(236, 370);
                Point point11 = new Point(216, 390);
                Point point12 = new Point(136, 390);
                Point[] curvePoints2 = { point7, point8, point9, point10, point11, point12 };
                scG.DrawPolygon(blackPen, curvePoints2);
                scG.FillPolygon(myBrush2, curvePoints2);
                scG.FillRectangle(myBrush, _myRectangle2);
                scG.DrawString(Mypok.Atacks[1].Name, new Font("Consolas", 10), drawBrush, new Point(136, 350));
                Bitmap myImage1 = (Bitmap)rm.GetObject(Mypok.Atacks[1].Type);

                scG.DrawImage(myImage1, 187, 377, 30, 12);
                /*tuka drugiot napad */

                Point point13 = new Point(11, 393);
                Point point14 = new Point(31, 373);
                Point point15 = new Point(111, 373);
                Point point16 = new Point(131, 393);
                Point point17 = new Point(111, 413);
                Point point18 = new Point(31, 413);
                Point[] curvePoints3 = { point13, point14, point15, point16, point17, point18 };
                scG.DrawPolygon(blackPen, curvePoints3);
                scG.FillPolygon(myBrush2, curvePoints3);
                scG.FillRectangle(myBrush, _myRectangle3);
                scG.DrawString(Mypok.Atacks[2].Name, new Font("Consolas", 10), drawBrush, new Point(31, 373));
                Bitmap myImage3 = (Bitmap)rm.GetObject(Mypok.Atacks[2].Type);
                scG.DrawImage(myImage3, 81, 400, 30, 12);
                Point point19 = new Point(136, 395);
                Point point20 = new Point(216, 395);
                Point point21 = new Point(236, 415);
                Point point22 = new Point(216, 435);
                Point point23 = new Point(136, 435);
                Point point24 = new Point(116, 415);
                Point[] curvePoints4 = { point19, point20, point21, point22, point23, point24 };
                scG.DrawPolygon(blackPen, curvePoints4);
                scG.FillPolygon(myBrush2, curvePoints4);
                scG.FillRectangle(myBrush, _myRectangle4);
                Bitmap myImage4 = (Bitmap)rm.GetObject(Mypok.Atacks[3].Type);
                scG.DrawImage(myImage4, 187, 422, 30, 12);
                scG.DrawString(Mypok.Atacks[3].Name, new Font("Consolas", 10), drawBrush, new Point(136, 395));
                scG.DrawString(Mypok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(28, 271));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(28, 299));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(384, 299));
                scG.DrawString(OPpok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(384, 271));
                string sostojba = Convert.ToString(Mypok.LifePoints) + " / " + Convert.ToString(progressBar1.Value);
                scG.DrawString(sostojba, new Font("COMIC SANS MS", 8), drawBrush, new Point(168, 299));
                string sostojba2 = Convert.ToString(OPpok.LifePoints) + " / " + Convert.ToString(progressBar2.Value);
                scG.DrawString(sostojba2, new Font("COMIC SANS MS", 8), drawBrush, new Point(520, 299));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[1].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 364));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[0].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 342));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[2].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 387));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[3].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 410));
           
                if (kolkuvremecoekkesedi > 0 && kolkuvremecoekkesedi < 10)
                {
                    scG.DrawImage(slikanamojtrainer, 0, 80, 100, 190);
                    scG.DrawImage(Properties.Resources.dialog, 29, 17, 160, 190);
                }
                g.DrawImage(btm, new Point(0, 0));
            }
            if (timer22 == 9)
            {
                timer3.Stop(); Calculate_Damage(atk);
                timer22 = 0;
                if (progressBar2.Value != 0)
                { startTimer5(); }
                whosturn = false;
                if (atk.Selfefect == "Oponent")
                {
                    Random random = new Random();
                    int p = random.Next(1, 4);
                }
             }     
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void timer4_Tick(object sender, EventArgs e)
        {
            scG.Clear(Color.White);
            scG.DrawImage(Pozadina, 0, 0, 578, 273);
            scG.DrawImage(animacijaMyPok.GiveNextImage(), new Point(20, 60));
            scG.DrawImage(anmacijaOpPok.GiveNextImage(), new Point(350, 60));
            scG.DrawImage(Properties.Resources.nova, 0, 273, 578, 200);
            if (timer22 > 0 && timer22<9&&whosturn==true)
            {
                scG.DrawImage(ba.GiveNextImage(), new Point(280, 61));
            }
   
            if (kolkuvremecoekkesedi > 0 && kolkuvremecoekkesedi<10)
            {
                SolidBrush drawBrush22 = new SolidBrush(Color.Black);
                scG.DrawImage(slikanamojtrainer, 0, 80, 100, 190);
                scG.DrawImage(Properties.Resources.dialog, 29, 17, 160, 190);
                string mojgpvpr = "My turn !";
                string mojgpvpr1 = Mypok.Name + " use now ";
                string mojgpvpr2 = atk.Name;
                scG.DrawString(mojgpvpr, new Font("Consolas", 10), drawBrush22, new Point(65, 29));
                scG.DrawString(mojgpvpr1, new Font("Consolas", 10), drawBrush22, new Point(65, 42));
                scG.DrawString(mojgpvpr2, new Font("Consolas", 10), drawBrush22, new Point(65, 55));
            }
            
            if (timer22 > 0 && timer22 < 9 && whosturn == false)
            {
                scG.DrawImage(ba.GiveNextImage(), new Point(20, 60));
            }
            SolidBrush myBrush = new SolidBrush(Color.Gainsboro);
            Pen blackPen = new Pen(Color.Black, 3);
            Point point1 = new Point(11, 348);
            Point point2 = new Point(31, 328);
            Point point3 = new Point(111, 328);
            Point point4 = new Point(131, 348);
            Point point5 = new Point(111, 368);
            Point point6 = new Point(31, 368);
           
            Point[] curvePoints = {  point1, point2, point3,  point4, point5, point6 };
            SolidBrush drawBrush = new SolidBrush(Color.Black);
           
            SolidBrush myBrush2 = new SolidBrush(Color.Gainsboro);
       
            scG.DrawPolygon(blackPen, curvePoints);
            scG.FillPolygon(myBrush2, curvePoints);
            scG.FillRectangle(myBrush, _myRectangle1);
            
            scG.DrawString(Mypok.Atacks[0].Name, new Font("Consolas", 10), drawBrush, new Point(31, 328));
            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(Mypok.Atacks[0].Type);
            Bitmap myImageTypePok = (Bitmap)rm.GetObject(Mypok.Type);
            scG.DrawImage(myImageTypePok, 180, 283, 30, 12);
            Bitmap myImageTypeOpPok = (Bitmap)rm.GetObject(OPpok.Type);
            scG.DrawImage(myImageTypeOpPok, 535, 283, 30, 12);
            scG.DrawImage(myImage, 81,355, 30, 12);
  
            Point point7 = new Point(116, 370);
            Point point8 = new Point(136, 350);
            Point point9 = new Point(216, 350);
            Point point10 = new Point(236, 370);
            Point point11 = new Point(216, 390);
            Point point12 = new Point(136, 390);
            Point[] curvePoints2 ={  point7, point8, point9,  point10, point11, point12 };
            scG.DrawPolygon(blackPen, curvePoints2);
            scG.FillPolygon(myBrush2, curvePoints2);
            scG.FillRectangle(myBrush, _myRectangle2);
            scG.DrawString(Mypok.Atacks[1].Name, new Font("Consolas", 10), drawBrush, new Point(136, 350));
        
            Bitmap myImage1 = (Bitmap)rm.GetObject(Mypok.Atacks[1].Type);

            scG.DrawImage(myImage1, 187, 377, 30, 12);
            Point point13 = new Point(11, 393);
            Point point14 = new Point(31, 373);
            Point point15 = new Point(111, 373);
            Point point16 = new Point(131, 393);
            Point point17 = new Point(111, 413);
            Point point18 = new Point(31, 413);
            Point[] curvePoints3 = { point13, point14, point15, point16, point17, point18};
            scG.DrawPolygon(blackPen, curvePoints3);
            scG.FillPolygon(myBrush2, curvePoints3);
            scG.FillRectangle(myBrush, _myRectangle3);
            scG.DrawString(Mypok.Atacks[2].Name, new Font("Consolas", 10), drawBrush, new Point(31, 373));

            Bitmap myImage3 = (Bitmap)rm.GetObject(Mypok.Atacks[2].Type);
            scG.DrawImage(myImage3, 81, 400, 30, 12);
       
            Point point19 = new Point(136, 395);
            Point point20 = new Point(216, 395);
            Point point21 = new Point(236, 415);
            Point point22 = new Point(216, 435);
            Point point23 = new Point(136, 435);
            Point point24 = new Point(116, 415);
            Point[] curvePoints4 = { point19, point20, point21, point22, point23, point24 };
            scG.DrawPolygon(blackPen, curvePoints4);
            scG.FillPolygon(myBrush2, curvePoints4);
            scG.FillRectangle(myBrush, _myRectangle4);
            Bitmap myImage4 = (Bitmap)rm.GetObject(Mypok.Atacks[3].Type);
            scG.DrawImage(myImage4, 187, 422, 30, 12);
           
            scG.DrawString(Mypok.Atacks[3].Name, new Font("Consolas", 10), drawBrush, new Point(136, 395));
            scG.DrawString(Mypok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(28,271));
            scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(28,299));
            scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(384, 299));
            scG.DrawString(OPpok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(384, 271));

            string sostojba = Convert.ToString(Mypok.LifePoints) + " / " + Convert.ToString(progressBar1.Value);
            scG.DrawString(sostojba, new Font("COMIC SANS MS", 8), drawBrush, new Point(168, 299));

            string sostojba2 = Convert.ToString(OPpok.LifePoints) + " / " + Convert.ToString(progressBar2.Value);
            scG.DrawString(sostojba2, new Font("COMIC SANS MS", 8), drawBrush, new Point(520, 299));
            scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[1].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 364));
            scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[0].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 342));
            scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[2].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 387));
            scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[3].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 410));
            g.DrawImage(btm, new Point(0,0));
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox1_DoubleClick(object sender, EventArgs e) { }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e) { }

        private void Bettel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (myturn == true)
            {
                if (this._myRectangle1.Contains(e.Location))
                {
                    atk = Mypok.Atacks[0];
                    ba = atk.Animacija;
                    if (atk.Selfefect == "Oponent")
                    {
                        Random random = new Random();
                        int p = random.Next(1, 4);
                        timer22 = 0;
                        ShowAttack();
                        myturn = false;
                    }
                }
                if (this._myRectangle2.Contains(e.Location))
                {
                    atk = Mypok.Atacks[1];
                    ba = atk.Animacija;
                    if (atk.Selfefect == "Oponent")
                    {
                        Random random = new Random();
                        int p = random.Next(1, 4);
                        timer22 = 0;
                        ShowAttack();
                        myturn = false;
                    }
                }
                if (this._myRectangle3.Contains(e.Location))
                {
                    atk = Mypok.Atacks[2];
                    ba = atk.Animacija;
                    if (atk.Selfefect == "Oponent")
                    {
                        Random random = new Random();
                        int p = random.Next(1, 4);
                        timer22 = 0;
                        ShowAttack();
                        myturn = false;
                    }
                }
                if (this._myRectangle4.Contains(e.Location))
                {
                    atk = Mypok.Atacks[3];
                    ba = atk.Animacija;
                    if (atk.Selfefect == "Oponent")
                    {
                        Random random = new Random();
                        int p = random.Next(1, 4);
                        timer22 = 0;
                        ShowAttack();
                        myturn = false;
                    }
                }
            }
        }

        private void Bettel2_Leave(object sender, EventArgs e) { }

        private void Bettel2_MouseHover(object sender, EventArgs e) { }

        private void Bettel2_MouseEnter(object sender, MouseEventArgs e) { }

        private void Bettel2_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer4.Stop();
            timer3.Stop();
            timer1.Stop();
            timer5.Stop();
            pomosen.Stop();
            timerzaCoeknaredba.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer22 += 1;
            if (timer22 < 9)
            {
                scG.Clear(Color.White);
                scG.DrawImage(Pozadina, 0, 0, 578, 273);
                scG.DrawImage(animacijaMyPok.GiveNextImage(), new Point(20, 60));

                scG.DrawImage(anmacijaOpPok.GiveNextImage(), new Point(350, 60));
                scG.DrawImage(Properties.Resources.nova, 0, 273, 578, 200);
                
                if (timer22 > 0 && timer22 < 9 && whosturn == false)
                {
                    scG.DrawImage(ba.GiveNextImage(), new Point(20, 60));
                }
                SolidBrush myBrush = new SolidBrush(Color.Gainsboro);
                Pen blackPen = new Pen(Color.Black, 3);
                Point point1 = new Point(11, 348);
                Point point2 = new Point(31, 328);
                Point point3 = new Point(111, 328);
                Point point4 = new Point(131, 348);
                Point point5 = new Point(111, 368);
                Point point6 = new Point(31, 368);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                SolidBrush myBrush2 = new SolidBrush(Color.Gainsboro);
                scG.DrawPolygon(blackPen, curvePoints);
                scG.FillPolygon(myBrush2, curvePoints);
                scG.FillRectangle(myBrush, _myRectangle1);
                scG.DrawString(Mypok.Atacks[0].Name, new Font("Consolas", 10), drawBrush, new Point(31, 328));
                ResourceManager rm = Properties.Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(Mypok.Atacks[0].Type);
                Bitmap myImageTypePok = (Bitmap)rm.GetObject(Mypok.Type);
                scG.DrawImage(myImageTypePok, 180, 283, 30, 12);
                Bitmap myImageTypeOpPok = (Bitmap)rm.GetObject(OPpok.Type);
                scG.DrawImage(myImageTypeOpPok, 535, 283, 30, 12);
                scG.DrawImage(myImage, 81, 355, 30, 12);

                Point point7 = new Point(116, 370);
                Point point8 = new Point(136, 350);
                Point point9 = new Point(216, 350);
                Point point10 = new Point(236, 370);
                Point point11 = new Point(216, 390);
                Point point12 = new Point(136, 390);
                Point[] curvePoints2 = { point7, point8, point9, point10, point11, point12 };
                scG.DrawPolygon(blackPen, curvePoints2);
                scG.FillPolygon(myBrush2, curvePoints2);
                scG.FillRectangle(myBrush, _myRectangle2);
                scG.DrawString(Mypok.Atacks[1].Name, new Font("Consolas", 10), drawBrush, new Point(136, 350));
                Bitmap myImage1 = (Bitmap)rm.GetObject(Mypok.Atacks[1].Type);

                scG.DrawImage(myImage1, 187, 377, 30, 12);

                Point point13 = new Point(11, 393);
                Point point14 = new Point(31, 373);
                Point point15 = new Point(111, 373);
                Point point16 = new Point(131, 393);
                Point point17 = new Point(111, 413);
                Point point18 = new Point(31, 413);
                Point[] curvePoints3 = { point13, point14, point15, point16, point17, point18 };
                scG.DrawPolygon(blackPen, curvePoints3);
                scG.FillPolygon(myBrush2, curvePoints3);
                scG.FillRectangle(myBrush, _myRectangle3);
                scG.DrawString(Mypok.Atacks[2].Name, new Font("Consolas", 10), drawBrush, new Point(31, 373));
                Bitmap myImage3 = (Bitmap)rm.GetObject(Mypok.Atacks[2].Type);
                scG.DrawImage(myImage3, 81, 400, 30, 12);
                Point point19 = new Point(136, 395);
                Point point20 = new Point(216, 395);
                Point point21 = new Point(236, 415);
                Point point22 = new Point(216, 435);
                Point point23 = new Point(136, 435);
                Point point24 = new Point(116, 415);
                Point[] curvePoints4 = { point19, point20, point21, point22, point23, point24 };
                scG.DrawPolygon(blackPen, curvePoints4);
                scG.FillPolygon(myBrush2, curvePoints4);
                scG.FillRectangle(myBrush, _myRectangle4);
                Bitmap myImage4 = (Bitmap)rm.GetObject(Mypok.Atacks[3].Type);
                scG.DrawImage(myImage4, 187, 422, 30, 12);
                scG.DrawString(Mypok.Atacks[3].Name, new Font("Consolas", 10), drawBrush, new Point(136, 395));
                scG.DrawString(Mypok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(28, 271));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(28, 299));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(384, 299));
                scG.DrawString(OPpok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(384, 271));

                string sostojba = Convert.ToString(Mypok.LifePoints) + " / " + Convert.ToString(progressBar1.Value);
                scG.DrawString(sostojba, new Font("COMIC SANS MS", 8), drawBrush, new Point(168, 299));

                string sostojba2 = Convert.ToString(OPpok.LifePoints) + " / " + Convert.ToString(progressBar2.Value);
                scG.DrawString(sostojba2, new Font("COMIC SANS MS", 8), drawBrush, new Point(520, 299));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[1].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 364));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[0].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 342));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[2].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 387));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[3].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 410));
           
                g.DrawImage(btm, new Point(0, 0));
            }
            if (timer22 ==9)
            {
                timer5.Stop(); 
                Take_Damage(atkOppok);
                timer22 = 0;
                whosturn = true;
                /*if (atk.Selfefect == "Oponent")
                {
                   
                }*/
            }  
        }
        
        public void startTimer5()
        {
            Random random = new Random();
            int p = random.Next(0, 4);
            atkOppok = OPpok.Atacks[p];
            ba = atkOppok.Animacija; 
            timer5.Start();
        }
        public void ShowAttack()
        {
            timerzaCoeknaredba.Start();
            pomosen.Start();
        }
        private void timerzaCoeknaredba_Tick(object sender, EventArgs e)
        {
            if (kolkuvremecoekkesedi < 10)
            {
                scG.Clear(Color.White);
                scG.DrawImage(Pozadina, 0, 0, 578, 273);
                scG.DrawImage(animacijaMyPok.GiveNextImage(), new Point(20, 60));
                scG.DrawImage(anmacijaOpPok.GiveNextImage(), new Point(350, 60));
                scG.DrawImage(Properties.Resources.nova, 0, 273, 578, 200);
                if (timer22 > 0 && timer22 < 9 && whosturn == true)
                {
                    scG.DrawImage(ba.GiveNextImage(), new Point(280, 61));
                }
                if (timer22 > 0 && timer22 < 9 && whosturn == false)
                {
                    scG.DrawImage(ba.GiveNextImage(), new Point(20, 60));
                }
                SolidBrush myBrush = new SolidBrush(Color.Gainsboro);
                Pen blackPen = new Pen(Color.Black, 3);
                Point point1 = new Point(11, 348);
                Point point2 = new Point(31, 328);
                Point point3 = new Point(111, 328);
                Point point4 = new Point(131, 348);
                Point point5 = new Point(111, 368);
                Point point6 = new Point(31, 368);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                SolidBrush myBrush2 = new SolidBrush(Color.Gainsboro);
                scG.DrawPolygon(blackPen, curvePoints);
                scG.FillPolygon(myBrush2, curvePoints);
                scG.FillRectangle(myBrush, _myRectangle1);

                scG.DrawString(Mypok.Atacks[0].Name, new Font("Consolas", 10), drawBrush, new Point(31, 328));
                ResourceManager rm = Properties.Resources.ResourceManager;
                Bitmap myImage = (Bitmap)rm.GetObject(Mypok.Atacks[0].Type);
                Bitmap myImageTypePok = (Bitmap)rm.GetObject(Mypok.Type);
                scG.DrawImage(myImageTypePok, 180, 283, 30, 12);
                Bitmap myImageTypeOpPok = (Bitmap)rm.GetObject(OPpok.Type);
                scG.DrawImage(myImageTypeOpPok, 535, 283, 30, 12);
                scG.DrawImage(myImage, 81, 355, 30, 12);

                Point point7 = new Point(116, 370);
                Point point8 = new Point(136, 350);
                Point point9 = new Point(216, 350);
                Point point10 = new Point(236, 370);
                Point point11 = new Point(216, 390);
                Point point12 = new Point(136, 390);
                Point[] curvePoints2 = { point7, point8, point9, point10, point11, point12 };
                scG.DrawPolygon(blackPen, curvePoints2);
                scG.FillPolygon(myBrush2, curvePoints2);
                scG.FillRectangle(myBrush, _myRectangle2);
                scG.DrawString(Mypok.Atacks[1].Name, new Font("Consolas", 10), drawBrush, new Point(136, 350));
                /*tuka drugiot napad */
                Bitmap myImage1 = (Bitmap)rm.GetObject(Mypok.Atacks[1].Type);

                scG.DrawImage(myImage1, 187, 377, 30, 12);

                Point point13 = new Point(11, 393);
                Point point14 = new Point(31, 373);
                Point point15 = new Point(111, 373);
                Point point16 = new Point(131, 393);
                Point point17 = new Point(111, 413);
                Point point18 = new Point(31, 413);
                Point[] curvePoints3 = { point13, point14, point15, point16, point17, point18 };
                scG.DrawPolygon(blackPen, curvePoints3);
                scG.FillPolygon(myBrush2, curvePoints3);
                scG.FillRectangle(myBrush, _myRectangle3);
                scG.DrawString(Mypok.Atacks[2].Name, new Font("Consolas", 10), drawBrush, new Point(31, 373));

                Bitmap myImage3 = (Bitmap)rm.GetObject(Mypok.Atacks[2].Type);
                scG.DrawImage(myImage3, 81, 400, 30, 12);

                Point point19 = new Point(136, 395);
                Point point20 = new Point(216, 395);
                Point point21 = new Point(236, 415);
                Point point22 = new Point(216, 435);
                Point point23 = new Point(136, 435);
                Point point24 = new Point(116, 415);
                Point[] curvePoints4 = { point19, point20, point21, point22, point23, point24 };
                scG.DrawPolygon(blackPen, curvePoints4);
                scG.FillPolygon(myBrush2, curvePoints4);
                scG.FillRectangle(myBrush, _myRectangle4);
                Bitmap myImage4 = (Bitmap)rm.GetObject(Mypok.Atacks[3].Type);
                scG.DrawImage(myImage4, 187, 422, 30, 12);
                scG.DrawString(Mypok.Atacks[3].Name, new Font("Consolas", 10), drawBrush, new Point(136, 395));
                scG.DrawString(Mypok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(28, 271));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(28, 299));
                scG.DrawString("Life Points:", new Font("COMIC SANS MS", 10), drawBrush, new Point(384, 299));
                scG.DrawString(OPpok.Name, new Font("COMIC SANS MS", 15), drawBrush, new Point(384, 271));

                string sostojba = Convert.ToString(Mypok.LifePoints) + " / " + Convert.ToString(progressBar1.Value);
                scG.DrawString(sostojba, new Font("COMIC SANS MS", 8), drawBrush, new Point(168, 299));

                string sostojba2 = Convert.ToString(OPpok.LifePoints) + " / " + Convert.ToString(progressBar2.Value);
                scG.DrawString(sostojba2, new Font("COMIC SANS MS", 8), drawBrush, new Point(520, 299));
                scG.DrawImage(slikanamojtrainer, 0, 80, 100, 190);
                scG.DrawImage(Properties.Resources.dialog, 29,17, 160, 190);
                string mojgpvpr = "My turn !";
                string mojgpvpr1 = Mypok.Name + " use now " ;
                string mojgpvpr2 =  atk.Name;
                scG.DrawString(mojgpvpr, new Font("Consolas", 10), drawBrush, new Point(65, 29));
                scG.DrawString(mojgpvpr1, new Font("Consolas", 10), drawBrush, new Point(65, 42));
                scG.DrawString(mojgpvpr2, new Font("Consolas", 10), drawBrush, new Point(65, 55));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[1].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 364));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[0].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 342));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[2].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(30, 387));
                scG.DrawString("DMG: " + Convert.ToString(Mypok.Atacks[3].Damage), new Font("COMIC SANS MS", 8), drawBrush, new Point(136, 410));
           
                g.DrawImage(btm, new Point(0, 0));
            }
            else
            {
                pomosen.Stop();
                timer3.Start();
                timerzaCoeknaredba.Stop();
                kolkuvremecoekkesedi = 0;
            }
        }

        private void pomosen_Tick(object sender, EventArgs e)
        {
            kolkuvremecoekkesedi += 1;
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (myturn == true && whosturn == true)
            {
                if (2000 > igrac.Money)
                {
                    MessageBox.Show("You don't have enough money !");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to heal your Pokemon for 2000 coins?", "Buy this Pokemon",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int p = progressBar1.Value + 50;
                        if (p > progressBar1.Maximum)
                        {
                            progressBar1.Value = progressBar1.Maximum;
                        }
                        else progressBar1.Value = p;
                        myturn = false;
                        whosturn = false;
                        startTimer5();
                        igrac.Money = igrac.Money - 2000;
                    }
                }
            }
        }

        private void pictureBox1_Paint_2(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.Wheat);
            e.Graphics.DrawString("Heal Pokemon", new Font("COMIC SANS MS", 10), br, new Point(20,3));
            e.Graphics.DrawString("+50 Life points", new Font("COMIC SANS MS", 10), br, new Point(18, 16));
        }

        private void Bettel2_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.nova, 0, 273, 578, 200);
        }
    }
}
