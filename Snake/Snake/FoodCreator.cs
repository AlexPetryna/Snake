using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator : Point
    {
        protected int mapWidht;
        protected int mapHeight;
        protected Random random;

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
            random = new Random();
            CreateFood();
         }

        public void CreateFood()
        {
            x = random.Next(2, mapWidht - 2);
            y = random.Next(2, mapHeight - 2);
            Draw();
        }

    }
}
