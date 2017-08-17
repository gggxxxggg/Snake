using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int x, int yDown, int yUp, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Drow();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
