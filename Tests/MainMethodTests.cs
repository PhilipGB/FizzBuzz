using FizzBuzz;
using NUnit.Framework;

namespace MainMethodTests;

public class MainMethodTests
{
    [Test()]
    public void TestMainNoArgs()
    {
        //Arrange
        StringWriter output = new ();
        Console.SetOut(output);

        var expected = 100;

        //Act
        Program.Main(Array.Empty<string>());
        var outputArray = output
            .ToString()
            .TrimEnd('\n') // End of Console output is '\n'
            .Split("\n");

        var actual  = outputArray.Length;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("1")]
    [TestCase("11")]
    [TestCase("101")]
    public void TestMainWithArgs(string count)
    {
        //Arrange
        StringWriter output = new ();
        Console.SetOut(output);

        var expected = int.Parse(count);

        //Act
        Program.Main(new string[] { count });
        var outputArray = output
            .ToString()
            .TrimEnd('\n') // End of Console output is '\n'
            .Split("\n");

        var actual  = outputArray.Length;

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(0, "1")]
    [TestCase(2, "Fizz")]
    [TestCase(4, "Buzz")]
    [TestCase(6, "7")]
    [TestCase(14, "FizzBuzz")]
    [TestCase(99, "Buzz")]
    public void TestMainOutputNoArgs(int index, string value)
    {
        //Arrange
        StringWriter output = new ();
        Console.SetOut(output);

        var expected = value;

        //Act
        Program.Main(Array.Empty<string>());
        var outputArray = output
            .ToString()
            .TrimEnd('\n') // End of Console output is '\n'
            .Split("\n");

        var actual = outputArray[index];

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("11")]
    public void TestMainOutputWithArgs(string count)
    {
        //Arrange
        StringWriter output = new ();
        Console.SetOut(output);

        var expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\n";

        //Act
        Program.Main(new string[] { count });
        var actual  = output.ToString();

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}