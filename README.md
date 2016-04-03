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
<li>
The World map:<br/>
<img src="https://raw.githubusercontent.com/VP-Pokemon/Pokemon2014/master/p5.PNG" alt="Main Screen" height="500"/> 

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
<img src="https://www.facebook.com/photo.php?fbid=863614490332317&set=pb.100000513235553.-2207520000.1423358726.&type=3&theater" alt="Main Screen" /> 

</li>
</ul>



Battel2.cs
=====
Доколку сакате да  имате битка со некој Pokemon ,  потребно е првин да изберете еден ваш Pokemon од  листата , да селектирате левел и да притисните на копчето Challenge Pokemon  по што ќе се отвори прозорецот Pokemon Battel, во кој треба да го контролирате вашиот Pokemon  со избирање на еден од нападите , дополнително има и копче кое овозможува да го излекуваш твојот Pokemon, при што треба да платиш 2000 coins :


<ul>
<li>
Избирање на напад :</li>
<li>
<img src="https://www.facebook.com/photo.php?fbid=863614420332324&set=pb.100000513235553.-2207520000.1423358726.&type=3&theater" alt="Main Screen" /> 
</li>

<br>
<li>

Приказ на твојот напад :</li>
<li>
<img src="https://www.facebook.com/photo.php?fbid=863614426998990&set=pb.100000513235553.-2207520000.1423358726.&type=3&theater" alt="Main Screen" /> 

</li>

<li>
Кодот за тоа как осе пресметува силата на нападот врз противникот е дадена во функцијата Calculate_Damage(Attack atk)
:





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
Доколку успеетеда го поразите противникот како награда се додалува одреден број на coins  и доколку за првпат сте победилр против тој Pokemon  добивате badge како знак дека го имате поминато тој левел 

</li>
<li>

<img src="https://scontent-a-vie.xx.fbcdn.net/hphotos-xfp1/v/t1.0-9/10177922_863614460332320_3800330579748136861_n.jpg?oh=a36d5d58c94b9bef66a1451685d35b1c&oe=55558798" alt="Main Screen" /> 
</li>

<li>
Вашата цел е да ги соберите сите 18  badges :


</li>

<img src="https://fbcdn-sphotos-b-a.akamaihd.net/hphotos-ak-xfp1/v/t1.0-9/10274225_863886803638419_505936988397338532_n.jpg?oh=c84afe6464111b3fe69f324ea604fd50&oe=5555EB4A&__gda__=1432238801_b6a89c4eabeb2387fca3b7e658557fbe" alt="Main Screen" /> 
</ul>


</p>








<b>
Pokemon Trouble-боунс игра</b>
<p>

        За да внесеме поголема динамичност во првичната игра,во склоп на додадена е една бонус игра која има за цел да му     обезбеди на играчот парички(Coins). Врз основа на бројот на освоени парички во рок од 1 минута после којашто бонус       играта  Pokemon Trouble завршува. Играчот понатаму со тие пари може во главната игра да купи Pokemon и со него да        тргне во освојување на неговите противници. Со секоја победа се приближува до целта, но секое ниво погоре значи и        потежок противник. Затоа треба во бонус играта да освои што е можно повеќе парички за да купи што е можно посилен        Pokemon. 
    Како инспирација за играта ни послужи играта  “The Space Invader Game “ која можете да ја видите на линкот што го имаме наведено во користена литература    .
    
    
    Од оваа игра се искористени некои готови функции како што е функцијата за пукање и движење     на играчот. Играчот се движи со на следниот начин: лаво-left arrow, десно-right  arrow и за пукање-space.
    <ul>
    <li>
    Имплементацијата на Pokemon Trouble :
    </li>
    
    <li>
    <img src="https://fbcdn-sphotos-c-a.akamaihd.net/hphotos-ak-xfp1/v/t1.0-9/10259929_863892236971209_7490066167148740756_n.jpg?oh=4170aa1ecea9ee02c590042749603a50&oe=55527137&__gda__=1432780222_915a56ccf5ce04f98e40aae91e61fd82" alt="Main Screen" /> 
    </li>
    
    <li>
    
     Нашата идеа ја имплементиравме на тој начин што воведовме Pokemon кои летаат и носат одреден број на поени. Облачето е исто така од класата FlyingPokemon.cs како и другите летачки          Pokmon, но во случај да биде погодено со Pokeball(што е исто со Bullet во “The Space Invader Game”) облачето не           експлодира како другите Pokemon и не се добиваат поени.Облачето има улога на препрека во собирањето на поени.        Hoppip , pokemon со розова боја се разликува по другите по тоа што тој не носи дополнителни поени,туку го продолжува времето     доделено за играта.
     Swablu носи дополнителни +120 Coins а пак Noibat  ти одзема - 20 Coins  па затоа мора да избегнуваш да го погодуваш него . 
     
    </li>
    <li>
    
        <img src="https://scontent-a-vie.xx.fbcdn.net/hphotos-xpa1/v/t1.0-9/10336804_863892250304541_1266176857296768015_n.jpg?oh=1e95379872ab61d9ff06495c7e69c973&oe=554A5C56" alt="Main Screen" /> 
    
    </li>
    
    
    
    </ul>

</p>


<p>
<b>
Се надеваме дека играта ќе ви се допадне и ви посакуваме пријатна игра!
</b>

</p>

Изработија :
=====
<p>
Кристијан Ласковски 125014<br/>
Анастасија Дaвиткова 125033<br/>
Марјана Петковска 125009<br/>
</p>

Користена Литература  :
=====
<p>
<a href="http://www.serebii.net/index2.shtml">http://www.serebii.net/index2.shtml</a>
<br/>
<a href="http://www.nintendo.com/games/detail/o_rRqkFsspvnTA2VRy-edUejTFlGkDq7">http://www.nintendo.com/games/detail/o_rRqkFsspvnTA2VRy-edUejTFlGkDq7</a>
<br/>
<a href="http://www.c-sharpcorner.com/UploadFile/mgold/SpaceInvaders11152005003340AM/SpaceInvaders.aspx?ArticleID=c20a28d9-d97">http://www.c-sharpcorner.com/UploadFile/mgold/SpaceInvaders11152005003340AM/SpaceInvaders.aspx?ArticleID=c20a28d9-d97</a>
http://www.pokemon.com/us/

</p>



