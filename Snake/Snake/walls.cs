using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figura> fList = new List<Figura>();


        public Walls(int mapWidth, int mapHeight)
        {
            HorisontalLine upLine = new HorisontalLine(0, 0, mapWidth-1, '+');
            HorisontalLine downLine = new HorisontalLine(0, 24, mapWidth-1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight-1, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, mapHeight, '+');

            fList.Add(upLine);
            fList.Add(downLine);
            fList.Add(leftLine);
            fList.Add(rightLine);
            Draw();
        }

        public void Draw()
        {
            foreach (var f in fList)
            {
                f.Draw();
            }
        }

        public bool IsHit(Figura figura)
        {
            foreach(var wall in fList)
            {
                if (wall.IsHit(figura))
                {
                    return true;
                }
            }
            return false;
            
        }
         
    }
}
