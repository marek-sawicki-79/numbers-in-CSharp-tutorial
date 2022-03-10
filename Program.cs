using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkWithIntegers();
            // OrderPrecedence();
            // WorkWithDoubles();
            // WorkWithDecimal();

            void WorkWithIntegers()
            {
                int a = 18;
                int b = 6;
                int c = a + b;
                Console.WriteLine(c);

                // substraction
                int d = a - b;
                Console.WriteLine(d);

                // multiplication
                int e = a * b;
                Console.WriteLine(e);

                // division
                int f = a / b;
                Console.WriteLine(f);

                // multiple math operations

                int g = c + b - a * f / e;
                Console.WriteLine(g);
            }
            void OrderPrecedence()
            {
                int a = 5;
                int b = 4;
                int c = 2;
                int d = a + b * c;
                Console.WriteLine(d);

                d = (a + b) * c;
                Console.WriteLine(d);

                d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
                Console.WriteLine(d);

                int e = 7;
                int f = 4;
                int g = 3;
                int h = (e + f) / g;
                Console.WriteLine(h);
            }
            /*
             int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
           
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            */
            void WorkWithDoubles()
            {
                double a = 78;
                double b = 29;
                double c = 157;
                double d = a + b * c / (a + b);
                Console.WriteLine(d);

                d = (a + b) * c;
                Console.WriteLine(d);

                d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
                Console.WriteLine(d);

                double e = 7;
                double f = 4;
                double g = 3;
                double h = (e + f) / g;
                Console.WriteLine(h);
            }

            void WorkWithDecimal()
            {
                decimal min = decimal.MinValue;
                decimal max = decimal.MaxValue;
                Console.WriteLine($"The range of the decimal type is {min} to {max}");

                double a = 1.0;
                double b = 3.0;
                Console.WriteLine(a / b);

                decimal c = 1.0m;
                decimal d = 3.0m;
                Console.WriteLine(c / d);
            }
            double r = 2.5;
            double circleField = Math.PI * r * r;
            Console.WriteLine($"The field of a circle with 2,5 radius equals {circleField}.");
        }
    }
}
