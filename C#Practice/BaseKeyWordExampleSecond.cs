namespace ConsoleApplications
{

	internal class BaseClass
	{
		private int i;

		public BaseClass() => Console.WriteLine("In the BaseClass");

		public BaseClass(int n)
		{
			i = n;
			Console.WriteLine($"In the Baseclass with int {i}");

		}
	}

	internal class DerivedClass : BaseClass
	{

		public DerivedClass() : base()
		{

		}

		public DerivedClass(int n) : base(n)
		{

		}

	}

	public class BaseKeyWordExampleSecond
	{
		private static void Main()
		{
			DerivedClass d = new DerivedClass();
			DerivedClass c = new DerivedClass(3);
		}
	}
}
