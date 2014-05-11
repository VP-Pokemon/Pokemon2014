using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
namespace Pokemon_Trouble
{
    public class FlyingPokemon : PokemonItem
    {
        public static int pom = 12;
        private int x { set; get; }
        private int y { set; get; }
        private Image img1 = null;
        private Image img2 = null;
        private Image img3 = null;
        public int ID;
        public bool Hit = false;

        public int CountExplosion = 0;

        public bool Died = false;

        private int rseed = (int)DateTime.Now.Ticks;
        private Random RandomNumber = null;

        private const int kInterval = 10;
        private long Counter = 0;

        public FlyingPokemon(string i1, string i2, string i3, string i4, int x, int y)
            : base(i1)
        {
            img1 = Image.FromFile(i2);
            img2 = Image.FromFile(i3);
            img3 = Image.FromFile(i4);
            RandomNumber = new Random(rseed);
            ID = pom;
            pom -= 1; ;
            X = x;
            Y = y;
            UpdateBounds();
        }

        public void Reset()
        {
            X = 20;
            Died = false;
            Hit = false;
            CountExplosion = 0;
            UpdateBounds();
        }

        public override void Draw(Graphics g)
        {
            UpdateBounds();
            if (Hit)
            {
                DrawExplosion(g);
                return;
            }
            if (Counter % 3 == 0)
                g.DrawImage(img, MovingBounds, 0, 0, ImageBounds.Width, ImageBounds.Height, GraphicsUnit.Pixel);
            else if (Counter % 3 == 1)
                g.DrawImage(img1, MovingBounds, 0, 0, ImageBounds.Width, ImageBounds.Height, GraphicsUnit.Pixel);
            else
                g.DrawImage(img2, MovingBounds, 0, 0, ImageBounds.Width, ImageBounds.Height, GraphicsUnit.Pixel);
        }

        public void DrawExplosion(Graphics g)
        {
            if (Died)   return;

            CountExplosion++;
            if (CountExplosion < 15)
            {
                for (int i = 0; i < 50; i++)
                {
                    int xval = RandomNumber.Next(MovingBounds.Width);
                    int yval = RandomNumber.Next(MovingBounds.Height);
                    xval += X;
                    yval += Y;
                    g.DrawLine(Pens.White, xval, yval, xval, yval + 1);
                }
            }
            else
            {
                Died = true;
            }
        }

        public void Move()
        {
            if (Hit)    return;
            X += kInterval;
            Counter++;
        }
    }
}

