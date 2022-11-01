namespace LR_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            num1 = int.Parse(System.Console.ReadLine());
            num2 = int.Parse(System.Console.ReadLine());

            (num1, num2) = (num2, num1);

            System.Console.WriteLine($"{num1}, {num2}");
        }
    }
}