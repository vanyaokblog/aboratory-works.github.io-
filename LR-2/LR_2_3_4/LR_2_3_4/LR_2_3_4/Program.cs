namespace LR_2_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum, sum2;
            string num_str;

            sum = 0;
            sum2 = 0;

            System.Console.WriteLine("Введите шестизначное число:");

            num_str = System.Console.ReadLine();
            num = int.Parse(num_str);

            if (num_str.Length < 6)
            {
                System.Console.WriteLine("Число не шестизначное");
            }

            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i >= 3)
                    {
                        sum2 = sum2 + int.Parse(num_str[i].ToString());

                    }
                    else
                    {
                        sum = sum + int.Parse(num_str[i].ToString());
                    }
                }

                if (sum == sum2)
                {
                    System.Console.WriteLine("Число является счастливым");
                }
                else
                {
                    System.Console.WriteLine("Число является не счастливым");
                }
            }
        }
    }
}