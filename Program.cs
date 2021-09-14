using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int newNum;
            Console.WriteLine("*********************");
            Console.WriteLine("* FizzBuzz Exercise *");
            Console.WriteLine("*********************\n\n");
            do
            {
                Console.WriteLine("Please enter a number 1 to 100");
                response = Console.ReadLine();

                if (!int.TryParse(response, out newNum))
                {
                    Console.WriteLine("I'm sorry,that was not a valid input. Please try again.");
                }
            }
            while (newNum < 1);

            Check(newNum);
        }

        public static void Check(int newNum)
        {
            if (newNum % 3 == 0)
            {
                if (newNum % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                }
                else
                {
                    Console.WriteLine("Fizz!");
                }
            }
            else if (newNum % 5 == 0)
            {
                Console.WriteLine("Buzz!");
            }
        }
    }
}
