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
    public partial class HelpCenter : Form
    {
        public HelpCenter()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        int kojenared = 0;
       
        private void HelpCenter_Load(object sender, EventArgs e) { }

        private void HelpCenter_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawImage(Properties.Resources.helpcenter, 0, 0, 723, 465);
            e.Graphics.DrawImage(Properties.Resources.Cheren_large1,580,140, 120, 280);
            if (kojenared == 0)
            {
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 170, 180);
                e.Graphics.DrawString("Hi ! ", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("My name is Chesen ", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("and this is the", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("Pokemon Help Center!", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 60));
            }
            if (kojenared ==1)
            {
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 180);
                e.Graphics.DrawString("I'm going to help ", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("you to learn how to", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("play this game!", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("So listen to me!", new Font("COMIC SANS MS", 10), drawBrush, new Point(526, 60));
            }
            if (kojenared == 2)
            {
                e.Graphics.DrawImage(Properties.Resources.T5, 0, 0, 550, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("After you have created", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("your avatar your journy ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("begins, now you have to ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("challenge all pokemons on", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("the Pokemon World map", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 3)
            {
                e.Graphics.DrawImage(Properties.Resources.T3, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("After you have selected", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("a pokemon from your ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("list, and choosen a level", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("the Pokemon Battle", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("begins!", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 4)
            {
                e.Graphics.DrawImage(Properties.Resources.T3, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("You must choose the", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("right pokemon when you ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("enter the Battel, because", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("there are 18 types of ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("Pokemons and depending ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 5)
            {
                e.Graphics.DrawImage(Properties.Resources.T3, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("of the type of the ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("pokemon the damgae that", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("is made is different", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("because each Pokemon has", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("its own advantages and", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 6)
            {
                e.Graphics.DrawImage(Properties.Resources.T6, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("disadvantages , and they", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("are given in this table!", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("You must learn this table", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("if you want to win in", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("the battels !", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 7)
            {
                e.Graphics.DrawImage(Properties.Resources.Tutorial4, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("If you win in a battel", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("for the first time, you will", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("be rewarded with a badge.", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("Your goal is to colect all", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("18 badges!", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 8)
            {
              e.Graphics.DrawImage(Properties.Resources.T4, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("To colect all badges you", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("will need stronger pokemon", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("and they can be  bought ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("in the Pokemon Shop !", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
            }
            if (kojenared == 9)
            {
                e.Graphics.DrawImage(Properties.Resources.T1, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 190, 190);
                e.Graphics.DrawString("To buy stronger pokemon", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("you will need more coins", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("and you can earn them in", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("the mini game ", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("Pokemon Trouble !", new Font("COMIC SANS MS", 9), drawBrush, new Point(526, 75));
            }
            if (kojenared == 10)
            {
                e.Graphics.DrawImage(Properties.Resources.T2, 0, 0, 520, 430);
                e.Graphics.DrawImage(Properties.Resources.talk2, 500, 1, 200, 200);
                e.Graphics.DrawString(" There are three kinds of", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("pokemon , Hoppip gives you", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("+1 sec to you time limit,", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("Swablu gives +120 coins ", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("and Nobiat -20 coins so avoid", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 75));
                e.Graphics.DrawString("       hiting Noibat!", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 90));
            }
            if (kojenared == 11)
            {
                e.Graphics.DrawImage(Properties.Resources.talk2, 490, 1, 210, 210);
                e.Graphics.DrawString(" This is all I had to tell", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 15));
                e.Graphics.DrawString("you about this game.If you", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 30));
                e.Graphics.DrawString("need help again you can", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 45));
                e.Graphics.DrawString("visit me whenever you want.", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 60));
                e.Graphics.DrawString("Now is your turn to start", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 75));
                e.Graphics.DrawString("exploring the Pokemon World!", new Font("COMIC SANS MS", 8), drawBrush, new Point(526, 90));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kojenared += 1;
            if (kojenared == 12)    kojenared =0;
            this.Paint+=new PaintEventHandler(HelpCenter_Paint);
            Invalidate(true);
        }
    }
}
