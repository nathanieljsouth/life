using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        public bool CurrentlyAlive=false;
        bool NextGenerationAlive = false;

        public void CalculateNextState(int NumberOfNeighbours)
        {
            //If the cell is currently alive
            if (CurrentlyAlive==true)
            {
                //If alive neighbours = 2/3 keep it alive, if not kill it
                if ((NumberOfNeighbours == 2) || (NumberOfNeighbours == 3))
                {
                    NextGenerationAlive = true;
                }
                else
                {
                    NextGenerationAlive = false;
                }
            }
            else
            {
                //If dead and alive neighbours = 3 revive the cell, if not keep it dead
                if (NumberOfNeighbours == 3)
                {
                    NextGenerationAlive = true;
                }
                else
                {
                    NextGenerationAlive = false;
                }
            }
        }
        //Call the ApplyNextState function
        public void ApplyNextState()
        {
            CurrentlyAlive = NextGenerationAlive;
        }
        
        
    }
}
