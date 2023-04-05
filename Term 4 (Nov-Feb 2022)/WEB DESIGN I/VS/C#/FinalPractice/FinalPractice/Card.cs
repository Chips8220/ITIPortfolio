using System;
using System.Collections.Generic;
using System.Text;

namespace FinalPractice
{
    class Card
    {
        int Face;
        string Suite;
        string Color;

        public Card()
        {

        }
        public Card(int face, string suite)
        {
            Face = face;
            Suite = suite;
            if (suite == "Club" || "Spade" == suite)
            {
                Color = "Black";
            }
            else
            {
                Color = "Red";
            }
        }
        public bool Beats(Card c)
        {
            if(Face > c.Face)
            {
                return true;
            }

            else
            {
                return false;
            }
        }





    }
}
