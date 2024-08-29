using ProblemSolversLib;
using Xunit;

namespace ProblemSolvers.Tests;

public class SingleNumberTest
{
    public class SingleNumberTests
    {
        private readonly SingleNumber _singleNumber;

        public SingleNumberTests()
        {
            _singleNumber = new SingleNumber();
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 1, 2, 3 }, 4)]
        [InlineData(new int[] { 0, 0, 1 }, 1)]
        public void GetUniqueNumber_VariousInputs_ReturnsExpectedResult(int[] numbers, int expected)
        {
            // Act
            var result = _singleNumber.GetUniqueNumber(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }

}
