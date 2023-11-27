namespace FizzBuzz;
public class Program
{
    private const int _defaultCount = 101;
    public static void Main(string[] args)
    {
        if (args.Length == 0 || !int.TryParse(args[0], out int count))
        {
            count = _defaultCount;
        }

        foreach(int value in Enumerable.Range(1, count))
        {
            Console.WriteLine(value.ToString());
        }
    }
}
