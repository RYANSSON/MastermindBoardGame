/*
Temple University
Component Based Software Design
Names:Ryan,Jacob,Victor
Class:Leaderboard 
Purpose:
The purpose of this class is to keep track of the top players. We have several methods in this class. 
Public void AddSScore, String createPlayerEntry, stopTime,startTime ,intializeTOP10List, writeTop10,
closeF,rwind 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
namespace MASTERMIND
{
    class Leaderboard
    {
        Stopwatch clock = new Stopwatch();
        
        
        System.TimeSpan playerTime;
        List<player> Top10 = new List<player>(10);

       //public static FileWriterClass LeaderboardFileWriter = new
        // FileWriterClass(@"LeaderboardU.txt");
       //public static  FileReaderClass LeaderboardFileReader = new
       // FileReaderClass(@"LeaderboardC.txt");

        public Leaderboard( )
        {
            
        }
        public void initializeTOP10List()
        {

            using (StreamReader sr = new StreamReader(@"LeaderboardU.txt"))
            {
                
                string nextRecord = "";
                int count = 0; 
                string success;
                
                nextRecord = sr.ReadLine(); 
                while (nextRecord != null)
                {
                    
                    player playa = new player();
                    success = playa.createPlayerString(nextRecord);

                    if (success == "")
                    {
                        MessageBox.Show("Unable to create an Employee Object.  Employee list not created.",
                            "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if(count < 10)
                    {
                        Top10.Add(playa);
                    }
                    
                    count++;
                    nextRecord = sr.ReadLine();
                } //end While


                return;
            }

             
        }
        

        // Starting the clock
        public void startTimer()
        {
            
            clock.Start();
            
     
        }
        // Stoping the clock
        public void stopTime()
        {
            clock.Stop();
            playerTime = clock.Elapsed;
        }
        /*
          AddScore
          The purpose of this method is to add a new high score to the leaderboard
          
         */
        public void addScore(string name, int tries)
        {
            int i;
            player newp = new player(name, tries, playerTime);// getting attributes in the playerclass 
            for( i = 0; i < Top10.Count; i++)
            {
                if(playerTime < Top10.ElementAt(i).getTime())
                {
                    Top10.Insert(i, newp);
                    if (Top10.Count == 11)
                    {
                        Top10.RemoveAt(10);
                    }
                    return;
                }
            }
            
            if (i <= 10)
            {
                Top10.Add(newp);
            }
            if (Top10.Count == 11)
            {
                Top10.RemoveAt(10);
            }
        }

        // This method returns the top ten players 
        public void writeTop10()
        {
            using (StreamWriter sr = new StreamWriter(@"LeaderboardU.txt"))
            {
                foreach (player p in Top10)
                {

                    sr.WriteLine(p.createPlayerString());

                    MessageBox.Show(p.createPlayerString());

                }
            }
            
        }
        
        public void closeF()
        {
          //  LeaderboardFileReader.closeFile();
          //  LeaderboardFileWriter.closeFile();
           

        }
        public void rwind()
        {
           // LeaderboardFileReader.rewindFile();
            
        }
    }
}
