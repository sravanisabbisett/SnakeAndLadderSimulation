using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAnDLadder
{
    class SnakeAndLadder
    {
        Random random = new Random();
        int WIN_POINT = 100;

        public void StartGame()
        {
            int playerPosition = 0, dicevalue = 0;
            int playerDiceCount = 0;
            while (true)
            {
                dicevalue = RollDie();
                playerDiceCount++;
                playerPosition = CalculatePlayerPosition(playerPosition, dicevalue);
                Console.WriteLine("Player position" + playerPosition);
                if (playerPosition == WIN_POINT)
                {
                    Console.WriteLine("player 1 wins");
                    Console.WriteLine("Die rolled " + playerDiceCount + " times to win");
                    break;
                }
            }
        }

        public int RollDie()
        {
            return random.Next(1, 7); 
        }

        public int CalculatePlayerPosition(int player,int diceValue)
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
            if (player < 0)
            {
                player = 0;
            }
            if (player > WIN_POINT)
            {
                player = player - diceValue;
            }
            return player;
        }
    }
}
