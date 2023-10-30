using TestTaskProq.Format;
using TestTaskProq.Handlers;

namespace TestTaskProq.Test;

using Xunit;
using TestTaskProq;

public class ProcessorTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 },
        new string[]
        {
            "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", "11", "fizz-muzz", "13", "guzz",
            "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz"
        })]
    public void TestNumberProcessing(int[] input, string[] expected)
    {
        var formatter = new Formatter();

        var divisibleBy3Handler = new DivisibleBy3Handler();
        var divisibleBy5Handler = new DivisibleBy5Handler();
        var divisibleBy4Handler = new DivisibleBy4Handler();
        var divisibleBy7Handler = new DivisibleBy7Handler();


        divisibleBy3Handler.SetNext(divisibleBy5Handler);
        divisibleBy5Handler.SetNext(divisibleBy4Handler);
        divisibleBy4Handler.SetNext(divisibleBy7Handler);

        var processor = new Processor(divisibleBy3Handler, formatter);

        // Act
        var result = processor.Process(input);

        // Assert
        Assert.Equal(expected, result);
    }
}