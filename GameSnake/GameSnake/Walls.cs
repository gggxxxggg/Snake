using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class Walls
    {
        List<Figure> wallslist;
        public void BuildWalls (int mapWidth, int mapHeight)
        {
            wallslist = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '*');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '*');
            downLine.Drow();
            VerticalLine rightLine = new VerticalLine(0,0,mapHeight - 1,'*');
            rightLine.Drow();
            VerticalLine leftLine = new VerticalLine(mapWidth - 2,0,mapHeight - 1,'*');
            leftLine.Drow();

            
            wallslist.Add(upLine);
            wallslist.Add(downLine);
            wallslist.Add(rightLine);
            wallslist.Add(leftLine);
        }
        

        public bool  isHit (Figure figure)
        {
            foreach(var wall in wallslist )
            {
                if(wall.isHit(figure))
                {
                    return true;
                }
               
            }
            return false;
        }
        public void Drow()
        {
            foreach (var wall in wallslist)
            {
                wall.Drow();
            }
        }

    }
}
