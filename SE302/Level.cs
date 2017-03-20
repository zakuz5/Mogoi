using System;
namespace SE302
{
	public class Level
	{
		public static int HEIGHT = 25, WIDTH = 80;
		public static int[,] map = new int[HEIGHT, WIDTH];
		public static int speed = 300;
		public Level()
		{
			level1();
		}

		private void level1()
		{
			for (int i = 0; i < HEIGHT; i++)
			{
				for (int j = 0; j < WIDTH; j++)
				{
					if (i == 0 || j == 0 || i == HEIGHT - 1 || j == WIDTH - 1)
					{
						// 1 - saad, hana
						map[i, j] = 1;
					}
					else
					{
						// 0 - hooson talbai
						map[i, j] = 0;
					}
				}
			}
			speed = 300;
		}
		private void level2()
		{
			level1();
			speed = 250;
			// hana nemj zurah
		}

	}
}
