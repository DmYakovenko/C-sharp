namespace Pz1
{
	internal class Ex2
	{
		private double a = 5;
		private double b = 8;
		private double c = 10;
		private double Perimeter(double a, double b, double c)
		{
			return a + b + c;
		}

		private double Area(double p, double a, double b, double c)
		{
			return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
		}

		private void Type(double a, double b, double c)
		{
			if (a == b && b == c)
			{
				Console.WriteLine("Трикутник ріносторонній");
			}
			else if (a == b || b == c || c == a)
			{
				Console.WriteLine("Трикутник рівнобедренний");
			}
			else
			{
				Console.WriteLine("Просто трикутник");
			}
		}
		public void Exercise()
		{

			if (((a + b) < c || (b + c) < a || (c + a) < b) || (a <= 0 || b <= 0 || c <= 0))
			{
				Console.WriteLine("Трикутника не існує");
				return;
			}

			Console.WriteLine("Периметр трикутника: " + (Perimeter(a, b, c)));

			double p = Perimeter(a, b, c) / 2;
			Console.WriteLine("Площа трикутника: " + Area(p, a, b, c));

			Type(a, b, c);
		}
	}
}
