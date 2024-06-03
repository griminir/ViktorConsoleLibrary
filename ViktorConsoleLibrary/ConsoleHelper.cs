using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViktorConsoleLibrary
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static string RequestString(this string message)
        {
            var output = "";


            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        private static int RequestInt(this string message, bool useLowerUpper, int lower = 0, int upper = 0)
        {
            var output = 0;
            var isValidAge = false;
            var isInValidRange = true;

            while (isValidAge == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidAge = int.TryParse(Console.ReadLine(), out output);

                if (useLowerUpper == true)
                {
                    isInValidRange = (output >= lower && output <= upper);
                    //if (output <= lower && output >= upper)
                    //{
                    //    isInValidRange = true;
                    //}
                    //else
                    //{
                    //    isInValidRange = false;
                    //}
                }
            }

            return output;
        }

        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
        }

        public static int RequestInt(this string message, int lower, int upper)
        {
            return message.RequestInt(true, lower, upper);
        }
    }
}
