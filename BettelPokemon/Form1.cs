using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pokemon_Trouble
{
      public partial class Form1 : Form
    {
        public  int score = 0;
        private FlyingPokemon Pokemon1 = null;
        private FlyingPokemon Pokemon3 = null;
        private bool flag_pok1 = false;
        private FlyingPokemon oblace = null;
        private FlyingPokemon Pokemon2 = null;
        private bool flag_oblace = false;
        private bool flag_pok2 = false;
        private bool flag_pok3 = false;
        private int interval_pok1 = 80;
        private int interval_pok3 = 80;
        private int interval_oblace = 100;
        private int interval_pok2 = 70;
        private long TimerCounter = 0;
        private bool Pow = false;
        private Player player = null;
        private Pokeball pokeball = new Pokeball(20, 30);
        public Coins coins = null;
        private string CurrentKeyDown = "";
        private string LastKeyDown = "";
        private int y;
        public Form1()
        {
            Random rnd = new Random();
            interval_pok3 = rnd.Next(63, 92);
            interval_pok2 = rnd.Next(62, 90);
            interval_pok1 = rnd.Next(60, 90);
            y= rnd.Next(70, 100);
            InitializeComponent();
            InitializeeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeAllGameObjects(true);
            this.Size = new Size(740, 520);
            progressBar1.Maximum = 60;
            progressBar1.Value = 60;
            timer1.Start();
            timer2.Start();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void InitializeAllGameObjects(bool bScore)
        {
            InitializeMan();
            InitializeCoins();
            Pokemon1 = new FlyingPokemon("D1.gif", "D2.gif", "D3.gif", "D4.gif", 20, 70);
            oblace = new FlyingPokemon("oblace.png", "oblace.png", "oblace.png", "oblace.png", 30, 200);
            Pokemon2 = new FlyingPokemon("P1.gif", "P2.gif", "P3.gif", "P4.gif", 30, 140);
            Pokemon3 = new FlyingPokemon("B1.gif", "B2.gif", "B3.gif", "B4.gif", 20, y);
        }

        private void InitializePokemon1()
        {
            Pokemon1.Reset();
            flag_pok1 = true;
        }
        
        private void InitializeOblace()
        {
            oblace.Reset();
            flag_oblace = true;
        }

        private void InitializePokemon2()
        {
            Pokemon2.Reset();
            flag_pok2 = true;
        }

        private void InitializePokemon3()
        {
            Pokemon3.Reset();
            flag_pok3 = true;
        }

        private void InitializeMan()
        {
            player = new Player();
            player.Y = ClientRectangle.Bottom - 100;
        }

        private void InitializeCoins()
        {
            coins = new Coins(ClientRectangle.Right - 150, 20);
        }

        private void InitializeeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout();
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 622);
            this.KeyPreview = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.Size = new Size(718, 539);
        }

        private void HandleKeys()
        {
            switch (CurrentKeyDown)
            {
                case "Space":
                    if (Pow == false)
                    {
                        pokeball.X = player.PokeballStart().X;
                        pokeball.Y = player.PokeballStart().Y;
                        Pow = true;
                    }
                    CurrentKeyDown = LastKeyDown;
                    break;
                case "Left":
                    player.MoveLeft();
                    Invalidate(player.GetBounds());
                    if (timer1.Enabled == false)
                        timer1.Start();
                    break;
                case "Right":
                    player.MoveRight(ClientRectangle.Right);
                    Invalidate(player.GetBounds());
                    if (timer1.Enabled == false)
                        timer1.Start();
                    break;
                default:
                    break;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
             HandleKeys();
             TimerCounter++;
             if (pokeball.Y < 0)   
             {
                 Pow = false;
            }
            if (flag_oblace && Pow && oblace.GetBounds().IntersectsWith(pokeball.GetBounds()))
            {
                Pow = false;
            }
            if (TimerCounter % interval_pok1 == 0)
            {
                InitializePokemon1();
                flag_pok1 = true;
            }
            if (TimerCounter % interval_oblace== 0)
            {
                InitializeOblace();
                flag_oblace = true;
            }
            if (TimerCounter % interval_pok2 == 0)
            {
                InitializePokemon2();
                flag_pok2 = true;
            }
            if (TimerCounter % interval_pok3 == 0)
            {
                InitializePokemon3();
                flag_pok3 = true;
            }
            if (flag_pok1 == true)
            {
                Pokemon1.Move();
                if (Pokemon1.GetBounds().Left > ClientRectangle.Right)
                {
                    flag_pok1 = false;
                }
            }
            if (flag_oblace == true)
            {
                oblace.Move();
                if (oblace.GetBounds().Left > ClientRectangle.Right)
                {
                    flag_oblace = false;
                }
            }
            if (flag_pok3 == true)
            {
                Pokemon3.Move();
                if (Pokemon3.GetBounds().Left > ClientRectangle.Right)
                {
                    flag_pok3 = false;
                }
            }
            if (flag_pok2 == true)
            {
                Pokemon2.Move();
                if (Pokemon2.GetBounds().Left > ClientRectangle.Right)
                {
                    flag_pok2 = false;
                }
            }
            TestBulletCollision();
            Invalidate();
        }

        void TestBulletCollision()
        {
          if (flag_pok1 && Pow && Pokemon1.GetBounds().IntersectsWith(pokeball.GetBounds()))
            {
                Pokemon1.Hit = true;
                coins.UpdateCoins(-20);
                flag_pok1 = false;
                label2.Text = " -20 Coins";
                label2.Refresh();
            }

          if (flag_pok3 && Pow && Pokemon3.GetBounds().IntersectsWith(pokeball.GetBounds()))
          {
              Pokemon3.Hit = true;
              if (progressBar1.Value+1 > 60)
              {
                  progressBar1.Value = 60;
              }
              else progressBar1.Value +=1;
              label2.Text = " +1 sec";
              label2.Refresh();
          } 
        
          if (flag_pok2 && Pow && Pokemon2.GetBounds().IntersectsWith(pokeball.GetBounds()))
            {
              Pokemon2.Hit = true;
              coins.UpdateCoins(120);
              flag_pok2 = false;
              label2.Text = " +120 Coins ";
              label2.Refresh();
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            string result = e.KeyData.ToString();
            CurrentKeyDown = result;
            if (result == "Left" || result == "Right")
            {
                LastKeyDown = result;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string result = e.KeyData.ToString();
            if (result == "Left" || result == "Right")
            {
                LastKeyDown = "";
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            player.Draw(g);
            coins.Draw(g); 
            if (Pow)      
            {
                pokeball.Draw(g);
            }
            if (flag_pok1)   
            {
                Pokemon1.Draw(g);
            }
            if (flag_oblace)
            {
                oblace.Draw(g);
            }
            if (flag_pok2)
            {
                Pokemon2.Draw(g);
            }
            if (flag_pok3)
            {
                Pokemon3.Draw(g);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = " ";
            label2.Refresh();
            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }
            if (progressBar1.Value == 0)
            {
                timer2.Stop();
                timer1.Stop();
                MessageBox.Show("Congratulation you have earned " + coins.getCoins().ToString() + "  Coins !");
                this.Close();
            }
        }
      }
   }
