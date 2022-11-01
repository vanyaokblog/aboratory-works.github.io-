namespace LR_3_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;

            System.Console.WriteLine("Введите числа А и Б:");

            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            n = b - 1;
            System.Console.WriteLine();

            for (int i = a+1; i < b; i++)
            {
                System.Console.WriteLine(n);
                n -= 1;
            }

            System.Console.WriteLine($"Количество чисел: {(b-a)-1}");

        }
    }
}