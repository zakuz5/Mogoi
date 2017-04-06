using System;
namespace SE302
{
	public class Snake
	{
		public const int TOP = 1, RIGHT = 2, BOTTOM = 3, LEFT = 4;
		private Point[] body = new Point[100];
		private Point newHead;
		private int lenght;
		private int direction;

		
		public Snake()
		{
			Point head = new Point(10, 10);
			body[0] = head;
			lenght = 1;
			direction = RIGHT;
		}
		public void go(int direction = 0)
		{
			if (!is_die()) {
				turn(direction);
				move();
			}
		}

		private void move()
		{
			for (int i = this.lenght-1; i > 0; i--)
			{
				body[i] = body[i - 1];
			}
			body[0] = newHead;
		}
		private bool is_die(int direction = 0)
		{
			newHead = new Point(body[0].x, body[0].y);
			switch (this.direction)
			{
				case TOP: newHead.y--; break;
				case RIGHT: newHead.x++; break;
				case BOTTOM: newHead.y++; break;
				case LEFT: newHead.x--; break;
			}
			if (Level.map[newHead.x, newHead.y] == Level.WALL)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool eat(Food food)
		{
			if (body[0].x == food.getPosition().x && body[0].y == food.getPosition().y)
			{
				grow(food);
				return true;
			}
			else
			{
				return false;
			}
		}


		private void grow(Food food)
		{
			lenght++;
		}
		private void turn(int direction = 0)
		{
			// Mogoin chiglel tegsh ued ergeh chiglel sondgoi baih yostoi
			if (((this.direction % 2 == 1 && direction % 2 == 0) || (this.direction % 2 == 0 && direction % 2 == 1)) && direction > 0)
			{
				this.direction = direction;
			}
		}
	}
}
