namespace LR_6_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Hms_to_secs(int hours, int minutes, int seconds, long sum) {

                sum = sum + (hours * 3600);
                sum = sum + (minutes * 60);
                sum += seconds;
                System.Console.WriteLine(sum);
            };

            while (true)
            {
                Hms_to_secs(int.Parse(System.Console.ReadLine()), int.Parse(System.Console.ReadLine()), int.Parse(System.Console.ReadLine()), 0 );
            }
        }
    }
}