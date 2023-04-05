using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Text_Adventure
{
    public class Encounter
    {
        static Random rand = new Random();
        //Encounter Generic

        
        
        // Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("*Enter First Encounter Prompt here*");
            Combat(false,"Goblin",rand.Next(8,13),10);
            int coins = 100;
            Program.currentplayer.coins += coins;
            Console.WriteLine("\nYou defeated the Goblin. He has alot of gold on him! You gained " + coins + " coins. You now have a total of " + Program.currentplayer.coins + " coins!"); 
            Console.WriteLine("Press a key to continue.");
            Console.ReadLine();

        }
        
        public static void BasicFightEncounter()
        {
            Console.WriteLine("\nYou continue to walk along the floor and a shadow jumps at you and you see...");
            
            Console.WriteLine("Press a key to continue.");
            Console.ReadLine();
            Combat(true, "", 0, 0);
            int coins = rand.Next(10, 50);
            Program.currentplayer.coins += coins;
            Console.WriteLine("You gained " + coins + " coins. You now have a total of " + Program.currentplayer.coins + " coins!");
            Console.WriteLine("Press a key to continue.");
            Console.ReadLine();
        }
        
        
        // Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 1))
            {
                   case 0: BasicFightEncounter();
                   break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0, h = 0;
            
            if (random)
            {
                n = GetName();
                p = rand.Next(Program.currentplayer.GetPowerLower(), Program.currentplayer.GetPowerUpper());
                h = Program.currentplayer.GetHealth();
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            

            while (h > 0)
            {
                Console.WriteLine("\nThe " + n + " has " + h + " health.\n");
                Console.WriteLine("=======================");
                Console.WriteLine("|| (A)ttack (M)agic  ||");
                Console.WriteLine("|| (P)otion (R)un    ||");
                Console.WriteLine("=======================");
                Console.WriteLine(" Health: " + Program.currentplayer.CurrHealth + "/" + Program.currentplayer.Maxhealth + " Mana: " + Program.currentplayer.CurrMana + "/" + Program.currentplayer.MaxMana+" Potions: " + Program.currentplayer.potion);
                Console.WriteLine("\n");
                Console.WriteLine("What would you like to do?");
                string input = Console.ReadLine();
                if(input.ToLower()== "a" || input.ToLower() == "attack")
                {
                    Console.Clear();
                    //Attack
                    Console.WriteLine("You attack");
                    int damage = p;
                    int attack = rand.Next(1, Program.currentplayer.weaponvalue) + rand.Next(0,5+Program.currentplayer.weaponvalue);
                    h -= attack;
                    Program.currentplayer.CurrHealth -= damage;
                    Console.WriteLine("You dealt " + attack + " damage to "+n+".");
                    Console.WriteLine("You take " + damage + " damage from the " +n+ ".\n");
                    
                    
                }
                else if(input.ToLower()== "m" || input.ToLower() == "magic")
                {
                    Console.Clear();
                    //Magic Option
                    Console.WriteLine("The " + n + " has " + h + " health.\n");
                    Console.WriteLine("=======================");
                    Console.WriteLine("|| (F)ireball (H)eal ||");
                    Console.WriteLine("||            (B)ack ||");
                    Console.WriteLine("=======================");
                    Console.WriteLine("Health: " + Program.currentplayer.CurrHealth + "/" + Program.currentplayer.Maxhealth + " Mana: " + Program.currentplayer.CurrMana + "/" + Program.currentplayer.MaxMana);
                    Console.WriteLine("\n");
                    Console.WriteLine("Select a spell.");
                    string Minput = Console.ReadLine();
                    if (Minput.ToLower() == "f" || Minput.ToLower() == "fireball")
                    {
                        double fireC = (int)Program.currentplayer.MaxMana * .4;
                        double fireD = 10 + ((int)Program.currentplayer.MaxMana * .05);
                        int damage = p;
                        if (Program.currentplayer.CurrMana <= Program.currentplayer.MaxMana)
                        {
                            h -= (int)fireD;
                            Program.currentplayer.CurrMana -= (int)fireC;
                            Program.currentplayer.CurrHealth -= damage;
                            Console.WriteLine("You charging up your fireball.");
                            Console.WriteLine("You fire your fireball! You dealt " + fireD + " damage to " + n + ".");
                            Console.WriteLine("You take " + damage + " damage from the " + n + ".\n");
                            Console.WriteLine("Press a key to continue.");
                            Console.ReadLine();

                        }
                        else if (fireC < Program.currentplayer.CurrMana)
                        {
                            Console.WriteLine("\nYou need more mana.\n");
                            Console.WriteLine("Press key to continue.");
                        }
                        Console.Clear();
                    }
                    else if (Minput.ToLower() == "h" || Minput.ToLower() == "heal")
                    {
                        int damage = p;
                        double healc =(int)Program.currentplayer.MaxMana * .5;
                        double heal =((int)Program.currentplayer.MaxMana * .5);
                        if (Program.currentplayer.CurrHealth < Program.currentplayer.Maxhealth)
                        {
                            Program.currentplayer.CurrHealth += (int)heal;
                            Program.currentplayer.CurrMana -= (int)healc;
                            Console.WriteLine("You cast heal. You were healed for" + heal + " health.");
                            if (Program.currentplayer.CurrHealth > Program.currentplayer.Maxhealth)
                            {
                                Program.currentplayer.CurrHealth = Program.currentplayer.Maxhealth;
                            }
                            Program.currentplayer.CurrHealth -= damage;
                            Console.WriteLine("You take " + damage + " damage from the " + n + ".\n");
                        }
                        else if (Program.currentplayer.CurrHealth >= Program.currentplayer.Maxhealth)
                        {

                            Console.WriteLine("You have full health");

                        }
                        Console.WriteLine("\nPress key to continue.");
                        Console.ReadLine();
                    }
                    else if (Minput.ToLower() == "b")
                    {
                        

                    }

                }
                else if(input.ToLower()== "p" || input.ToLower() == "potion")
                {
                    int damage = p;
                    //Use Potion
                    if (Program.currentplayer.potion == 0)
                    {
                        
                        // No Potions
                        Console.WriteLine("You have run out of potions.");
                        Console.WriteLine("Press a key to continue.");
                        Console.ReadKey();

                    }
                    else
                    {
                        double potheal = (int)Program.currentplayer.Maxhealth * .5;
                        // Use a potions
                        if (Program.currentplayer.CurrHealth < Program.currentplayer.Maxhealth && Program.currentplayer.potion > 0)
                        {
                            
                            Program.currentplayer.CurrHealth += (int)potheal;
                            Program.currentplayer.potion -= 1;
                            Console.WriteLine("You use a potion. You gain " + potheal + " health!");
                            Console.WriteLine("You now have " + Program.currentplayer.potion + " potions.");
                            if (Program.currentplayer.CurrHealth > Program.currentplayer.Maxhealth)
                            {
                                Program.currentplayer.CurrHealth = Program.currentplayer.Maxhealth;
                            }
                            Program.currentplayer.CurrHealth -= damage;
                            Console.WriteLine("You take " + damage + " from the " + n + ".");
                            Console.WriteLine("Press a key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if(Program.currentplayer.CurrHealth >= Program.currentplayer.Maxhealth)
                        {
                            
                            Console.WriteLine("You have full health");
                            Console.WriteLine("\nPress a Key to continue.");
                            Console.ReadKey();
                        }
                        
                    }
                }
                else if(input.ToLower()== "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2)== 0)
                    {
                        Console.WriteLine("You failed to escape from" + n+ ".");
                        int damage = p / 2;
                        if (damage > 0)
                        {
                            damage = 0;
                        }
                        Program.currentplayer.CurrHealth -= damage;
                        Console.WriteLine("As you tried to run away, the " +n+" attack grazed you. You took " + damage + ".");
                        Console.WriteLine("Press a key to continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You swiftly escape.");
                        Console.WriteLine("Press a key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if (Program.currentplayer.CurrHealth <= 0)
                {
                    //Death
                    Console.WriteLine("You have taken fatal damage from the " + n + ". You have died.");
                    Console.WriteLine("Press a key to exit.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                } 


            }

           
           
           


        }

       public static string GetName()
        {
            switch (rand.Next(0,8))
            {
                case 0: return "Skeleton";
                case 1: return "Zombie";
                case 2: return "Goblin";
                case 3: return "Kobold";
                case 4: return "Spider";
                case 5: return "Green Slime";
                case 6: return "Mushroom Monster";
                case 7: return "Giant Bat";
            }
            return "Human Scout";
        }




    }
}
