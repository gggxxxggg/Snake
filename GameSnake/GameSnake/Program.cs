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
            int x1 = 1;
            int y1 = 3;
            String sym1 = "*";

            Drow(x1,y1, sym1);

            int x2 = 5;
            int y2 = 5;
            String sym2 = "#";

            Drow(x2, y2, sym2);

            Console.ReadKey();

        }
        static void Drow (int x, int y, String sym) 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
