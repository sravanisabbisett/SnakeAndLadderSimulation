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

        public int calculatePlayerPosition(int player,int diceValue)
        {
            int checkPlay;
            checkPlay = random.Next(3);
            switch (checkPlay)
            {
                case 0:
                    Console.WriteLine("No play");
                    break;
                case 1:
                    Console.WriteLine("ladder");
                    player = player + diceValue;
                    break;
                default:
                    Console.WriteLine("Snake");
                    player = player - diceValue;
                    break;
            }
            return player;
        }
    }
}
