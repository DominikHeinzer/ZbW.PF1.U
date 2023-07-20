﻿namespace MB07.ZifferSortierAufgabe
{
    public static class ZifferMaschine
    {

        static void SortDigitsVariante1()
        {
            int number;
            do
            {
                Console.Write("Gebe eine beliebige Zahl < 2'000'000'000 ein: ");
            } while (!int.TryParse(Console.ReadLine(), out number));

            var numberOfDigits = Math.Floor(Math.Log10(number) + 1);
            var currentDigitForTest = 1;
            while (currentDigitForTest <= 9)
            {
                if (!(currentDigitForTest == 0 || currentDigitForTest == 5))
                {
                    for (var i = 0; i < numberOfDigits; i++)
                    {
                        var currentDigit = (number / (int)Math.Pow(10, i)) % 10;
                        if (currentDigit == currentDigitForTest)
                        {
                            Console.Write(currentDigit);
                        }
                    }
                }
                currentDigitForTest++;
            }
        }

        public static void SortDigitsVariante2()
        {
            int number;
            do
            {
                Console.Write("Gebe eine beliebige Zahl < 2'000'000'000 ein: ");
            } while (!int.TryParse(Console.ReadLine(), out number));

            for (int i = 1; i <= 9; i++)
            {
                if (SortDigitsVariante2(number, i))
                {
                    Console.Write(i);
                }
            }
        }

        private static bool SortDigitsVariante2(int number, int digit)
        {
            if (digit == 0 || digit == 5)
            {
                return false;
            }

            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit == digit)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }


    }
}
