/*
Temple University
Component Based Software Design
Names:Ryan,Jacob,Victor
Class: Game Solution 
Purpose: 
This class purpose is to take care of the solution aspects of the game.
In this class we also have a random generate solution method that will randomly generate a solution for the player to guess. 
In this class we have a ismatch method that stores the solution string.
The isMatch method takes four respective characters and each character represents a slot on the board that the user has inputted.
We used nested if else statements to check if each slot is a match.
RR and RW have +1 added to them each time there is a color match . 
This method will return a boolean value depending on whether RR had reached the value of 4.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASTERMIND
{
    class GameSolutionClass 
    {
        //Right color Right Column
        int RR = 0;
        //Right color Wrong Column
        int RW = 0;
        //solution string , holds to secret code generated using the random object
        private string solution = "";
        char[] colorPallette = new char[] { 'R', 'B', 'G', 'Y', 'C', 'O', 'P', 'E' };
        //Random object used to generate solution
        Random rand = new Random();
        //Default constructor calls the solution
        public GameSolutionClass()
        {
            for(int i = 0; i<=3; i++)
            {
               solution += colorPallette[rand.Next(0, 8)];
            }
           
        }

        /* showSolution
           This method returns the solution
        */
        public string showSolution()
        {
            
            MessageBox.Show( " The Solution was: \r\n " + solution );
            return solution;
        }

        //getters
        public int getRR()
        {
            return RR;
        }
        //Getters
        public int getRW()
        {
            return RW;
        }


      /*
       isMatch is  a boolean method
       sets the two integers RR, and RW to 0
       RR stands for the Black hint
       RW stands for the White hint
       it uses the char array and flag array inside of its for loop
       The for loops has another for loop nested inside of it,
       it goes through the user's guess and determinds what colors match
       using the .Equals method.  If it does match RR++ or RW++ is added respectively.
       After the loops occur, there are if statements that check to see if there are 4
       black hints, if there are 4 black hints, it means the user guess presents a
       full match.
     */

        public bool isMatch(char c1, char c2, char c3, char c4)
        {
        RR = 0;
        RW = 0;
            char[] guess = new char[] { c1, c2, c3, c4 };
        int[] flag = new int[4];
            
            for (int slot = 0; slot < 4; slot++)
            {
                if(guess[slot].Equals(solution[slot])){
                    RR++;
                    flag[slot] = 1;   
                }
                else
                {
                    for(int s = 0; s < 4; s++)
                    {
                        if(s != slot && guess[slot].Equals(solution[s]) && flag[s] == 0)
                        {
                            RW++;
                            flag[s] = 1;
                            break;
                        }
                    }
                }
            }
            
            if (RR == 4)
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
