using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls();
            walls.BuildWalls(80, 25);
           

            Point p = new Point(4,5,'*');
            Snake s = new Snake(p,4,Direction.RIGHT);
            s.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Drow();

         
            while (true)
            {

                if (walls.isHit(s) || s.isHitTail())
                {
                    break;
                }
                food.Drow();
                if (s.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s.jostik(key.Key);
                }
                Thread.Sleep(100);
                s.Move();
            }

            
        }


       
    }
}
