using System;
namespace SE302
{
	public class Food
	{
		private Point position;
		public Food()
		{
			position = new Point();
			this.refresh();
		}
		public Point getPosition()
		{
			return position;
		}
		public void refresh()
		{
			Random r = new Random();
			this.position.x = r.Next(1, Level.WIDTH - 2);
			this.position.y = r.Next(1, Level.HEIGHT - 2);
		}

	}
}
