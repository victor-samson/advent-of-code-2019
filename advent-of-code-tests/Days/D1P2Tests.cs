using advent_of_code.Puzzles;
using NUnit.Framework;

namespace advent_of_code_tests.Days
{
    [TestFixture]
    public class D1P2Tests
    {
        [TestCase(14, 2)]
        [TestCase(1969, 966)]
        [TestCase(100756, 50346)]
        public void CalculateFuelRequired(decimal mass, int expected)
        {
            // Arrange.
            // Act.
            var result = D1P2.CalculateRecursiveFuelRequired(mass);

            // Assert.
            Assert.AreEqual(expected, result);
        }
    }
}
