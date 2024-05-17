using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_decimal
{
    internal class Program
    {
        public static bool IsDigit(char ch)
        {
            return ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9';
        }

        public static bool IsNumber()
        {
            bool is_number = true;

            ConsoleKeyInfo key = Console.ReadKey();
            int cnt = 0;
            bool start_with_zero = false, last_is_zero = false;
            bool plusMinus = false, last_plus_minus = false;
            bool decimalPoint = false, last_is_decimal_point = false;
            while(key.Key != ConsoleKey.Enter)
            {
                char ch = Convert.ToChar(key.Key);

                if (ch == '0')
                {
                    if (cnt == 0)
                        start_with_zero = true;
                    
                    // Check 2 zeros at the beggining
                    else if (cnt == 1 && start_with_zero)
                        is_number = false;

                    // Check 2 zeros after +/-
                    else if (cnt == 2 && plusMinus && last_is_zero)
                        is_number = false;

                    last_is_zero = true;
                    last_plus_minus = false; // reset last char = +/=
                }

                // '+' / '-'
                else if (key.Key == ConsoleKey.OemPlus || key.Key == ConsoleKey.OemMinus)
                {
                    // Check for +/- not in the beggining (1st)
                    if (cnt > 0)
                        is_number = false;

                    else if (cnt == 0)
                    {
                        plusMinus = true;
                        last_plus_minus = true;
                    }
                }

                // '.'
                else if (key.Key == ConsoleKey.OemPeriod)
                {
                    // Check if period not in right spot
                    if (cnt == 0 || decimalPoint || last_plus_minus)
                        is_number = false;

                    else
                    {
                        decimalPoint = true;
                        last_is_decimal_point = true;
                    }
                }

                else
                {
                    // Check if input is digit
                    if (!IsDigit(ch))
                        is_number = false;

                    // Check for beggining zero with digit after (e.g. "05.2")
                    if (cnt == 1 && last_is_zero)
                        is_number = false;

                    last_plus_minus = false;
                    last_is_decimal_point = false;
                    last_is_zero = false;
                }

                key = Console.ReadKey();
                cnt++;
            }

            // Check if last input was a period
            if (last_is_decimal_point)
                is_number = false;

            return is_number;
        }

        static void Main(string[] args)
        {
            while(true)
                Console.WriteLine(IsNumber());
        }
    }
}