namespace ConsoleApplications
{

	public class Clock
	{
		private static string time = "00:00";

		private static int hours, minutes;

		public void setTime(int hours, int minutes)
		{
			time = hours.ToString() + ":" + minutes.ToString();
		}

		public string GetTimeString()
		{
			return time;
		}

		public void Tick()
		{
			string[] values = time.Split(":");
			int.TryParse(values[0], out hours);
			int.TryParse(values[1], out minutes);

			string shours = "";
			string sminutes = "";

			if (minutes >= 0 && minutes <= 59)
			{
				minutes = minutes + 1;
			}

			if (minutes == 60)
			{
				minutes = 0;
				hours = hours + 1;
			}
			if (hours == 24 & minutes == 0)
			{
				hours = 0;
			}

			if (hours >= 0 && hours < 10)
			{
				shours = "0" + hours.ToString();
			}
			else
			{
				shours = hours.ToString();
			}

			if (minutes >= 0 && minutes < 10)
			{
				sminutes = "0" + minutes.ToString();
			}
			else
			{
				sminutes = minutes.ToString();
			}
			time = shours + ":" + sminutes;
		}
	}
	internal class ClockExample
	{
		public static void Main()
		{
			Clock c = new Clock();
			Console.WriteLine("Midnight " + c.GetTimeString());
			c.setTime(23, 58);
			Console.WriteLine("Before Midnight " + c.GetTimeString());
			for (int i = 0; i < 4; i++)
			{
				c.Tick();
				Console.WriteLine("Tick " + c.GetTimeString());
			}

		}
	}
}
