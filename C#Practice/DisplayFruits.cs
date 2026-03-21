namespace ConsoleApplications
{
	public class DisplayFruits
	{
		private static void Main()
		{
			FruitLooping();
		}

		private static void FruitLooping()
		{
			var fruits = new List<string> { "Apple", "Banana", "Strawberry", "Mango", "PineApple" };

			Console.WriteLine("The below are my favorite fruits ");

			for (int index = 0; index < fruits.Count; index++)
			{
				Console.WriteLine($"{index + 1}:{fruits[index]}");
			}
		}
	}
}
