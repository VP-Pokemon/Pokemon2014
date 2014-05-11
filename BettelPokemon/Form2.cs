using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using Pokemon_Trouble;
using System.IO;

namespace BettelPokemon
{
    public partial class Form2 : Form
    {
        public string FileName;
        Graphics g;
        Graphics scG;
        Bitmap btm;
        int kadedasenacrtacoeceto1 = 565;
        int kadedasenacrtacoeceto2 = 425;
        public Pokemon pk1 { get; set; }
        public Pokemon pk2 { get; set; }
        public Attack ThunderShock { get; set; }
        public Attack Tackle { get; set; }
        public Attack Rest { get; set; }
        public Attack Poison { get; set; }
        public Attack Scratch { get; set; }
        public Attack Flamethrower { get; set; }
        public Attack ThunderWave { get; set; }
        public Bitmap myImageTrainer { get; set; }
        public Pokemon Delphox { get; set; }
        public Pokemon Gardevoir { get; set; }
        public Pokemon Froakie { get; set; }
        public Pokemon Pikachu { get; set; }
        public Pokemon Spewpa { get; set; }
        public Pokemon Keldeo { get; set; }
        public Pokemon Yveltal { get; set; }
        public Pokemon Articuno { get; set; }
        public Pokemon Aggron { get; set; }
        public Pokemon Altaria { get; set; }
        public Pokemon Auroras { get; set; }
        public Pokemon Bunneldy { get; set; }
        public Pokemon Burmy { get; set; }
        public Pokemon Charizard { get; set; }
        public Pokemon Chesinn { get; set; }
        public Pokemon Combee { get; set; }
        public Pokemon Croagunk { get; set; }
        public Pokemon Dedenne { get; set; }
        public Pokemon Escavaler { get; set; }
        public Pokemon Fenniken { get; set; }
        public Pokemon Floate { get; set; }
        public Pokemon Goodra { get; set; }
        public Pokemon Gorgiest { get; set; }
        public Pokemon Hawlucha { get; set; }
        public Pokemon Hydragon { get; set; }
        public Pokemon Klefkie { get; set; }
        public Pokemon Luxary { get; set; }
        public Pokemon Noivern { get; set; }
        public Pokemon Pangoro { get; set; }
        public Pokemon Pyroar { get; set; }
        public Pokemon Pyroarr { get; set; }
        public Pokemon Rootom { get; set; }
        public Pokemon Smoochum { get; set; }
        public Pokemon Spritzee { get; set; }
        public Pokemon Trevenant { get; set; }
        public Pokemon Tyranturum { get; set; }
        public Pokemon Vanillite { get; set; }
        public Pokemon Vivillion { get; set; }
        public Pokemon Volcarona { get; set; }
        public Pokemon Gyarados { get; set; }
        public Pokemon Xerneas { get; set; }
        public Pokemon Zoroak { get; set; }
        public Pokemon Aerodactil { get; set; }
        public Image arena1 { get; set; }
        public Pokemon setepaso{ get; set; }
        public Pokemon Chesnaught { get; set; }
        public Animations Pocetnaanimacija { get; set; }
        public bool level1 = true;
        public bool level2 = true;
        public bool level3 = true;
        public bool level4 = true;
        public bool level5 = true;
        public bool level6 = true;
        public bool level7 = true;
        public bool level8 = true;
        public bool level9 = true;
        public bool level10 = true;
        public bool level11 =true;
        public bool level12 = true;
        public bool level13 = true;
        public bool level14 = false;
        public bool level15 = false;
        public bool level16 = false;
        public bool level17 = false;
        public bool level18 = false;
        public  Image ts { get; set; }
        public  Trainer MyTrainer { get; set; }
        public Pokemon ChalangePokemon { get; set; }
        public List<Pokemon> listaZavoProdavnica { get; set; }
        public LevelKlasa MomentalenLevel { get; set; }
        public LevelKlasa Level1 { get; set; }
        public LevelKlasa Level2 { get; set; }
        public LevelKlasa Level3 { get; set; }
        public LevelKlasa Level4 { get; set; }
        public LevelKlasa Level5 { get; set; }
        public LevelKlasa Level6 { get; set; }
        public LevelKlasa Level7 { get; set; }
        public LevelKlasa Level8 { get; set; }
        public LevelKlasa Level9 { get; set; }
        public LevelKlasa Level10 { get; set; }
        public LevelKlasa Level11 { get; set; }
        public LevelKlasa Level12 { get; set; }
        public LevelKlasa Level13 { get; set; }
        public LevelKlasa Level14 { get; set; }
        public LevelKlasa Level15 { get; set; }
        public LevelKlasa Level16 { get; set; }
        public LevelKlasa Level17 { get; set; }
        public LevelKlasa Level18 { get; set; }
        public void postavi()
        {
            Level1 = new LevelKlasa(Properties.Resources.badge__1_, false, 1200, Bunneldy);
            Level2 = new LevelKlasa(Properties.Resources.badge__2_, false, 1800, Floate);
            Level3 = new LevelKlasa(Properties.Resources.badge__3_, false, 2400, Gorgiest);
            Level4 = new LevelKlasa(Properties.Resources.badge__4_, false, 3000,Aggron);
            Level5 = new LevelKlasa(Properties.Resources.badge_5_, false, 3600, Tyranturum);
            Level6 = new LevelKlasa(Properties.Resources.badge__6_, false, 4200, Pangoro);
            Level7 = new LevelKlasa(Properties.Resources.badge__7_, false, 4800,Luxary);
            Level8 = new LevelKlasa(Properties.Resources.badge__8_, false, 5400, Articuno);
            Level9 = new LevelKlasa(Properties.Resources.badge__9_, false, 6000, Goodra);
            Level10 = new LevelKlasa(Properties.Resources.badge__10_, false, 6600, Volcarona);
            Level11 = new LevelKlasa(Properties.Resources.badge__11_, false, 7200, Gardevoir);
            Level12 = new LevelKlasa(Properties.Resources.badge__12_, false,7800, Gyarados);
            Level13 = new LevelKlasa(Properties.Resources.badge__13_, false, 8400, Trevenant);
            Level14 = new LevelKlasa(Properties.Resources.badge__14_, false, 9000, Auroras);
            Level15 = new LevelKlasa(Properties.Resources.badge__15_, false, 9600, Noivern);
            Level16 = new LevelKlasa(Properties.Resources.badge__16_, false, 10000, Delphox);
            Level17 = new LevelKlasa(Properties.Resources.badge__17_, false, 11000, Aerodactil);
            Level18 = new LevelKlasa(Properties.Resources.badge__18_, false, 12000, Yveltal);
        }

     public void iscrtajBadges() { }

     public void setPozadina1()
     {
         arena1 = Properties.Resources.arena1__10_;
         setepaso = Floate;
         MomentalenLevel = Level2;
     }
     public void setPozadina2()
     {
         arena1 = Properties.Resources.arena1__6_;
         setepaso = Bunneldy;
         MomentalenLevel = Level1;
     }
     public void setPozadina3()
     {
         arena1 = Properties.Resources.arena1__4_;
         setepaso = Gorgiest;
         MomentalenLevel = Level3;
     }
     public void setPozadina4()
     {
         arena1 = Properties.Resources.arena1__7_;
         setepaso = Aggron;
         MomentalenLevel = Level4;
     }
     public void setPozadina5()
     {
         arena1 = Properties.Resources.arena1__8_;
         setepaso = Tyranturum;
         MomentalenLevel = Level5;
     }
     public void setPozadina6()
     {
         arena1 = Properties.Resources.arena1__18_;
         setepaso = Pangoro;
         MomentalenLevel = Level6;
     }
     public void setPozadina7()
     {
         arena1 = Properties.Resources.arena1__2_;
         setepaso = Luxary;
         MomentalenLevel = Level7;
     }
     public void setPozadina8()
     {
         arena1 = Properties.Resources.arena1__3_;
         setepaso = Articuno;
         MomentalenLevel = Level8;
     }
     public void setPozadina9()
     {
         arena1 = Properties.Resources.arena1__17_;
         setepaso = Goodra;
         MomentalenLevel = Level9;
     }
     public void setPozadina10()
     {
         arena1 = Properties.Resources.arena1__15_;
         setepaso =Volcarona;
         MomentalenLevel = Level10;
     }
     public void setPozadina11()
     {
         arena1 = Properties.Resources.arena1__1_;
         setepaso = Gardevoir;
         MomentalenLevel = Level11;
     }
     public void setPozadina12()
     {
         arena1 = Properties.Resources.arena1__12_;
         setepaso = Gyarados;
         MomentalenLevel = Level12;
     }
     public void setPozadina13()
     {
         arena1 = Properties.Resources.arena1__9_;
         setepaso =Trevenant;
         MomentalenLevel = Level13;
     }
     public void setPozadina14()
     {
         arena1 = Properties.Resources.arena1__14_;
         setepaso = Auroras;
         MomentalenLevel = Level14;
     }
     public void setPozadina15()
     {
         arena1 = Properties.Resources.arena1__13_;
         setepaso = Aerodactil;
         MomentalenLevel = Level17;
     }
     public void setPozadina16()
     {
         arena1 = Properties.Resources.arena1__11_;
         setepaso = Yveltal;
         MomentalenLevel = Level18;
     }
     public void setPozadina17()
     {
         arena1 = Properties.Resources.arena1__16_;
         setepaso =Noivern;
         MomentalenLevel = Level15;
     }
     public void setPozadina18()
     {
         arena1 = Properties.Resources.arena1__5_;
         setepaso = Delphox;
         MomentalenLevel = Level16;
     }
    
     public void levelipromeni()
     {
         if (MyTrainer.Leveli[0] == false)
         {
             pictureBox1.Image = Properties.Resources.logo;
         }
         else { pictureBox1.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[1] == false)
         {
             pictureBox2.Image = Properties.Resources.logo;
         }
         else { pictureBox2.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[2] == false)
         {
             pictureBox3.Image = Properties.Resources.logo;
         }
         else { pictureBox3.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[3] == false)
         {
             pictureBox5.Image = Properties.Resources.logo;
         }
         else { pictureBox5.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[4] == false)
         {
             pictureBox4.Image = Properties.Resources.logo;
         }
         else { pictureBox4.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[5] == false)
         {
             pictureBox6.Image = Properties.Resources.logo;
         }
         else { pictureBox6.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[6] == false)
         {
             pictureBox7.Image = Properties.Resources.logo;
         }
         else { pictureBox7.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[7] == false)
         {
             pictureBox8.Image = Properties.Resources.logo;
         }
         else { pictureBox8.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[8] == false)
         {
             pictureBox9.Image = Properties.Resources.logo;
         }
         else { pictureBox9.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[9] == false)
         {
             pictureBox10.Image = Properties.Resources.logo;
         }
         else { pictureBox10.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[10] == false)
         {
             pictureBox11.Image = Properties.Resources.logo;
         }
         else { pictureBox11.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[11] == false)
         {
             pictureBox12.Image = Properties.Resources.logo;
         }
         else { pictureBox12.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[12] == false)
         {
             pictureBox13.Image = Properties.Resources.logo;
         }
         else { pictureBox13.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[13] == false)
         {
             pictureBox14.Image = Properties.Resources.logo;

         }
         else { pictureBox14.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[14] == false)
         {
             pictureBox15.Image = Properties.Resources.logo;
         }
         else { pictureBox15.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[15] == false)
         {
             pictureBox16.Image = Properties.Resources.logo;
         }
         else { pictureBox16.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[16] == false)
         {
             pictureBox17.Image = Properties.Resources.logo;
         }
         else { pictureBox17.Image = Properties.Resources.location; }
         if (MyTrainer.Leveli[17] == false)
         {
             pictureBox18.Image = Properties.Resources.logo;
         }
         else { 
             pictureBox18.Image = Properties.Resources.location; 
         }
     }
        public Trainer mojigrac { get; set; }
        public int kojenared=0;
        public Rectangle _myRectangle1;
        public int iscrtuvanje = 1;
        public Rectangle _myRectangle2;
        public Rectangle _myRectangle3;
        public Rectangle _myRectangle4;
        public Rectangle _myRectangle5;
        public Rectangle _myRectangle6;
        public Rectangle _myRectangle7;
        public Rectangle _myRectangle8;
        public int pol = 0;
        public string Ime_trainer;
        public Pokemon Myfirstpokemon { get; set; }
        public void iscrtaj()
        {
            _myRectangle1.Height = 40;
            _myRectangle1.Width = 160;
            _myRectangle1.Location = new Point(300, 280);
            _myRectangle2.Height = 20;
            _myRectangle2.Width = 85;
            _myRectangle3.Height = 20;
            _myRectangle3.Width = 85;
            _myRectangle4.Height = 20;
            _myRectangle4.Width = 85;
            _myRectangle5.Height = 20;
            _myRectangle5.Width = 85;
            _myRectangle6.Height = 20;
            _myRectangle6.Width = 85;
            _myRectangle7.Height = 20;
            _myRectangle7.Width = 85;
            _myRectangle8.Height = 20;
            _myRectangle8.Width = 120;
            this.DoubleBuffered = true;
            timer1.Start();
        }
        public Form2()
        {
            InitializeComponent();
            postavi();
            iscrtaj();
            MomentalenLevel = new LevelKlasa();
            Animations Swift_A = new Animations(new Bitmap[] { Properties.Resources.swift_001__3_, Properties.Resources.swift_001__4_, Properties.Resources.swift_001__5_, Properties.Resources.swift_001__9_, Properties.Resources.swift_001__11_ });
            Attack Swift = new Attack("Swift", "normal", 20, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", Swift_A);
            Animations Poison_A = new Animations(new Bitmap[] { Properties.Resources.frame_021, Properties.Resources.frame_022, Properties.Resources.frame_023 });
            Attack Poison = new Attack("Poison", "poison", 30, "The user scatters a cloud of poisonous dust on the target. It may poison the target.", "Oponent", Poison_A);
            Animations Firework_A = new Animations(new Bitmap[] { Properties.Resources.firework__1_, Properties.Resources.firework__2_, Properties.Resources.firework__3_, });
            Attack Firework = new Attack("Incinerate", "fire", 25, "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.", "Oponent", Firework_A);
            Attack Ember = new Attack("Ember", "fire", 12, "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.", "Oponent", Firework_A);
            Animations ThunderWave_A = new Animations(new Bitmap[] { Properties.Resources.tundershock__1_, Properties.Resources.tundershock__2_, Properties.Resources.tundershock__3_, });
            Attack ThunderWave = new Attack("Thunder Wave", "electric", 17, "A weak electric charge is launched at the target. It causes paralysis if it hits.", "Oponent", ThunderWave_A);
            Animations ThunderFlash_A = new Animations(new Bitmap[] { Properties.Resources.flash__1_, Properties.Resources.flash__2_, Properties.Resources.flash__3_, });
            Attack ThunderFlash = new Attack("Volt Switch", "electric", 27, "A weak electric charge is launched at the target. It causes paralysis if it hits.", "Oponent", ThunderFlash_A);
            Animations VoltCharge_A = new Animations(new Bitmap[] { Properties.Resources.flash__1_, Properties.Resources.flash__2_, Properties.Resources.flash__3_, });
            Attack VoltCharge = new Attack("Flash", "electric", 13, "A weak electric charge is launched at the target. It causes paralysis if it hits.", "Oponent", ThunderFlash_A);
            Animations Imprison_A = new Animations(new Bitmap[] { Properties.Resources.psybeam__1_, Properties.Resources.psybeam__2_, Properties.Resources.psybeam__3_, });
            Attack Imprison = new Attack("Imprison", "psychic", 26, "If the opponents know any move also known by the user, the opponents are prevented from using it.", "Oponent", Imprison_A);
            Animations Psyshock_A = new Animations(new Bitmap[] { Properties.Resources.psybomb__1_, Properties.Resources.psybomb__2_, Properties.Resources.psybomb__3_, });
            Attack Psyshock = new Attack("Psyshock", "psychic", 19, "If the opponents know any move also known by the user, the opponents are prevented from using it.", "Oponent", Psyshock_A);
            Animations SnowStorm_A = new Animations(new Bitmap[] { Properties.Resources.snowstorm__1_, Properties.Resources.snowstorm__2_, Properties.Resources.snowstorm__3_, });
            Attack SnowStorm = new Attack("Freeze-Dry", "ice", 27, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", SnowStorm_A);
            Animations Heal_A = new Animations(new Bitmap[] { Properties.Resources.heal__1_, Properties.Resources.heal__2_, Properties.Resources.heal__3_, });
            Attack Heal = new Attack("Dazzling", "fairy", 30, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", Heal_A);
            Animations NaturalPower_A = new Animations(new Bitmap[] { Properties.Resources.heal__1_, Properties.Resources.heal__2_, Properties.Resources.heal__3_, });
            Attack NaturalPower = new Attack("Energy Ball", "grass", 14, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", Heal_A);
            Animations Geomancy_A = new Animations(new Bitmap[] { Properties.Resources.psybomb__1_, Properties.Resources.psybomb__2_, Properties.Resources.psybomb__3_, });
            Attack Geomancy = new Attack("Geomancy", "fairy", 45, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", Geomancy_A);
            Animations SnowFlakes_A = new Animations(new Bitmap[] { Properties.Resources.snowflakes__1_, Properties.Resources.snowflakes__2_, Properties.Resources.snowflakes__3_, });
            Attack SnowFlakes = new Attack("Snow Flakes", "ice", 32, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", SnowFlakes_A);
            Animations Snow_A = new Animations(new Bitmap[] { Properties.Resources.snowflakes__1_, Properties.Resources.snowflakes__2_, Properties.Resources.snowflakes__3_, });
            Attack Snow = new Attack("Snow", "ice", 13, "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.", "Oponent", SnowFlakes_A);
            Animations HudroCanon_A = new Animations(new Bitmap[] { Properties.Resources.hudroCanon__1_, Properties.Resources.hudroCanon__2_, Properties.Resources.hudroCanon__3_, Properties.Resources.hudroCanon__4_, Properties.Resources.hudroCanon__5_ });
            Attack HudroCanon = new Attack("Hudro Canon", "water", 20, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", HudroCanon_A);
            Animations OverHeat_A = new Animations(new Bitmap[] { Properties.Resources.overheat__1_, Properties.Resources.overheat__2_, Properties.Resources.overheat__3_, Properties.Resources.overheat__3_, Properties.Resources.overheat__2_ });
            Attack OverHeat = new Attack("Over Heat", "fire", 20, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", OverHeat_A);
            Animations Bubble_A = new Animations(new Bitmap[] { Properties.Resources.bubble__1_, Properties.Resources.bubble__2_, Properties.Resources.bubble__3_, Properties.Resources.bubble__3_, Properties.Resources.bubble__2_ });
            Attack Bubble = new Attack("Bubble", "water", 10, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", Bubble_A);
            Animations Chrunch_A = new Animations(new Bitmap[] { Properties.Resources.chrunch__1_, Properties.Resources.chrunch__2_, Properties.Resources.chrunch__3_, Properties.Resources.chrunch__4_, });
            Attack Chrunch = new Attack("Chrunch", "normal", 15, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", Chrunch_A);
            Animations ShadowBall_A = new Animations(new Bitmap[] { Properties.Resources.shadowball__1_, Properties.Resources.shadowball__2_, Properties.Resources.shadowball__3_, Properties.Resources.shadowball__4_, Properties.Resources.shadowball__5_ });
            Attack ShadowBall = new Attack("Shadow Ball", "ghost", 25, "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.", "Oponent", ShadowBall_A);
            Animations MudShot_A = new Animations(new Bitmap[] { Properties.Resources.mud_shot__1_, Properties.Resources.mud_shot__2_, Properties.Resources.mud_shot__3_, Properties.Resources.mud_shot__4_, Properties.Resources.mud_shot__4_ });
            Attack MudShot = new Attack("Mud Shot", "ground", 20, "The user attacks by hurling a blob of mud at the target. It also reduces the target's Speed.", "Oponent", MudShot_A);
            Animations LeafsStorm_A = new Animations(new Bitmap[] { Properties.Resources.leafs__1_, Properties.Resources.leafs__2_, Properties.Resources.leafs__3_, Properties.Resources.leafs__4_ });
            Attack LeafsStorm = new Attack("Leaf Storm", "grass", 30, "The user whips up a storm of leaves around the target. The attack's recoil harshly reduces the user's Sp. Atk stat.", "Oponent", LeafsStorm_A);
            Attack VineWhip = new Attack("Vine Whip", "grass", 14, "The user whips up a storm of leaves around the target. The attack's recoil harshly reduces the user's Sp. Atk stat.", "Oponent", LeafsStorm_A);
            Animations Cut_A = new Animations(new Bitmap[] { Properties.Resources.cut__1_, Properties.Resources.cut__2_, Properties.Resources.cut__3_, Properties.Resources.cut__4_, Properties.Resources.cut__5_, Properties.Resources.cut__6_ });
            Attack Cut = new Attack("Cut", "normal", 10, "The target is cut with a scythe or a claw. It can also be used to cut down thin trees.", "Oponent", Cut_A);
            Animations SkaryFace_A = new Animations(new Bitmap[] { Properties.Resources.scaryface__1_, Properties.Resources.scaryface__2_, Properties.Resources.scaryface__3_, Properties.Resources.scaryface__3_, Properties.Resources.scaryface__2_, Properties.Resources.scaryface__1_, });
            Attack SkaryFace = new Attack("Skary Face", "ghost", 10, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", SkaryFace_A);
            Animations Dig_A = new Animations(new Bitmap[] { Properties.Resources.dig__1_, Properties.Resources.dig__2_, Properties.Resources.dig__3_, Properties.Resources.dig__4_, Properties.Resources.dig__5_, Properties.Resources.dig__6_ });
            Attack Dig = new Attack("Dig", "ground", 15, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", Dig_A);
            Animations DragonClaw_A = new Animations(new Bitmap[] { Properties.Resources.dragonclaw__1_, Properties.Resources.dragonclaw__2_, Properties.Resources.dragonclaw__3_, Properties.Resources.dragonclaw__4_, });
            Attack DragonClaw = new Attack(" Dragon Claw", "dragon", 25, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", DragonClaw_A);
            Animations FireBlast_A = new Animations(new Bitmap[] { Properties.Resources.fireblast__1_, Properties.Resources.fireblast__2_, Properties.Resources.fireblast__3_, Properties.Resources.fireblast__4_ });
            Attack FireBlast = new Attack("Fire  Blast", "fire", 25, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", FireBlast_A);
            Animations RockSmash_A = new Animations(new Bitmap[] { Properties.Resources.rockSmash__1_, Properties.Resources.rockSmash__2_, Properties.Resources.rockSmash__3_, Properties.Resources.rockSmash__4_, Properties.Resources.rockSmash__3_, Properties.Resources.rockSmash__2_, Properties.Resources.rockSmash__1_, });
            Attack RockSmash = new Attack("Rock Smash", "rock", 18, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", RockSmash_A);
            Animations Rock_A = new Animations(new Bitmap[] { Properties.Resources.rockSmash__1_, Properties.Resources.rockSmash__2_, Properties.Resources.rockSmash__3_, Properties.Resources.rockSmash__4_, Properties.Resources.rockSmash__3_, Properties.Resources.rockSmash__2_, Properties.Resources.rockSmash__1_, });
            Attack Rock = new Attack("Stealth Rock", "rock", 27, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", RockSmash_A);
            Animations Surf_A = new Animations(new Bitmap[] { Properties.Resources.surf__1_, Properties.Resources.surf__2_, Properties.Resources.surf__3_, Properties.Resources.surf__4_, });
            Attack Surf = new Attack("Surf", "water", 18, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", Surf_A);
            Animations Sprudel_A = new Animations(new Bitmap[] { Properties.Resources.sprudel__1_, Properties.Resources.sprudel__2_, Properties.Resources.sprudel__3_, Properties.Resources.sprudel__4_, });
            Attack Sprudel = new Attack("Sprudel", "water", 13, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", Sprudel_A);
            Animations SplashCut_A = new Animations(new Bitmap[] { Properties.Resources.splashcut__1_, Properties.Resources.splashcut__2_, Properties.Resources.splashcut__3_, Properties.Resources.splashcut__4_, Properties.Resources.splashcut__5_, Properties.Resources.splashcut__6_, });
            Attack SplashCut = new Attack("Splash Cut", "water", 5, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", SplashCut_A);
            Animations Tackle_A = new Animations(new Bitmap[] { Properties.Resources.tackle__1_, Properties.Resources.tackle__2_, });
            Attack Tackle = new Attack("Tackle", "normal", 10, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", Tackle_A);
            Animations StuneSpore_A = new Animations(new Bitmap[] { Properties.Resources.Stun_Spore__1_, Properties.Resources.Stun_Spore__2_, Properties.Resources.Stun_Spore__3_, });
            Attack StuneSpore = new Attack("Stune Spore", "bug", 16, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", StuneSpore_A);
            Animations BugBite_A = new Animations(new Bitmap[] { Properties.Resources.Bug_Bite__1_, Properties.Resources.Bug_Bite__2_, });
            Attack BugBite = new Attack("Bug Bite", "bug", 25, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", BugBite_A);
            Animations AerialAce_A = new Animations(new Bitmap[] { Properties.Resources.aerialAce__1_, Properties.Resources.aerialAce__2_, Properties.Resources.aerialAce__3_, });
            Attack AerialAce = new Attack("Wing cut", "flying", 26, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", AerialAce_A);
            Animations SignalBeam_A = new Animations(new Bitmap[] { Properties.Resources.Signal_Beam__4_, Properties.Resources.Signal_Beam__4_, });
            Attack SignalBeam = new Attack("Signal Beam", "flying", 15, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", SignalBeam_A);
            Animations MegaPunch_A = new Animations(new Bitmap[] { Properties.Resources.punch__1_, Properties.Resources.punch__2_, Properties.Resources.punch__3_, });
            Attack MegaPunch = new Attack("Mega Punch", "fighting", 35, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", MegaPunch_A);
            Animations RazorLeaf_A = new Animations(new Bitmap[] { Properties.Resources.leafstormg__1_, Properties.Resources.leafstormg__1_, });
            Attack RazorLeaf = new Attack("Razor Leaf", "grass", 21, "The user whips up a storm of leaves around the target. The attack's recoil harshly reduces the user's Sp. Atk stat.", "Oponent", RazorLeaf_A);
            Attack StealCr = new Attack("Confide", "steel", 31, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", AerialAce_A);
            Attack Puf = new Attack("Cloudin", "flying", 23, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", StuneSpore_A);
            Attack Fairypower = new Attack("Fairy power", "fairy", 19, "Star-shaped rays are shot at the opposing team. This attack never misses.", "Oponent", SignalBeam_A);
            Attack Darkness = new Attack("Shadow Ball", "dark", 30, "The user hurls a shadowy blob at the target. It may also lower the target's Sp. Def stat.", "Oponent", ShadowBall_A);
            Attack WaterPulse = new Attack("Water pulse", "water", 35, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", SplashCut_A);
            Animations HudroPump_A = new Animations(new Bitmap[] { Properties.Resources.hydropump__1_, Properties.Resources.hydropump__2_, Properties.Resources.hydropump__3_, Properties.Resources.hydropump__4_});
            Attack HudroPump = new Attack("Hudro Pump", "water", 38, "The target is hit with a watery blast. The user must rest on the next turn, however..", "Oponent", HudroPump_A);
           
            Animations Froakie_A = new Animations(new Bitmap[] { Properties.Resources.froakie__1_, Properties.Resources.froakie__2_, Properties.Resources.froakie__3_, Properties.Resources.froakie__4_, Properties.Resources.froakie__5_, Properties.Resources.froakie__5_, Properties.Resources.froakie__4_, Properties.Resources.froakie__3_, Properties.Resources.froakie__2_, Properties.Resources.froakie__1_, Properties.Resources.froakie__1_, Properties.Resources.froakie__1_, Properties.Resources.froakie__1_, Properties.Resources.froakie__1_ });
            Froakie = new Pokemon("Froakie", "grass", "water", 100, Froakie_A, "fire",100);
            Froakie.AddAtack(Tackle);
            Froakie.AddAtack(Surf);
            Froakie.AddAtack(SplashCut);
            Froakie.AddAtack(Bubble);
            Animations Chesnaught_A = new Animations(new Bitmap[] { Properties.Resources.cespin_000, Properties.Resources.cespin_003, Properties.Resources.cespin_006, Properties.Resources.cespin_007, Properties.Resources.cespin_009, Properties.Resources.cespin_007, Properties.Resources.cespin_006, Properties.Resources.cespin_003, Properties.Resources.cespin_000 });
            Chesnaught = new Pokemon("Chesnaught", "Chesnaught_", "grass", 240, Chesnaught_A, "water",2000);
            Chesnaught.AddAtack(LeafsStorm);
            Chesnaught.AddAtack(Cut);
            Chesnaught.AddAtack(NaturalPower);
            Chesnaught.AddAtack(Dig);
            Animations Spewpa_A = new Animations(new Bitmap[] { Properties.Resources.spewpa__1_, Properties.Resources.spewpa__2_, Properties.Resources.spewpa__3_, Properties.Resources.spewpa__4_, Properties.Resources.spewpa__5_, Properties.Resources.spewpa__6_, Properties.Resources.spewpa__7_, Properties.Resources.spewpa__7_, Properties.Resources.spewpa__8_, Properties.Resources.spewpa__8_, Properties.Resources.spewpa__1_, Properties.Resources.spewpa__1_, Properties.Resources.spewpa__2_, Properties.Resources.spewpa__2_, Properties.Resources.spewpa__1_, Properties.Resources.spewpa__2_, Properties.Resources.spewpa__2_ });
             Spewpa = new Pokemon("Spewpa", "fire", "bug", 100, Spewpa_A, "ground",300);
            Spewpa.AddAtack(StuneSpore);
            Spewpa.AddAtack(Tackle);
            Spewpa.AddAtack(Cut);
            Spewpa.AddAtack(BugBite);
            Animations Yveltal_A = new Animations(new Bitmap[] { Properties.Resources.yveltal__1_, Properties.Resources.yveltal__2_, Properties.Resources.yveltal__3_, Properties.Resources.yveltal__4_, Properties.Resources.yveltal__5_, Properties.Resources.yveltal__6_, Properties.Resources.yveltal__7_, Properties.Resources.yveltal__8_, Properties.Resources.yveltal__9_, Properties.Resources.yveltal__10_, Properties.Resources.yveltal__11_, Properties.Resources.yveltal__12_, Properties.Resources.yveltal__13_, Properties.Resources.yveltal__14_, Properties.Resources.yveltal__14_, Properties.Resources.yveltal__15_, Properties.Resources.yveltal__16_, Properties.Resources.yveltal__17_, Properties.Resources.yveltal__18_, Properties.Resources.yveltal__19_ });
             Yveltal = new Pokemon("Yveltal", "ice", "dark", 700, Yveltal_A, "ghost",17000);
            Yveltal.AddAtack(ShadowBall);
            Yveltal.AddAtack(Chrunch);
            Yveltal.AddAtack(Darkness);
            Yveltal.AddAtack(AerialAce);
            Animations Delpho_A = new Animations(new Bitmap[] { Properties.Resources.delphox__1_, Properties.Resources.delphox__2_, Properties.Resources.delphox__3_, Properties.Resources.delphox__4_, Properties.Resources.delphox__5_, Properties.Resources.delphox__5_, Properties.Resources.delphox__4_, Properties.Resources.delphox__3_, Properties.Resources.delphox__2_, Properties.Resources.delphox__1_ });
             Delphox = new Pokemon("Delphox", "water", "fire", 640, Delpho_A, "grass",5000);
            Delphox.AddAtack(OverHeat);
            Delphox.AddAtack(FireBlast);
            Delphox.AddAtack(Firework);
            Delphox.AddAtack(Chrunch);
            Animations Pikachu_A = new Animations(new Bitmap[] { Properties.Resources.pikachu__1_, Properties.Resources.pikachu__1_, Properties.Resources.pikachu__2_, Properties.Resources.pikachu__3_, Properties.Resources.pikachu__4_, Properties.Resources.pikachu__5_, Properties.Resources.pikachu__5_, Properties.Resources.pikachu__4_, Properties.Resources.pikachu__3_, Properties.Resources.pikachu__2_, Properties.Resources.pikachu__1_, Properties.Resources.pikachu__1_, });
            Pikachu = new Pokemon("Pikachu", "ground", "electric", 100, Pikachu_A, "water",2000);
            Pikachu.AddAtack(Tackle);
            Pikachu.AddAtack(ThunderFlash);
            Pikachu.AddAtack(Chrunch);
            Pikachu.AddAtack(ThunderWave);
            Animations Articuno_A = new Animations(new Bitmap[] { /*Properties.Resources.Articuno__1_, Properties.Resources.Articuno__2_,*/Properties.Resources.Articuno__3_, Properties.Resources.Articuno__4_, Properties.Resources.Articuno__5_, Properties.Resources.Articuno__6_, Properties.Resources.Articuno__7_, Properties.Resources.Articuno__6_, Properties.Resources.Articuno__5_, Properties.Resources.Articuno__4_, Properties.Resources.Articuno__3_,/* Properties.Resources.Articuno__2_, Properties.Resources.Articuno__1_ */});
            Articuno = new Pokemon("Articuno", "fighting", "ice", 430, Articuno_A, "ghost",6000);
            Articuno.AddAtack(AerialAce);
            Articuno.AddAtack(Snow);
            Articuno.AddAtack(SnowFlakes);
            Articuno.AddAtack(Tackle);

            Animations Aggron_A = new Animations(new Bitmap[] { Properties.Resources.aggron__1_, Properties.Resources.aggron__2_, Properties.Resources.aggron__3_, Properties.Resources.aggron__4_, Properties.Resources.aggron__5_, Properties.Resources.aggron__6_, Properties.Resources.aggron__7_, Properties.Resources.aggron__7_, Properties.Resources.aggron__6_, Properties.Resources.aggron__5_, Properties.Resources.aggron__4_, Properties.Resources.aggron__3_, Properties.Resources.aggron__2_, Properties.Resources.aggron__1_, });
            Aggron = new Pokemon("Aggron", "fire", "steel", 200, Aggron_A, "ice",4000);
            Aggron.AddAtack(Tackle);
            Aggron.AddAtack(StealCr);
            Aggron.AddAtack(Chrunch);
            Aggron.AddAtack(Dig);
            Animations Altaria_A = new Animations(new Bitmap[] { Properties.Resources.altaria__1_, Properties.Resources.altaria__2_, Properties.Resources.altaria__3_, Properties.Resources.altaria__4_, Properties.Resources.altaria__5_ });
            Altaria = new Pokemon("Altaria", "steel", "flying", 220, Altaria_A, "fighting",2500);
            Altaria.AddAtack(DragonClaw);
            Altaria.AddAtack(AerialAce);
            Altaria.AddAtack(Tackle);
            Altaria.AddAtack(Puf);
            Animations Auroras_A = new Animations(new Bitmap[] { Properties.Resources.auroras__1_, Properties.Resources.auroras__1_, Properties.Resources.auroras__2_, Properties.Resources.auroras__2_, Properties.Resources.auroras__3_, Properties.Resources.auroras__3_, Properties.Resources.auroras__4_, Properties.Resources.auroras__4_, Properties.Resources.auroras__5_, Properties.Resources.auroras__5_, });
            Auroras = new Pokemon("Auroras", "fighting", "ice", 620, Auroras_A, "ghost",3100);
            Auroras.AddAtack(Tackle);
            Auroras.AddAtack(Rock);
            Auroras.AddAtack(SnowStorm);
            Auroras.AddAtack(SnowFlakes);
            Animations Bunneldy_A = new Animations(new Bitmap[] { Properties.Resources.bunneldy__1_, Properties.Resources.bunneldy__2_, Properties.Resources.bunneldy__3_, Properties.Resources.bunneldy__4_, Properties.Resources.bunneldy__5_, Properties.Resources.bunneldy__6_, });
            Bunneldy = new Pokemon("Bunneldy", "ghost", "normal", 100, Bunneldy_A, "steel",2000);
            Bunneldy.AddAtack(Tackle);
            Bunneldy.AddAtack(Dig);
            Bunneldy.AddAtack(Chrunch);
            Bunneldy.AddAtack(MudShot);
            Animations Burmy_A = new Animations(new Bitmap[] { Properties.Resources.burmy__1_, Properties.Resources.burmy__1_, Properties.Resources.burmy__1_, Properties.Resources.burmy__1_, Properties.Resources.burmy__1_, Properties.Resources.burmy__2_, Properties.Resources.burmy__2_, Properties.Resources.burmy__3_, Properties.Resources.burmy__4_, Properties.Resources.burmy__5_, Properties.Resources.burmy__6_, Properties.Resources.burmy__7_, Properties.Resources.burmy__8_, Properties.Resources.burmy__8_, Properties.Resources.burmy__7_, Properties.Resources.burmy__6_, Properties.Resources.burmy__5_, Properties.Resources.burmy__4_, Properties.Resources.burmy__3_, Properties.Resources.burmy__2_, Properties.Resources.burmy__1_, });
            Burmy = new Pokemon("Burmy", "fire", "grass", 70, Burmy_A, "water",1500);
            Burmy.AddAtack(RazorLeaf);
            Burmy.AddAtack(Tackle);
            Burmy.AddAtack(Cut);
            Burmy.AddAtack(BugBite);
            Animations Charizard_A = new Animations(new Bitmap[] { Properties.Resources.charizard__1_, Properties.Resources.charizard__2_, Properties.Resources.charizard__3_, Properties.Resources.charizard__4_, Properties.Resources.charizard__5_, Properties.Resources.charizard__6_, Properties.Resources.charizard__7_, Properties.Resources.charizard__8_, Properties.Resources.charizard__9_, });
            Charizard = new Pokemon("Charizard", "water", "fire", 270, Charizard_A, "grass",4900);
            Charizard.AddAtack(Chrunch);
            Charizard.AddAtack(FireBlast);
            Charizard.AddAtack(OverHeat);
            Charizard.AddAtack(AerialAce);
            Animations Chesinn_A = new Animations(new Bitmap[] { Properties.Resources.Chespinn__1_, Properties.Resources.Chespinn__2_, Properties.Resources.Chespinn__3_, Properties.Resources.Chespinn__4_, Properties.Resources.Chespinn__5_, Properties.Resources.Chespinn__5_, Properties.Resources.Chespinn__4_, Properties.Resources.Chespinn__3_, Properties.Resources.Chespinn__2_, Properties.Resources.Chespinn__1_, Properties.Resources.Chespinn__1_, });
            Chesinn = new Pokemon("Chespin", "fire", "grass", 100, Chesinn_A, "water",100);
            Chesinn.AddAtack(Tackle);
            Chesinn.AddAtack(MudShot);
            Chesinn.AddAtack(RazorLeaf);
            Chesinn.AddAtack(NaturalPower);
            Animations Combee_A = new Animations(new Bitmap[] { Properties.Resources.combee__1_, Properties.Resources.combee__2_, Properties.Resources.combee__3_, Properties.Resources.combee__3_, Properties.Resources.combee__2_, Properties.Resources.combee__1_, });
            Combee = new Pokemon("Combee", "flying", "grass", 100, Combee_A, "psychic",1200);
            Combee.AddAtack(Poison);
            Combee.AddAtack(BugBite);
            Combee.AddAtack(StuneSpore);
            Combee.AddAtack(Tackle);
            Animations Croagunk_A = new Animations(new Bitmap[] { Properties.Resources.croagunk__1_, Properties.Resources.croagunk__2_, Properties.Resources.croagunk__3_, Properties.Resources.croagunk__4_, Properties.Resources.croagunk__5_, Properties.Resources.croagunk__6_, Properties.Resources.croagunk__7_, Properties.Resources.croagunk__8_, Properties.Resources.croagunk__9_, Properties.Resources.croagunk__1_, Properties.Resources.croagunk__1_, Properties.Resources.croagunk__1_, Properties.Resources.croagunk__1_, });
            Croagunk = new Pokemon("Croagunk", "poison", "fighting", 100, Croagunk_A, "ice",1800);
            Croagunk.AddAtack(Poison);
            Croagunk.AddAtack(MudShot);
            Croagunk.AddAtack(MegaPunch);
            Croagunk.AddAtack(Tackle);
            Animations Dedenne_A = new Animations(new Bitmap[] { Properties.Resources.dedene__1_, Properties.Resources.dedene__2_, Properties.Resources.dedene__3_, Properties.Resources.dedene__4_, Properties.Resources.dedene__5_, Properties.Resources.dedene__5_, Properties.Resources.dedene__4_, });
            Dedenne = new Pokemon("Dedenne", "poison", "fairy", 80, Dedenne_A, "dragon",900);
            Dedenne.AddAtack(Tackle);
            Dedenne.AddAtack(VoltCharge);
            Dedenne.AddAtack(ThunderWave);
            Dedenne.AddAtack(Fairypower);
            Animations Escavaler_A = new Animations(new Bitmap[] { Properties.Resources.escavalier__1_, Properties.Resources.escavalier__2_, Properties.Resources.escavalier__3_, Properties.Resources.escavalier__4_, Properties.Resources.escavalier__5_, Properties.Resources.escavalier__5_, Properties.Resources.escavalier__4_, Properties.Resources.escavalier__3_, Properties.Resources.escavalier__2_, Properties.Resources.escavalier__1_, });
            Escavaler = new Pokemon("Escavaler", "fire", "steel", 110, Escavaler_A, "ice",7000);
            Escavaler.AddAtack(StuneSpore);
            Escavaler.AddAtack(Tackle);
            Escavaler.AddAtack(StealCr);
            Escavaler.AddAtack(SplashCut);
            Animations Fenniken_A = new Animations(new Bitmap[] { Properties.Resources.fennekin__1_, Properties.Resources.fennekin__2_, Properties.Resources.fennekin__3_, Properties.Resources.fennekin__4_, Properties.Resources.fennekin__4_, Properties.Resources.fennekin__3_, Properties.Resources.fennekin__2_, Properties.Resources.fennekin__1_, });
            Fenniken = new Pokemon("Fenniken", "water", "fire", 100, Fenniken_A, "grass",100);
            Fenniken.AddAtack(Tackle);
            Fenniken.AddAtack(Dig);
            Fenniken.AddAtack(OverHeat);
            Fenniken.AddAtack(Ember);
            Animations Floate_A = new Animations(new Bitmap[] { Properties.Resources.floaete__1_, Properties.Resources.floaete__1_, Properties.Resources.floaete__1_, Properties.Resources.floaete__1_, Properties.Resources.floaete__2_, Properties.Resources.floaete__3_, Properties.Resources.floaete__4_, Properties.Resources.floaete__5_, Properties.Resources.floaete__5_, Properties.Resources.floaete__4_, Properties.Resources.floaete__3_, Properties.Resources.floaete__2_, Properties.Resources.floaete__1_, });
            Animations Gardevoir_A = new Animations(new Bitmap[] { Properties.Resources.gardevoir__5_, Properties.Resources.gardevoir__1_, Properties.Resources.gardevoir__2_, Properties.Resources.gardevoir__3_, Properties.Resources.gardevoir__4_, Properties.Resources.gardevoir__4_, Properties.Resources.gardevoir__3_, Properties.Resources.gardevoir__2_, Properties.Resources.gardevoir__1_, Properties.Resources.gardevoir__5_ });
            Gardevoir = new Pokemon("Gardevoir", "dark", "psychic", 520, Gardevoir_A, "fighting",4300);
            Gardevoir.AddAtack(Cut);
            Gardevoir.AddAtack(RazorLeaf);
            Gardevoir.AddAtack(Psyshock);
            Gardevoir.AddAtack(Poison);
            Floate = new Pokemon("Floate", "poison", "fairy", 150, Floate_A, "dragon",5000);
            Floate.AddAtack(NaturalPower);
            Floate.AddAtack(Fairypower);
            Floate.AddAtack(VineWhip);
            Floate.AddAtack(Cut);
            Animations Goodra_A = new Animations(new Bitmap[] { Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__7_, Properties.Resources.goodra__7_, Properties.Resources.goodra__6_, Properties.Resources.goodra__5_, Properties.Resources.goodra__4_, Properties.Resources.goodra__3_, Properties.Resources.goodra__2_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__2_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__8_, Properties.Resources.goodra__2_, });
            Goodra = new Pokemon("Goodra", "fairy", "dragon", 480, Goodra_A, "dragon",8800);
            Goodra.AddAtack(Tackle);
            Goodra.AddAtack(DragonClaw);
            Goodra.AddAtack(Firework);
            Goodra.AddAtack(MudShot);
            Animations Gorgiest_A = new Animations(new Bitmap[] { Properties.Resources.gorgeist__1_, Properties.Resources.gorgeist__1_, Properties.Resources.gorgeist__2_, Properties.Resources.gorgeist__3_, Properties.Resources.gorgeist__3_, Properties.Resources.gorgeist__3_, Properties.Resources.gorgeist__3_, Properties.Resources.gorgeist__3_, Properties.Resources.gorgeist__4_, Properties.Resources.gorgeist__4_, Properties.Resources.gorgeist__5_, Properties.Resources.gorgeist__6_, Properties.Resources.gorgeist__6_, Properties.Resources.gorgeist__5_, Properties.Resources.gorgeist__4_, });
            Gorgiest = new Pokemon("Gorgiest", "dark", "ghost", 160, Gorgiest_A, "normal",3000);
            Gorgiest.AddAtack(ShadowBall);
            Gorgiest.AddAtack(SkaryFace);
            Gorgiest.AddAtack(NaturalPower);
            Gorgiest.AddAtack(LeafsStorm);
            Animations Hawlucha_A = new Animations(new Bitmap[] { Properties.Resources.hawlucha__1_, Properties.Resources.hawlucha__2_, Properties.Resources.hawlucha__3_, Properties.Resources.hawlucha__4_, Properties.Resources.hawlucha__4_, Properties.Resources.hawlucha__3_, Properties.Resources.hawlucha__2_, Properties.Resources.hawlucha__1_, });
            Hawlucha = new Pokemon("Hawlucha", "poison", "fighting", 120, Hawlucha_A, "ice",5050);
            Hawlucha.AddAtack(SignalBeam);
            Hawlucha.AddAtack(MegaPunch);
            Hawlucha.AddAtack(AerialAce);
            Hawlucha.AddAtack(Tackle);
            Animations Hydragon_A = new Animations(new Bitmap[] { Properties.Resources.hydreigon__1_, Properties.Resources.hydreigon__2_, Properties.Resources.hydreigon__3_, Properties.Resources.hydreigon__4_, Properties.Resources.hydreigon__5_, Properties.Resources.hydreigon__6_, Properties.Resources.hydreigon__7_, Properties.Resources.hydreigon__8_, Properties.Resources.hydreigon__9_, Properties.Resources.hydreigon__10_, Properties.Resources.hydreigon__11_, Properties.Resources.hydreigon__12_, });
            Hydragon = new Pokemon("Hydragon", "fairy", "dragon",620, Hydragon_A, "dragon",9990);
            Hydragon.AddAtack(AerialAce);
            Hydragon.AddAtack(DragonClaw);
            Hydragon.AddAtack(Poison);
            Hydragon.AddAtack(ShadowBall);
            Animations Klefkie_A = new Animations(new Bitmap[] { Properties.Resources.klefki__1_, Properties.Resources.klefki__2_, Properties.Resources.klefki__3_, Properties.Resources.klefki__4_, Properties.Resources.klefki__5_, Properties.Resources.klefki__5_, Properties.Resources.klefki__4_, Properties.Resources.klefki__3_, Properties.Resources.klefki__2_, Properties.Resources.klefki__1_, });
            Klefkie = new Pokemon("Klefkie", "poison", "fairy", 120, Klefkie_A, "dragon",7000);
            Klefkie.AddAtack(StealCr);
            Klefkie.AddAtack(Fairypower);
            Klefkie.AddAtack(Tackle);
            Klefkie.AddAtack(Swift);
            Animations Luxary_A = new Animations(new Bitmap[] { Properties.Resources.luxary__1_, Properties.Resources.luxary__1_, Properties.Resources.luxary__2_, Properties.Resources.luxary__3_, Properties.Resources.luxary__4_, Properties.Resources.luxary__5_, Properties.Resources.luxary__6_, Properties.Resources.luxary__7_, Properties.Resources.luxary__8_, Properties.Resources.luxary__8_, Properties.Resources.luxary__7_, Properties.Resources.luxary__6_, Properties.Resources.luxary__5_, Properties.Resources.luxary__4_, Properties.Resources.luxary__3_, Properties.Resources.luxary__2_, Properties.Resources.luxary__1_, Properties.Resources.luxary__1_, Properties.Resources.luxary__1_, });
            Luxary = new Pokemon("Luxary", "ground", "electric", 370, Luxary_A, "water",8500);
            Luxary.AddAtack(ShadowBall);
            Luxary.AddAtack(ThunderFlash);
            Luxary.AddAtack(VoltCharge);
            Luxary.AddAtack(Chrunch);
            Animations Noivern_A = new Animations(new Bitmap[] { Properties.Resources.noivren__1_, Properties.Resources.noivren__2_, Properties.Resources.noivren__3_, Properties.Resources.noivren__4_, Properties.Resources.noivren__5_, Properties.Resources.noivren__6_, Properties.Resources.noivren__7_, Properties.Resources.noivren__8_, Properties.Resources.noivren__9_, Properties.Resources.noivren__10_, });
            Noivern = new Pokemon("Noivern", "fairy", "dragon", 250, Noivern_A, "dragon",6500);
            Noivern.AddAtack(AerialAce);
            Noivern.AddAtack(DragonClaw);
            Noivern.AddAtack(SignalBeam);
            Noivern.AddAtack(Chrunch);
            Animations Pangoro_A = new Animations(new Bitmap[] { Properties.Resources.pangoro__1_, Properties.Resources.pangoro__2_, Properties.Resources.pangoro__3_, Properties.Resources.pangoro__4_, Properties.Resources.pangoro__4_, Properties.Resources.pangoro__3_, Properties.Resources.pangoro__2_, Properties.Resources.pangoro__1_, });
            Pangoro = new Pokemon("Pangoro", "ghost", "fighting",310, Pangoro_A, "ice",7700);
            Pangoro.AddAtack(MegaPunch);
            Pangoro.AddAtack(ShadowBall);
            Pangoro.AddAtack(Chrunch);
            Pangoro.AddAtack(MudShot);
            Animations Pyroar_A = new Animations(new Bitmap[] { Properties.Resources.pyroar__1_, Properties.Resources.pyroar__2_, Properties.Resources.pyroar__3_, Properties.Resources.pyroar__4_, Properties.Resources.pyroar__5_, Properties.Resources.pyroar__5_, Properties.Resources.pyroar__4_, Properties.Resources.pyroar__3_, Properties.Resources.pyroar__2_, Properties.Resources.pyroar__1_, });
            Pyroar = new Pokemon("Pyroar♀", "water", "fire", 190, Pyroar_A, "grass",4000);
            Pyroar.AddAtack(Chrunch);
            Pyroar.AddAtack(FireBlast);
            Pyroar.AddAtack(Tackle);
            Pyroar.AddAtack(Ember);
            Animations Pyroarr_A = new Animations(new Bitmap[] { Properties.Resources.pyroarr__1_, Properties.Resources.pyroarr__2_, Properties.Resources.pyroarr__3_, Properties.Resources.pyroarr__4_, Properties.Resources.pyroarr__5_, Properties.Resources.pyroarr__5_, Properties.Resources.pyroarr__4_, Properties.Resources.pyroarr__3_, Properties.Resources.pyroarr__2_, Properties.Resources.pyroarr__1_, });
            Pyroarr = new Pokemon("Pyroar♂", "water", "fire", 190, Pyroarr_A, "grass",4200);
            Pyroarr.AddAtack(Chrunch);
            Pyroarr.AddAtack(FireBlast);
            Pyroarr.AddAtack(Tackle);
            Pyroarr.AddAtack(Ember);
            Animations Smoochum_A = new Animations(new Bitmap[] { Properties.Resources.smoochum__1_, Properties.Resources.smoochum__1_, Properties.Resources.smoochum__1_, Properties.Resources.smoochum__1_, Properties.Resources.smoochum__2_, Properties.Resources.smoochum__3_, Properties.Resources.smoochum__4_, Properties.Resources.smoochum__5_, Properties.Resources.smoochum__6_, Properties.Resources.smoochum__7_, Properties.Resources.smoochum__7_, Properties.Resources.smoochum__6_, });
            Smoochum = new Pokemon("Smoochum", "dark", "psychic", 80, Smoochum_A, "fighting",1100);
            Smoochum.AddAtack(MegaPunch);
            Smoochum.AddAtack(Psyshock);
            Smoochum.AddAtack(Fairypower);
            Smoochum.AddAtack(Imprison);
            Animations Spritzee_A = new Animations(new Bitmap[] { Properties.Resources.spritzee__1_, Properties.Resources.spritzee__1_, Properties.Resources.spritzee__2_, Properties.Resources.spritzee__2_, Properties.Resources.spritzee__2_, Properties.Resources.spritzee__1_, Properties.Resources.spritzee__1_, Properties.Resources.spritzee__2_, Properties.Resources.spritzee__3_, Properties.Resources.spritzee__4_, Properties.Resources.spritzee__5_, Properties.Resources.spritzee__6_, Properties.Resources.spritzee__7_, Properties.Resources.spritzee__8_, Properties.Resources.spritzee__9_, });
            Spritzee = new Pokemon("Spritzee", "poison", "fairy", 80, Spritzee_A, "dragon",1010);
            Spritzee.AddAtack(AerialAce);
            Spritzee.AddAtack(Heal);
            Spritzee.AddAtack(Puf);
            Spritzee.AddAtack(Fairypower);
            Animations Trevenant_A = new Animations(new Bitmap[] { Properties.Resources.trevenant__1_, Properties.Resources.trevenant__1_, Properties.Resources.trevenant__1_, Properties.Resources.trevenant__2_, Properties.Resources.trevenant__3_, Properties.Resources.trevenant__4_, Properties.Resources.trevenant__5_, Properties.Resources.trevenant__5_, Properties.Resources.trevenant__4_, Properties.Resources.trevenant__3_, Properties.Resources.trevenant__2_, Properties.Resources.trevenant__1_, Properties.Resources.trevenant__1_, Properties.Resources.trevenant__1_, Properties.Resources.trevenant__1_, });
            Trevenant = new Pokemon("Trevenant", "fire", "grass", 560, Trevenant_A, "water",4520);
            Trevenant.AddAtack(Darkness);
            Trevenant.AddAtack(LeafsStorm);
            Trevenant.AddAtack(SkaryFace);
            Trevenant.AddAtack(NaturalPower);
            Animations Tyranturum_A = new Animations(new Bitmap[] { Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__2_, Properties.Resources.tyranturum__3_, Properties.Resources.tyranturum__4_, Properties.Resources.tyranturum__5_, Properties.Resources.tyranturum__6_, Properties.Resources.tyranturum__7_, Properties.Resources.tyranturum__8_, Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__1_, Properties.Resources.tyranturum__1_, });
            Tyranturum = new Pokemon("Tyranturum", "steel", "rock", 250, Tyranturum_A, "fire",5420);
            Tyranturum.AddAtack(RockSmash);
            Tyranturum.AddAtack(Chrunch);
            Tyranturum.AddAtack(Rock);
            Tyranturum.AddAtack(MudShot);
            Animations Vivillion_A = new Animations(new Bitmap[] { Properties.Resources.vivilion__1_, Properties.Resources.vivilion__2_, Properties.Resources.vivilion__3_, Properties.Resources.vivilion__4_, Properties.Resources.vivilion__5_, Properties.Resources.vivilion__5_, Properties.Resources.vivilion__4_, Properties.Resources.vivilion__3_, Properties.Resources.vivilion__2_, Properties.Resources.vivilion__1_, });
            Vivillion = new Pokemon("Vivillion", "flying", "bug", 200, Vivillion_A, "dark",2200);
            Vivillion.AddAtack(StuneSpore);
            Vivillion.AddAtack(BugBite);
            Vivillion.AddAtack(Poison);
            Vivillion.AddAtack(AerialAce);
            Animations Vanillite_A = new Animations(new Bitmap[] { Properties.Resources.Vanillite__1_, Properties.Resources.Vanillite__2_, Properties.Resources.Vanillite__3_, Properties.Resources.Vanillite__4_, Properties.Resources.Vanillite__5_, Properties.Resources.Vanillite__6_, Properties.Resources.Vanillite__1_, Properties.Resources.Vanillite__1_, Properties.Resources.Vanillite__1_, });
            Vanillite = new Pokemon("Vanillite", "flying", "ice", 80, Vanillite_A, "ground",1200);
            Vanillite.AddAtack(Snow);
            Vanillite.AddAtack(SnowFlakes);
            Vanillite.AddAtack(HudroCanon);
            Vanillite.AddAtack(Tackle);
            Animations Volcarona_A = new Animations(new Bitmap[] { Properties.Resources.volcarona__1_, Properties.Resources.volcarona__2_, Properties.Resources.volcarona__3_, Properties.Resources.volcarona__4_, Properties.Resources.volcarona__5_, Properties.Resources.volcarona__6_, Properties.Resources.volcarona__6_,/* Properties.Resources.volcarona__5_, Properties.Resources.volcarona__4_, Properties.Resources.volcarona__3_,*/ Properties.Resources.volcarona__2_, Properties.Resources.volcarona__1_, /**/ });
            Volcarona = new Pokemon("Volcarona", "flying", "bug", 500, Volcarona_A, "dark",8520);
            Volcarona.AddAtack(FireBlast);
            Volcarona.AddAtack(StuneSpore);
            Volcarona.AddAtack(BugBite);
            Volcarona.AddAtack(AerialAce);
            Animations Gyarados_A = new Animations(new Bitmap[] { Properties.Resources.gyaradis__1_, Properties.Resources.gyaradis__2_, Properties.Resources.gyaradis__3_, Properties.Resources.gyaradis__4_, Properties.Resources.gyaradis__5_, Properties.Resources.gyaradis__6_, Properties.Resources.gyaradis__7_, Properties.Resources.gyaradis__8_, Properties.Resources.gyaradis__9_, });
            Gyarados = new Pokemon("Gyarados", "grass", "water", 540, Gyarados_A, "fire", 8530);
            Gyarados.AddAtack(HudroCanon);
            Gyarados.AddAtack(HudroPump);
            Gyarados.AddAtack(Chrunch);
            Gyarados.AddAtack(WaterPulse);
            Animations Xerneas_A = new Animations(new Bitmap[] { Properties.Resources.xerneas__1_, Properties.Resources.xerneas__1_, Properties.Resources.xerneas__1_, Properties.Resources.xerneas__1_, Properties.Resources.xerneas__1_, Properties.Resources.xerneas__2_, Properties.Resources.xerneas__3_, Properties.Resources.xerneas__4_, Properties.Resources.xerneas__5_, Properties.Resources.xerneas__6_, Properties.Resources.xerneas__7_, Properties.Resources.xerneas__8_, Properties.Resources.xerneas__9_, Properties.Resources.xerneas__9_, });
            Xerneas = new Pokemon("Xerneas", "poison", "fairy", 700, Xerneas_A, "dragon",12000);
            Xerneas.AddAtack(Geomancy);
            Xerneas.AddAtack(SnowStorm);
            Xerneas.AddAtack(SnowFlakes);
            Xerneas.AddAtack(Fairypower);
            Animations Zoroak_A = new Animations(new Bitmap[] { Properties.Resources.zorokak__1_, Properties.Resources.zorokak__1_, Properties.Resources.zorokak__1_, Properties.Resources.zorokak__2_, Properties.Resources.zorokak__3_, Properties.Resources.zorokak__4_, Properties.Resources.zorokak__5_, Properties.Resources.zorokak__5_, Properties.Resources.zorokak__4_, Properties.Resources.zorokak__3_, Properties.Resources.zorokak__2_, Properties.Resources.zorokak__1_, });
            Zoroak = new Pokemon("Zoroak", "bug", "dark", 600, Zoroak_A, "psychic",11050);
            Zoroak.AddAtack(Poison);
            Zoroak.AddAtack(Darkness);
            Zoroak.AddAtack(Chrunch);
            Zoroak.AddAtack(Dig);
            Animations Aerodactil_A = new Animations(new Bitmap[] { Properties.Resources.frame_003, Properties.Resources.frame_005, Properties.Resources.frame_006, Properties.Resources.frame_008, Properties.Resources.frame_009, Properties.Resources.frame_009, Properties.Resources.frame_008, Properties.Resources.frame_006, Properties.Resources.frame_005, Properties.Resources.frame_003 });
            Aerodactil = new Pokemon("Aerodactil", "water", "rock", 580, Aerodactil_A, "fire",4580);
            Aerodactil.AddAtack(RockSmash);
            Aerodactil.AddAtack(MudShot);
            Aerodactil.AddAtack(AerialAce);
            Aerodactil.AddAtack(Chrunch);
            listaZavoProdavnica = new List<Pokemon>();
            listaZavoProdavnica.Add(Zoroak);
            listaZavoProdavnica.Add(Delphox);
            listaZavoProdavnica.Add(Froakie);
            listaZavoProdavnica.Add(Pikachu);
            listaZavoProdavnica.Add(Spewpa);
            listaZavoProdavnica.Add(Aerodactil);
            listaZavoProdavnica.Add(Yveltal);
            listaZavoProdavnica.Add(Chesnaught);
            listaZavoProdavnica.Add(Articuno);
            listaZavoProdavnica.Add(Aggron);
            listaZavoProdavnica.Add(Altaria);
            listaZavoProdavnica.Add(Auroras);
            listaZavoProdavnica.Add(Bunneldy);
            listaZavoProdavnica.Add(Burmy);
            listaZavoProdavnica.Add(Charizard);
            listaZavoProdavnica.Add(Chesinn);
            listaZavoProdavnica.Add(Combee);
            listaZavoProdavnica.Add(Gardevoir);
            listaZavoProdavnica.Add(Croagunk);
            listaZavoProdavnica.Add(Dedenne);
            listaZavoProdavnica.Add(Escavaler);
            listaZavoProdavnica.Add(Fenniken);
            listaZavoProdavnica.Add(Floate);
            listaZavoProdavnica.Add(Goodra);
            listaZavoProdavnica.Add(Gorgiest);
            listaZavoProdavnica.Add(Hawlucha);
            listaZavoProdavnica.Add(Hydragon);
            listaZavoProdavnica.Add(Klefkie);
            listaZavoProdavnica.Add(Luxary);
            listaZavoProdavnica.Add(Noivern);
            listaZavoProdavnica.Add(Pangoro);
            listaZavoProdavnica.Add(Pyroarr);
            listaZavoProdavnica.Add(Pyroar);
            listaZavoProdavnica.Add(Smoochum);
            listaZavoProdavnica.Add(Spritzee);
            listaZavoProdavnica.Add(Tyranturum);
            listaZavoProdavnica.Add(Trevenant);
            listaZavoProdavnica.Add(Vanillite);
            listaZavoProdavnica.Add(Vivillion);
            listaZavoProdavnica.Add(Volcarona);
            listaZavoProdavnica.Add(Gyarados);
            listaZavoProdavnica.Add(Xerneas);
            textBox1.Visible = false;
            listBox1.Items.Add(Fenniken);
            listBox1.Items.Add(Chesinn);
            listBox1.Items.Add(Froakie);
            listBox1.Visible = false;
            pictureBox1.Location = new Point(994,555);
            pictureBox2.Location = new Point(994, 555);
            pictureBox3.Location = new Point(994, 555);
            pictureBox4.Location = new Point(994, 555);
            pictureBox5.Location = new Point(994, 555);
            pictureBox6.Location = new Point(994, 555);
            pictureBox7.Location = new Point(994, 555);
            pictureBox8.Location = new Point(994, 555);
            pictureBox9.Location = new Point(994, 555);
            pictureBox10.Location = new Point(994, 555);
            pictureBox11.Location = new Point(994, 555);
            pictureBox12.Location = new Point(994, 555);
            pictureBox13.Location = new Point(994, 555);
            pictureBox14.Location = new Point(994, 555);
            pictureBox15.Location = new Point(994, 555);
            pictureBox16.Location = new Point(994, 555);
            pictureBox17.Location = new Point(994, 555);
            pictureBox18.Location = new Point(994, 555);
            pictureBox19.Location = new Point(994, 555);
            pictureBox20.Location = new Point(994, 555);
            pictureBox21.Location = new Point(994, 555);
            pictureBox24.Location = new Point(994, 555);
            listBox123.Location = new Point(994, 555);
        }
        public Image grad1;
        private void Form2_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            btm = new Bitmap(this.Width, this.Height);
            scG = Graphics.FromImage(btm);
            this.DoubleBuffered = true;
            grad1 = Properties.Resources.location;
        }
        public void Form2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            SolidBrush myBrush2 = new SolidBrush(Color.Black);
            Pen greenPen = new Pen(Color.FromArgb(255, 255,215,0), 2);
            e.Graphics.DrawImage(Properties.Resources.Isshu2, 0, 0, 650, 524);
            e.Graphics.DrawImage(Properties.Resources.Cover2, 650, 0, 280,524);
            e.Graphics.DrawImage(myImageTrainer, 773, 30, 150, 270);
            e.Graphics.DrawString("Choose pokemon :", new Font("Consolas", 10), myBrush2, new Point(653, 298));
            e.Graphics.DrawLine(greenPen, 20,419, 80,410);
            e.Graphics.DrawLine(greenPen, 140,385, 80, 413);
            e.Graphics.DrawLine(greenPen, 143, 386, 172,450);
            e.Graphics.DrawLine(greenPen, 215,490, 172, 450);
            e.Graphics.DrawLine(greenPen, 334,275, 195, 275);
            e.Graphics.DrawLine(greenPen, 50,176, 195, 275);
            e.Graphics.DrawLine(greenPen, 52, 179, 195, 105);
            e.Graphics.DrawLine(greenPen, 195, 108, 334, 108);
            e.Graphics.DrawLine(greenPen, 490,108, 334, 108);
            e.Graphics.DrawLine(greenPen, 490, 108, 611,177);
            e.Graphics.DrawLine(greenPen, 496, 275, 615, 180);
            e.Graphics.DrawLine(greenPen, 304,346, 334,270);
            e.Graphics.DrawLine(greenPen, 304, 346, 385,418);
            e.Graphics.DrawLine(greenPen, 304, 348, 138,382);
            e.Graphics.DrawLine(greenPen, 470,360, 387, 420);
            e.Graphics.DrawLine(greenPen, 555, 293, 474, 356);
            e.Graphics.DrawLine(greenPen, 561,283, 570, 380);
            e.Graphics.DrawLine(greenPen, 590, 425, 570, 380);
            SolidBrush myBrush3 = new SolidBrush(Color.Gold);
            Pen goldPen = new Pen(Color.Gold, 2);
            e.Graphics.FillEllipse(myBrush3, 588, 423, 10, 10);
            e.Graphics.DrawString("Home", new Font("Consolas", 8), myBrush3, new Point(596, 423));
            e.Graphics.DrawString("Your Money:" + Convert.ToString(MyTrainer.Money), new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 50));
            e.Graphics.DrawString(MyTrainer.Name, new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 35));
       }
        private void Form2_MouseDown(object sender, MouseEventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox123.SelectedIndex == -1)
            {
            }
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e) { }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kojenared == 1)
            {
                pictureBox23.Location = new Point(999, 999);
                if (listBox123.SelectedIndex == -1)
                {
                    SolidBrush myBrush2 = new SolidBrush(Color.Black);
                    Pen greenPen = new Pen(Color.FromArgb(255, 255, 215, 0), 2);
                    Pokemon tvoj = listBox123.SelectedItem as Pokemon;
                    scG.Clear(Color.White);
                    scG.DrawImage(Properties.Resources.Cover2, 650, 0, 280, 524);
                    scG.DrawImage(myImageTrainer, 773, 30, 150, 270);
                    scG.DrawImage(Properties.Resources.Isshu2, 0, 0, 650, 524);
                    scG.DrawImage(ts, kadedasenacrtacoeceto1, kadedasenacrtacoeceto2, 30, 30);
                    ResourceManager rm = Properties.Resources.ResourceManager;
                    scG.DrawString("Obtained badges:", new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 80));
                    if (Level1.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level1.BadgeImg, 653, 100,15,20);
                    } if (Level2.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level2.BadgeImg, 668, 100, 15, 20);
                    }
                    if (Level3.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level3.BadgeImg, 683, 100, 15, 20);
                    } if (Level4.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level4.BadgeImg, 698, 100, 15, 20);
                    }
                    if (Level5.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level5.BadgeImg, 713, 100, 15, 20);
                    }
                    if (Level6.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level6.BadgeImg, 728, 100, 15, 20);
                    }
                    if (Level7.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level7.BadgeImg, 744, 100, 16, 20);
                    }
                    if (Level8.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level8.BadgeImg, 756, 100, 16, 20);
                    }
                    if (Level9.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level9.BadgeImg, 771, 100, 16, 20);
                    }

                    if (Level10.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level10.BadgeImg, 653, 125, 15, 20);
                    } if (Level11.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level11.BadgeImg, 668, 125, 15, 20);
                    }
                    if (Level12.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level12.BadgeImg, 683, 125, 15, 20);
                    } if (Level13.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level13.BadgeImg, 698, 125, 15, 20);
                    }
                    if (Level14.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level14.BadgeImg, 713, 125, 15, 20);
                    }
                    if (Level15.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level15.BadgeImg, 728, 125, 15, 20);
                    }
                    if (Level16.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level16.BadgeImg, 744, 125, 16, 20);
                    }
                    if (Level17.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level17.BadgeImg, 756, 125, 16, 20);
                    }
                    if (Level18.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level18.BadgeImg, 771, 125, 16, 20);
                    }
                    scG.DrawString("Choose pokemon :", new Font("Consolas", 10), myBrush2, new Point(653, 298));
                    scG.DrawLine(greenPen, 20, 419, 80, 410);
                    scG.DrawLine(greenPen, 140, 385, 80, 413);
                    scG.DrawLine(greenPen, 143, 386, 172, 450);
                    scG.DrawLine(greenPen, 215, 490, 172, 450);
                    scG.DrawLine(greenPen, 334, 275, 195, 275);
                    scG.DrawLine(greenPen, 50, 176, 195, 275);
                    scG.DrawLine(greenPen, 52, 179, 195, 105);
                    scG.DrawLine(greenPen, 195, 108, 334, 108);
                    scG.DrawLine(greenPen, 490, 108, 334, 108);
                    scG.DrawLine(greenPen, 490, 108, 611, 177);
                    scG.DrawLine(greenPen, 496, 275, 615, 180);
                    scG.DrawLine(greenPen, 304, 346, 334, 270);
                    scG.DrawLine(greenPen, 304, 346, 385, 418);
                    scG.DrawLine(greenPen, 304, 348, 138, 382);
                    scG.DrawLine(greenPen, 470, 360, 387, 420);
                    scG.DrawLine(greenPen, 555, 293, 474, 356);
                    scG.DrawLine(greenPen, 561, 283, 570, 380);
                    scG.DrawLine(greenPen, 590, 425, 570, 380);
                    SolidBrush myBrush3 = new SolidBrush(Color.Gold);
                    Pen goldPen = new Pen(Color.Gold, 2);
                    scG.FillEllipse(myBrush3, 588, 423, 10, 10);
                    scG.DrawString("Home", new Font("Consolas", 8), myBrush3, new Point(596, 423));
                    scG.DrawString("Your Money:" + Convert.ToString(MyTrainer.Money), new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 50));
                    scG.DrawString(MyTrainer.Name, new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 35));
                    scG.DrawString("Trainer informations :", new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(651, 10));
                    g.DrawImage(btm, new Point(0, 0));
                }
                if (listBox123.SelectedIndex != -1)
                {
                    SolidBrush myBrush2 = new SolidBrush(Color.Black);
                    Pen greenPen = new Pen(Color.FromArgb(255, 255, 215, 0), 2);
                    Pokemon tvoj = listBox123.SelectedItem as Pokemon;
                    Animations animacijaMoj = tvoj.AnimacijaPokemon;
                    scG.Clear(Color.White);
                    scG.DrawImage(Properties.Resources.Cover2, 650, 0, 280, 524);
                    scG.DrawImage(myImageTrainer, 773, 30, 150, 270);
                    scG.DrawImage(animacijaMoj.GiveNextImage(), 670, 140, 150, 150);
                    scG.DrawImage(Properties.Resources.Isshu2, 0, 0, 650, 524);
                    scG.DrawImage(ts, kadedasenacrtacoeceto1, kadedasenacrtacoeceto2, 30, 30);
                    ResourceManager rm = Properties.Resources.ResourceManager;
                    Bitmap myImagep = (Bitmap)rm.GetObject(tvoj.Type);
                    scG.DrawImage(myImagep, 653, 260, 30, 12);
                    scG.DrawString("Life points :" + tvoj.LifePoints, new Font("Consolas", 8), myBrush2, new Point(653, 277));
                    scG.DrawString("Choose pokemon:", new Font("Consolas", 10), myBrush2, new Point(653, 298));
                    scG.DrawLine(greenPen, 20, 419, 80, 410);
                    scG.DrawLine(greenPen, 140, 385, 80, 413);
                    scG.DrawLine(greenPen, 143, 386, 172, 450);
                    scG.DrawLine(greenPen, 215, 490, 172, 450);
                    scG.DrawLine(greenPen, 334, 275, 195, 275);
                    scG.DrawLine(greenPen, 50, 176, 195, 275);
                    scG.DrawLine(greenPen, 52, 179, 195, 105);
                    scG.DrawLine(greenPen, 195, 108, 334, 108);
                    scG.DrawLine(greenPen, 490, 108, 334, 108);
                    scG.DrawLine(greenPen, 490, 108, 611, 177);
                    scG.DrawLine(greenPen, 496, 275, 615, 180);
                    scG.DrawLine(greenPen, 304, 346, 334, 270);
                    scG.DrawLine(greenPen, 304, 346, 385, 418);
                    scG.DrawLine(greenPen, 304, 348, 138, 382);
                    scG.DrawLine(greenPen, 470, 360, 387, 420);
                    scG.DrawLine(greenPen, 555, 293, 474, 356);
                    scG.DrawLine(greenPen, 561, 283, 570, 380);
                    scG.DrawLine(greenPen, 590, 425, 570, 380);
                    scG.DrawString("Obtained badges:", new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 80));
                    if (Level1.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level1.BadgeImg, 653, 100, 15, 20);
                    } if (Level2.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level2.BadgeImg, 668, 100, 15, 20);
                    }
                    if (Level3.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level3.BadgeImg, 683, 100, 15, 20);
                    } if (Level4.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level4.BadgeImg, 698, 100, 15, 20);
                    }
                    if (Level5.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level5.BadgeImg, 713, 100, 15, 20);
                    }
                    if (Level6.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level6.BadgeImg, 728, 100, 15, 20);
                    }
                    if (Level7.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level7.BadgeImg, 744, 100, 16, 20);
                    }
                    if (Level8.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level8.BadgeImg, 756, 100, 16, 20);
                    }
                    if (Level9.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level9.BadgeImg, 771, 100, 16, 20);
                    }
                    if (Level10.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level10.BadgeImg, 653, 125, 15, 20);
                    } if (Level11.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level11.BadgeImg, 668, 125, 15, 20);
                    }
                    if (Level12.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level12.BadgeImg, 683, 125, 15, 20);
                    } if (Level13.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level13.BadgeImg, 698, 125, 15, 20);
                    }
                    if (Level14.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level14.BadgeImg, 713, 125, 15, 20);
                    }
                    if (Level15.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level15.BadgeImg, 728, 125, 15, 20);
                    }
                    if (Level16.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level16.BadgeImg, 744, 125, 16, 20);
                    }
                    if (Level17.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level17.BadgeImg, 756, 125, 16, 20);
                    }
                    if (Level18.PoinatNePoiminat == true)
                    {
                        scG.DrawImage(Level18.BadgeImg, 771, 125, 16, 20);
                    }
                    SolidBrush myBrush3 = new SolidBrush(Color.Gold);
                    Pen goldPen = new Pen(Color.Gold, 2);
                    scG.FillEllipse(myBrush3, 588, 423, 10, 10);
                    scG.DrawString("Home", new Font("Consolas", 8), myBrush3, new Point(596, 423));
                    scG.DrawString("Your Money:" + Convert.ToString(MyTrainer.Money), new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 50));
                    scG.DrawString(MyTrainer.Name, new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(652, 35));
                    scG.DrawString("Trainer informations :", new Font("Consolas", 11), new SolidBrush(Color.Black), new Point(651, 10));
                    g.DrawImage(btm, new Point(0, 0));
                }
            }
            if (kojenared == 0)
            {
                SolidBrush myBrush10 = new SolidBrush(Color.LightSlateGray);
                SolidBrush myBrush9 = new SolidBrush(Color.White);
                SolidBrush myBrush4 = new SolidBrush(Color.Black);
                SolidBrush myBrush2 = new SolidBrush(Color.LightSteelBlue);
                SolidBrush myBrush5 = new SolidBrush(Color.White);
                Pen greenPen = new Pen(Color.FromArgb(255, 255, 215, 0), 2);
                SolidBrush myBrush3 = new SolidBrush(Color.LightSlateGray);
                scG.Clear(Color.White);
                if (iscrtuvanje == 1)
                {
                    scG.DrawImage(Properties.Resources.pocetok, 0, 0, 944, 551);
                    scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.FillRectangle(myBrush5, _myRectangle1);
                    scG.DrawString("New Game", new Font("Consolas", 20), myBrush2, new Point(300, 280));
                    scG.DrawString("Created by:", new Font("Consolas", 15), myBrush3, new Point(660,421));
                    scG.DrawString("Kristijan Laskovski", new Font("Consolas", 15), myBrush2, new Point(660, 436));
                    scG.DrawString("Marjana Petkovska", new Font("Consolas", 15), myBrush2, new Point(660, 451));
                    scG.DrawString("Anastasija Davitkova", new Font("Consolas", 15), myBrush2, new Point(660, 466));
                }
                if (iscrtuvanje == 2)
                {
                    pictureBox22.Location = new Point(999, 999);
                    pictureBox23.Location = new Point(999, 999);
                    scG.DrawImage(Properties.Resources.back, 0, 0, 944, 551);
                    scG.DrawImage(Properties.Resources.prof, 10, 96, 200, 409);
                    scG.DrawString("Hi There!  Welcome to the world of Pokemon!  ", new Font("Consolas", 10), myBrush4, new Point(140, 10));
                    scG.DrawString("My name is Professor Juniper. Every one calls me the Pokemon Professor.", new Font("Consolas", 10), myBrush4, new Point(140, 23));
                    scG.DrawString("This world is widely inhabited by mysterious creatures called Pokemon!", new Font("Consolas", 10), myBrush4, new Point(140, 36));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("Pokemon have mysterious powers. They come in many shapes and live in ", new Font("Consolas", 10), myBrush4, new Point(140, 49));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("many different places. We humans live with Pokemon ! Living and working ", new Font("Consolas", 10), myBrush4, new Point(140, 62));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("together we complement each other, we help each other to accomplish ", new Font("Consolas", 10), myBrush4, new Point(140, 75));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("difficult tasks.Having pokemon battels is particulary popular , and it deepens ", new Font("Consolas", 10), myBrush4, new Point(140, 88));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("the bounds between people and Pokemon ,and that is why I reasurch Pokemon! ", new Font("Consolas", 10), myBrush4, new Point(140, 101));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.DrawString("Well that's enough from mee...?", new Font("Consolas", 10), myBrush4, new Point(140, 114));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));
                    scG.FillRectangle(myBrush9, _myRectangle2);
                    scG.DrawString("Next >> ", new Font("Consolas", 13), myBrush10, new Point(400, 124));// scG.DrawString("Pokemon", new Font("Consolas", 20), myBrush3, new Point(300, 240));

                }
                if (iscrtuvanje == 3)
                {
                    _myRectangle2.Location = new Point(944, 541);
                    scG.DrawImage(Properties.Resources.back, 0, 0, 944, 551);
                    scG.DrawImage(Properties.Resources.prof, 10, 96, 200, 409);
                    scG.DrawString("Could you tell me about yourself !  ", new Font("Consolas", 10), myBrush4, new Point(140, 10));
                    scG.DrawString("Are you a boy or a girl ?", new Font("Consolas", 10), myBrush4, new Point(140, 23));
                    scG.FillRectangle(myBrush9, _myRectangle3);
                    scG.FillRectangle(myBrush9, _myRectangle4);
                    scG.DrawString("BOY", new Font("Consolas", 15), new SolidBrush(Color.DodgerBlue), new Point(140, 36));
                    scG.DrawString("GIRL", new Font("Consolas", 15), new SolidBrush(Color.Salmon), new Point(250, 36));
                    if (pol == 0)
                    {
                        scG.DrawImage(Properties.Resources.Ash_Ketchum, 600, 150, 160, 350);
                    }
                    if (pol == 1)
                    {
                        scG.DrawImage(Properties.Resources.trainer1, 600, 150, 160, 350);
                    }
                    scG.FillRectangle(myBrush9, _myRectangle5);
                    scG.DrawString("Next >> ", new Font("Consolas", 13), myBrush10, new Point(140, 65));
                } 
                if (iscrtuvanje == 4)
                {
                    scG.DrawImage(Properties.Resources.back, 0, 0, 944, 551);
                    scG.DrawImage(Properties.Resources.prof, 10, 96, 200, 409);
                    scG.DrawString("Please tell me your name :   ", new Font("Consolas", 10), myBrush4, new Point(140, 10));
                    if (pol == 0)
                    {
                        scG.DrawImage(Properties.Resources.Ash_Ketchum, 600, 150, 160, 350);
                    }
                    if (pol == 1)
                    {
                        scG.DrawImage(Properties.Resources.trainer1, 600, 150, 160, 350);
                    }
                    scG.FillRectangle(myBrush9, _myRectangle6);
                    scG.DrawString("Next >> ", new Font("Consolas", 13), myBrush10, new Point(256, 30));
                }
                if (iscrtuvanje == 5)
                {
                    scG.DrawImage(Properties.Resources.back, 0, 0, 944, 551);
                    scG.DrawImage(Properties.Resources.prof, 10, 96, 200, 409);
                    scG.DrawString("So," + Ime_trainer + ", I'm going to entrust you with a Pokemon.", new Font("Consolas", 10), myBrush4, new Point(140, 10));
                    scG.DrawString("I'm sure you will be great partners. The moment you choose the Pokemon that ", new Font("Consolas", 10), myBrush4, new Point(140, 23));
                    scG.DrawString("will accompany you and your journey , your story will truly begin .", new Font("Consolas", 10), myBrush4, new Point(140, 36));
                    scG.DrawString("Choose one of this starter Pokemon : ", new Font("Consolas", 10), myBrush4, new Point(140, 49));
                    if (pol == 0)
                    {
                        scG.DrawImage(Properties.Resources.Ash_Ketchum, 600, 150, 160, 350);
                    }
                    if (pol == 1)
                    {
                        scG.DrawImage(Properties.Resources.trainer1, 600, 150, 160, 350);
                    }
                    if (listBox1.SelectedIndex != -1)
                    {
                        Pokemon tvoj = listBox1.SelectedItem as Pokemon;
                        Animations animacijaMoj = tvoj.AnimacijaPokemon;
                        scG.DrawImage(animacijaMoj.GiveNextImage(), 460, 300, 230, 230);
                        scG.FillRectangle(myBrush9, _myRectangle7);
                        if (listBox1.SelectedIndex == 0)
                        {
                            scG.DrawString("FENNIKEN , the fire type Pokemon", new Font("Consolas", 10), myBrush4, new Point(140, 114));
                            scG.DrawString("As it walks, it munches on a twig in place of a snack. It intimidates ", new Font("Consolas", 10), myBrush4, new Point(140, 127));
                            scG.DrawString("opponents by puffing hot air out of its ears.", new Font("Consolas", 10), myBrush4, new Point(140, 140));
                            scG.DrawString("Fenniken, I choose you!", new Font("Consolas", 10), myBrush4, new Point(730, 180));
                            scG.DrawString("Next>>", new Font("Consolas", 15), myBrush10, new Point(780, 194));
                        }
                        if (listBox1.SelectedIndex == 1)
                        {
                            scG.DrawString("CHESPIN , the grass type Pokemon", new Font("Consolas", 10), myBrush4, new Point(140, 114));
                            scG.DrawString("The quills on its head are usually soft. When it flexes them, the ", new Font("Consolas", 10), myBrush4, new Point(140, 127));
                            scG.DrawString("points become so hard and sharp that they can pierce rock.", new Font("Consolas", 10), myBrush4, new Point(140, 140));
                            scG.DrawString("Chespin, I choose you!", new Font("Consolas", 10), myBrush4, new Point(730, 180));
                            scG.DrawString("Next>>", new Font("Consolas", 15), myBrush10, new Point(780, 194));
                        }
                        if (listBox1.SelectedIndex == 2)
                        {
                            scG.DrawString("FROAKIE , the water type Pokemon", new Font("Consolas", 10), myBrush4, new Point(140, 114));
                            scG.DrawString("It protects its skin by covering its body in delicate bubbles. ", new Font("Consolas", 10), myBrush4, new Point(140, 127));
                            scG.DrawString("Beneath its happy-go-lucky air, it keeps a watchful eye on its surroundings.", new Font("Consolas", 10), myBrush4, new Point(140, 140));
                            scG.DrawString("Froakie, I choose you!", new Font("Consolas", 10), myBrush4, new Point(730, 180));
                            scG.DrawString("Next>>", new Font("Consolas", 15), myBrush10, new Point(780, 194));
                        }
                    }
                } 
                if (iscrtuvanje == 6)
                {
                    scG.DrawImage(Properties.Resources.back, 0, 0, 944, 551);
                    scG.DrawImage(Properties.Resources.prof, 10, 96, 200, 409);
                    scG.DrawString("Well done " + Ime_trainer + ", now you have your first Pokemon. ", new Font("Consolas", 10), myBrush4, new Point(140, 10));
                    scG.DrawString("During your journey you will meet many Pokemon with different types", new Font("Consolas", 10), myBrush4, new Point(140, 23));
                    scG.DrawString("some of them are weak but there are also many strong Pokemons .", new Font("Consolas", 10), myBrush4, new Point(140, 36));
                    scG.DrawString("Try to find the those which you think will help you to beat all Chalange Pokemons", new Font("Consolas", 10), myBrush4, new Point(140, 49));
                    scG.DrawString("Now  let's go visit the world of Pokemon ! ", new Font("Consolas", 10), myBrush4, new Point(140, 62));
                    scG.FillRectangle(myBrush9, _myRectangle8);
                    scG.DrawString("START Adventure ", new Font("Consolas", 13), myBrush10, new Point(140, 75));
                    if (pol == 0)
                    {
                        scG.DrawImage(Properties.Resources.Ash_Ketchum, 600, 150, 160, 350);
                    }
                    if (pol == 1)
                    {
                        scG.DrawImage(Properties.Resources.trainer1, 600, 150, 160, 350);
                    }
                    Animations animacijaMoj = Myfirstpokemon.AnimacijaPokemon;
                    scG.DrawImage(animacijaMoj.GiveNextImage(), 460, 300, 230, 230);
                }
                g.DrawImage(btm, new Point(0, 0));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[4] == true)
            {
                setPozadina5();
                kadedasenacrtacoeceto1 = pictureBox4.Location.X;
                kadedasenacrtacoeceto2 = pictureBox4.Location.Y - 28;
                pictureBox20.Location = new Point(313, 357);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this level for 1500 coins?", "Unlock Level",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MyTrainer.Money = MyTrainer.Money - 2500;
                    MyTrainer.Leveli[4] = true;
                    levelipromeni();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setPozadina1();
            kadedasenacrtacoeceto1 = pictureBox2.Location.X;
            kadedasenacrtacoeceto2 = pictureBox2.Location.Y - 28;
            pictureBox20.Location = new Point(527,302);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setPozadina2();
            kadedasenacrtacoeceto1 = pictureBox1.Location.X;
            kadedasenacrtacoeceto2 = pictureBox1.Location.Y - 28;
            pictureBox20.Location = new Point(527, 394);
            pictureBox20.Image = Properties.Resources.chalange2;
            MomentalenLevel = Level1;
            ChalangePokemon = Pyroarr;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setPozadina3();
            kadedasenacrtacoeceto1 = pictureBox3.Location.X;
            kadedasenacrtacoeceto2 = pictureBox3.Location.Y - 28;
            pictureBox20.Location = new Point(422, 375);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[3] == true)
            {
                setPozadina4();
                kadedasenacrtacoeceto1 = pictureBox5.Location.X;
                kadedasenacrtacoeceto2 = pictureBox5.Location.Y - 28;
                pictureBox20.Location = new Point(405, 426);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
            else {
                DialogResult result = MessageBox.Show("Do you want to unlock this level for 1000 coins?", "Unlock Level",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 2000)
                    {
                        MyTrainer.Money = MyTrainer.Money - 2000;
                        MyTrainer.Leveli[3] = true;
                        levelipromeni();
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough money to unlock this level!");
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            setPozadina6();
            kadedasenacrtacoeceto1 = pictureBox6.Location.X;
            kadedasenacrtacoeceto2 = pictureBox6.Location.Y - 28;
            pictureBox20.Location = new Point(344, 278);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                setPozadina7();
                kadedasenacrtacoeceto1 = pictureBox7.Location.X;
                kadedasenacrtacoeceto2 = pictureBox7.Location.Y - 28;
                pictureBox20.Location = new Point(85, 278);
                pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            setPozadina8();
            kadedasenacrtacoeceto1 = pictureBox8.Location.X;
            kadedasenacrtacoeceto2 = pictureBox8.Location.Y - 28;
            pictureBox20.Location = new Point(65,186);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            setPozadina9();
            kadedasenacrtacoeceto1 = pictureBox9.Location.X;
            kadedasenacrtacoeceto2 = pictureBox9.Location.Y - 28;
            pictureBox20.Location = new Point(199, 114);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            setPozadina10();
            kadedasenacrtacoeceto1 = pictureBox10.Location.X;
            kadedasenacrtacoeceto2 = pictureBox10.Location.Y - 28;
            pictureBox20.Location = new Point(342, 114);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            setPozadina11();
            kadedasenacrtacoeceto1 = pictureBox11.Location.X;
            kadedasenacrtacoeceto2 = pictureBox11.Location.Y - 28;
            pictureBox20.Location = new Point(405, 119);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            setPozadina12();
            kadedasenacrtacoeceto1 = pictureBox12.Location.X;
            kadedasenacrtacoeceto2 = pictureBox12.Location.Y - 28;
            pictureBox20.Location = new Point(513, 186);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            setPozadina13();
            kadedasenacrtacoeceto1 = pictureBox13.Location.X;
            kadedasenacrtacoeceto2 = pictureBox13.Location.Y - 28;
            pictureBox20.Location = new Point(385, 278);
            pictureBox20.Image = Properties.Resources.chalange2;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[13] == false)
            {
               DialogResult result = MessageBox.Show("Do you want to unlock this BONUS level for 6000 coins?", "Bonus",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 6000)
                    {
                        MyTrainer.Money = MyTrainer.Money - 6000;
                        MyTrainer.Leveli[13] = true;
                        levelipromeni();
                        setPozadina14();
                        kadedasenacrtacoeceto1 = pictureBox14.Location.X;
                        kadedasenacrtacoeceto2 = pictureBox14.Location.Y - 28;
                        pictureBox20.Location = new Point(149, 394);
                        pictureBox20.Image = Properties.Resources.chalange2;
                    }
                    else 
                    { 
                        MessageBox.Show("You don't have enough money!"); 
                    }
                }
            }
            else {
                setPozadina14();
                kadedasenacrtacoeceto1 = pictureBox14.Location.X;
                kadedasenacrtacoeceto2 = pictureBox14.Location.Y - 28;
                pictureBox20.Location = new Point(149, 394);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[17] == false)
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this BONUS level for 6000 coins?", "Bonus",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 6000)
                    {
                        MyTrainer.Money = MyTrainer.Money - 6000;
                        MyTrainer.Leveli[17] = true;
                        levelipromeni();
                        setPozadina17();
                        kadedasenacrtacoeceto1 = pictureBox18.Location.X;
                        kadedasenacrtacoeceto2 = pictureBox18.Location.Y - 28;
                        pictureBox20.Location = new Point(100, 403);
                        pictureBox20.Image = Properties.Resources.chalange2;

                    }
                    else 
                    { 
                        MessageBox.Show("You don't have enough money!"); 
                    }
                }
            }
            else
            {
                setPozadina17();
                kadedasenacrtacoeceto1 = pictureBox18.Location.X;
                kadedasenacrtacoeceto2 = pictureBox18.Location.Y - 28;
                pictureBox20.Location = new Point(100, 403);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[14] == false)
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this BONUS level for 6000 coins?", "Bonus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 6000)
                    {
                        MyTrainer.Money = MyTrainer.Money - 6000;
                        MyTrainer.Leveli[14] = true;
                        levelipromeni();
                        setPozadina18();
                        kadedasenacrtacoeceto1 = pictureBox15.Location.X;
                        kadedasenacrtacoeceto2 = pictureBox15.Location.Y - 28;
                        pictureBox20.Location = new Point(27, 427);
                        pictureBox20.Image = Properties.Resources.chalange2;
                    }
                    else 
                    {
                        MessageBox.Show("You don't have enough money!"); 
                    }
                }
            }
            else
            {
                setPozadina18();
                kadedasenacrtacoeceto1 = pictureBox15.Location.X;
                kadedasenacrtacoeceto2 = pictureBox15.Location.Y - 28;
                pictureBox20.Location = new Point(27, 427);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[16] == false)
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this BONUS level for 6000 coins?", "Bonus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 6000)
                    {
                        MyTrainer.Money = MyTrainer.Money - 6000;
                        MyTrainer.Leveli[16] = true;
                        levelipromeni();
                        setPozadina15();
                        kadedasenacrtacoeceto1 = pictureBox17.Location.X;
                        kadedasenacrtacoeceto2 = pictureBox17.Location.Y - 28;
                        pictureBox20.Location = new Point(185, 444);
                        pictureBox20.Image = Properties.Resources.chalange2;
                    }
                    else 
                    {
                        MessageBox.Show("You don't have enough money!"); 
                    }
                }
            }
            else
            {
                setPozadina15();
                kadedasenacrtacoeceto1 = pictureBox17.Location.X;
                kadedasenacrtacoeceto2 = pictureBox17.Location.Y - 28;
                pictureBox20.Location = new Point(185, 444);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (MyTrainer.Leveli[15] == false)
            {
                DialogResult result = MessageBox.Show("Do you want to unlock this BONUS level for 6000 coins?", "Bonus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (MyTrainer.Money > 6000)
                    {
                         MyTrainer.Money = MyTrainer.Money - 6000;
                        MyTrainer.Leveli[15] = true;
                        levelipromeni();
                        setPozadina16();
                        kadedasenacrtacoeceto1 = pictureBox16.Location.X;
                        kadedasenacrtacoeceto2 = pictureBox16.Location.Y - 28;
                        pictureBox20.Location = new Point(231, 475);
                        pictureBox20.Image = Properties.Resources.chalange2;
                    }
                    else 
                    {
                        MessageBox.Show("You don't have enough money!"); 
                    }
                }
            }
            else
            {
                setPozadina16();
                kadedasenacrtacoeceto1 = pictureBox16.Location.X;
                kadedasenacrtacoeceto2 = pictureBox16.Location.Y - 28;
                pictureBox20.Location = new Point(231, 475);
                pictureBox20.Image = Properties.Resources.chalange2;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (listBox123.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose one of your pokemons to join the battle!");
            }
            else
            {
                Pokemon tvoj = listBox123.SelectedItem as Pokemon;
                Bettel2 bb = new Bettel2(tvoj,setepaso, arena1, MyTrainer, MomentalenLevel);
                this.Visible = false;
                timer1.Stop();
                bb.ShowDialog();
                MomentalenLevel = bb.currentLevel;
                MyTrainer = bb.igrac;
                timer1.Start() ;
                listBox123.SelectedIndex = -1;
                this.Visible = true;
            }
        }
        public void aruzirajpokemonivolista()
        {
            listBox123.Items.Clear();
            for (int i = 0; i < MyTrainer.Mypokemon.Count; i++)
            {
                listBox123.Items.Add(MyTrainer.Mypokemon[i]);
            }
        }
        public void mapa()
        {
            pictureBox1.Location = new Point(564, 375);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(555, 278);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(466, 351);
            pictureBox4.Location = new Point(298, 341);
            pictureBox5.Location = new Point(380, 412);
            pictureBox6.Location = new Point(329, 267);
            pictureBox7.Location = new Point(185, 267);
            pictureBox8.Location = new Point(46, 172);
            pictureBox9.Location = new Point(185, 101);
            pictureBox10.Location = new Point(329, 101);
            pictureBox11.Location = new Point(486, 101);
            pictureBox12.Location = new Point(608, 172);
            pictureBox13.Location = new Point(486, 267);
            pictureBox14.Location = new Point(134, 375);
            pictureBox15.Location = new Point(12, 412);
            pictureBox16.Location = new Point(210, 483);
            pictureBox17.Location = new Point(166, 444);
            pictureBox18.Location = new Point(76, 403);
            pictureBox19.Location = new Point(786, 306);
            pictureBox20.Location = new Point(994, 555);
            pictureBox21.Location = new Point(786, 351);
            pictureBox22.Location = new Point(786,396);

            pictureBox24.Location = new Point(828, 444);
            pictureBox24.BackColor = Color.Transparent;

            listBox123.Location = new Point(651, 314);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
            pictureBox19.BackColor = Color.Transparent;
            pictureBox20.BackColor = Color.Transparent;
            pictureBox21.BackColor = Color.Transparent;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(listaZavoProdavnica, MyTrainer);
            this.Visible = false;
            timer1.Stop();
            f3.ShowDialog();
            MyTrainer = f3.Mykarakter;
            aruzirajpokemonivolista();
            timer1.Start();
            this.Visible = true;
        }

        private void Form2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (this._myRectangle1.Contains(e.Location))
            {
                iscrtuvanje = 2;
                _myRectangle2.Location = new Point(400, 123);
            }
            if (this._myRectangle2.Contains(e.Location))
            {
                iscrtuvanje = 3;
                _myRectangle1.Location = new Point(944, 551);
                _myRectangle2.Location = new Point(944, 551);
                _myRectangle3.Location = new Point(140, 40);
                _myRectangle4.Location = new Point(250, 40);
                _myRectangle5.Location = new Point(140, 63);
            }
            if (this._myRectangle3.Contains(e.Location))
            {
                pol = 0;
            }
            if (this._myRectangle4.Contains(e.Location))
            {
                pol = 1;
            }
            if (this._myRectangle5.Contains(e.Location))
            {
                _myRectangle1.Location = new Point(944, 551);
                _myRectangle2.Location = new Point(944, 551);
                _myRectangle3.Location = new Point(944, 541);
                _myRectangle4.Location = new Point(944, 541);
                _myRectangle6.Location = new Point(255, 30);
                iscrtuvanje = 4; 
                textBox1.Visible = true;
            }
            if (this._myRectangle6.Contains(e.Location))
            {
                _myRectangle5.Location = new Point(944, 541);
                if (textBox1.Text.Trim().Length == 0) 
                { 
                    MessageBox.Show("Choose name:"); 
                }
                else
                {
                    Ime_trainer = textBox1.Text;
                    iscrtuvanje = 5; 
                    textBox1.Visible = false;
                    listBox1.Visible = true;
                    _myRectangle7.Location = new Point(780, 196);
                }
            }
            if (this._myRectangle7.Contains(e.Location))
            {
                Myfirstpokemon = listBox1.SelectedItem as Pokemon;
                _myRectangle6.Location = new Point(944, 551);
                _myRectangle7.Location = new Point(944,551);
                _myRectangle8.Location = new Point(140, 75);
                listBox1.Visible = false;
                iscrtuvanje = 6;
            }
            if (this._myRectangle8.Contains(e.Location))
            {
                if (pol == 0)
                {
                    Trainer mojigrac = new Trainer(Ime_trainer, "Male", 3000, "slika", Properties.Resources.Ash_Ketchum,Properties.Resources.trainer2,Properties.Resources.trainersmall,Properties.Resources.srednaMale);
                    bool lv1 = true;
                    bool lv2 = true;
                    bool lv3 = true;
                    bool lv4 = true;
                    bool lv5 =true;
                    bool lv6 = true;
                    bool lv7 = true;
                    bool lv8 = true;
                    bool lv9 = true;
                    bool lv10 = true;
                    bool lv11 = true;
                    bool lv12 =true;
                    bool lv13 = true;
                    bool lv14 = false;
                    bool lv15 = false;
                    bool lv16 = false;
                    bool lv17 = false;
                    bool lv18 = false;
                    mojigrac.Leveli.Add(lv1);
                    mojigrac.Leveli.Add(lv2);
                    mojigrac.Leveli.Add(lv3);
                    mojigrac.Leveli.Add(lv4);
                    mojigrac.Leveli.Add(lv5);
                    mojigrac.Leveli.Add(lv6);
                    mojigrac.Leveli.Add(lv7);
                    mojigrac.Leveli.Add(lv8);
                    mojigrac.Leveli.Add(lv9);
                    mojigrac.Leveli.Add(lv10);
                    mojigrac.Leveli.Add(lv11);
                    mojigrac.Leveli.Add(lv12);
                    mojigrac.Leveli.Add(lv13);
                    mojigrac.Leveli.Add(lv14);
                    mojigrac.Leveli.Add(lv15);
                    mojigrac.Leveli.Add(lv16);
                    mojigrac.Leveli.Add(lv17);
                    mojigrac.Leveli.Add(lv18);  
                    mojigrac.Mypokemon.Add(Myfirstpokemon);
                    MyTrainer = mojigrac;
                    ts = mojigrac.MalaSlika;
                    myImageTrainer = (Bitmap)mojigrac.GolemaSlika;
                    this.Paint += new PaintEventHandler(Form2_Paint);
                    mapa();
                    aruzirajpokemonivolista();
                    levelipromeni();
                    kojenared = 1;
                }
                if (pol == 1)
                {
                    Trainer mojigrac = new Trainer(Ime_trainer, "Female", 3000, "slika", Properties.Resources.trainer1, Properties.Resources.mugshot21, Properties.Resources.Rosa_OD, Properties.Resources.srednaGirl);
                    bool lv1 = true;
                    bool lv2 = true;
                    bool lv3 = true;
                    bool lv4 = true;
                    bool lv5 = true;
                    bool lv6 = true;
                    bool lv7 = true;
                    bool lv8 = true;
                    bool lv9 = true;
                    bool lv10 = true;
                    bool lv11 = true;
                    bool lv12 = true;
                    bool lv13 = true;
                    bool lv14 = false;
                    bool lv15 = false;
                    bool lv16 = false;
                    bool lv17 = false;
                    bool lv18 = false;
                    mojigrac.Leveli.Add(lv1);
                    mojigrac.Leveli.Add(lv2);
                    mojigrac.Leveli.Add(lv3);
                    mojigrac.Leveli.Add(lv4);
                    mojigrac.Leveli.Add(lv5);
                    mojigrac.Leveli.Add(lv6);
                    mojigrac.Leveli.Add(lv7);
                    mojigrac.Leveli.Add(lv8);
                    mojigrac.Leveli.Add(lv9);
                    mojigrac.Leveli.Add(lv10);
                    mojigrac.Leveli.Add(lv11);
                    mojigrac.Leveli.Add(lv12);
                    mojigrac.Leveli.Add(lv13);
                    mojigrac.Leveli.Add(lv14);
                    mojigrac.Leveli.Add(lv15);
                    mojigrac.Leveli.Add(lv16);
                    mojigrac.Leveli.Add(lv17);
                    mojigrac.Leveli.Add(lv18);       
                    mojigrac.Mypokemon.Add(Myfirstpokemon);
                    MyTrainer = mojigrac;
                    ts = mojigrac.MalaSlika; 
                    myImageTrainer = (Bitmap)mojigrac.GolemaSlika;
                    this.Paint += new PaintEventHandler(Form2_Paint);
                    mapa();
                    aruzirajpokemonivolista();
                    levelipromeni();
                    kojenared =1;
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Form1 f = new Form1();
            f.ShowDialog();
            int cpinsearned = f.coins.getCoins();
            MyTrainer.Money += cpinsearned;
            timer1.Start();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            HelpCenter h = new HelpCenter();
            h.ShowDialog();
            timer1.Start();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            if (MessageBox.Show("Do you want to save the game?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (FileName == null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Pokemon game (*.pokemon)|*.pokemon";
                    saveFileDialog1.Title = "Save a Your Game";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileName = saveFileDialog1.FileName;
                }
                if (FileName != null)
                {
                    System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    fmt.Serialize(strm, MyTrainer);
                    strm.Close();
                }
            }
   */     }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            OpenFileDialog o1 = new OpenFileDialog();
            if (o1.ShowDialog() == DialogResult.OK)
            {
                FileName = o1.FileName;
            }
            else { timer1.Start(); return; }
            FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            MyTrainer = (Trainer)fmt.Deserialize(strm);
            Myfirstpokemon = MyTrainer.Mypokemon[0];
            strm.Close();
            if (MyTrainer.Gender == "Male") pol = 0;
            else pol = 1;
            if (pol == 0)
            {
                Trainer mojigrac = new Trainer(MyTrainer.Name, "Male", 3000, "slika", Properties.Resources.Ash_Ketchum, Properties.Resources.trainer2, Properties.Resources.trainersmall, Properties.Resources.srednaMale);
                bool lv1 = true;
                bool lv2 = true;
                bool lv3 = true;
                bool lv4 = true;
                bool lv5 = true;
                bool lv6 = true;
                bool lv7 = true;
                bool lv8 = true;
                bool lv9 = true;
                bool lv10 = true;
                bool lv11 = true;
                bool lv12 = true;
                bool lv13 = true;
                bool lv14 = false;
                bool lv15 = false;
                bool lv16 = false;
                bool lv17 = false;
                bool lv18 = false;
                mojigrac.Leveli.Add(lv1);
                mojigrac.Leveli.Add(lv2);
                mojigrac.Leveli.Add(lv3);
                mojigrac.Leveli.Add(lv4);
                mojigrac.Leveli.Add(lv5);
                mojigrac.Leveli.Add(lv6);
                mojigrac.Leveli.Add(lv7);
                mojigrac.Leveli.Add(lv8);
                mojigrac.Leveli.Add(lv9);
                mojigrac.Leveli.Add(lv10);
                mojigrac.Leveli.Add(lv11);
                mojigrac.Leveli.Add(lv12);
                mojigrac.Leveli.Add(lv13);
                mojigrac.Leveli.Add(lv14);
                mojigrac.Leveli.Add(lv15);
                mojigrac.Leveli.Add(lv16);
                mojigrac.Leveli.Add(lv17);
                mojigrac.Leveli.Add(lv18);
                mojigrac.Mypokemon = MyTrainer.Mypokemon;
                mojigrac.Money = MyTrainer.Money;
                MyTrainer = mojigrac;
                ts = mojigrac.MalaSlika;
                myImageTrainer = (Bitmap)mojigrac.GolemaSlika;
                this.Paint += new PaintEventHandler(Form2_Paint);
                mapa();
                aruzirajpokemonivolista();
                levelipromeni();
                kojenared = 1;
            }
            if (pol == 1)
            {
                Trainer mojigrac = new Trainer(MyTrainer.Name, "Female", 3000, "slika", Properties.Resources.trainer1, Properties.Resources.mugshot21, Properties.Resources.Rosa_OD, Properties.Resources.srednaGirl);
                bool lv1 = true;
                bool lv2 = true;
                bool lv3 = true;
                bool lv4 = true;
                bool lv5 = true;
                bool lv6 = true;
                bool lv7 = true;
                bool lv8 = true;
                bool lv9 = true;
                bool lv10 = true;
                bool lv11 = true;
                bool lv12 = true;
                bool lv13 = true;
                bool lv14 = false;
                bool lv15 = false;
                bool lv16 = false;
                bool lv17 = false;
                bool lv18 = false;
                mojigrac.Leveli.Add(lv1);
                mojigrac.Leveli.Add(lv2);
                mojigrac.Leveli.Add(lv3);
                mojigrac.Leveli.Add(lv4);
                mojigrac.Leveli.Add(lv5);
                mojigrac.Leveli.Add(lv6);
                mojigrac.Leveli.Add(lv7);
                mojigrac.Leveli.Add(lv8);
                mojigrac.Leveli.Add(lv9);
                mojigrac.Leveli.Add(lv10);
                mojigrac.Leveli.Add(lv11);
                mojigrac.Leveli.Add(lv12);
                mojigrac.Leveli.Add(lv13);
                mojigrac.Leveli.Add(lv14);
                mojigrac.Leveli.Add(lv15);
                mojigrac.Leveli.Add(lv16);
                mojigrac.Leveli.Add(lv17);
                mojigrac.Leveli.Add(lv18);
                mojigrac.Mypokemon = MyTrainer.Mypokemon;
                mojigrac.Money = MyTrainer.Money;
                MyTrainer = mojigrac;
                ts = mojigrac.MalaSlika;
                myImageTrainer = (Bitmap)mojigrac.GolemaSlika;
                this.Paint += new PaintEventHandler(Form2_Paint);
                mapa();
                aruzirajpokemonivolista();
                levelipromeni();
                kojenared = 1;
            }
            iscrtuvanje = 6;
            timer1.Start();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the game?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (FileName == null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Pokemon game (*.pokemon)|*.pokemon";
                    saveFileDialog1.Title = "Save a Your Game";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        FileName = saveFileDialog1.FileName;
                }
                if (FileName != null)
                {
                    System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    fmt.Serialize(strm, MyTrainer);
                    strm.Close();
                }
            }
        }

        private void pictureBox24_Paint(object sender, PaintEventArgs e)
        {

            using (Font myFont = new Font("COMIC SANS MS", 13))
            {
                e.Graphics.DrawString("Save", myFont, Brushes.White, new Point(16, 2));
            }
        }
    }
}
