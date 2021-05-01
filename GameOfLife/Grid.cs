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
        public int Alive;
        public int Generations=0; //Should be read only, should not be updatable outside this class.

        private Cell[,] GridCells;

        public void createGrid()
        {
            if ((Rows*Columns)<Alive)
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
        }

        public void processOneGeneration()
        {
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
                        GridDisplay = GridDisplay + "O ";
                    }
                }
                GridDisplay = GridDisplay + "\r\n";
            }
            return GridDisplay;


        }


    }
}
