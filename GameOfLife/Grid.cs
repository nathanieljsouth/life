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
                //If the number of requested cells is greater than the space available, return an error
                throw new Exception("The number of alive cells cannot exceed the total number of cells");
            }
            //Populate the Grid with new cell classes
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
            Generations = 0;

        }
        //Function that calculates the number of cells currently alive
        public int GetNumberAlive()
        {
            int CellsCurrentlyAlive = 0;

            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //If the coordinate chosen is currently alive
                    if (GridCells[RowCounter, ColumnCounter].CurrentlyAlive)
                    {
                        //Add 1 to the number of cells alive
                        CellsCurrentlyAlive = CellsCurrentlyAlive + 1;
                    }
                }
            }
            return CellsCurrentlyAlive;
        }

        //Function that applies the rules for one generation
        public void processOneGeneration()
        {
            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //Tell the cell the number of live neighbours it has and commanding it calculate its next state
                    GridCells[RowCounter, ColumnCounter].CalculateNextState(GetNumberOfAliveNeighbours(RowCounter, ColumnCounter));
                }                
            }
            //Go over every cell and update its state
            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //Tell the cell to update its current state with the state it just calculated
                    GridCells[RowCounter, ColumnCounter].ApplyNextState();
                }
            }
            //Add 1 to the number of Generations
            Generations = Generations + 1;
        }


        //Function that displays the alive and dead cells in the text box. X for alive, space for dead.
        public string getGridDisplay()
        {
            string GridDisplay = "";

            for (int RowCounter = 0; RowCounter < Rows; RowCounter++)
            {
                for (int ColumnCounter = 0; ColumnCounter < Columns; ColumnCounter++)
                {
                    //If the cell chosen is currently alive
                    if (GridCells[RowCounter,ColumnCounter].CurrentlyAlive == true)
                    {
                        //If cells is alive add an "X" to the grid
                        GridDisplay = GridDisplay + "X";
                    }
                    else
                    {
                        //If the cells is dead add a " " to the grid
                        GridDisplay = GridDisplay + " ";
                    }
                }
                //At the end of each row add a new line
                GridDisplay = GridDisplay + "\r\n";
            }
            return GridDisplay;


        }

        private int GetNumberOfAliveNeighbours(int Row, int Column)
        {
            //Calculate the number of alive neighbours
            int AliveNeighbours = 0;

            //Create variables to hold the neighbouring cells rows and columns
            int RowAbove;
            int RowBelow;
            int ColumnLeft;
            int ColumnRight;

            //Find which rows we need to look at
            if (Row == 0)
            {
                RowAbove = Rows - 1;
            }
            else
            {
                RowAbove = Row - 1;
            }
            if (Row == Rows - 1)
            {
                RowBelow = 0;
            }
            else
            {
                RowBelow = Row + 1;
            }

            //Find which columns we need to look at
            if (Column == 0)
            {
                ColumnLeft = Columns - 1;
            }
            else
            {
                ColumnLeft = Column - 1;
            }
            if (Column == Columns - 1)
            {
                ColumnRight = 0;
            }
            else
            {
                ColumnRight = Column + 1;
            }

            //Count the number of alive neighbours
            //Top row
            if (GridCells[RowAbove, ColumnLeft].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            if (GridCells[RowAbove, Column].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            if (GridCells[RowAbove, ColumnRight].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }

            //Middle row
            if (GridCells[Row, ColumnLeft].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            if (GridCells[Row, ColumnRight].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }

            //Bottom row
            if (GridCells[RowBelow, ColumnLeft].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            if (GridCells[RowBelow, Column].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            if (GridCells[RowBelow, ColumnRight].CurrentlyAlive == true)
            {
                AliveNeighbours = AliveNeighbours + 1;
            }
            return AliveNeighbours;
        } 

    }
}
