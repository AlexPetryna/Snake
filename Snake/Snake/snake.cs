using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figura
    {

        protected Direction direction;

        public Snake(Point tail, int _len, Direction _direction)
        {
            direction = _direction;

            for (int i = 0; i<_len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }


        public void Move()
        {
            Point tail = pList.First();
            pList.RemoveAt(0);
            Point next = GetNextPoint();
            pList.Add(next);
            next.Draw();
            tail.Clear();
        }

        public void HandleKey(ConsoleKey key)
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

        public bool Eat(Point _p)
        {

            Point nextPoint = GetNextPoint();

            if (nextPoint.IsHit(_p))
            {
                pList.Add(nextPoint);
                nextPoint.Draw();
                return true;
            }
            else return false;

            
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i <= pList.Count() - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
