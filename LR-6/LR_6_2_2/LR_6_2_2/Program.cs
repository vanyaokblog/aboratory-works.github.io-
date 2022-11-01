namespace LR_6_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance1, distance2;

            distance1 = int.Parse(System.Console.ReadLine());
            distance2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine();

            static void countDist(int distance1, int distance2) {
                if (distance1 > distance2) {
                    System.Console.WriteLine(distance1);
                }
                else {
                    System.Console.WriteLine(distance2);
                }
            };

            countDist(distance1, distance2);
        }
    }
}