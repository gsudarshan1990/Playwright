namespace ConsoleApplications
{
	public class Contact
	{
		public string name { get; set; }
		public string phone { get; set; }
		public string email { get; set; }

		public Contact()
		{

		}

		public Contact(string fullName, string phoneNumber, string emailAddress)
		{
			name = fullName;
			phone = phoneNumber;
			email = emailAddress;
		}

		public void print()
		{
			Console.WriteLine($"Name : {name}, phoneNumber: {phone}, email:{email}");
		}

		public void printSecondFormat()
		{
			Console.WriteLine(@"Name : {0}, phoneNumber: {1}, email:{2}", name, phone, email);
		}

		public override string ToString()
		{
			return string.Format("Name : {0}\n Phone Number : {1}\n Email : {2}", name, phone, email);
		}
	}
}
