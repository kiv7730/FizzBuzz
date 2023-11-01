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
    }
}