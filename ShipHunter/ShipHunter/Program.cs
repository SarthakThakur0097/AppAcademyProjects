using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShipHunter
{
    enum Color
    {
        Blue,
        Red,
        Black,
        Gray
    }
    enum ShipType
    {
        Aircraft,
        Battleship,
        Cruiser,
        Destroyer,
        Submarine
    }


    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int[,] grid = GetGrid();
            int[,] originalGrid = GetGrid();
            int miss = 0;
            int point = 0;
            int hitOrMissDet;
            ShipType[] enemyShips = new ShipType[]
                {
                    ShipType.Aircraft,
                    ShipType.Battleship,
                    ShipType.Cruiser,
                    ShipType.Destroyer,
                    ShipType.Submarine
                };

            //bool[,] enemyShip = testShips(grid);
           
            DrawBoard(grid);
            bool playGame = true;

            int[,] testShip = testShips(grid, enemyShips);


            while (playGame) {
                if (miss == 25)
                {
                    DrawBoard(originalGrid);
                    Console.WriteLine("You lost the game");
                    playGame = false;
                }
                else if (point == 18)
                {
                    DrawBoard(originalGrid);
                    Console.WriteLine("You won the game!");
                    playGame = false;
                }
                else
                {
                    int[,] updateGrid = new int [10,10];
                    string currGuess = "";
                    currGuess = GetUserInput();

                    try
                    {
                       updateGrid = CheckGuess(testShip, currGuess, originalGrid);
               
                    }
                    catch(System.FormatException)
                    {
                        currGuess = GetUserInput();
                        updateGrid = CheckGuess(testShip, currGuess, originalGrid);
                    }
                    hitOrMissDet = DrawBoard(updateGrid);
                    if (hitOrMissDet == 1)
                    {
                        Console.WriteLine("You hit a ship!");
                        point++;
                    }
                    else if(hitOrMissDet == 3)
                    {
                        Console.WriteLine("You missed!");
                        miss++;
                    }
                    Console.WriteLine("Number of Misses: {0}", miss);
                    Console.WriteLine("Ships hit: {0}", point);

                }
            }

            Console.ReadLine();


            //char firstLet = 'A';
         
            //    // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        
        /// <summary>
        /// Gets the grid location of what where the user has placed his guess
        /// </summary>
        /// <returns></returns>
        static string GetUserInput()
        {
            string userInput;
            Console.WriteLine("Enter your guess (Ex: C8 or A4) ");
            userInput = Console.ReadLine();

            return userInput;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shipGrid">Passes in the 2D array of the where the current enemy ships are</param>
        /// <param name="userGuess">Passes in the current user guess</param>
        /// <param name="originalGrid">Passes in the current state of the grid</param>
        /// <returns></returns>
        static int [,] CheckGuess(int[,] shipGrid, string userGuess, int [,] originalGrid )
        {

            int RowGuess = 0;
            int ColumnGuess = 0;
            RowGuess = userGuess[0] - 65;
            ColumnGuess = int.Parse(userGuess[1].ToString());

            ColumnGuess = ColumnGuess - 1;
            int[,] newGrid = originalGrid;
            
            Console.Clear();
            
            string[] rowHeaders = {
                "A ",
                "B ",
                "C ",
                "D ",
                "E ",
                "F ",
                "G ",
                "H ",
                "I ",
                "J ",
            };

            //ConsoleColor oldForegroundColor = Console.ForegroundColor;
            //ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int row = 0; row < shipGrid.GetLength(0); row++)
            {
                //Console.BackgroundColor = ConsoleColor.Black;
               // Console.ForegroundColor = ConsoleColor.White;
                //Console.Write(rowHeaders[row]);
                for (int column = 0; column < shipGrid.GetLength(1); column++)
                {
                    
                    if (shipGrid[row, column] == 0 && (RowGuess == row && ColumnGuess == column))
                    {
                        newGrid[row, column] = 3;
                    }
                    else if (shipGrid[row, column] == 1 && (RowGuess == row && ColumnGuess == column))
                    {
                      //  Console.BackgroundColor = ConsoleColor.Red;
                        newGrid[row, column] = 1;
                      
                        

                    }
                   // Console.Write("  ");
                    //Console.BackgroundColor = ConsoleColor.Blue;
                }

                //Console.BackgroundColor = ConsoleColor.Black;
               // Console.WriteLine();
            }

            return newGrid;

        }

        static ShipType GetRandomShipType()
        {
            Random rand = new Random();
            int ranNum = rand.Next(0, 6);
            switch (ranNum)
            {
                case 1:
                    return ShipType.Aircraft;
                   
                    break;
                case 2:
                    return ShipType.Battleship;

                    break;
                case 3:
                    return ShipType.Cruiser;

                    break;
                case 4:
                    return ShipType.Destroyer;

                    break;
                case 5:
                    return ShipType.Submarine;
                    break;
            }
            return ShipType.Aircraft;
        }
        static int DrawBoard(int [,] currGrid)
        {
            int hitOrMiss = 0;
            string[] rowHeaders = {
                "A ",
                "B ",
                "C ",
                "D ",
                "E ",
                "F ",
                "G ",
                "H ",
                "I ",
                "J ",
            };

            ConsoleColor oldForegroundColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

           
            
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int row = 0; row<currGrid.GetLength(0); row++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(rowHeaders[row]);
                for (int column = 0; column<currGrid.GetLength(1); column++)
                {
                    if(currGrid[row,column] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if(currGrid[row,column] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        hitOrMiss = 1;
                    }
                    else if(currGrid[row,column] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        hitOrMiss = 3;
                    }
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                
                Console.WriteLine();
            }

            return hitOrMiss;
         

        }

        static int [,] testShips(int [,] currGrid, ShipType[] EnemyShips)
        {
            int[,] enemyGrid = currGrid;
            for(int i = 0; i<EnemyShips.Length; i++)
            {
                for(int row = 0; row<currGrid.GetLength(0); row++)
                {
                    for(int column = 0; column<currGrid.GetLength(1); column++)
                    {
                        if(EnemyShips[i] == ShipType.Aircraft)
                        {
                            enemyGrid[3,3] = 1;
                            enemyGrid[3, 4] = 1;
                            enemyGrid[3, 5] = 1;
                            enemyGrid[3, 6] = 1;
                            enemyGrid[3, 7] = 1;
                        }
                        if (EnemyShips[i] == ShipType.Battleship)
                        {
                            enemyGrid[0, 1] = 1;
                            enemyGrid[1, 1] = 1;
                            enemyGrid[2, 1] = 1;
                            enemyGrid[3, 1] = 1;
                          

                        }
                        if (EnemyShips[i] == ShipType.Cruiser)
                        {
                            enemyGrid[7, 3] = 1;
                            enemyGrid[7, 4] = 1;
                            enemyGrid[7, 5] = 1;
                        
                        }
                        if (EnemyShips[i] == ShipType.Destroyer)
                        {

                            enemyGrid[3, 5] = 1;
                            enemyGrid[4, 5] = 1;

                        }
                        if (EnemyShips[i] == ShipType.Submarine)
                        {
                            enemyGrid[1, 7] = 1;
                           
                        }
                    }
                }
            }
            
            return enemyGrid;
        }
        
        static int[,] GetGrid()
        {

            int[,] toPop = new int[10, 10];
            for (int column = 0; column < toPop.GetLength(0); column++)
            {
              
                for (int row = 0; row < toPop.GetLength(1); row++)
                {
                    toPop[row, column] = 0;
                }
                
            }
            return toPop;
        }

    }
}
