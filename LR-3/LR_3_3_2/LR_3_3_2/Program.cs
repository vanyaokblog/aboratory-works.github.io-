namespace LR_3_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            System.Console.WriteLine("Введите длину отрезка A: ");
            a = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Введите длину отрезка B: ");
            b = int.Parse(System.Console.ReadLine());
            sum = 0;

            for (int i = 0; i < a+1; i++)
            {
                if (sum + b > a)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine($"Остаточная длина от отрезка A = {a-sum}");
                    break;
                }

                else if (sum + b < a)
                {
                    sum = sum + b;
                }


            }

        }
    }
}