using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UglyTicTacToe.Models;

namespace UglyTicTacToe.Controls
{
    public partial class TicTacToeBoard : System.Web.UI.UserControl
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
           // player1 = currentPlayer.Turn;
            PopulateGrid();
        }

        public void testMethod()
        {

        }
       public void PopulateGrid()
        {
            
            string buttonIDBuilder = "rc";
           
            for(int i = 0; i<grid.GetLength(0); i++)
            {
                for(int j = 0; j<grid.GetLength(1); j++)
                {              
                    grid[i, j] =(Button)FindControl(buttonIDBuilder + i + "" + j);
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

      

        protected void rc00_Click(object sender, EventArgs e)
        {

            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc00.Text.Equals(" "))
                {
                    rc00.Text = "X";
                    rc00.Enabled = false;
                }
                if(checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;

                }
                Player1 = !Player1;
            }
            else
            {
                if (rc00.Text.Equals(" "))
                {
                   
                    rc00.Text = "O";
                    rc00.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }


        }
        protected void rc01_Click(object sender, EventArgs e)
            {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc01.Text.Equals(" "))
                {
                    rc01.Text = "X";
                    rc01.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc01.Text.Equals(" "))
                {
                    rc01.Text = "O";
                    rc01.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }

        protected void rc02_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc02.Text.Equals(" "))
                {
                    rc02.Text = "X";
                    rc02.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc02.Text.Equals(" "))
                {
                    rc02.Text = "O";
                    rc02.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }

        }


        protected void rc10_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc10.Text.Equals(" "))
                {
                    rc10.Text = "X";
                    rc10.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc10.Text.Equals(" "))
                {
                    rc10.Text = "O";
                    rc10.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }

        protected void rc11_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc11.Text.Equals(" "))
                {
                    rc11.Text = "X";
                    rc11.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc11.Text.Equals(" "))
                {
                    rc11.Text = "O";
                    rc11.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }

        protected void rc12_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc12.Text.Equals(" "))
                {
                    rc12.Text = "X";
                    rc12.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc12.Text.Equals(" "))
                {
                    rc12.Text = "O";
                    rc12.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }


        protected void rc20_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc20.Text.Equals(" "))
                {
                    rc20.Text = "X";
                    rc20.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc20.Text.Equals(" "))
                {
                    rc20.Text = "O";
                    rc20.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }

        protected void rc21_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc21.Text.Equals(" "))
                {
                    rc21.Text = "X";
                    rc21.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc21.Text.Equals(" "))
                {
                    rc21.Text = "O";
                    rc21.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
        }

        protected void rc22_Click(object sender, EventArgs e)
        {
            if (!Player1)
            {
                PlayerTurnDisplay.Text = "Player 1 Turn";
                if (rc22.Text.Equals(" "))
                {
                    rc22.Text = "X";
                    rc22.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 1 Wins!";
                    AllButtons.Enabled = false;
                }
                Player1 = !Player1;
            }
            else
            {
                if (rc22.Text.Equals(" "))
                {
                    rc22.Text = "O";
                    rc00.Enabled = false;
                }
                if (checkWin())
                {
                    TestBox.Text = "Player 2 Wins!";
                    AllButtons.Enabled = false;
                }
                PlayerTurnDisplay.Text = "Player 2 Turn";
                Player1 = !Player1;
            }
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