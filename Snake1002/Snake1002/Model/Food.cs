using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Yellow;
            sign = '$';
        }

        public void SetNewPosition()
        {
            body.Clear();

            //create point in safe place
            List<Point> dangerPoints = new List<Point>();
            dangerPoints.AddRange(Game.wall.body);
            dangerPoints.AddRange(Game.snake.body);

            while (true)
            {
                int x = new Random().Next() % 70;
                int y = new Random().Next() % 20;
                Point posit = new Point(x, y);
                bool isnotsafe = false;

                foreach (Point dangerP in dangerPoints)
                {
                    if (dangerP.Equals(posit))
                    {
                        isnotsafe = true;
                    }
                }

                if (!isnotsafe)
                {
                    if (body.Count == 0)
                        body.Add(posit);
                    else
                    {
                        body[0].x = x;
                        body[0].y = y;
                    }
                    break;
                }
            }
        }

    }
}
