using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace BettelPokemon
{
    [Serializable]public class Trainer
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int  Money { get; set; }
        public List<Pokemon> Mypokemon{ get; set; }
        public string ProfilePicture { get; set; }
        public Image GolemaSlika{ get; set; }
        public Image BettelSlika {get; set; }
        public Image MalaSlika {get; set; }
        public Image SrednaSlika {get; set; }
        public List<bool> Leveli { get; set; }
        public Trainer(string name, string gender, int money, string profilepicture,Image golemaSlika,Image  bettelSlika,Image malaSlika,Image srednaSlika)
        { 
            Name=name;
            Gender = gender;
            Money = money;
            ProfilePicture = profilepicture;
            Mypokemon = new List<Pokemon>();
            GolemaSlika=golemaSlika;
            BettelSlika=bettelSlika;
            MalaSlika=malaSlika;
            SrednaSlika=srednaSlika;
            Leveli = new List<bool>();
        }
        public void  AddMyPokemon(Pokemon muPok)
        {
            Mypokemon.Add(muPok);
        }
        public void AddMyPokemon(string name, string image_name, string type, int lifepoints, Animations animacija, string strongAgenst,int cena)
        {
            Pokemon pok = new Pokemon(name, image_name, type, lifepoints, animacija, strongAgenst,cena);
            Mypokemon.Add(pok);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
