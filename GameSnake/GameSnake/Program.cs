using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Drow();

            Point p2 = new Point(4,5,'#');
            p2.Drow();
            Point p3 = new Point(6, 7, '-');
            p3.Drow();
            Point p4 = new Point(3, 8, '+');
            p4.Drow();


            HorizontalLine q1 = new HorizontalLine(1, 20, 8, '$');
            q1.Drow();

            Console.ReadKey();

        }
        
    }
}
