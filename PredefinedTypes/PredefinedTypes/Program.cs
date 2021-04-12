using System;

namespace PredefinedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            bool isValidName = (p.Name != null) &&
                                (p.Name.Length > 0);

            if (isValidName)
            {
                p.SayHowManyLetters();
            }
            else
            {
                Console.WriteLine("Hey, the person's name is not valid!");
            }
        }

        private static void Boolean_ConversionFromString()
        {
            string text = "True";

            if (bool.TryParse(text, out bool valueAsBool))
            {
                Console.WriteLine("String is convertible to boolean");
                Console.WriteLine(valueAsBool);
            }
            else
            {
                Console.WriteLine("String is NOT convertible to boolean");
            }
        }

        private static void Boolean_EvaluateExpression()
        {
            int nr = 25;

            bool isEven = nr % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("Number " + nr + " is even");
            }
            else
            {
                Console.WriteLine("Number " + nr + " is odd");
            }
        }

        private static bool ReturnBool(bool value)
        {
            Console.WriteLine("Called ReturnBool(" + value + ")");
            return value;
        }

        private static void Boolean_ConditionalVsBitwiseOperators()
        {
            Console.WriteLine("Bitwise AND:");

            bool condition1 = ReturnBool(false) & ReturnBool(true);
            Console.WriteLine(condition1);

            Console.WriteLine("-----------------");

            bool condition2 = ReturnBool(false) && ReturnBool(true);
            Console.WriteLine(condition2);
        }
    }
}
