namespace ConsoleApplications
{
	public class ProgramForLoops
	{
		private static void Main()
		{

			Console.Title = "Example of For loops";

			Console.WriteLine("Print 0 to 9");

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("Print 9 to 0");

			for (int j = 9; j > -1; j--)
			{
				Console.WriteLine(j);
			}

		}
	}
}
