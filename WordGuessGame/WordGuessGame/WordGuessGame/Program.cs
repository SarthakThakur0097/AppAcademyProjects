using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = GetPhrases();
            Console.WriteLine("Welcome to the guess a word app!");
            Console.WriteLine("Press 1 to play or 0 To Quit");
            int contOrQuit = int.Parse(Console.ReadLine());
            bool startGame = true;
            while (startGame)
            {
                if (contOrQuit == 0)
                {
                    startGame = false;
                }
                PlayGame(phrases);
                Console.WriteLine("Press 1 to play or 0 To Quit");
                contOrQuit = int.Parse(Console.ReadLine());
            }

            /*Java Implemention
             * List <String> phrases = new ArrayList()
             */



        }
        /// <summary>
        /// Passes in a string phrase variable which is then converted to an all uppercase string
        /// The phrase is then traversed through while each char value in it is added into a char array phraseLetters
        /// </summary>
        /// <param name="phrase">selected phrase that needs to be converted into a char array</param>
        /// <returns>char array of the string that was passed in</returns>
        static char[] GetPhraseCharacters(string phrase)
        {

            char[] phraseLetters = phrase.ToUpper().ToCharArray();
            return phraseLetters;
        }
        /// <summary>
        /// char array is passed in
        /// char array is traversed through and spaces are removed
        /// the result is then added to a List collection which is then returned
        /// </summary>
        /// <param name="phraseCharacters">char array of phrase that was selected</param>
        /// <returns></returns>
        static List<char> GetPhraseDistinctCharacters(char[] phraseCharacters)
        {
            List<char> distinctPhraseCharacters = new List<char>();
            for (int i = 0; i < phraseCharacters.Length; i++)
            {

                if (distinctPhraseCharacters.Count == 0)
                {
                    distinctPhraseCharacters.Add(phraseCharacters[i]);
                }

                else if (distinctPhraseCharacters.Count > 0)
                {
                    if (distinctPhraseCharacters.Contains(phraseCharacters[i]))
                    {
                        continue;
                    }
                    else
                    {
                        distinctPhraseCharacters.Add(phraseCharacters[i]);
                    }
                }
            }
            return distinctPhraseCharacters;
        }
        /// <summary>
        /// Randomly selects a phrase from the list of strings
        /// returns a random string
        /// </summary>
        /// <param name="selections">A list of phrases that contain string variables</param>
        /// <returns>A random string variable</returns>
        static string SelectPhrase(List<string> selections)
        {
            var random = new Random();
            var randomInteger = random.Next(0, (selections.Capacity - 1));
            string phrase = selections.ElementAt(randomInteger);

            return phrase;
        }

        /// <summary>
        /// 1) A list of phrases is passed in 
        /// 2) A random phrase is chosen from the List
        /// 3) Removes spaces from the chosen phrase using the GetPhraseDistinctCharacters Method
        /// 4)
        /// </summary>
        /// <param name="phrasesToChoseFrom"></param>
        static void PlayGame(List<string> phrasesToChoseFrom)
        {


            string phrase = SelectPhrase(phrasesToChoseFrom);
            char[] phraseCharacters = GetPhraseCharacters(phrase);
            List<char> phraseDistinctCharacters = GetPhraseDistinctCharacters(phraseCharacters);

            List<char> phraseGuessedCharacters = new List<char>();
            const int maxGuess = 3;
            int incorrectGuesses = 0;

            List<char> alreadyEntered = new List<char>();
            List<char> incorrectChars = new List<char>();


            bool playGame = true;
            while (playGame)
            {

                

                DisplayPhrase(phraseCharacters, phraseGuessedCharacters);


                if ((phraseDistinctCharacters.Count() - 1) == alreadyEntered.Count())
                {
                    Console.WriteLine("\nYou got all the characters!");
                    playGame = false;
                    break;
                }
                char currGuess = GetCharacterGuess(phraseGuessedCharacters);


                    if (phraseDistinctCharacters.Contains(currGuess))
                    {

                        
                        if (alreadyEntered.Contains(currGuess))
                        {
                            Console.WriteLine("\nYou've already entered {0}! Try something else.", currGuess);

                            continue;

                        }

                        else
                        {

                            Console.WriteLine("\nNice! You found {0}", currGuess);


                            //phraseGuessedCharacters.Add(currGuess);
                            alreadyEntered.Add(currGuess);
                        }
                    }

                    else
                    {
                        incorrectGuesses++;

                        if (incorrectGuesses == maxGuess)
                        {
                            Console.WriteLine("All out of attempts");
                        playGame = false;
                        }
                        if (incorrectChars.Contains(currGuess))
                        {
                            Console.WriteLine("You've tried {0} already, try something else!", currGuess);
                            continue;
                        }
                        else if (!(incorrectChars.Contains(currGuess)))
                        {
                            Console.WriteLine("\nSorry, {0} isn't one of them, try again!"
                                + "\nYou have {1} attempts left ", currGuess, maxGuess - incorrectGuesses);
                            incorrectChars.Add(currGuess);
                        }
                        else
                        {
                            Console.WriteLine("Got it!");
                        }

                    }





                
                    
                


            }
           

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phraseCharacters"></param>
        /// <param name="phraseGuessedCharacters"></param>
        static void DisplayPhrase(char[] phraseCharacters, List<char> phraseGuessedCharacters)
        {

            foreach (char currChar in phraseCharacters)
            {
                if (phraseGuessedCharacters.Contains(currChar) || currChar == ' ')
                {
                    Console.Write(currChar);
                }
                else
                {
                    Console.Write("X");
                }
            }
            //for (int i = 0; i < phraseCharacters.Length; i++)
            // {
            // if (phraseCharacters[i] == phraseGuessedCharacters.ElementAt(i))
            // {

            // Console.WriteLine(phraseCharacters[i]);

            // }

            // else
            // {
            //   Console.WriteLine("X");
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="guessedCharacters"></param>
        /// <returns></returns>
        static char GetCharacterGuess(List<char> guessedCharacters)
        {

            // List<string> guessedCharacters = new List<string>();

            bool confirmedLetter = true;
            char guessedCharacter;




            while (confirmedLetter)
            {
                Console.WriteLine("\nGuess a letter!");
                ConsoleKeyInfo key = Console.ReadKey();

                guessedCharacter = char.ToUpper(key.KeyChar);
                if (guessedCharacter >= 'A' && guessedCharacter <= 'Z')
                {

                    guessedCharacters.Add(guessedCharacter);

                    return guessedCharacter;
                }
                else
                {
                    Console.WriteLine("\nPlease guess a valid letter!");
                }

            }

            return ' ';
        }
        static List<string> GetPhrases()
        {
            List<string> newPhrases = new List<string>();

            newPhrases.Add("Every guilty person is his own hangman");
            newPhrases.Add("If you cant do the time dont do the crime");
            newPhrases.Add("Phrase to be added");

            return newPhrases;
        }
    }
}

