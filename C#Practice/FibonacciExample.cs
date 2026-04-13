namespace ConsoleApplications
{
	internal class FibonacciExample
	{
		private List<int> fibonacciNumbers = [1, 1];
		public static void Main()
		{
			FibonacciExample f = new FibonacciExample();

			for (int i = 2; i < 20; i++)
			{
				f.fibonacci();
			}

			foreach (var num in f.fibonacciNumbers)
			{
				Console.WriteLine(num);
			}

		}

		public void fibonacci()
		{
			int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
			int previoussecond = fibonacciNumbers[fibonacciNumbers.Count - 2];

			fibonacciNumbers.Add(previous + previoussecond);
		}

	}
}
