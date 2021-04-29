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
        public int Generations=0;

        public void createGrid()
        {
            if ((Rows*Columns)<Alive)
            {
                throw new Exception("The number of alive cells cannot exceed the total number of cells");
            }
        }

        public void processOneGeneration()
        {
            Generations = Generations + 1;
        }

        public string getGridDisplay()
        {
            return DateTime.Now.ToString();
        }


    }
}
