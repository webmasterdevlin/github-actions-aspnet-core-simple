using WeatherApi;
using Xunit;

namespace Tests
{
    public class CalculatorTest
    {
        private readonly Calculator _underTest = new Calculator();

        [Fact]
        public void ItShouldAddTwoNumbers()
        {
            // arrange
            const int numberOne = 1;
            const int numberTwo = 2;
            const int expected = 3;

            // act
            var result = _underTest.Add(numberOne, numberTwo);

            // assert
            Assert.Equal(result, expected);
        }
    }
}