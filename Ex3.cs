namespace Pz1
{
	internal class Ex3
	{
		private void Print(int[] numbers, int N)
		{
			foreach (int i in numbers)
			{
				Console.WriteLine(i + "\t");
			}
		}

		private void MinMax(int[] numbers, int N)
		{
			int min = int.MaxValue, max = int.MinValue;

			for(int i = 0; i < N; i++)
			{
				if (numbers[i] < min)
					min = numbers[i];
				else if (numbers[i] > max)
					max = numbers[i];
			}

			Console.WriteLine($"мін: {min}\nмакс: {max}");
		}

		public void Exercise(int N)
		{
			Random random = new Random();

			int[] numbers = new int[N];

			for(int i = 0; i < N; i++)
			{
				numbers[i] = random.Next() % 101;
			}

			Print(numbers, N);

			MinMax(numbers, N);
		}
	}
}
