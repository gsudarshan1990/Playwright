namespace ConsoleApplications
{
	public class PrintContact
	{
		public static void Main()
		{
			Contact c1 = new Contact("Rakesh", "993-123-7686", "rakesh@gmail.com");
			Contact c2 = new Contact("Somesh", "913-139-7863", "Somesh@yahoo.com");
			Contact c3 = new Contact("Sachin", "993-543-8941", "sachin@rediffmail.com");

			Console.WriteLine("Name" + c1.name);
			Console.WriteLine("Phone" + c1.phone);
			Console.WriteLine("Email" + c1.email);
			Console.WriteLine();
			c2.print();
			Console.WriteLine();
			c3.printSecondFormat();
			Console.WriteLine();
			Contact c4 = new Contact();
			c4.name = "Rahul";
			c4.phone = "991-323-2343";
			c4.email = "rahul2012@gmail.com";

			List<Contact> l1 = new List<Contact>() { c1, c2, c3, c4 };
			foreach (Contact c in l1)
			{
				Console.WriteLine(c);
			}
					}
	}
}
