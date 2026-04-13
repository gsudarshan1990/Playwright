namespace ConsoleApplications
{
	internal abstract class Shape()
	{
		public abstract int GetArea();
	}

	internal class Square : Shape
	{
		private int _side;

		public Square(int n) => _side = n;

		public override int GetArea()
		{
			return _side * _side;
		}
	}

	internal class RectanlgeTwo : Shape
	{
		private int _length, _breadth;

		public RectanlgeTwo(int a, int b)
		{
			_length = a;
			_breadth = b;
		}

		public override int GetArea()
		{
			return _length * _breadth;
		}
	}

	public class OverRideExample
	{
		private static void Main()
		{
			Square s = new Square(8);
			Console.WriteLine($"Area of square is {s.GetArea()}");

			RectanlgeTwo r = new RectanlgeTwo(8, 5);

			Console.WriteLine($"Area of the rectangle is {r.GetArea()}");

			Console.ReadKey();
		}
	}
}
