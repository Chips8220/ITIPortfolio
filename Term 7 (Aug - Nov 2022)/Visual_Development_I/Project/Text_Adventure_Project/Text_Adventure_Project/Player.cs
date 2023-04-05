using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure_Project
{
     public class Player
    {
        
        public string name;
        public int coins = 0, Maxhealth = 100, CurrHealth = 100, damage = 1, potion = 5, CurrMana = 100, MaxMana = 100;
        public int weaponvalue = 1, ArmorValue= 1;

        public int ModD = 0;

        public int GetHealth()
        {
            Random rand = new Random();
            int upper = (2 * ModD + 30);
            int lower = (ModD + 15);
            rand.Next(lower, upper);
            return rand.Next(lower,upper);
        }        
        public int GetPowerLower()
        {
            Random rand = new Random();
            int upper = (2 * ModD + 5);
            int lower = (ModD + 1);
            rand.Next(lower, upper);
            return rand.Next(lower,upper);
        } public int GetPowerUpper()
        {
            Random rand = new Random();
            int upper = (2 * ModD + 10);
            int lower = (ModD + 6);
            rand.Next(lower, upper);
            return rand.Next(lower,upper);
        }

        public void FloorDiff(int d)
        {
            ModD += d;
            
        }
    }   
        


}
