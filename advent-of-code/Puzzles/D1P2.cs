using System;
using System.Collections.Generic;
using System.IO;

namespace advent_of_code.Puzzles
{
    public class D1P2 : IPuzzle
    {
        public int Result { get; private set; }
        private List<decimal> _masses { get; set; }

        public D1P2()
        {
            _masses = new List<decimal>();
            ReadPuzzleInputFromFile();
            CalculateAnswer();
        }

        public void CalculateAnswer()
        {
            var result = 0;
            foreach (var mass in _masses)
            {
                result += CalculateRecursiveFuelRequired(mass);
            }
            Result = result;
        }

        public void ReadPuzzleInputFromFile()
        {
            string line;
            using (var file = new StreamReader(@"c:\victor\advent-of-code-2019\advent-of-code\Inputs\D1P2.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    _masses.Add(Decimal.Parse(line));
                }
            }
        }

        public static int CalculateRecursiveFuelRequired(decimal mass)
        {
            var result = 0;
            while (mass > 0)
            {
                var fuel = CalculateFuelRequired(mass);
                if (fuel > 0)
                {
                    result += fuel;
                }
                mass = fuel;
            }
            return result;
        }

        private static int CalculateFuelRequired(decimal mass)
        {
            return (int)Math.Truncate(mass / 3) - 2;
        }
    }
}
