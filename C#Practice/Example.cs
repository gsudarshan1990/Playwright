namespace ConsoleApplications
{
	public class Example
	{
		public int n { get; set; }
		public double d { get; set; }

		public Example() { }

		public Example(int a, double b)
		{
			n = a;
			d = b;
		}

		public override string ToString()
		{
			return "Example : n=" + n + ", d=" + d;
		}
	}
}
