/*
Temple University
Component Based Software Design
Names:Ryan,Jacob,Victor
Class: Hints 
Purpose: 
The purpose of this class is to give users hints about their guess if their guess is incorrect.
There are getters and setters in this class.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASTERMIND
{
    class Hints
    {
        public int White;
        public int Black;

        public int returnWhite()
        {
            return White;

        }
        public int returnBlack()
        {
            return Black;

        }
        public int setW()
        {
            return White;

        }
        public void SetB(int num)
        {
            Black = num;
            

        }
        public void SetW(int num)
        {
            White = num;


        }
    }
}
