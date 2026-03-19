namespace ConsoleApplications
{
	public class ListsExample
	{
		private static void Main()
		{
			List<string> names = ["somesh", "rakesh", "rajesh"];

			foreach (string name in names)
			{
				Console.WriteLine($" Hello {name.ToUpper()}");
			}

			names.Add("Shashank");
			names.Add("Venkatesh");
			names.Add("Ashok");


			Console.WriteLine();
			Console.WriteLine("After Dynamic Addtion of names in Runtime");

			foreach (string name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}");
			}

			Console.WriteLine($"Total number of items on the list {names.Count}");

			names.Sort();

			Console.WriteLine("After applying soring method <names.sort()>");

			Console.WriteLine();

			foreach (string name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}");
			}
		}
	}
}
