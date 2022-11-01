namespace LR_7_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 , num3;

            System.Console.WriteLine("Диапазон чисел от: ");
            num1 = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Диапазон чисел до: ");
            num2 = int.Parse(System.Console.ReadLine());

            Random rnd = new Random();
            int value = rnd.Next(num1, num2+1);

            System.Console.WriteLine("Введите число: ");
            num3 = int.Parse(System.Console.ReadLine());

            while (true)
            {
                if (num3 == num3)
                {
                    System.Console.WriteLine("Вы отгадали число, поздравляю!");
                    break;
                }

                else {
                    System.Console.WriteLine("Неверно, попробуйте снова");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Введите число: ");
                    num3 = int.Parse(System.Console.ReadLine());
                }
            }
        }

    }
}