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


            Console.WriteLine("\n\n");



            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            c1.radius = 50;
            Console.WriteLine(c1.radius);

            Circle c2 = new Circle();
            Console.WriteLine(c2.radius);

            c2.radius = 100;
            Console.WriteLine(c1.radius);



            string s1 = "hello";
            string s2 = s1;

            s2 = "world";
            Console.WriteLine(s1);  // hello
            Console.WriteLine(s2);  // world


            int j = 5;
            int k = j;

            k = 10;


            string str = null;
            int num = Convert.ToInt32(str);
            //int num = int.Parse(str);
            Console.WriteLine(num);


            double amount = 234324.3242;
            Console.WriteLine(amount.ToString("C"));

            double discount = 0.15;
            Console.WriteLine(discount.ToString("P0"));


            int? z = null;
        }
    }

    class Circle
    {
        public double radius;
    }
}
