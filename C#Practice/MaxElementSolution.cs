namespace ConsoleApplications
{
	public class MaxElementSolution
	{

		public int _findMaxElement(int[] elements)
		{
			int maxElement = elements[0];
			foreach (int element in elements)
			{
				if (element > maxElement)
					maxElement = element;
			}

			return maxElement;
		}

		public static void Main()
		{
			MaxElementSolution solution = new MaxElementSolution();

			int[] items = { 121, 32, 45, 300, 41, 50, 100, 200, 11, 75 };

			Console.WriteLine();

			foreach (int item in items)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			Console.WriteLine("The Max Element in the above values is " + solution._findMaxElement(items));


		}
	}
}
