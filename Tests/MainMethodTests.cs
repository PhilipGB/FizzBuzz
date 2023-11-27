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
}