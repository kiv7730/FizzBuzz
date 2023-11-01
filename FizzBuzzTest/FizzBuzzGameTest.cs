using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void should_return_given_number_when_countoff_given_normal_number()
        {
            int normalNumber = 1;
            FizzBuzzGame game = new FizzBuzzGame();
            string result = game.DoGame(1);
            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void should_return_fizz_when_countoff_given_multiple_of_three()
        {
            int normalNumber = 3;
            FizzBuzzGame game = new FizzBuzzGame();
            string result = game.DoGame(3);
            //then
            Assert.Equal("fizz", result);
        }

        public void should_return_buzz_when_countoff_given_multiple_of_five()
        {
            int normalNumber = 5;
            FizzBuzzGame game = new FizzBuzzGame();
            string result = game.DoGame(5);
            //then
            Assert.Equal("buzz", result);
        }
    }
}