using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHunter
{
    //enum ShipType {
    // Aircraft,
    // Battleship,
    // Cruiser,
    // Destroyer,
    // Submarine
    //}
    class Ship
    {
        bool[,] grid = new bool[10, 10];

        public bool [,] GenerateRandomShips()
        {
            Random rand = new Random();
            ShipType[] shipsToDeploy = new ShipType[3];
            int generateShips = 0;
            while(generateShips<4)
            {
                shipsToDeploy[generateShips] = RandomShip();
                generateShips++;
            }

            int randomRow = rand.Next(0, 5);
            int randomColumn = rand.Next(0, 5);

            bool rowOrColumn;
            int rowOrColumnNum = rand.Next(0, 3);
            if(rowOrColumnNum == 1)
            {
                rowOrColumn = true;
            }
            else
            {
                rowOrColumn = false;
            }
            for (int i = 0; i<4; i++)
            {
                if(shipsToDeploy[i] == ShipType.Aircraft)
                {
                   if(rowOrColumn)
                    {
                       
                    }
                }
                else if (shipsToDeploy[i] == ShipType.Battleship)
                {

                }
                else if (shipsToDeploy[i] == ShipType.Cruiser)
                {

                }
                else if (shipsToDeploy[i] == ShipType.Destroyer)
                {

                }
                else if (shipsToDeploy[i] == ShipType.Submarine)
                {

                }
            }


            return grid;
        }

        private ShipType RandomShip()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 5);

            switch(randomNum)
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

    }
}
