using System.Text;
using TestTaskProq.Handlers;

namespace TestTaskProq;

public class Processor
{
    private readonly INumberHandler _handler;

    public Processor(INumberHandler handler)
    {
        ArgumentNullException.ThrowIfNull(handler);
        _handler = handler;
    }

    public IEnumerable<string> Process(IEnumerable<int> numbers)
    {
        return numbers.Select(x =>
        {
            var number = new Number(x);
            _handler.Handle(number);
            return FormatResult(number.Substitutions);
        });
    }

    private static string FormatResult(IEnumerable<string> substitutions)
    {
        return string.Join('-', substitutions);
    }
}