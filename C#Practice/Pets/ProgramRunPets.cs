namespace ConsoleApplications.Pets
{
	public class ProgramRunPets
	{
		private static void Main()
		{
			List<IPet> pets = new List<IPet>
			{
				new Dog(),
				new Cat()

			};

			foreach (IPet pet in pets)
			{
				Console.WriteLine(pet.TalkToOwner());
			}


		}
	}
}
