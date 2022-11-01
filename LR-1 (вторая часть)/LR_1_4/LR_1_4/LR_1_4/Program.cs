namespace LR_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            
            name = System.Console.ReadLine();
            surname = System.Console.ReadLine();
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"{name}, {surname}, {age}");
        }
    }
}