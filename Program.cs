using System;

namespace ConsoleRoman
{
    class Program
    {
        // https://leetcode.com/problems/integer-to-roman/description/
        static void Main(string[] args)
        {
            Console.WriteLine("12. Integer to Roman");
            Console.WriteLine($"3 = {IntToRoman(3)}");
            Console.WriteLine($"6 = {IntToRoman(6)}");
            Console.WriteLine($"58 = {IntToRoman(58)}");
            Console.WriteLine($"1994 = {IntToRoman(1994)}");
            Console.ReadKey();
        }

        //Example 1:
        //Input: num = 3
        //Output: "III"
        //Explanation: 3 is represented as 3 ones.

        //Example 2:
        //Input: num = 58
        //Output: "LVIII"
        //Explanation: L = 50, V = 5, III = 3.

        //Example 3:
        //Input: num = 1994
        //Output: "MCMXCIV"
        //Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

        static public string Base(int num, char X, char V, char I)
        {
            switch (num)
            {
                case 9:
                    return $"{I}{X}";
                case 8:
                    return $"{V}{I}{I}{I}";
                case 7:
                    return $"{V}{I}{I}";
                case 6:
                    return $"{V}{I}";
                case 5:
                    return $"{V}";
                case 4:
                    return $"{I}{V}";
                case 3:
                    return $"{I}{I}{I}";
                case 2:
                    return $"{I}{I}";
                case 1:
                    return $"{I}";
                default:
                    return "";
            }
        }
        static public string IntToRoman(int num)
        {
            string result = "";

            int x = num / 1000;
            int y = num % 1000;
            if (x > 0)
            {
                result += new string('M', x);
                num = y;
            }

            x = num / 100;
            y = num % 100;
            if (x > 0)
            {
                result += Base(x,'M','D','C');
                num = y;
            }

            x = num / 10;
            y = num % 10;
            if (x > 0)
            {
                result += Base(x, 'C', 'L', 'X');
                num = y;
            }

            result += Base(num, 'X', 'V', 'I');

            return result;
        }

        

    }
}
