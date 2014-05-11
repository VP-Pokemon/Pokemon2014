using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BettelPokemon
{
   [Serializable]public  class Animations
    {

     public   Bitmap[] Images;
      public  int place = 0;

      public Animations(Bitmap[] frames)
      {
          Images = frames;
      }
      public Bitmap GiveNextImage()
      {
          Bitmap b = null;
          if (place < Images.Length)
          {
              b = Images[place++];
          }
          else
          {
              place = 0;
              b=Images[place++];
          }
          return b;
      }
   }
}
