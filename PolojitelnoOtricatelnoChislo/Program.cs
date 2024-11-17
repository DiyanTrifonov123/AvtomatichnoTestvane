namespace PolojitelnoOtricatelnoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            PositiveNegative test = new PositiveNegative();
            Console.WriteLine(test.IsPositive(num));
        }
    }
}