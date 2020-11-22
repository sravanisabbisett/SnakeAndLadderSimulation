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
            int player1Position = 0, dicevalue = 0;
            int player1DiceCount = 0;
            int currentPlayer = -1;
            int player2Position = 0, player2DiceCount = 0;
            while (true)
            {
                dicevalue = RollDie();
                if (currentPlayer == -1)
                {
                    player1DiceCount++;
                    player1Position = CalculatePlayerPosition(player1Position, dicevalue);
                    Console.WriteLine("Player 1 Position" + player1Position);
                    if (player1Position == WIN_POINT)
                    {
                        Console.WriteLine("player 1 wins");
                        Console.WriteLine("Die rolled " + player1DiceCount + " times to win");
                        break;
                    }
                }
                else
                {
                    player2DiceCount++;
                    player2Position = CalculatePlayerPosition(player2Position, dicevalue);
                    Console.WriteLine("Player2position" + player2Position);
                    if (player2Position == WIN_POINT)
                    {
                        Console.WriteLine("player 2 Wins");
                        Console.WriteLine("Die rolled " + player2DiceCount + " times to win");
                        break;
                    }
                }
                currentPlayer = -(currentPlayer);
            }
        }


        /// <summary>
        /// Method return a number from 1 to 6
        /// </summary>
        /// <returns></returns>
        public int RollDie()
        {
            return random.Next(1, 7); 
        }

        /// <summary>
        /// Calculates the player position.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="diceValue">The dice value.</param>
        /// <returns></returns>
       
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
                    Console.WriteLine("Congrats You got ladder roll die again");
                    diceValue = RollDie();
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
