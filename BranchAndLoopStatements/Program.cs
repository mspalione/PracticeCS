using System;

namespace BranchAndLoopStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if/else statements
            int a = 5;
            int b = 6;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int aa = 5;
            int bb = 3;
            int cc = 4;
            if (aa + bb > 10)
            { 
                    Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
            
            if ((aa + bb + cc > 10) && (aa == bb))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((aa + bb + cc > 10) || (aa == bb))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            // while loops

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // for loops

            for (int counterL = 0; counterL < 10; counterL++)
            {
                Console.WriteLine($"Hello World! The counter is {counterL}");
            }

            // todo
            // find the sum of all integers 1 through 20 
            // that are divisible by 3

            double sum = 0;
            for (double c = 1; c < 21; c++)
            {
                if (c % 3 == 0)
                {
                    sum = sum + c;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
