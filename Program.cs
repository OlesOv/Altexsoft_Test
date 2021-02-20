using System;

namespace Altexsoft_Test
{
    class Program
    {
        static bool isLucky(string number)
        {
            if (number.Length % 2 == 1) number = '0' + number;
            int firstHalf = 0;
            for (int i = 0; i < number.Length / 2; i++)
            {
                firstHalf += Convert.ToInt32(number[i]);
            }
            int secondHalf = 0;
            for (int i = number.Length / 2; i < number.Length; i++)
            {
                secondHalf += Convert.ToInt32(number[i]);
            }
            return firstHalf == secondHalf;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter q for exit.\nOr enter a ticket number: ");
            var input = Console.ReadLine();
            while (input != "q")
            {
                try
                {
                    if (input.Length < 4 || input.Length > 8) throw new FormatException();
                    Int32.Parse(input);
                    if (isLucky(input))
                    {
                        Console.WriteLine("This ticket number is lucky\n");
                    }
                    else
                    {
                        Console.WriteLine("This ticket number is not lucky\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format\n");
                }
                Console.Write("Enter q for exit.\nOr enter a ticket number: ");
                input = Console.ReadLine();
            }
        }
    }
}
