namespace LR_6_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Power(double n, int p)
            {
                System.Console.WriteLine(Math.Pow(n, p));

            };

            Power(double.Parse(System.Console.ReadLine()), int.Parse(System.Console.ReadLine()));
            
        }
    }
}