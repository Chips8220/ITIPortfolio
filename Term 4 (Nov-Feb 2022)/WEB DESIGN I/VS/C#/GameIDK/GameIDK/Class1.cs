using System;
using System.Collections.Generic;
using System.Text;

namespace GameIDK
{
    class GameIDK
    {
        //attributes - fields ----> components
        private int goal;
        private int curTurn, totalTurns;
        private static int totalWins, totalGames;

        //cuntructor method
        public GameIDK(int tTurns)
        {
            //set up goal number
            goal = genNum(0,20);
            curTurn = 0;
            totalTurns = tTurns;
            totalGames++;
        }
        public  int genNum(int low, int high)
        {
            Random rando = new Random();
            
            
            return rando.Next(low, high + 1);
        }

        //check if in range
        public bool checkCorrect(int toCheck)
        {
            if(toCheck >= 0 && toCheck <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check if winner
        public bool checkWin(int toCheck)
        {
            if (toCheck == goal)
            {
                totalWins++;
                return true;
            }
            else
            {
                return false;
            }
        }





        public void playGame()
        {
            while (curTurn < totalTurns)
            {
                takeTurn();
            }
        }

    }
}
