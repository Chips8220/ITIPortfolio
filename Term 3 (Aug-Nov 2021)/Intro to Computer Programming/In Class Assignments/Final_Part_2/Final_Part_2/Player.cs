using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Part_2
{
    class Player
    {
        private string Name;
        private int MaxHealth, CurHealth, NumPot;
        public Player()
        {

        }


        public Player(string name, int maxhealth, int curhealth, int numpot)
        {
            Name = name;
            MaxHealth = maxhealth;
            CurHealth = curhealth;
            NumPot = numpot;
        }
        
        public bool CheckAlive()
        {
            if (CurHealth <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UsePotion()
        {
            if(NumPot > 0 && (double)CurHealth/MaxHealth <= 0.4)
            {
                Console.WriteLine("You Used a Potion. Your Health is now full.");
                CurHealth = 100;
            }
        }

        public override string ToString()
        {
            return "Your Name is " + Name + " and your current health is " + CurHealth + " out a total of " + MaxHealth + " and you have a total of " + NumPot + " Potions. ";
        }












    }
}
