using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BettelPokemon
{
  [Serializable]public class Pokemon
    {
      public string Name { get; set; }
      public string Weakness { get; set; }
      public string StrongAgenst { get; set; }
      public string Type { get; set; }
      public int  LifePoints { get; set; }
      public List<Attack> Atacks { get; set; }
      public Animations AnimacijaPokemon { get; set; }
      public int CenaPokemon { get; set; }
      public Pokemon(string name, string image_name,string type,int lifepoints,Animations animacijapokemon,string strongAgenst,int cena)
      {
          Name=name;
          Weakness = image_name;
          Type = type;
          LifePoints = lifepoints;
          Atacks = new List<Attack>();
          AnimacijaPokemon = animacijapokemon;
          StrongAgenst = strongAgenst;
          CenaPokemon = cena;
      }
      public void AddAtack(Attack atk )
      {
          Atacks.Add(atk);
      }
      public void AddAtack(string name, string type , int damage , string efect,string selfatack,Animations animacija)
      {
          Attack atk = new Attack(name,type,damage,efect,selfatack,animacija);
          Atacks.Add(atk);
      }
      public override string ToString()
      {
          return Name;
      }
    }
}
