namespace LR_4_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {135, 134, 130, 120, 33, 3, 9, 34 };
            int max_n;

            max_n = -1;

            foreach (int num in array)
            {
                if (num > max_n) { 
                    max_n = num;
                }
            }

            foreach (int num in array)
            {
                System.Console.WriteLine($"{num} / {max_n} = {num/max_n}");
            }

        }
    }
}