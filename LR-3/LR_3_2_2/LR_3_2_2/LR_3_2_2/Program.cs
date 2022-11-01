namespace LR_3_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, sum, some_n;

            a = 11;
            some_n = a;
            sum = 0;

            n = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("");

            for (int i = 0; i < (n / a); i++)
            {
                sum = sum + some_n;
                some_n += 11;
                System.Console.WriteLine(sum);
            }
        }
    }
}