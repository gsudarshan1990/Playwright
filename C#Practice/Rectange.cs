namespace ConsoleApplications
{
	public class Rectangle
	{
		private double length;
		private double breadth;

		public Rectangle(double l, double b)
		{
			length = l;
			breadth = b;
		}

		public double GetArea()
		{
			return length * breadth;
		}

		private static void Main()
		{
			Rectangle r = new Rectangle(12.3d, 8.4d);
			r.GenerateArea();
		}

		private void GenerateArea()
		{
			double area = length * breadth;
			Console.WriteLine($"The area of the rectangle is: {area}");
		}
	}
}
