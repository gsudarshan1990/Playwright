namespace ConsoleApplications
{
	public class ExampleClassObject
	{
		public static void Main()
		{
			Example e = new Example(1, 2.5);
			Console.WriteLine($"n:{e.n}");
			Console.WriteLine($"d:{e.d}");
			Console.WriteLine(e);

			Example e1 = new Example();
			e1.n = 25;
			e1.d = 3.14;
			Console.WriteLine($"n:{e1.n}");
			Console.WriteLine($"d:{e1.d}");
			Console.WriteLine(e1);

			Example e2 = new Example(3, 10.5);
			e = e2;
			Console.WriteLine(e);
			e2.n = 77;
			Console.WriteLine(e2);
			Console.WriteLine(e);
		}
	}
}
