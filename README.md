Pokemon
=======
<p>
Our idea in this project was to create a simple pokemon game using C#, and present some of the features and functionalities, like creating your own avatar, choosing your starter pokemon and simple navigation through the world map, where you can battle aginst other pokemons and collect badges for every won match, buying strong pokemons from the pokemon shop which will be neaded for completing the game. When you start the game the main screen apears where you can choose if you want to start a new game, or you want to continue to play where from your last saved game, or you don't know how to play and see the "How to play screen".
</p>
<ul>
<li>
the main screen: <br /> 
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p1.PNG" alt="HowToPlay Screen"/> </li>
<li>
The "How to play" screen weher you can learn hot to play the game :  <br /> 
<img src="https://github.com/VP-Pokemon/Pokemon2014/blob/master/p2.PNG" alt="Main Screen" /> 
</li>

<li>
If you choose to start a new gamet then you need to insert your name , to choose if you want to play with a girl or a boy, and then select your first starter pokemon. <br /> 
</li>

<li>
choosing a gender:<br />
<img src="https://github.com/VP-Pokemon/Pokemon2014/blob/master/p3.PNG" height="300"/> 
</li>
<li>
Starter pokemons:<br/>
<img src="https://github.com/VP-Pokemon/Pokemon2014/blob/master/p4.PNG" alt="Main Screen" height="300"/> 

</li>




</ul>
<p>
In this projects there are codes for the following classes: Pokemon, Avatar(Trainer), Animations, Attack, FlyingPokemon.
</p>

Animations.cs
======
<p>
The Animation class is the main class that we use to mke the animation and moverments of the pokemons and to display the attacks of the pokemons. Every animation contains a array of Bitmaps. To implement the moverments we use the method GiveNextImage() with which every pictures is drawn on the screen.
</p>



<a name="blockquotes"/>

```no-highlight
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
```
</a>

Attack.cs
=====
<p>
The next class is for the Attacks of the pokemons and she contains properties for the name of the attack, type : Normal, Bug, Dark, Dragon, Electric, Fairy, Fighting, Fire, Flying, Ghost, Grass, Ground, Ice, Poison, Psychic, Rock, Steel and Water, which will play a important role while battle between two different types of pokemons. The next property is the Damage property, Effect property which gives inforamtions about he effect of the attack, a boolean property oponent, and the last property is the animation property which is used for the animation of the attack.
<ul>
<li>
A pokemon atacking another one<br>
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p9.PNG" alt="Pokeshop" /> <br>
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p10.PNG" alt="Pokeshop" /> 

</li>
</ul>

</p>
Pokemon.cs
======

<p>

The next class is the Pokemon class, the most important class, because with this class we represent the main heros of the game. For every pokemon we define this properties: name, type, StrongAgainst, Weakness, LifePoints, array form Attacks, AnimationPokemon is the property for the animation of the moverment of the pokemon. the last property is for the price of the pokemon which will be aviable in the Pokemon shop.



<ul>
<li>
 Pokemon Shop place where you can buy a pokemon:
</li>
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p6.PNG" alt="Pokeshop" /> 
</ul>


</p>

Trainer.cs
=====

The next class ist the class for the player, or the Trainer class with with the following properties: name,Gender,money,4 Images and a list of boolean properties for the levels that he has cleared. 

<ul>
<li>
This is the screen where you can see the plaer, choose a pokemon, see the badges that you have earned, money balance and then select a level and play:
</li>

<li>
The World map:<br/>
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p5.PNG" alt="Main Screen" height="500"/> 

</li>
</ul>





<ul>




<li>
Some of the code that is used to calculate the damege on the opponents pokemon, Calculate_Damage(Attack atk) :
</li>
</ul>
```


  public void Calculate_Damage(Attack atk)
        {
            int rezultat = progressBar2.Value;
            String typeOpPok = OPpok.Type;
            String weaknessOpPok = OPpok.Weakness;
            if (weaknessOpPok == atk.Type)
            {
           rezultat -= atk.Damage*2;
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(atk.Damage*2) + " damage - SUPER EFFECTIVE";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;
                }
                else
                    progressBar2.Value = rezultat;
            }
            if (OPpok.StrongAgenst== atk.Type)
            {
                rezultat -= Convert.ToInt32(atk.Damage*0.2);
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(10*0.2) + " damage -NOT VERY EFFECTIVE";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;
                }
                else
                    progressBar2.Value = rezultat;
            }
            if ((weaknessOpPok != atk.Type) && OPpok.StrongAgenst != atk.Type)
            {
                rezultat -= atk.Damage;
                string pp = Mypok.Name + " used : " + atk.Name + "  and dealed " + Convert.ToString(atk.Damage) + " damage";
                textBox1.Text =  pp;
                if (rezultat < 0)
                {
                    rezultat = 0;
                    progressBar2.Value = rezultat;
                }
                else
                    progressBar2.Value = rezultat;
            }
        }

```


<p>

<ul>
<li>
If you win a battle than as an award you recive money and a badge. And your goal is to collect all 18 badges to clear the Game.
</li>

</ul>


</p>

References :
=====
<p>
<a href="http://www.serebii.net/index2.shtml">http://www.serebii.net/index2.shtml</a>
<br/>
<a href="http://www.nintendo.com/games/detail/o_rRqkFsspvnTA2VRy-edUejTFlGkDq7">http://www.nintendo.com/games/detail/o_rRqkFsspvnTA2VRy-edUejTFlGkDq7</a>
<br/>
<a href="http://www.c-sharpcorner.com/UploadFile/mgold/SpaceInvaders11152005003340AM/SpaceInvaders.aspx?ArticleID=c20a28d9-d97">http://www.c-sharpcorner.com/UploadFile/mgold/SpaceInvaders11152005003340AM/SpaceInvaders.aspx?ArticleID=c20a28d9-d97</a>
http://www.pokemon.com/us/

</p>



