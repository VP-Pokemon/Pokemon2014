using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BettelPokemon
{
   [Serializable]public  class Attack
    {
       public string Name { get; set; }
       public string Type { get; set; }
       public int Damage { get; set; }
       public string Effect { get; set; }
       public string Selfefect { get; set; }
       public Animations Animacija { get; set; }

       public Attack(string name, string type, int damage, string effect, string selfefect, Animations animacija)
       {
           Name = name;
           Type = type;
           Damage = damage;
           Effect=effect;
           Selfefect = selfefect;
           Animacija = animacija;
       }
       public override string ToString()
       {
           return Name;
       }    
    }
}
