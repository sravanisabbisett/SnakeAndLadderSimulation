using System;

namespace SnakeAnDLadder
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake And Ladder simulation");
            SnakeAndLadder snake = new SnakeAndLadder();
            int diceValue = snake.RollDie();
            Console.WriteLine(diceValue);
            Console.ReadKey();
        }
    }
}
