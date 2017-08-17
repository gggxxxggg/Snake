using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Figure
    {
      protected List<Point> pList;
     
        public virtual void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }

        }

        internal bool isHit(Figure figure)
        {
            foreach(var point in pList)
            {
                if (figure.isHit(point))
                {
                    return true;
                }
            }
            return false;
        }
      
        private bool isHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
