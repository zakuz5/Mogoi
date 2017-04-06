using System;
using System.Threading;
namespace SE302
{
	public class Game
	{
		public Game()
		{
		}
		public void Start()
		{
			int direction = 0;
			bool snakeLive = true;
			Level level = new Level();
			Snake snake = new Snake();
			Food food = new Food();
			Display display = new Display();

			display.drawLevel();
			display.drawSnake(snake);
			display.drawFood(food);

			while (snakeLive)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					switch (key.Key)
					{
						case ConsoleKey.UpArrow: direction = Snake.TOP; break;
						case ConsoleKey.DownArrow: direction = Snake.BOTTOM; break;
						case ConsoleKey.LeftArrow: direction = Snake.LEFT; break;
						case ConsoleKey.RightArrow: direction = Snake.RIGHT; break;
					}
				}
				snake.go(direction);
				display.drawSnake(snake);

				if (snake.eat(food))
				{
					food.refresh();
					display.drawFood(food);
				}
				if () // todo
				{
					snakeLive = false;
				}
				Thread.Sleep(500);
			}

		}
		public void Pause() 
		{ 
		}
		public void Resume()
		{
		}
		public void Quit()
		{
		}
	}
}
