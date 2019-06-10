/*
Temple University
Component Based Software Design
Names:Ryan,Jacob,Victor
Class: Form 
Purpose: This is the form is connect all classes together and make the game run. We have two methods
in this form. SetPins,WinMsg. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MASTERMIND
{
    public partial class frmMASTERMIND : Form

    {

        public frmMASTERMIND()
        {
            InitializeComponent();
            
            
        }
        Leaderboard L = new Leaderboard();
        GameSolutionClass Game = new GameSolutionClass();
        Hints Hint = new Hints();
        char Marble1; int M1Count = -1;
        char Marble2; int M2Count = -1;
        char Marble3; int M3Count = -1;
        char Marble4; int M4Count = -1;
        int currentButton = 0;
        int currentPin = 0;
        string PlayerName = "";
        string Mode = "";
        int Black = 0;
        int White = 0;
        public int guessNumber = 1;
        Color[] clrArray = new Color[] {Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Cyan, Color.Orange ,Color.Fuchsia, Color.Black };
        char[] clrChar = new char[] {'R', 'B', 'G', 'Y', 'C', 'O', 'P', 'E' };
        Boolean Winner = false;

        //Displaying a messagebox that says you win the game if four black pegs are shown
        //close form
        //stoptime and adding user to leaderboard
        public void winMsg()
        {
            MessageBox.Show("YOU WIN!!! \r\n You guessed the correct marbles \r\n ");
            L.rwind();
            L.stopTime();
            L.addScore(PlayerName, guessNumber);
            L.writeTop10();
            L.closeF();
            
            
            this.Close();
        }

        //Setting the black and what pins 
        public void setPins()
        {
            Winner = Game.isMatch(clrChar[M1Count], clrChar[M2Count], clrChar[M3Count], clrChar[M4Count]);
            Hint.SetB(Game.getRR());
            Hint.SetW(Game.getRW());
            Black = Hint.returnBlack();
            White = Hint.returnWhite();
            for (int b = 0; b < Black; b++)
            {
                this.Controls["pin" + currentPin.ToString()].Visible = true;
                this.Controls["pin" + currentPin.ToString()].BackColor = Color.Black;
                currentPin++;
            }
            for (int w = 0; w < White; w++)
            {
                this.Controls["pin" + currentPin.ToString()].Visible = true;
                this.Controls["pin" + currentPin.ToString()].BackColor = Color.White;
                currentPin++;
            }
        }
        // Guess button click event handler. Checking if the user input matches to the solution that the computer generated
        private void btnGuess_Click(object sender, EventArgs e)
        {
            switch (guessNumber)
            {
                case 1:
                    try
                    {
                        setPins();
                        currentPin = 4;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn0"].Enabled = false;
                    this.Controls["btn1"].Enabled = false;
                    this.Controls["btn2"].Enabled = false;
                    this.Controls["btn3"].Enabled = false;

                    this.Controls["btn4"].Visible = true;
                    this.Controls["btn5"].Visible = true;
                    this.Controls["btn6"].Visible = true;
                    this.Controls["btn7"].Visible = true;

                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 2:
                    try
                    {
                        setPins();
                        currentPin = 8;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    this.Controls["btn4"].Enabled = false;
                    this.Controls["btn5"].Enabled = false;
                    this.Controls["btn6"].Enabled = false;
                    this.Controls["btn7"].Enabled = false;

                    this.Controls["btn8"].Visible = true;
                    this.Controls["btn9"].Visible = true;
                    this.Controls["btn10"].Visible = true;
                    this.Controls["btn11"].Visible = true;
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 3:
                    try
                    {
                        setPins();
                        currentPin = 12;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    this.Controls["btn8"].Enabled = false;
                    this.Controls["btn9"].Enabled = false;
                    this.Controls["btn10"].Enabled = false;
                    this.Controls["btn11"].Enabled = false;

                    this.Controls["btn12"].Visible = true;
                    this.Controls["btn13"].Visible = true;
                    this.Controls["btn14"].Visible = true;
                    this.Controls["btn15"].Visible = true;
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                 
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 4:
                    try
                    {
                        setPins();
                        currentPin = 16;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    
                    this.Controls["btn12"].Enabled = false;
                    this.Controls["btn13"].Enabled = false;
                    this.Controls["btn14"].Enabled = false;
                    this.Controls["btn15"].Enabled = false;

                    this.Controls["btn16"].Visible = true;
                    this.Controls["btn17"].Visible = true;
                    this.Controls["btn18"].Visible = true;
                    this.Controls["btn19"].Visible = true;
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 5:
                    try
                    {
                        setPins();
                        currentPin = 20;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn16"].Enabled = false;
                    this.Controls["btn17"].Enabled = false;
                    this.Controls["btn18"].Enabled = false;
                    this.Controls["btn19"].Enabled = false;

                    this.Controls["btn20"].Visible = true;
                    this.Controls["btn21"].Visible = true;
                    this.Controls["btn22"].Visible = true;
                    this.Controls["btn23"].Visible = true;
                  
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 6:
                    try
                    {
                        setPins();
                        currentPin = 24;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn20"].Enabled = false;
                    this.Controls["btn21"].Enabled = false;
                    this.Controls["btn22"].Enabled = false;
                    this.Controls["btn23"].Enabled = false;

                    this.Controls["btn24"].Visible = true;
                    this.Controls["btn25"].Visible = true;
                    this.Controls["btn26"].Visible = true;
                    this.Controls["btn27"].Visible = true;
                    
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 7:
                    try
                    {
                        setPins();
                        currentPin = 28;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn24"].Enabled = false;
                    this.Controls["btn25"].Enabled = false;
                    this.Controls["btn26"].Enabled = false;
                    this.Controls["btn27"].Enabled = false;

                    this.Controls["btn28"].Visible = true;
                    this.Controls["btn29"].Visible = true;
                    this.Controls["btn30"].Visible = true;
                    this.Controls["btn31"].Visible = true;
                  
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 8:
                    try
                    {
                        setPins();
                        currentPin = 32;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn28"].Enabled = false;
                    this.Controls["btn29"].Enabled = false;
                    this.Controls["btn30"].Enabled = false;
                    this.Controls["btn31"].Enabled = false;
                    if(Winner)
                    {
                        winMsg();
                    }
                    if (Mode.Equals("Hard"))
                    {
                        MessageBox.Show("You ran out of guesses...\r\n Please play again and \r\nthink about choosing an easier game Mode!");
                        Game.showSolution();
                        this.Close();
                    }
                    else if(Mode.Equals("Medium") || Mode.Equals("Easy"))
                    {
                        this.Controls["btn32"].Visible = true;
                        this.Controls["btn33"].Visible = true;
                        this.Controls["btn34"].Visible = true;
                        this.Controls["btn35"].Visible = true;

                        M1Count = -1;
                        M2Count = -1;
                        M3Count = -1;
                        M4Count = -1;
                        guessNumber++;
                    }
                    
                    break;
                case 9:
                    try
                    {
                        setPins();
                        currentPin = 36;
                        
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn32"].Enabled = false;
                    this.Controls["btn33"].Enabled = false;
                    this.Controls["btn34"].Enabled = false;
                    this.Controls["btn35"].Enabled = false;

                    this.Controls["btn36"].Visible = true;
                    this.Controls["btn37"].Visible = true;
                    this.Controls["btn38"].Visible = true;
                    this.Controls["btn39"].Visible = true;
                 
                    M1Count = -1;
                    M2Count = -1;
                    M3Count = -1;
                    M4Count = -1;
                    
                    if (Winner)
                    {
                        winMsg();
                    }
                    guessNumber++;
                    break;
                case 10:
                    try
                    {
                        setPins();
                        currentPin = 40;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid Guess!");
                        guessNumber++;
                        return;
                    }
                    //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                    this.Controls["btn36"].Enabled = false;
                    this.Controls["btn37"].Enabled = false;
                    this.Controls["btn38"].Enabled = false;
                    this.Controls["btn39"].Enabled = false;
                    if (Winner)
                    {
                        winMsg();
                    }
                    if (Mode.Equals("Medium"))
                    {
                        MessageBox.Show("You ran out of guesses...\r\n Please play again and \r\nthink about choosing an easier game Mode!");
                        Game.showSolution();
                        this.Close();
                    }
                    else if(Mode.Equals("Easy") && Winner!= true)
                    {
                        try
                        {
                            this.Controls["btn40"].Visible = true;
                            this.Controls["btn41"].Visible = true;
                            this.Controls["btn42"].Visible = true;
                            this.Controls["btn43"].Visible = true;
                            M1Count = -1;
                            M2Count = -1;
                            M3Count = -1;
                            M4Count = -1;
                            guessNumber++;
                        }
                        catch
                        {
                            this.Close();
                        }
                        
                    }
                    
                    break;
                case 11:
                    if (Mode.Equals("Easy"))
                    {
                        try
                        {
                            setPins();
                            currentPin = 44;
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a valid Guess!");
                            guessNumber++;
                            return;
                        }
                        //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                        this.Controls["btn40"].Enabled = false;
                        this.Controls["btn41"].Enabled = false;
                        this.Controls["btn42"].Enabled = false;
                        this.Controls["btn43"].Enabled = false;
                        if (Winner)
                        {
                            winMsg();
                        }
                        if(Mode == "Easy" && Winner != true)
                        {
                            this.Controls["btn44"].Visible = true;
                            this.Controls["btn45"].Visible = true;
                            this.Controls["btn46"].Visible = true;
                            this.Controls["btn47"].Visible = true;
                            M1Count = -1;
                            M2Count = -1;
                            M3Count = -1;
                            M4Count = -1;
                            guessNumber++;
                        }
                        
                    }
                    break;
                case 12:
                    if (Mode.Equals("Easy"))
                    {
                        try
                        {
                            setPins();
                            currentPin = 48;
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a valid Guess!");
                            guessNumber++;
                            return;
                        }
                        //MessageBox.Show(Convert.ToString(clrChar[M1Count]) + clrChar[M2Count] + clrChar[M3Count] + clrChar[M4Count]);
                        this.Controls["btn44"].Enabled = false;
                        this.Controls["btn45"].Enabled = false;
                        this.Controls["btn46"].Enabled = false;
                        this.Controls["btn47"].Enabled = false;
                        if (Winner)
                        {
                            winMsg();
                        }

                        MessageBox.Show("You ran out of guesses...\r\n Please play again and \r\nthink about choosing an easier game Mode!");
                        Game.showSolution();
                        this.Close();

                    }
                    break;

            }
        }

        //button event handler for the four button 
        private void btnEVENT_Click(object sender, EventArgs e)
        {
            Round_Button button = sender as Round_Button;
            if (button != null)
            {
                // now you know the button that was clicked
                switch ((int)button.Tag)
                {
                    case 0:
                        // First Button Clicked
                        M1Count++;
                        if (M1Count == 8)
                        {
                            M1Count = 0;
                        }
                        button.BackColor = clrArray[M1Count];
                        Marble1 = clrChar[M1Count];
                        break;
                    case 1:
                        // Second Button Clicked
                        M2Count++;
                        if (M2Count == 8)
                        {
                            M2Count = 0;
                        }
                        button.BackColor = clrArray[M2Count];
                        Marble2 = clrChar[M2Count];
                        break;
                    case 2:
                        //third button clicked
                        M3Count++;
                        if (M3Count == 8)
                        {
                            M3Count = 0;
                        }
                        button.BackColor = clrArray[M3Count];
                        Marble3 = clrChar[M3Count];
                        break;
                    case 3:
                        //fourth button clicked
                        M4Count++;
                        if (M4Count == 8)
                        {
                            M4Count = 0;
                        }
                        button.BackColor = clrArray[M4Count];
                        Marble4 = clrChar[M4Count];
                        break;

                }
            }

        }

        // dynamically creating a  level board design when user hits easy button
        private void btnEasy_Click(object sender, EventArgs e)
        {
            
            L.startTimer();
            Mode = "Easy";
            currentButton = 0;
            currentPin = 0;
            for (int r = 0; r < 12; r++)
            {
                //Create One Row of Round color Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(15 + (80 * i), 40 +(52 * r));
                    button.Size = new Size(50, 50);
                    //sets buttons borderless appearance
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.DarkGray;
                    //sets the event of color buttons to the color event handler!
                    button.Click += new EventHandler(btnEVENT_Click);
                    //give button a tag switching which event handler path it takes depends on which column
                    button.Tag = i;
                    if (r != 0)
                    {
                        button.Visible = false;
                    }
                    button.Name = "btn" + Convert.ToString(currentButton);
                    currentButton++;
                    this.Controls.Add(button);
                }
                //Create 4 Pin Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(325 + (30 * i),40+(52* r));
                    button.Size = new Size(20, 20);
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Enabled = false;
                    button.Visible = false;
                    
                    button.Name = "pin" + Convert.ToString(currentPin);
                    currentPin++;
                    this.Controls.Add(button);
                }
            }
            currentPin = 0;
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
        }
        // dynamically creating a medium level board design when user hits medium button
        private void btnMedium_Click(object sender, EventArgs e)
        {
            L.startTimer();
            Mode = "Medium";
            currentButton = 0;
            currentPin = 0;
            for (int r = 0; r < 10; r++)
            {
                //Create One Row of Round color Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(15 + (80 * i), 5 + (65 * r));
                    button.Size = new Size(50, 50);
                    //sets buttons borderless appearance
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.DarkGray;
                    //sets the event of color buttons to the color event handler!
                    button.Click += new EventHandler(btnEVENT_Click);
                    //give button a tag switching which event handler path it takes depends on which column
                    button.Tag = i;
                    if (r != 0)
                    {
                        button.Visible = false;
                    }
                    button.Name = "btn" + Convert.ToString(currentButton);
                    currentButton++;
                    this.Controls.Add(button);
                }
                //Create 4 Pin Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(325 + (30 * i), 10 + (70 * r));
                    button.Size = new Size(20, 20);
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Enabled = false;
                    button.Visible = false;

                    button.Name = "pin" + Convert.ToString(currentPin);
                    currentPin++;
                    this.Controls.Add(button);
                }
            }
            currentPin = 0;
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
        }
        // dynamically creating a hard level board design when user hits hard button
        private void btnHard_Click(object sender, EventArgs e)
        {
            L.startTimer();
            Mode = "Hard";
            currentButton = 0;
            currentPin = 0;
            for (int r = 0; r < 8; r++)
            {
                //Create One Row of Round color Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(15 + (80 * i), 5 + (65 * r));
                    button.Size = new Size(50, 50);
                    //sets buttons borderless appearance
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.DarkGray;
                    //sets the event of color buttons to the color event handler!
                    button.Click += new EventHandler(btnEVENT_Click);
                    //give button a tag switching which event handler path it takes depends on which column
                    button.Tag = i;
                    if (r != 0)
                    {
                        button.Visible = false;
                    }
                    button.Name = "btn" + Convert.ToString(currentButton);
                    currentButton++;
                    this.Controls.Add(button);
                }
                //Create 4 Pin Buttons
                for (int i = 0; i < 4; i++)
                {
                    Round_Button button = new Round_Button();
                    button.Location = new Point(325 + (30 * i), 10 + (70 * r));
                    button.Size = new Size(20, 20);
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Enabled = false;
                    button.Visible = false;

                    button.Name = "pin" + Convert.ToString(currentPin);
                    currentPin++;
                    this.Controls.Add(button);
                }
            }
            currentPin = 0;
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
        }


        private void frmMASTERMIND_Load(object sender, EventArgs e)
        {
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            btnHard.Enabled = false;
            btnGuess.Enabled = false;
            L.initializeTOP10List();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMASTERMIND_Deactivate(object sender, EventArgs e)
        {
            
            
        }
        // checking if name is empty or not and making other buttons enabled. 
        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if(String.IsNullOrWhiteSpace(name)){

                MessageBox.Show("Enter a name!");
                return;
            }
            btnOK.Enabled = false;
            btnEasy.Enabled = true;
            btnMedium.Enabled = true;
            btnHard.Enabled = true;
            btnGuess.Enabled = true;
            PlayerName =(txtName.Text);
        }
        //Closes the form 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Resets the form
        private void btnReset_Click(object sender, EventArgs e)
        {
            Form newForm = new frmMASTERMIND();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        //Display the rules 
        private void btnDisplayRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to master mind!\n Here is how you play:\n Players will choose what level they want to play\nEasy has 12 guess, Medium has 10 guess, and hard has 8 guess\n Players will make four color guess against the computer solution and hit the guess button\n If you get a black peg that means you got the right color in the right spot.\nIf you get a white peg that means you got a color right but in the wrong spot.\n  Players will play until they get the right solution or run out of guesses");
        }

        //Closes the form 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
