using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.White;
            sign = 'o';
            body.Add(new Point(10, 10));
        }

        public void move(int dx, int dy)
        {
            foreach (Point snakebodyIt in body)
            {
                Console.SetCursorPosition(snakebodyIt.x, snakebodyIt.y);
                Console.Write(" ");
            }

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x > 70)
            {
                body[0].x = 0;
            }
            if (body[0].x < 0)
            {
                body[0].x = 70;
            }
            if (body[0].y > 20)
            {
                body[0].y = 0;
            }
            if (body[0].y < 0)
            {
                body[0].y = 20;
            }

            //// проверка еды
            //if (body[0].x == Game.food.body[0].x &&
            //    body[0].y == Game.food.body[0].y)
            //{
            //    body.Add(new Point(0, 0));
            //    Game.food.SetNewPosition();
            //}

        }

        public bool CollistionWithWall()
        {
            foreach (Point p in Game.wall.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;

        }

        public void StartWithZero()
        {
            body.Clear();

            //create point in safe place
            List<Point> dangerPoints = new List<Point>();
            dangerPoints.AddRange(Game.wall.body);
            dangerPoints.Add(Game.food.body[0]);

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
                    body.Add(posit);
                    break;
                }
            }
        }
    }
}
