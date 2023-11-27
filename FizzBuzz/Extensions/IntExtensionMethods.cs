namespace FizzBuzz.Extensions;
public static class IntExtensionMethods
{
    public static string ToFizzBuzzValue(this int value)
    {
        if (value % 15 == 0)
        {
            return "FizzBuzz";
        }

        if (value % 3 == 0)
        {
            return "Fizz";
        }

        if (value % 5 ==0)
        {
            return "Buzz";
        }

        return value.ToString();
    }
}
