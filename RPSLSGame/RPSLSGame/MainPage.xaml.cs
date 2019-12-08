using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RPSLSGame
{
    public partial class MainPage : ContentPage
    {
        // Variables
        private int playerChoice;
        private int scorePlayer = 0;
        private int scoreComputer = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Method activated by the Rock Button
        private void BtnPlayerChoice_Clicked(object sender, EventArgs e)
        {
            ImageButton b = (ImageButton)sender;

            playerChoice = Convert.ToInt32(b.ClassId);
            ImgPlayerChoice.Source = b.Source;
            ResultLbl.Text = "";
            // Runs the CheckResult method
            CheckResult();
        }

        // Method to check the result
        private void CheckResult()
        {
            // Random int number for computer
            Random randomIntComputer = new Random();
            int computerChoice = randomIntComputer.Next(1, 6);

            // If/else if/else if statement for setting the images based on the picks of the CPU
            if (computerChoice == 1)
            {
                ImgCPUChoice.Source = "rock.png";
            }
            else if (computerChoice == 2)
            {
                ImgCPUChoice.Source = "paper.png";
            }
            else if (computerChoice == 3)
            {
                ImgCPUChoice.Source = "scissors.png";
            }
            else if (computerChoice == 4)
            {
                ImgCPUChoice.Source = "lizard.png";
            }
            else if (computerChoice == 5)
            {
                ImgCPUChoice.Source = "spock.png";
            }

            // If statement for printing out (TIE)
            if (playerChoice == computerChoice)
            {
                ResultLbl.Text = "Tie - no winner";
                return;
            }

            // If/else if/Nested if statements for the player choices
            // PLAYER ROCK
            if (playerChoice == 1)
            {
                // PLAYER ROCK - COMPUTER PAPER (COMPUTER WIN)
                if (computerChoice == 2)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER ROCK - COMPUTER SPOCK (COMPUTER WIN)
                else if (computerChoice == 5)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER ROCK - COMPUTER SCISSORS (PLAYER WIN)
                else if (computerChoice == 3)
                {
                    ResultLbl.Text = "Player wins this round!";

                    // Increments the Player Score variable and converts it to a String
                    // then printing it out in the Player Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER ROCK - COMPUTER LIZARD (PLAYER WIN)
                else if (computerChoice == 4)
                {
                    ResultLbl.Text = "Player wins this round!";

                    // Increments the Player Score variable and converts it to a String
                    // then printing it out in the Player Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
            }
            // PLAYER PAPER
            else if (playerChoice == 2)
            {
                // PLAYER PAPER - COMPUTER ROCK (PLAYER WIN)
                if (computerChoice == 1)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER PAPER - COMPUTER SCISSORS (COMPUTER WIN)
                else if (computerChoice == 3)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Player Score variable and converts it to a String
                    // then printing it out in the Player Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER PAPER - COMPUTER LIZARD (COMPUTER WIN)
                else if (computerChoice == 4)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Player Score variable and converts it to a String
                    // then printing it out in the Player Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER PAPER - COMPUTER SPOCK (PLAYER WIN)
                else if (computerChoice == 5)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
            }
            // PLAYER SCISSORS
            else if (playerChoice == 3)
            {
                // PLAYER SCISSORS - COMPUTER ROCK (COMPUTER WIN)
                if (computerChoice == 1)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER SCISSORS - COMPUTER PAPER (PLAYER WIN)
                else if (computerChoice == 2)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER SCISSORS - COMPUTER LIZARD (PLAYER WIN)
                else if (computerChoice == 4)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER SCISSORS - COMPUTER SPOCK (COMPUTER WIN)
                else if (computerChoice == 5)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
            }
            // PLAYER LIZARD
            else if (playerChoice == 4)
            {
                // PLAYER LIZARD - COMPUTER ROCK (PLAYER WIN)
                if (computerChoice == 1)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER LIZARD - COMPUTER PAPER (PLAYER WIN)
                else if (computerChoice == 2)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER LIZARD - COMPUTER SCISSORS (COMPUTER WIN)
                else if (computerChoice == 3)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER LIZARD - COMPUTER SPOCK (PLAYER WIN)
                else if (computerChoice == 5)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
            }
            // PLAYER SPOCK
            else if (playerChoice == 5)
            {
                // PLAYER SPOCK - COMPUTER ROCK (PLAYER WIN)
                if (computerChoice == 1)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER SPOCK - COMPUTER PAPER (COMPUTER WIN)
                else if (computerChoice == 2)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
                // PLAYER SPOCK - COMPUTER SCISSORS (PLAYER WIN)
                else if (computerChoice == 3)
                {
                    ResultLbl.Text = "Player wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scorePlayer++;
                    ScorePlayerLbl.Text = scorePlayer.ToString();
                }
                // PLAYER SPOCK - COMPUTER LIZARD (COMPUTER WIN)
                else if (computerChoice == 4)
                {
                    ResultLbl.Text = "Computer wins this round!";
                    // Increments the Computer Score variable and converts it to a String
                    // then printing it out in the Computer Score Label
                    scoreComputer++;
                    ScoreComputerLbl.Text = scoreComputer.ToString();
                }
            }
        }

        // Method for restarting the game after the restart button is clicked
        private void BtnRestart_Clicked(object sender, EventArgs e)
        {
            // Sets the Computer Score to zero, converts it to a string and
            // sets the Computer Score label to the Computer Score variable string
            scoreComputer = 0;
            string ScoreComputer = scoreComputer.ToString();
            ScoreComputerLbl.Text = ScoreComputer;

            // Sets the Player Score to zero, converts it to a string and
            // sets the Player Score label to the Player Score variable string
            scorePlayer = 0;
            string ScorePlayer = scorePlayer.ToString();
            ScorePlayerLbl.Text = ScorePlayer;

            // Sets the result label to nothing
            ResultLbl.Text = "";
            ImgCPUChoice.Source = null;
            ImgPlayerChoice.Source = null;
            // Displays an alert to notify the player that the game has restarted
            DisplayAlert("New Game", "Your game has restarted.", "Continue");
        }
    }
}
