using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    { 
        
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        } 

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }


        public void Move(int step, Direction destination)
        {
            if(destination == Direction.RIGHT) 
            {
                x += step;
            } 
            else if(destination == Direction.LEFT)
            {
                x -= step;
            }
            else if (destination == Direction.UP)
            {
                y -= step;
            }
            else if (destination == Direction.DOWN)
            {
                y += step;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point _p)
        {
            return _p.x == this.x & _p.y == this.y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

    }
}
