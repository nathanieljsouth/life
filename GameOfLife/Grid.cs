using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Grid
    {
        public int Rows;
        public int Columns;
        public int AliveRequested;
        public int Generations=0; //Should be read only, should not be updatable outside this class.

        private Cell[,] GridCells;

        public void createGrid()
        {
            if ((Rows*Columns)<AliveRequested)
            {
                throw new Exception("The number of alive cells cannot exceed the total number of cells");
            }

            GridCells = new Cell[Rows, Columns];

            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    GridCells[RowCounter, ColumnCounter] = new Cell();
                }
            }

            //Random generation for # alive set by user
            int NumberAlive = 0;

            //Create the random number generator
            Random RandomNumberGenerator = new Random();

            //Loop until number of cells alive is equal to user request
            while (NumberAlive < AliveRequested)
            {
                int RandomRow = RandomNumberGenerator.Next(0, Rows);
                int RandomColumn = RandomNumberGenerator.Next(0, Columns);

                if (GridCells[RandomRow,RandomColumn].CurrentlyAlive == false)
                {
                    GridCells[RandomRow, RandomColumn].CurrentlyAlive = true;

                    NumberAlive = NumberAlive + 1;
                }              
            }


        }

        public void processOneGeneration()
        {
            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //Tell the cell the number of live neighbours it has and commanding it calculate its next state
                    GridCells[RowCounter, ColumnCounter].CalculateNextState(1);
                }                
            }

            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //Tell the cell to update its current state with the state it just calculated
                    GridCells[RowCounter, ColumnCounter].ApplyNextState();
                }
            }

            Generations = Generations + 1;
        }

        public string getGridDisplay()
        {
            string GridDisplay = "";

            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    if (GridCells[RowCounter,ColumnCounter].CurrentlyAlive == true)
                    {
                        GridDisplay = GridDisplay + "X";
                    }
                    else
                    {
                        GridDisplay = GridDisplay + " ";
                    }
                }
                GridDisplay = GridDisplay + "\r\n";
            }
            return GridDisplay;


        }


    }
}
