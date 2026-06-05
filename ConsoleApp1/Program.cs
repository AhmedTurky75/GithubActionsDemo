namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int result = MathHelper.Sum(a, b);

            Console.WriteLine($"Sum({a}, {b}) = {result}");
        }
    }
}
