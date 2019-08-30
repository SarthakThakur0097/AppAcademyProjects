using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            Console.WriteLine("Welcome to the Number Guess app!");
            Console.WriteLine("Press 1 to continue or 0 to quit");
            int toContinue = Convert.ToInt32(Console.ReadLine());
            if (toContinue == 1)
            {
                while (keepPlaying)
                {

                    PlayGame();
                    Console.WriteLine("Press 1 to continue or 0 to quit");
                    toContinue = Convert.ToInt32(Console.ReadLine());
                    if(toContinue == 0)
                    {
                        break;
                    }
                }
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerName">Name of player one whos number is to be guessed</param>
        /// 
        /// <returns>The number the player would like to be guesed</returns>
        static int GetNumber(String playerName)
        {
            bool stayInLoop = true;
            const int maxValue = 100;
            const int minValue = 1;
            int numToGuess = 0;
            while (stayInLoop)
            {
                try
                {
                    bool rangeLoop = true;
                    while (rangeLoop)
                    {

                        Console.WriteLine("{0} what is your number? ", playerName);
                        numToGuess = Convert.ToInt32(Console.ReadLine());
                        if(numToGuess>=minValue && numToGuess <= maxValue)
                        {
                            rangeLoop = false;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number between 1 to 100");
                        }
                    }

                    stayInLoop = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                
                
            }
            
            
            

            return numToGuess;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerNumber">Calls number based on how many players are applicable</param>
        /// <returns> The player name</returns>
        static string GetPlayerNames(int playerNumber)
        {

            string userName = "";

            
                Console.WriteLine("Player {0} please enter your name", playerNumber);
                userName = Console.ReadLine();

            return userName;

            }
            
        /// <summary>
        /// PlayGame method where the logic of the game occurs
        /// </summary>
        static void PlayGame()
        {
            string player1Name, player2Name;
           
            string[] playerNames = new string[2];


            for (int numOfPlayers = 1; numOfPlayers <= 2; numOfPlayers++)
            {

                playerNames[numOfPlayers - 1] = GetPlayerNames(numOfPlayers);

            }
            player1Name = playerNames[0];
            player2Name = playerNames[1];

            int numToBeGuessed = GetNumber(player1Name);

            int numOfAttempts = 10;

            while (numOfAttempts > 0)
            {

                try {
                    Console.WriteLine("{0} Guess a number", player2Name);
                    int player2Guess = Convert.ToInt32(Console.ReadLine());

                    if (numToBeGuessed == player2Guess)
                    {
                        Console.WriteLine("Nice {0}, you guessed it!", player2Name);
                        numOfAttempts = 0;
                       


                    }

                    else
                    {
                        numOfAttempts--;
                        if(numToBeGuessed>player2Guess)
                        {
                            Console.WriteLine("Your guess is a little too low, try a bigger number!");
                            Console.WriteLine("You have {0} attempts left", numOfAttempts);
                        }
                        else if(numToBeGuessed<player2Guess)
                        {
                            Console.WriteLine("Your guess is a little too high, try a smaller number!");
                            Console.WriteLine("You have {0} attempts left", numOfAttempts);
                        }
                    }

                    }
               catch(FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

        }

        }
    }

