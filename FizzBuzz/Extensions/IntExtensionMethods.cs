namespace FizzBuzz.Extensions;

public static class IntExtensionMethods
{
    private const string Fizz = nameof(Fizz);
    private const string Buzz = nameof(Buzz);

    public static string ToFizzBuzzValue(this int value)
    {
        string? result = null;

        if (value % 3 == 0)
        {
            result = Fizz;
        }

        if (value % 5 ==0)
        {
            result += Buzz;
        }

        return result ?? value.ToString();
    }
}
