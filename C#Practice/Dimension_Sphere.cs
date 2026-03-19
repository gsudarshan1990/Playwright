namespace ConsoleApplications
{
	public class Dimension_Sphere
	{
		private const double _pi = 3.14d;

		private static double radius = 0.0d;

		private static double area = 0.0d;

		private static double volume = 0.0d;

		private static void Main()
		{
			Console.WriteLine("Enter the Radius");

			string? input = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Invalid input");
				return;
			}

			if (!double.TryParse(input, out radius))
			{
				Console.WriteLine("Invalid Input");
			}

			area = 4 * _pi * (radius * radius);

			volume = 4 / 3 * _pi * (radius * radius * radius);

			Console.WriteLine($"Area {area}");

			Console.WriteLine($"Volume {volume}");
		}
	}
}
