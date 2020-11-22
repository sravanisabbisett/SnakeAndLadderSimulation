using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAnDLadder
{
    class SnakeAndLadder
    {
        Random random = new Random();
        int playerPosition = 0;

        public int RollDie()
        {
            return random.Next(1, 7); 
        }
    }
}
