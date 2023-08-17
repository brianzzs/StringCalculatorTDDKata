using Calculator;
using FluentAssertions;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("1", 1)]
    [InlineData("1,2", 3)]
    [InlineData("1\n2,3", 6)]

    public void ShouldReturnNumberOrSum(string numbers, int expectedNumber)
    {
        var calc = new StringCalculator();
        var result = calc.Add(numbers);
        result.Should().Be(expectedNumber);
    }
}