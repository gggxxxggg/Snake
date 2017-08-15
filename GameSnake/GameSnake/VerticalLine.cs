using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int x, int yDown, int yUp, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
              foreach (Point p in pList)
              {
                  p.Drow();
              }
        }
    }

}
