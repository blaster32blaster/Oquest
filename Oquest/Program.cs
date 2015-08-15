using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oquest
{
    class Program
    {
 
        public static void partOne()
        {
            Console.Write("You find yourself on a dark and winding path overhung by trees, allowing only scant light to navigate by.  \n");
            Console.Write("You don't remember why you are on this path but continue onwards, into parts unknown.  \n");
        }
        public static void partTwo()
        {
            int selection = 0;
            string select = " ";
            do
            {
                Console.Write("\nYou come to a fork in the road.  The Left fork heads towards a distant \n ridge line and you see the peaks of mountains beyond." +
                    "The right fork heads downhill, deeper into the woods.  Off in the distance you can see \n the smoke of a settlement");
                select = Console.ReadLine();
                selection = int.Parse(select);
            } while (selection != 1 || selection != 2);
        }
        public static string pickWeapon()
        {
            string weapon = " ";
            string select = " ";
            int selection = 0;
            Console.Write("Choose your Weapon : \n");
            Console.Write("             1. Dagger \n");
            Console.Write("             2. Short Sword \n");
            Console.Write("             3. Long Sword \n");
            Console.Write("             4. FISTS \n");
            Console.Write("             SELECT :  ");
            select = Console.ReadLine();
            selection = int.Parse(select);
            switch (selection)
            {
                case 1 :
                    weapon = "dagger";
                    break;
                case 2 :
                    weapon = "shortsword";
                    break;
                case 3 :
                    weapon = "longsword";
                    break;
                default :
                    weapon = "fists";
                    break;
            }
           
            
            return weapon;
        }
        public static Boolean isDead(int health)
        {
            Boolean dead = false;
            if(health <= 0)
            {
                dead = true;
                Console.WriteLine("\n\n\n\n\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("                                                     You Have Died");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                
            }
            return dead;
        }
        public static Boolean isWinner(int health)
        {
            Boolean victor = false;
            if(health <= 0)
            {
                victor = true;
                Console.WriteLine("\n\n\n\n\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("                                                     You Are Victorious");
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
             
            }
            return victor;
        }
        public static int getRandNum()
        {
            Random randNum = new Random();
            int numbers = randNum.Next(1, 10);
            return numbers;
        }
        public static int getRandNum2()
        {
            Random randNum = new Random();
            int numbers = randNum.Next(0, 3);
            return numbers;
        }
        public static int getRandNum3(int low, int high)
        {
            Random randNum = new Random();
            int numbers = randNum.Next(low, high);
            return numbers;
        }
        public static int getWeaponDamage(string weapon)
        {
            int damage = 0;
           
            
            switch (weapon)
            {
                case "dagger" :
                    damage = 3;
                    break;
                case "shortsword" :
                    damage = 4;
                    break;
                case "longsword" :
                    damage = 5;
                    break;
                default :
                    damage = 2;
                    break;

            }
            return damage;
        }
        public static void outRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(s);
            
            Console.ResetColor();
        }
        public static void outGreen(string s2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(s2);
            
            Console.ResetColor();
        }
        public static string getCreature()
        {
            string creature = " ";
            int numba = getRandNum();
            switch (numba)
            {
                case 1 :
                    creature = "a Lizard Man";
                    break;
                case 2:
                    creature = "a Bandit";
                    break;
                case 3:
                    creature = "a Bandit";
                    break;
                case 4:
                    creature = "an Evil Mage";
                    break;
                case 5:
                    creature = "a Necromancer";
                    break;
                case 6:
                    creature = "Wolves";
                    break;
                case 7:
                    creature = "a Giant Spider";
                    break;
                case 8:
                    creature = "a Giant Lizard";
                    break;
                case 9:
                    creature = "a Skeleton Warrior";
                    break;
                case 10:
                    creature = "a Draugr Ancient";
                    break;
            }
            return creature;
        }
        public static void combat(string weapon)
        {
            string monster = " ";
            int helt = 10;
            int enemhelt = 10;
            int curDmg = 0;
            int whoHurt = 0;
            int enemDmg = 0;
            int topDmg = getWeaponDamage(weapon);
            int sele = 0;
            string selected = " ";
            monster = getCreature();
            string injMsg = "You were hit for : ";
            string injMsg2 = "The enemy " + monster + " was hit for : ";
            Console.Write("\n\nYou meet "+ monster + "\n\n");

            Console.WriteLine("DO YOU WANT TO    :");
            Console.WriteLine("                     1. Attack");
            Console.WriteLine("                     2. Retreat");
            Console.WriteLine("          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.Write("                     Select :  ");
            
            selected = Console.ReadLine();
            
            do
            {
                Console.WriteLine("Your Health : " + helt);
                Console.WriteLine(monster + " : " + enemhelt);

                Console.WriteLine("\n                     1. Attack");
                Console.WriteLine("                     2. Retreat");
                Console.WriteLine("          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.Write("\n                Select :  ");

                selected = Console.ReadLine();
                sele = int.Parse(selected);
                whoHurt = getRandNum();
                

                if (whoHurt >= 6)
                {
                    curDmg = getRandNum2();
                    Boolean muerto = false;
                    helt = helt - curDmg;
                    string msg1 = injMsg + "  " + curDmg;
                    outRed(msg1);
                    muerto = isDead(helt);
                    if(muerto == true)
                    {
                        break;
                    }
                    Console.WriteLine("\n\n");
                }
                else
                {
                   
                    enemDmg = getRandNum3(1, topDmg);

                    Boolean enemyLife = false;
                    enemhelt = enemhelt - enemDmg;
                    string msg2 = injMsg2 + "  " + enemDmg;
                    outGreen(msg2);
                    enemyLife = isWinner(enemhelt);
                    if (enemyLife == true)
                    {
                        break;
                    }
                    Console.WriteLine("\n\n");
                }
               
                if(sele == 2)
                {
                    Console.WriteLine("GoodBye");
                    break;
                }

            } while (helt > 0 && enemhelt > 0 && sele != 2);
        }
        public static void keyTest()
        {
            ConsoleKeyInfo keyInfo;

while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
{
    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow:
            break;
        case ConsoleKey.RightArrow:
            break;
        case ConsoleKey.DownArrow:
            break;
        case ConsoleKey.LeftArrow:
            break;
    }
}

        }
        public static void checkEncounter(string weapon)
        {
            Random randNum = new Random();
            int numb = randNum.Next(1, 10);
            switch (numb)
            {
                case 1 :
                    combat(weapon);
                    break;
                case 2 :
                   
                    break;
                case 3 :
                    combat(weapon);
                    break;
                case 4 :
                    
                    break;
                case 5 :
                    combat(weapon);
                    break;
                case 6 :
                   
                    break;
                case 7 :
                    combat(weapon);
                    break;
                case 8 :
                    drawMap();
                    break;
                case 9 :
                    break;
                case 10 :
                    break;
            }

        }
        public static void drawMap()
        {
            int locationX = 40;
            int locationY = 4;
            int locationPath = 40;
            char[] mapsX = new char[80];
            char[] mapsY = new char[20];
            for (int i = 0; i < mapsY.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < mapsX.Length; j++)
                {

                    if (j == locationX && i == locationY)
                    {
                        Console.Write("O");
                    }
                    if (j == locationPath && count == 0)
                    {
                        Console.Write(" ");
                        count++;
                    }
                    else
                    {
                        Console.Write("t");
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
      
            int selection = 0;
            do
            {

                string getIt;
                Console.WriteLine("                     WELCOME TO OLAF QUEST            ");
                Console.WriteLine("                                XXX       ");
                Console.WriteLine("                              XX   XX");
                Console.WriteLine("                            XX       XX ");
                Console.WriteLine("                                ");
                Console.WriteLine("                                ");
                Console.WriteLine("\n\n WOULD YOU LIKE TO \n");
                Console.WriteLine("           1. Start a New Game");
                Console.WriteLine("           2. Load a saved Game");
                Console.WriteLine("          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.Write("                SELECT :  ");
                getIt = Console.ReadLine();
                selection = int.Parse(getIt);
            } while (selection != 1 && selection != 2);
            if (selection == 1)
            {
                String getIt2 = " ";
                int selection2 = 0;
                string weapon = " ";
                weapon = pickWeapon();
                partOne();
                
                do
                {
                 
                    
                    Console.WriteLine("\n\n           1. Move Forward");
                    Console.WriteLine("           2. Exit");
                    Console.WriteLine("          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.Write("\n                SELECT :  ");
                    getIt2 = Console.ReadLine();
                    selection2 = int.Parse(getIt2);
                    if (selection2 == 1)
                    {
                        checkEncounter(weapon)
;
                    }
                    if (selection2 == 2)
                    {
                        break;
                    }
                    
                } while (selection2 != 2);
            }
        }
    }
}
