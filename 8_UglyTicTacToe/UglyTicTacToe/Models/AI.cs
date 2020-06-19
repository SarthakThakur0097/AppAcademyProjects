using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UglyTicTacToe.Models
{
    public class AI
    {
        public string[,] AIGrid = new string[3,3];

       public string makeMove(string [,] currentBoard )
        {
            string move = "";
            for (int i = 0; i < AIGrid.GetLength(0); i++)
            {
                for (int j = 0; j < AIGrid.GetLength(1); j++)
                {
                    if(currentBoard[i,j].Equals(" "))
                    {
                         move = i + "" + j;
                    }
                }
            }
            return move;
        }

        public void PopulateGrid()
        {

            string buttonIDBuilder = "rc";

            for (int i = 0; i < AIGrid.GetLength(0); i++)
            {
                for (int j = 0; j < AIGrid.GetLength(1); j++)
                {
                   
                }
            }
        }
    }
}