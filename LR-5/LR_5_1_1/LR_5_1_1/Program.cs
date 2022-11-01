namespace LR_5_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, mult = 1;

            System.Console.WriteLine("Введите кол-во строк: ");
            int n = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Введите кол-во столбцов: ");
            int m = int.Parse(System.Console.ReadLine());

            int[,] array = new int[n, m];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[i, x] = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine($"Строк: {i+1}, столбцов: {x+1}");
                }
            }

            System.Console.WriteLine();

            foreach (int i in array)
            {
                sum += 1;
            }

            System.Console.WriteLine($"Сумма всех элементов равна {sum}");
            System.Console.WriteLine();

            foreach (int i in array)
            {
                mult *= i;
            }

            System.Console.WriteLine($"Произведение всех элементов равно {mult}");
        }
    }
}