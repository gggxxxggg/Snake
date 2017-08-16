using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Snake : Figure
    {
      
        public  Snake(Point tail, int lenght, Direction direction) 
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point q = new Point(tail);
                q.Move(i, direction);
                pList.Add(q);
            }
        }
        

        

    }
}
