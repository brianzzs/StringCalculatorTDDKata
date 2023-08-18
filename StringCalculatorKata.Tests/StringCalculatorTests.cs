using Calculator;
using FluentAssertions;
using Xunit;
using System;
namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{

    [Theory]
    [InlineData("", 0, null)]
    [InlineData("1", 1, null)]
    [InlineData("1,2", 3, null)]
    [InlineData("1\n2,3", 6, null)]
    [InlineData("1,2,-3,-4", 0, "Negatives not allowed: -3,-4")]
    public void ShouldReturnNumberOrSum_OrThrowException(string numbers, int expectedNumber, string expectedExceptionMessage)
    {
        var calc = new StringCalculator();

        if (expectedExceptionMessage != null)
        {
            Action act = () => calc.Add(numbers);
            act.Should().Throw<Exception>().WithMessage(expectedExceptionMessage);
        }
        else
        {
            var result = calc.Add(numbers);
            result.Should().Be(expectedNumber);
        }
    }


}