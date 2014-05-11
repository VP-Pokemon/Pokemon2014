using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BettelPokemon
{
   public  class LevelKlasa
    {
       public Image BadgeImg;
       public bool PoinatNePoiminat;
       public int CoinsRewards;
       public Pokemon LevelPokemon;
       public  LevelKlasa(Image badgeimg, bool pn, int rcoins, Pokemon pok)
       {
           BadgeImg = badgeimg;
           PoinatNePoiminat = pn;
           CoinsRewards = rcoins;
           LevelPokemon = pok;
       }
       public LevelKlasa() { }
    }
}
