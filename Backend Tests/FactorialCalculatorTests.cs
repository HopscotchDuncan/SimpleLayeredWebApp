using Backend;

namespace Backend_Tests
{
    public class FactorialCalculatorTests
    {
        FactorialCalculator calculator = new FactorialCalculator();

        [Fact]
        public void Test0()
        {
            Assert.Equal(1, calculator.factorialRecursive(0));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(2, calculator.factorialRecursive(2));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(720, calculator.factorialRecursive(6));
        }
    }
}