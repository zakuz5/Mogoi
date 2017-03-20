using System;
using System.Threading;

namespace SE302
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int x = 10, y = 10, x0 = 10, y0 = 10;
			Console.CursorVisible = false;
			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					switch (key.Key)
					{
						case ConsoleKey.UpArrow:
							y = y - 1;
							break;
						case ConsoleKey.DownArrow:
							y = y + 1;
							break;
						case ConsoleKey.LeftArrow:
							x = x - 1;
							break;
						case ConsoleKey.RightArrow:
							x = x + 1;
							break;
						case ConsoleKey.Escape:
							Console.WriteLine("Game over");
							break;
					}
				}
				Thread.Sleep(100);
				Console.SetCursorPosition(x0, y0);
				Console.Write(' ');
				Console.SetCursorPosition(x, y);
				Console.Write('$');
				x0 = x; y0 = y;
			}

		}
	}
}
