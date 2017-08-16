using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Snake : Figure
    {
        Direction direction;
        public  Snake(Point tail, int lenght, Direction _direction) 
        {
            pList = new List<Point>();
            _direction = direction;

            for (int i = 0; i < lenght; i++)
            {
                Point q = new Point(tail);
                q.Move(i, direction);
                pList.Add(q);
            }
        }





        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clen();
            head.Drow();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = head;
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }

}
