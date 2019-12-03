using advent_of_code.Puzzles;
using NUnit.Framework;

namespace advent_of_code_tests.Days
{
    [TestFixture]
    public class D1P1Tests
    {
        [TestCase(12, 2)]
        [TestCase(14, 2)]
        [TestCase(1969, 654)]
        [TestCase(100756, 33583)]
        public void CalculateFuelRequired(decimal mass, int expected)
        {
            // Arrange.
            // Act.
            var result = D1P1.CalculateFuelRequired(mass);

            // Assert.
            Assert.AreEqual(expected, result);
        }
    }
}
