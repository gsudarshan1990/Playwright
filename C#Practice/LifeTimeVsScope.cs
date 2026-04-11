namespace ConsoleApplications
{
	public class LifeTimeVsScope
	{
		private int instanceVariable;

		public LifeTimeVsScope(int value)
		{
			instanceVariable = value;
		}

		public static void Main()
		{
			int x = 5;
			LifeTimeVsScope lifeTimeVsScope = new LifeTimeVsScope(8);
			ScopeHolder();
			Console.WriteLine("Still Alive {0},{1}", x, lifeTimeVsScope.instanceVariable);
		}

		private static void ScopeHolder()
		{
			Console.WriteLine(" Both X and instance value not live here");
		}
	}
}
