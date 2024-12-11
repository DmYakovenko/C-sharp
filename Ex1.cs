namespace Pz1
{
    internal class Ex1
    {
        private bool Compare(int N, int Number)
        {
            if (Number >= 1 && Number <= N)
                return true;
            else
                return false;
        }
        public void Exercise(int N)
        {
            int[] Numbers = {6, 90, 12};

            foreach (int i in Numbers)
            {
                if (Compare(N, i))
                    Console.WriteLine($"{i} в діапазоні");
                else
                    Console.WriteLine($"{i} не в діапазоні");
            }
        }
    }
}
