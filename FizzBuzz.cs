namespace Fizzbuzztest
{
    internal class Program
    {
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            return number.ToString();
        }
        static void Main(string[] args)
        {
            int number = 15;
            string result = FizzBuzz(number);
            Console.WriteLine(result);
        }
    }
}