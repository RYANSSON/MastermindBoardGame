/*
Temple University
Component Based Software Design
Names:Ryan,Jacob,Victor
Class: player 
Purpose: 
The purpose of this class is too hold attributes of the players. We have two methods, createplayerstring,
get time and several getters and setters.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASTERMIND
{
    class player
    {
        string Name;
        public System.TimeSpan Time;
        int numTry;
        public player()
        {
            Name = "";
            numTry = 0;
        }
        public player(string Name, System.TimeSpan time)
        {

        }
        public player(string Name, int numTry, System.TimeSpan time)
        {
            this.Name = Name;
            this.numTry = numTry;
            this.Time = time;
        }
        public string createPlayerString(string line)
        {
            string[] playerSplit = line.Split('*');
            playerSplit[0].Trim();
            playerSplit[1].Trim();
            playerSplit[2].Trim();
            Name = playerSplit[0];
            numTry = Convert.ToInt32(playerSplit[1]);
            Time = TimeSpan.Parse(playerSplit[2]);


            return (Name+" * "+ numTry+ " * " + Time);
        }

        //returning name.
        public string createPlayerString()
        {
            Name.Trim();
            return (Name.ToString() + " * " + numTry.ToString() + " * " + Time.ToString());
        }

        //getters
        public string getName()
        {
            return (Name);
        }

        //setter
        public void setName(string na)
        {
            Name = na;
        }
        //getter
        public TimeSpan getTime()
        {
            return Time;
        }

    }
}
