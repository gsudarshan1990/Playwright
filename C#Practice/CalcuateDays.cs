namespace ConsoleApplications
{
	public class CalculateDays
	{
		private static void Main()
		{
			Console.WriteLine(CalculateDaysFromBirthDate(new DateTime(2000, 1, 1)));

		}

		public static int CalculateDaysFromBirthDate(DateTime birthdate)
		{
			var numDays = (DateTime.Now - birthdate).Days;
			return numDays;
		}
	}
}
