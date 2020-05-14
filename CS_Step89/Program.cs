using System;

namespace CS_Step89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int mult = num1 * 50;
            Console.WriteLine("Your number times 50 is " + mult);

            Console.WriteLine("\r\nEnter a second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num2 + 25;
            Console.WriteLine("Your number plus 25 is " + add);

            Console.WriteLine("\r\nEnter a third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            double div = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + div);

            Console.WriteLine("\r\nEnter a fourth number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50 = num4 > 50;
            string msg = num4.ToString();
            if (greaterThan50 == true)
            {
                msg += " is greater than 50";
            }
            else if (greaterThan50 == false)
            {
                msg += " is less than or equal to 50";
            }
            else
            {
                msg += " is not a valid number";
            }
            Console.WriteLine(msg);

            Console.WriteLine("\r\nEnter a fifth number:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num4 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + remainder);
            Console.ReadLine();
        }
    }
}
