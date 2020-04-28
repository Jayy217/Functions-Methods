using System;

namespace functions_Methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            string lineBreak = "==========================";

            //Task 1
            WelcomeFriends();
            System.Console.WriteLine(lineBreak);

            //Task 2
            System.Console.Write("What's your name?: ");
            string name = Console.ReadLine();
            Welcome(name);
            System.Console.WriteLine(lineBreak);

            //Task 3
            System.Console.WriteLine("Enter two numbers and I'll return their sum");
            System.Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.WriteLine("The sum of these two numbers is: " + Sum(x, y));
            System.Console.WriteLine(lineBreak);

            //Task 4
            System.Console.WriteLine("Type a sentence and I'll tell you how many spaces are in it.");
            string sentence = Console.ReadLine();
            System.Console.WriteLine("This sentence has " + SpaceCounter(sentence) + " spaces.");
            System.Console.WriteLine(lineBreak);



            //Task 5
            int[] nums = new int[5];

            System.Console.WriteLine("Enter 5 numbers and I'll return their sum:");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Sum5Nums(nums);

            System.Console.WriteLine(lineBreak);

            //Task 6
            System.Console.WriteLine("Enter two numbers so I can swap their values");
            System.Console.Write("x is equal to: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.Write("y is equal to: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("-----------------");

            Swap(num1, num2);

            System.Console.WriteLine(lineBreak);

            //Task 7
            System.Console.WriteLine("Enter two numbers, the first number will be calculated to the power of the second");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            System.Console.WriteLine(x + "^" + y + " is equal to: " + PowerOf(x, y));
            System.Console.WriteLine(lineBreak);

            //Task 8
            System.Console.Write("Input a number and I'll give you it's fibonacci sequence: ");
            
            int fibo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("The Fibonacci series of " + fibo + " is: " + Fibonacci(fibo));
            System.Console.WriteLine(lineBreak);

            //Task 9
            System.Console.Write("Enter a number and I'll tell you if it's a prime number or not: ");
            x = int.Parse(Console.ReadLine());

            Prime(x);

            System.Console.WriteLine(lineBreak);

            //Task 10
            System.Console.WriteLine("Enter a multiple digit number and I'll give you the sum of the individual digits in that number. *sprinkles confusion dust*");

            int bigNum = int.Parse(Console.ReadLine());

            System.Console.WriteLine("The sum of all the digits in " + bigNum + " is equal to " + BigSum(bigNum));
            System.Console.WriteLine(lineBreak);
        }
        static void WelcomeFriends()
        {
            System.Console.WriteLine("Welcome friends!");
            System.Console.WriteLine("Have a nice day!");
        }
        static void Welcome(string name)
        {
            System.Console.WriteLine("Welcome friend " + name);
            System.Console.WriteLine("Have a nice day!");
        }
        static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static int SpaceCounter(string sentence)
        {
            int counter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                // This got me for a little, why does this only work with single brackets not double? e.g. (str[i] == " ")
                if (sentence[i] == ' ')
                {
                    counter++;
                }
            }

            return counter;
        }
        static void Sum5Nums(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            System.Console.WriteLine("The sum of your numbers is " + sum);
        }
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            System.Console.WriteLine("x is now equal to " + x);
            System.Console.WriteLine("y is now equal to " + y);
        }
        static double PowerOf(int x, int y)
        {
            double ans = Math.Pow(x, y);
            return ans;
        }
        static string Fibonacci(int num)
        //Was this unorthodox to use a string here? I just found it made more sense to me, or was there another way you wanted me doing it?
        {
            int temp;
            int num1 = 0;
            int num2 = 1;
            string str = "";

            for (int i = 0; i < num; i++)
            {
                str = str + num1 + " ";
                temp = num1;
                num1 = num2;
                num2 += temp;
            }
            return str;
        
        }
        static void Prime(int x)
        {
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
        static int BigSum(int num)
        {
            int sum = 0;
            int input1 = num;

            while (input1 != 0)
            {
                int remainder = input1 % 10;
                sum += remainder;
                input1 = input1 / 10;
            }
            return sum;
        }

    }
}

