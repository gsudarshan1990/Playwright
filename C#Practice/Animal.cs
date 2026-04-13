namespace ConsoleApplications
{
	public class Animal
	{
		public string name;
		public List<string> gut;

		public Animal(string animalName)
		{
			name = animalName;
			gut = new List<string>();
		}

		public void Greet()
		{
			Console.WriteLine($"Hello, my name is {name}");
		}

		public void Eat(string food)
		{
			gut.Add(food);
		}

		public void Excrete()
		{
			if (gut.Count == 0)
			{
				Console.WriteLine("Empty");
			}
			else if (gut.Count > 0)
			{
				string item = gut[0];
				gut.Remove(item);
				Console.WriteLine(item);

			}
		}

		public override string ToString()
		{
			return string.Format("Animal:{0}", name);
		}
	}
}
