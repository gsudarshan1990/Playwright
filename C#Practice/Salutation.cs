namespace ConsoleApplications
{
	public class Salutation
	{
		private static void Main()
		{
			Console.WriteLine(GreetingMessage(string.Empty));
		}

		public static string GreetingMessage(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				name = "Rajesh";
			}

			return $"Welcome, {name}";
		}
	}
}
