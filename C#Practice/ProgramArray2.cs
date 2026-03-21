namespace ConsoleApplications
{
	public class ProgramArray2
	{

		private static void Main()
		{
			string[] grocerylist = new string[] { "banana", "orange", "avacado" };

			char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

			string[] lunch = { "sandwich", "fruit salad", "Pani Puri" };

			string[] planets = new string[4];
			planets[0] = "Earth";
			planets[3] = "Mars";

			for (int i = 0; i < grocerylist.Length; i++)
			{
				Console.WriteLine(grocerylist[i]);
			}

			Console.WriteLine();

			for (int j = 0; j < vowels.Length; j++)
			{
				Console.WriteLine(vowels[j]);
			}

			Console.WriteLine();

			for (int k = 0; k < lunch.Length; k++)
			{
				Console.WriteLine(lunch[k]);
			}

			Console.WriteLine();

			for (int l = 0; l < planets.Length; l++)
			{
				Console.WriteLine($"Planet at {l} is {planets[l]}");
			}

			string[] items =
			{
				"banana",
				"orange",
				"avacado",
				"lemons",
				"pretzels",
				"pecans",
				"peanut butter",
				"butter",
				"cheese",
				"biscuits"
			};

			Console.WriteLine();

			foreach (string item in items)
			{
				Console.WriteLine(item);
			}




		}
	}
}
