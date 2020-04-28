using System;

namespace functions_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineBreak = "==========================";

            Task1();
            System.Console.WriteLine(lineBreak);
            Task2();
            System.Console.WriteLine(lineBreak);
            Task3();
            System.Console.WriteLine(lineBreak);
            Task4();
            System.Console.WriteLine(lineBreak);
            Task5();
            System.Console.WriteLine(lineBreak);
            Task6();
            System.Console.WriteLine(lineBreak);
            Task7();
            System.Console.WriteLine(lineBreak);
            Task8();
            System.Console.WriteLine(lineBreak);
            Task9();
            System.Console.WriteLine(lineBreak);
            Task10();
            System.Console.WriteLine(lineBreak);
        }
        static void Task1()
        {
            System.Console.WriteLine("Welcome friends!");
            System.Console.WriteLine("Have a nice day!");
        }
        static void Task2()
        {
            System.Console.Write("What's your name?: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Welcome friend " + name);
            System.Console.WriteLine("Have a nice day!");
        }
        static void Task3()
        {
            System.Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.WriteLine("The sum of these two numbers is: " + (y + x));
        }
        static void Task4()
        {
            System.Console.Write("Input a string: ");
            string str = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                // This got me for a little, why does this only work with single brackets not double? e.g. (str[i] == " ")
                if (str[i] == ' ')
                {
                    counter++;
                }
            }
            System.Console.WriteLine("This string has " + counter + " spaces");
        }
        static void Task5()
        {
            int[] numbers = new int[5];
            int sum = 0;

            System.Console.Write("Enter 5 numbers and I'll return their sum:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            System.Console.WriteLine("The sum of your numbers is " + sum);
        }
        static void Task6()
        {
            int x, y, temp;

            System.Console.WriteLine("Enter two numbers so I can swap their values");
            System.Console.Write("x is equal to: ");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("y is equal to: ");
            y = int.Parse(Console.ReadLine());
            System.Console.WriteLine("-----------------");

            temp = x;
            x = y;
            y = temp;

            System.Console.WriteLine("x now equals: " + x);
            System.Console.WriteLine("y now equals: " + y);
        }
        static void Task7()
        {
            System.Console.WriteLine("Enter two numbers, the first number will be calculated to the power of the second");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double ans = Math.Pow(x, y);

            System.Console.WriteLine(x + "^" + y + " is equal to: " + ans);
        }
        static void Task8()
        {

        }
        static void Task9()
        {
            System.Console.Write("Enter a number and I'll tell you if it's a prime number or not: ");
            int x = int.Parse(Console.ReadLine());

            int prime = 1;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prime = 0;
                    break;
                }
            }
            if (prime == 1 && x > 2)
            {
                System.Console.WriteLine(x + " is a prime number.");
            }
            else
            {
                System.Console.WriteLine(x + " is not a prime number.");
            }
        }
        static void Task10()
            {
                System.Console.WriteLine("Enter a multiple digit number and I'll give you the sum of the individual digits in that number. *sprinkles confusion dust*");
                int input = int.Parse(Console.ReadLine());

                int sum = 0;
                int input1 = input;

                while (input1 != 0)
                {
                    int remainder = input1 % 10;
                    sum += remainder;
                    input1 = input1 / 10;
                }

                System.Console.WriteLine("The sum of all the digits in " + input + " is equal to " + sum);
            }

    }
}

