using System;
namespace SE302
{
	public class Display
	{
		Food oldFood;
		public Display()
		{
			oldFood = new Food();
		}
		public void drawSnake(Snake snake)
		{
			
		}
		public void drawLevel()
		{
		}
		public void drawFood(Food food)
		{
			Console.SetCursorPosition(oldFood.getPosition().x, oldFood.getPosition().y);
			Console.Write(' ');

			Console.SetCursorPosition(food.getPosition().x, food.getPosition().y);
			Console.Write('*');
			oldFood = food;
		}

	}
}
