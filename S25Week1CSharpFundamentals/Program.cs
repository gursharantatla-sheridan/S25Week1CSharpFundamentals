namespace S25Week1CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int @double = 5;

            int i = 5;
            double d = 5.5;
            float f = 5.5F;
            decimal m = 5.5M;
            long l = 454332L;

            var n = 5;


            Console.WriteLine(@"hello\nworld");
            Console.WriteLine("\n\n");


            int cars = 4, trucks = 6, bikes = 2;

            // string concatenation
            Console.WriteLine("There are " + cars + " cars, " + trucks + " trucks and " + bikes + " bikes");

            // string interpolation
            Console.WriteLine($"There are {cars} cars, {trucks} trucks and {bikes} bikes");
        }
    }
}
