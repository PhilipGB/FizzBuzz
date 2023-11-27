using FizzBuzz.Extensions;
using NUnit.Framework;

namespace ExtensionsTests;

public class ExtensionsTests
{
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(7)]
    [TestCase(8)]
    [TestCase(11)]
    public void NumbersNotDivisibleBy3or5(int value)
    {
        // Arrange
        var expected = value.ToString();

        //Act
        var actual = value.ToFizzBuzzValue();

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    [TestCase(12)]
    [TestCase(18)]
    [TestCase(21)]
    public void NumbersDivisibleBy3(int value)
    {
        // Arrange
        var expected = "Fizz";

        //Act
        var actual = value.ToFizzBuzzValue();

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    [TestCase(25)]
    [TestCase(35)]
    [TestCase(40)]
    public void NumbersDivisibleBy5(int value)
    {
        // Arrange
        var expected = "Buzz";

        //Act
        var actual = value.ToFizzBuzzValue();

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    [TestCase(60)]
    [TestCase(75)]
    [TestCase(90)]
    public void NumbersDivisibleBy3and5(int value)
    {
        // Arrange
        var expected = "FizzBuzz";

        //Act
        var actual = value.ToFizzBuzzValue();

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
