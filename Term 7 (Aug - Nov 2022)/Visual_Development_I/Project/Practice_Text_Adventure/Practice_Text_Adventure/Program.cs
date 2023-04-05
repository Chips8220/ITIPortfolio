using System;

namespace Practice_Text_Adventure
{
    class Program
    {
        public static Player currentplayer = new Player();
        public static bool mainLoop = true;
        static void Main(string[] args)
        {
            //Enter Name to start
            Start();
            //First Encounter
            Encounter.FirstEncounter();
            while (mainLoop)
            {
                for (int a = 0; a <= 3; a++)
                {
                    for (int b = 0; b <= 10; b++)
                    {
                        Encounter.RandomEncounter();
                    }
                    Program.currentplayer.ModD += 5;
                }
                // shop encounter
            }
        }


        static void Start()
        {
            //Introduction and Players Name
            Console.WriteLine("Welcome to Bipple's Dungeon!");
            Console.WriteLine("What is your name?");
            currentplayer.name = Console.ReadLine();
            while (currentplayer.name == "")
            {
                Console.WriteLine("Please Enter your name.");
                currentplayer.name = Console.ReadLine();
            }
            Console.WriteLine("Your name is " + currentplayer.name + ". Is this correct? Y/N");
            //Name approval
            string nameapp = Console.ReadLine();
            if (nameapp == "Y")
            {
                Console.WriteLine("Your name is " + currentplayer.name + ".");
                Console.WriteLine("Please press a key to continue.");
               
            }
            else if(nameapp != "Y" || nameapp != "N")
            {
                    Console.WriteLine("Your name is " + currentplayer.name + ". Is this correct? Y/N\n");
                    nameapp = Console.ReadLine();
                
            }
            while (nameapp == "N")
            {
                Console.WriteLine("What is your name?");
                currentplayer.name = Console.ReadLine();
                Console.WriteLine("Your name is " + currentplayer.name + ". Is this correct? Y/N");
                nameapp = Console.ReadLine();
                if (nameapp == "Y")
                {
                    Console.WriteLine("Your name is " + currentplayer.name + ".");
                    Console.WriteLine("Please press a key to continue.");
                }
            }
            
            Console.ReadKey();
            Console.Clear();
            //Starting Prompt 
            Console.WriteLine("*insert beginning prompt here*\n\n");
            
        }

        

    }
}
