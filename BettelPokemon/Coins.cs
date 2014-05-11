using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Pokemon_Trouble
{
  public  class Coins
    {
       public  int NumCoins = 0;
       public int X = 0;
       public int Y = 0;
 
       public Font MyFont = new Font("Compact", 20.0f, GraphicsUnit.Pixel);

       public Coins(int x, int y)
       {
           X = x;
           Y = y;
       }
      
       public virtual void Draw(Graphics g)
       {
           g.DrawString("Coins: " + NumCoins.ToString(), new Font("Comic Sans MS", 20.0f, FontStyle.Bold), Brushes.Black, X, Y, new StringFormat());         
       }
      
       public void UpdateCoins(int coins) //AddScore
       {
           if (NumCoins >= 0)
           {
               NumCoins += coins;
               if (NumCoins < 0) NumCoins = 0;           
           }
       }

       public int getCoins()
       {
           return NumCoins;
       }
    }
}
