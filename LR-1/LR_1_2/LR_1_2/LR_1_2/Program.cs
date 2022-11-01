namespace LR_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            bool flag;

            x = int.Parse(System.Console.ReadLine());
            y = int.Parse(System.Console.ReadLine());
            z = int.Parse(System.Console.ReadLine());

            flag = (x > z);
            System.Console.WriteLine(flag);

            flag = (x+5 > y);
            System.Console.WriteLine(flag);

            flag = ((z > x) || (y > x));
            System.Console.WriteLine(flag);
        }
    }
}