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
            if (CurrentlyAlive==true)
            {
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
        public void ApplyNextState()
        {
            CurrentlyAlive = NextGenerationAlive;
        }
        
        
    }
}
