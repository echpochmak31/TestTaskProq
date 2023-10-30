using TestTaskProq.Format;
using TestTaskProq.Handlers;

namespace TestTaskProq.Test;

using Xunit;
using TestTaskProq;

public class ProcessorTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
        new string[]
            { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz-buzz" })]
    [InlineData(new int[] { 5, -55, 30, -1 },
        new string[]
            { "buzz", "buzz", "fizz-buzz", "-1", })]
    public void TestNumberProcessing(int[] input, string[] expected)
    {
        var formatter = new Formatter();

        var divisibleBy3Handler = new DivisibleBy3Handler();
        var divisibleBy5Handler = new DivisibleBy5Handler();

        divisibleBy3Handler.SetNext(divisibleBy5Handler);

        var processor = new Processor(divisibleBy3Handler, formatter);

        // Act
        var result = processor.Process(input);

        // Assert
        Assert.Equal(expected, result);
    }
}