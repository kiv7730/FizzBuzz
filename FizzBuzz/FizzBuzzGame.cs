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
            return number.ToString();
        }
}
}
