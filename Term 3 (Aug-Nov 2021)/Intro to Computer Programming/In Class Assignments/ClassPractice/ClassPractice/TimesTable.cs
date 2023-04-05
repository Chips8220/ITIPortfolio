using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class TimesTable
    {
        //attributes
        private int row;
        private int column;

        //properties
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        
        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        //Constructors
        public TimesTable(int r,int c)
        {
            row = r;
            column = c;
        }

        // Print Table Method
        public void PrintTable()
        {
            for (int c = 1; c <= column; c++)
            {
                for (int r = 1; r <= row; r++)
                {
                    int product = c * r;
                    Console.Write("{0,4:f0}", product);
                    
                }
                Console.Write("\n");
            }
        }

        public override bool Equals(object obj)
        {
            //TimesTable toComp = obj as TimesTable;
            TimesTable toComp = obj as TimesTable;

            if (row==toComp.row && column== toComp.column )
            {
                return true;
            }
            else if(row==toComp.column && column==toComp.row)
            {
                return true;
            }else
            {
                return false;
            }

        }

    }

}
