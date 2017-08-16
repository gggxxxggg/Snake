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
            Snake s = new Snake(p,6,Direction.RIGHT);
            s.Drow();
            s.Move();
            Thread.Sleep(300);
            s.Move();
            Thread.Sleep(300);
            s.Move();
            Thread.Sleep(300);

            Console.ReadKey();
        }
        
    }
}
