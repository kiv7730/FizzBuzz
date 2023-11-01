namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string DoGame(int number)
        {
            if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            return number.ToString();
        }
}
}
