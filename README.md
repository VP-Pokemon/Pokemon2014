Pokemon
=======
<p>
Сите ние  уште од мали нозе сме играле игри најпрвин на онаа малата игричка наречена Тетрис. Но подоцна излезе нешто што го нарекуваа Nintendo. Му се воодушевувавме. Уште повеќе подоцна кога ги игравме игрите на него. Е оттука прозлегува идејата за нашата семинарска работа која е да направиме апликација која ќе ја
имплементира една од најпознатите игри за Nintendo 3DS, а тоа е играта 
Pokemon. Нашата идеа е да претставиме дел од можностите и функционалностите
во играта Pokemon, односно ќе бидат имплементирани можноста за креирање на 
сопствен аватар, избирање на сопствен почетен Pokemon, едноставна навигација
низ мапата при што е овозможена битка помеѓу Pokemon од различни области,
купување на нови Pokemon кои ќе ти бидат од корист за победување на лошите Pokemon
од наредните стази кои се се потешки се победување. Дополнително 
ќе имаме и мала игра Pokemon Trouble наменета за собирање на coins, односно пари, 
се со цел да се олесни купувањето на појак Pokemon.
Идеjата за играта ја измисливме сами, направивме целосна 
замисла за изгледот на апликацијата.</p>
<ul>
<li>Главниот екран: <br /> 
<img src="https://fbcdn-sphotos-b-a.akamaihd.net/hphotos-ak-xfp1/v/t1.0-9/10171007_863618393665260_9047700993413522808_n.jpg?oh=75be23e64f8e6cf7103f16dd82e1f2ec&oe=5552ADB3&__gda__=1431101754_8e72a36d464a2a15e93203087b48f9bf" alt="HowToPlay Screen"/> </li>
<li>
How to play  екранот во кој се објаснува како се игра играта : <br /> 
<img src="https://scontent-b-vie.xx.fbcdn.net/hphotos-xpf1/v/t1.0-9/10259451_863614503665649_7462720126849326976_n.jpg?oh=088b69c4303ad13ac58d415d38fa7fae&oe=5558A9B1" alt="Main Screen" /> 
</li>

<li>
При изборот на нова игра потребно е да се избери дали ќе играш како Boy / Girl , да внесиш твое име , потоа од листата на  три почетни Pokemon  да избериш еден , а послетоа се започнува со играта : <br /> 


</li>

<li>
Избор на пол:<br />
<img src="https://scontent-a-vie.xx.fbcdn.net/hphotos-xfa1/v/t1.0-9/10269382_863626996997733_7102921837685817971_n.jpg?oh=634b5467fe63a7d948836754b4464370&oe=55567342" height="300"/> 
</li>

<li>

Внесување име :<br/>
<img src="https://fbcdn-sphotos-c-a.akamaihd.net/hphotos-ak-xfa1/v/t1.0-9/10173757_863626993664400_539012307662050299_n.jpg?oh=bd18b20366d547fb2d8fec648fc704de&oe=554D4CC0&__gda__=1431729040_8c76836ea21ee8ca445f98b48e7534a7" alt="Main Screen" height="300"/> 

</li>


<li>

Избирање на почетен Pokemon:<br/>
<img src="https://www.facebook.com/photo.php?fbid=863618396998593&set=pb.100000513235553.-2207520000.1423358726.&type=3&theater" alt="Main Screen" height="300"/> 

</li>




</ul>
<p>
Во кодот има имплементации на класи за Pokemon, Avatar(Trainer), Animations, Attack, FlyingPokemon.
</p>

Animations.cs
======
<p>
Класата Animations е основната класа која ја користиме за доловување на анимацијата за движењата на Pokemoni-те, како и нивните меѓусебни напаѓања. Таа се состои од поле од Bitmaps и нивни редни броеви. За имплементација на овие движења го користиме методот GiveNextImage() со кој редоследно се исцртуваат сликите.






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
Следната класа, класата Attack, е задолжена за реализација на нападите на Pokemon. Таа се состои од име на нападот, како и вкупно 18 типови на напади: Normal, Bug, Dark, Dragon, Electric, Fairy, Fighting, Fire, Flying, Ghost, Grass, Ground, Ice, Poison, Psychic, Rock, Steel и Water така што при битката помеѓу два Pokemon од различен тип ќе играат огромна улога заради предностите и слабостите на Pokemoni-те. Следен параметар во класата Attack е Damage или сила на нападот, Effect – опис на нападот, Opponent кој кажува дали нападот се извршува врз противникот, и последниот параметар од оваа класа е Animacija кој го користиме за визуелно претставување на нападот врз противникот.
<ul>
<li>
Тебела која кажува колку damage  ќе се изврши при битката на дава различни Pokemon:
</li>
<img src="https://scontent-a-vie.xx.fbcdn.net/hphotos-xpa1/v/t1.0-9/10341837_863647500329016_2119377125619475598_n.jpg?oh=9f89bfbb467beb798de7e2c099d875f4&oe=55565CD0" alt="Main Screen" /> 
</ul>

</p>
Pokemon.cs
======

<p>
Следната класа е Pokemon. Доста важна класа затоа што во неа се претставуваат главните херои во играта. За секој Pokemon се дефинирани следните параметри: име на Pokemon-от, тип, следи параметарот кој ги опишува предностите на дадениот Pokemon параметарот StrongAgainst, односно ги опишуваме предностите на еден Pokemon врз друг. Спротивно на овој е параметарот Weakness. Следи параметарот LifePoints, овие поени се всушност јачината на Pokemon-от, пославите Pokemon имаат помалку LifePoints па затоа се полесни за победување. Тука чуваме и листа од класата Attack, односно секој Pokemon има по 4 напади предефинирани за него кои најчесто се од ист тип како и Pokemon-от. Параметарот AnimacijaPokemon е всушност објект од Animations и го корстиме за изгледот и движењето на Pokemon-от. Последен е параметарот CenaPokemon кој како што кажува името е цената на Pokemon-от кој ќе биде достапен во Pokemon Shop – продавницата за Pokemon.

<ul>
<li>
 Pokemon Shop  местото каде што можите да купите Pokemon и притоа има детелен приказ за карактеристиките како и цената на секој Pokemon:
</li>
<img src="https://fbcdn-sphotos-g-a.akamaihd.net/hphotos-ak-frc3/v/t1.0-9/10309176_863614470332319_2260707826821677264_n.jpg?oh=427e8907d0915af5b74cd46b79f3756d&oe=5407123A&__gda__=1409951786_1377f9c1dac9c31e6d66f76f1642a0d8" alt="Main Screen" /> 
</ul>


</p>

Trainer.cs
=====

Следната класа Trainer претставува класа за Аватарот. Нејзини параметри се :  Name - име на аватарот, Gender – машки или женски, кој се избира на почетокот на играта, Money – парите со кои располагаме во моментот. Потоа, оваа класа има четири параметри од типот Image. Аватарот има листа од класата Pokemon, така што секој trainer може да има колку што сака Pokemoni и какви што сака. И последниот параметар е листа од тип bool – Leveli кој ни покажува кои стази ти има отворено карактерот, односно на кои места го има победено противникот

<ul>
<li>
Ова претставува главниот прозорец каде што се прикаживаат информациите за твојот карактер како и мапата со левелите каде што треба да се одржи битката помеѓу Pokemoni,  притоа во играта оставивме повеќето левели да се отворени , а само 5 левели се заклучени  :
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



