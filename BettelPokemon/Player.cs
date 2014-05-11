using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Pokemon_Trouble
{
  public  class Player :PokemonItem
    {
        public int player_interval = 5;
        public Player(): base("player.gif")
        {
            X = 300;
            Y = 530;
        }
        public Point PokeballStart() 
        {
            Point pokeball = new Point(MovingBounds.Left + MovingBounds.Width / 2, MovingBounds.Top - 10);
            return pokeball; 
        }
        public void MoveLeft()
        {
            X -= player_interval;
            if (X < 0)
                X = 0;
        }
        public void MoveRight(int nLimit)
        {
            X += player_interval;
            if (X > nLimit - Width)      X = nLimit - Width;
        }
    }
}
