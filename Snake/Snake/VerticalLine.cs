using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figura
    {

       public VerticalLine(int xStart, int yStart, int _len, char _sym)
        {
            for (int i = 0; i < _len; i++)
            {
                Point p = new Point(xStart, yStart + i, _sym);
                pList.Add(p);
            }
        }
    }
}
