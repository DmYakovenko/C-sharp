namespace Pz1
{
	internal class Ex4
	{
		private int M = 45;
		private void Print(int[] Arr, int Size)
		{
			foreach (int i in Arr)
			{
				Console.Write(i + "\t");
			}
		}
		private void Yfill(int[] X, int[] Y, int N, int M)
		{
			int k = 0;
			for (int i = 0; i < N; i++)
			{
				if (Math.Abs(X[i]) > M)
				{
					Y[k] = X[i];
					k++;
				}
			}
		}
		public void Exercise(int N)
		{
			Random random = new Random();

			int[] X = new int[N];

			for (int i = 0; i < N; i++)
			{
				X[i] = random.Next() % 201 - 100;
			}

			Console.Write("X: ");
			Print(X, N);

			int P = 0;

			foreach (int i in X)
			{
				if (Math.Abs(i) > M)
					P++;
			}

			int[] Y = new int[P];

			Yfill(X, Y, N, M);

			Console.Write("\nY: ");
			Print(Y, P);
		}
	}
}