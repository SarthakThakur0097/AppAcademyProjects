using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UglyTicTacToe.Models;

namespace UglyTicTacToe.Controls
{
    public partial class TicTacToeBoardAI : System.Web.UI.UserControl
    {
        public Button[,] grid = new Button[3, 3];
        public Player currentPlayer = new Player();
        public bool player1Turn;

        string playerKey = "PlayerKey";
        public bool Player1
        {
            get
            {
                object viewStateInt = ViewState[playerKey];

                if (viewStateInt != null)
                {
                    return (bool)viewStateInt;
                }
                else
                {
                    return false;
                }

            }
            set
            {
                ViewState[playerKey] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            currentPlayer.Turn = true;
            //player1 = currentPlayer.Turn;
            PopulateGrid();
          
           
            
        }

        public void PopulateGrid()
        {

            string buttonIDBuilder = "rc";

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = (Button)FindControl(buttonIDBuilder + i + "" + j);
                }
            }
        }

        public bool checkWin()
        {
            String[,] field = new String[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j] = grid[i, j].Text;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (field[i, 0].Equals(field[i, 1])
                        && field[i, 0].Equals(field[i, 2])
                        && !field[i, 0].Equals(" "))
                {

                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (field[0, i].Equals(field[1, i])
                        && field[0, i].Equals(field[2, i])
                        && !field[0, i].Equals(" "))
                {

                    return true;
                }
            }

            if (field[0, 0].Equals(field[1, 1])
                       && field[0, 0].Equals(field[2, 2])
                       && !field[0, 0].Equals(" "))
            {

                return true;
            }

            if (field[0, 2].Equals(field[1, 1])
                       && field[0, 2].Equals(field[2, 0])
                       && !field[0, 2].Equals(" "))
            {

                return true;
            }

            return false;

        }


        public void makeMove()
        {
            String[,] fields = new String[3, 3];
            bool middleSpot = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i, j] = grid[i, j].Text;
                    if(!grid[i, j].Text.Equals(" "))
                    {
                        middleSpot = false;
                           
                    }
                }
            }

            string move = "rc";
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    if (fields[i, j].Equals(" "))
                    {
                        
                        Button marked = (Button)FindControl(move + i + "" + j);
                        marked.Text = "O";

                        marked.Enabled = false;
                        return;
                    }
                }
            }
            
        }
        public void ResetGrid()
        {

            string buttonIDBuilder = "rc";

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Button CurrentButton = (Button)FindControl(buttonIDBuilder + i + "" + j);
                    CurrentButton.Text = " ";
                    CurrentButton.Enabled = true;
                }
            }
        }
        public void takeTurn(string buttonID)
        {
            string rc = "rc";
            rc = rc + buttonID[2] + "" + buttonID[3];
            Button marked = (Button)FindControl(rc);


            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (marked.Text.Equals(" "))
                {
                    marked.Text = "X";
                    marked.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }

            makeMove();

            marked.Enabled = false;

            if (checkWin())
            {
                TestBox.Text = "Player 2 Wins!";
                AllButtons.Enabled = false;
            }
            PlayerTurnDisplay.Text = "Player 2 Turn";
            Player1 = !Player1;



        }

        protected void rc00_Click(object sender, EventArgs e)
        {
            takeTurn(rc00.ID);


        }
        protected void rc01_Click(object sender, EventArgs e)
        {
            takeTurn(rc01.ID);
        }

        protected void rc02_Click(object sender, EventArgs e)
        {
            takeTurn(rc02.ID);
            
        }


        protected void rc10_Click(object sender, EventArgs e)
        {
            takeTurn(rc10.ID);
        }

        protected void rc11_Click(object sender, EventArgs e)
        {
            takeTurn(rc11.ID);
        }

        protected void rc12_Click(object sender, EventArgs e)
        {
            takeTurn(rc12.ID);
        }


        protected void rc20_Click(object sender, EventArgs e)
        {
            takeTurn(rc20.ID);
        }

        protected void rc21_Click(object sender, EventArgs e)
        {
            takeTurn(rc21.ID);
        }

        protected void rc22_Click(object sender, EventArgs e)
        {
            takeTurn(rc22.ID);
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            ResetGrid();
            AllButtons.Enabled = true;
            Player1 = true;
            PlayerTurnDisplay.Text = "Player 1 Turn";

        }
    }
}