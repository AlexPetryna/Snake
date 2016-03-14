using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
  
            Point p = new Point(5, 7, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator food = new FoodCreator(80, 25, '$');


            while (true)
            {
                if (snake.IsHitTail() || walls.IsHit(snake))
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food.CreateFood();
                }
                else snake.Move();

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }


            }

         //   Console.ReadLine();

        }
    }
}
