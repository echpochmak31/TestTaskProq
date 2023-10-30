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
            "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", "11", "dog-muzz", "13", "guzz",
            "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz"
        })]
    public void TestNumberProcessing(int[] input, string[] expected)
    {
        var formatter = new GoodBoyFormatter();

        var dogHandler = new DogNumberHandler();
        var catHandler = new CatNumberHandler();
        var divisibleBy4Handler = new DivisibleBy4Handler();
        var divisibleBy7Handler = new DivisibleBy7Handler();

        dogHandler.SetNext(catHandler);
        catHandler.SetNext(divisibleBy4Handler);
        divisibleBy4Handler.SetNext(divisibleBy7Handler);

        var processor = new Processor(dogHandler, formatter);

        // Act
        var result = processor.Process(input);

        // Assert
        Assert.Equal(expected, result);
    }
}