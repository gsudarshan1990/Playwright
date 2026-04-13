namespace ConsoleApplications
{
	internal class Person
	{
		protected string ssn = "444-55-6666";
		protected string name = "Ramesh Raghav Reddy";

		public virtual void GetInfo()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"SSN :{ssn}");
		}
	}

	internal class Employee : Person
	{
		public readonly string id = "ABC35FEG33H";

		public override void GetInfo()
		{
			base.GetInfo();
			Console.WriteLine($"ID:{id}");
		}

	}

	public class BaseKeyWordExample
	{
		private static void Main()
		{
			Employee E = new Employee();
			E.GetInfo();
		}
	}
}
