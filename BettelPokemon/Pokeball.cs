using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Pokemon_Trouble
{
   public class Pokeball : PokemonItem
    {
        public static readonly int BallInterval = 20;
        public Pokeball(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void Draw(Graphics g)
        {
           Pen pen = new Pen(Brushes.Black,3);
           UpdateBounds();
           g.FillEllipse(Brushes.Red, X,Y, 10, 10);
           g.DrawEllipse(pen, X - 3, Y - 3, 13, 13);
           g.FillPie(Brushes.White,X,Y, 10, 10, 0, 180);
           g.DrawEllipse(pen, X + 3, Y + 3, 2, 2);
            Y = Y - BallInterval;
        }
    }
}
