namespace LR_2_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(System.Console.ReadLine());
            b = int.Parse(System.Console.ReadLine());
            c = int.Parse(System.Console.ReadLine());

            if (a > b && a > c)
            {
                if (Math.Pow(a,2) == Math.Pow(b,2) + Math.Pow(c, 2))
                {
                    System.Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    System.Console.WriteLine("Треугольник не является прямоугольным");
                }
            }

            if (b > c && b > a)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                {
                    System.Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    System.Console.WriteLine("Треугольник не является прямоугольным");
                }
            }

            if (c > b && c > a)
            {
                if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                {
                    System.Console.WriteLine("Треугольник является прямоугольным");
                }
                else
                {
                    System.Console.WriteLine("Треугольник не является прямоугольным");
                }
            }
        }
    }
}