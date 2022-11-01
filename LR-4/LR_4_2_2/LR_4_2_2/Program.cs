namespace LR_4_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {135, 134, -130, 120, -33, -3, -9, 34 };
            int count;

            count = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    count += 1;
                }
            }

            System.Console.WriteLine($"Положительных чисел: {count}");
        }
    }
}