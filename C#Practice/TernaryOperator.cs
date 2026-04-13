namespace ConsoleApplications
{
	internal class TernaryOperator
	{

		private static string GetWeatherDisplay(double temparatureCelcius) => temparatureCelcius < 20 ? "Cold" : "Perfect!";

		private static void Main()
		{
			int energyLevel = 10;

			string status = (energyLevel > 5) ? "Energey Sufficient" : "Recharge Needed";

			Console.WriteLine($"Status: {status}");

			Console.WriteLine();
			int mynumber = 8;

			string message = (mynumber > 10) ? "greater than 10" : "less than or equal to 10";

			Console.WriteLine("The number is " + message);
			Console.WriteLine();
			Console.WriteLine(GetWeatherDisplay(15));
			Console.WriteLine(GetWeatherDisplay(27));
			Console.WriteLine();
			int input = new Random().Next(-5, 5);

			Console.WriteLine((input >= 0) ? "nonnegative" : "negative");
		}
	}
}