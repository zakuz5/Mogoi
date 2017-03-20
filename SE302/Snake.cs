using System;
namespace SE302
{
	public class Snake
	{
		private int LEFT = 1, RIGHT = 2;
		private Point[] body = new Point[100];
		private int lenght;
		
		public Snake()
		{
			Point head = new Point(10, 10);
			body[0] = head;
			lenght = 1;
		}
		public void go(int direction = 0)
		{
			turn(direction);
			// todo
		}
		public void die()
		{
			
		}
		public void eat(Food food)
		{
		}


		private void grow(Food food)
		{
			
		}
		private void turn(int direction)
		{
			
		}
	}
}
