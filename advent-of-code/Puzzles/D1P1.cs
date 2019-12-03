using System;
using System.Collections.Generic;
using System.IO;

namespace advent_of_code.Puzzles
{
    public class D1P1 : IPuzzle
    {
        public int Result { get; private set; }
        private List<decimal> _masses { get; set; }

        public D1P1()
        {
            _masses = new List<decimal>();
            CalculateAnswer();
        }

        public void CalculateAnswer()
        {
            ReadPuzzleInputFromFile();
            var result = 0;
            foreach (var mass in _masses)
            {
                result += CalculateFuelRequired(mass);
            }
            Result = result;
        }

        public void ReadPuzzleInputFromFile()
        {
            string line;

            using (var file = new StreamReader(@"c:\victor\advent-of-code-2019\advent-of-code\Inputs\D1P1.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    _masses.Add(Decimal.Parse(line));
                }
            }
        }

        public static int CalculateFuelRequired(decimal mass)
        {
            return (int)Math.Truncate(mass / 3) - 2;
        }
    }
}
