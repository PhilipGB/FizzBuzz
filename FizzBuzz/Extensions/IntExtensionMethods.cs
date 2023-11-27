namespace FizzBuzz.Extensions;
public static class IntExtensionMethods
{
    public static string ToFizzBuzzValue(this int value)
    {
        if (value % 3 == 0)
        {
            return "Fizz";
        }

        return value.ToString();
    }
}
