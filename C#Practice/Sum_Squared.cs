namespace ConsoleApplications
{
	public class Sum_Squared
	{
		private static int number = 0;

		private static int square_number = 0;

		private static void Main()
		{
			Console.WriteLine("Enter the number for squaring");

			string? input = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Invalid Input");
			}

			if (!int.TryParse(input, out number))
			{
				Console.WriteLine("Invalid Input");
			}

			square_number = number * number;

			Console.WriteLine($"Square of the given number {number} is {square_number}");
		}
	}
}
