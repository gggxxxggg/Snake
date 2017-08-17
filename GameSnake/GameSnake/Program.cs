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


            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            downLine.Drow();
            VerticalLine rightLine = new VerticalLine(0,0,24,'*');
            rightLine.Drow();
            VerticalLine leftLine = new VerticalLine(78,0,24,'*');
            leftLine.Drow();

            Point p = new Point(4,5,'*');
            Snake s = new Snake(p,4,Direction.RIGHT);
            s.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Drow();
           


            while (true)
            {
                if (s.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }

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
