using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Snake : Figure
    {
      public Direction direction;

        public  Snake(Point tail, int lenght, Direction _direction) 
        {
            pList = new List<Point>();
            direction = _direction;

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
            head.Drow1();
        }
      
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void jostik (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                    {
                       direction = Direction.LEFT;
                    }
                    else if (key == ConsoleKey.RightArrow)
                    {
                        direction = Direction.RIGHT;
                    }
                    else if (key == ConsoleKey.UpArrow)
                    {
                        direction = Direction.UP;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        direction = Direction.DOWN;
                    }
        }

        internal bool Eat(Point food)
        {
            Point head = pList.Last();
            if (head.isHit(food))
            {
               food.sym = head.sym;
               pList.Add(food);
               return true;
            }
            else
            {
                return false; 
            }
        }

        internal bool isHitTail()
        {
            Point head = pList.Last();

            for (var i = 0; i < pList.Count - 1; i++ )
            {
                if (head.isHit(pList[ i ]))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
