using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Game
    {
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public bool GameOver = false;

        public static int level;
        public int score;
        public Game()
        {
            Init();
            Play();
        }

        public void Init()
        {
            food.SetNewPosition();
            level = 1;
            wall.LoadLevel(level);
        }

        public void Play()
        {
            while (!GameOver)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();                
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);

                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);

                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);

                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);

                //if (button.Key == ConsoleKey.F5)
                //    wall.LoadLevel(2);
                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F3)
                    Resume();
                GameOver = snake.CollistionWithWall();

                if (Game.snake.body.Count > 3)
                {
                    level++;
                    wall.LoadLevel(level);
                    snake.StartWithZero();

                    Console.Clear();
                }

                // проверка еды
                if (snake.body[0].Equals(food.body[0]))
                {
                    snake.body.Add(new Point(0, 0));

                    //score = score+3;
                    Console.SetCursorPosition(6, 24);
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.Write("Points:" + snake.body.Count);
                    Game.food.SetNewPosition();
                }


                Console.SetCursorPosition(5, 23);
                Console.Write("Level:" + level);
            }
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Game Over!!!!");
            Console.ReadKey();
        }
        public void Draw()
        {
            //Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();
        }
        public void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }

    }
}
