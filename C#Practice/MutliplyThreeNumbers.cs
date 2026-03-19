namespace ConsoleApplications
{
	public class MutliplyThreeNumbers
	{
		private static int number1;
		private static int number2;
		private static int number3;
		private static int result;

		private static void Main()
		{
			Console.WriteLine("Enter the number 1");

			string? input1 = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input1))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			if (!int.TryParse(input1, out number1))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			Console.WriteLine("Enter the number 2");

			string? input2 = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input2))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			if (!int.TryParse(input2, out number2))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			Console.WriteLine("Enter the number 1");

			string? input3 = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input3))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			if (!int.TryParse(input3, out number3))
			{
				Console.WriteLine("Invalid Input");
				return;
			}

			result = number1 * number2 * number3;

			Console.WriteLine($"The product of three numbers {number1}, {number2}, and {number3} is {result}");

		}
	}
}
