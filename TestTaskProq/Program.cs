using TestTaskProq;
using TestTaskProq.Format;
using TestTaskProq.Handlers;

var formatter = new Formatter();

var divisibleBy3Handler = new DivisibleBy3Handler();
var divisibleBy5Handler = new DivisibleBy5Handler();

divisibleBy3Handler.SetNext(divisibleBy5Handler);

var processor = new Processor(divisibleBy3Handler, formatter);
var result = processor.Process(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15});

foreach (var s in result)
{
    Console.WriteLine(s);
}