
public static string fizzBuzz(int number)
{
    if (number % 3 == 0)
    {
        return "fizz";
    }

    if (number % 5 == 0)
    {
        return "buzz";
    }
    
    if (number % 3 == 0 && number % 5 == 0)
    {
        return "fizzbuzz";
    }
}