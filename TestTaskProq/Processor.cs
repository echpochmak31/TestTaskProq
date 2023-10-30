using TestTaskProq.Format;
using TestTaskProq.Handlers;

namespace TestTaskProq;

public class Processor

{
    private INumberHandler _handler;
    private IFormatter _formatter;

    public Processor(INumberHandler handler, IFormatter formatter)
    {
        Handler = handler;
        Formatter = formatter;
    }

    public INumberHandler Handler
    {
        get => _handler;
        set
        {
            ArgumentNullException.ThrowIfNull(value, nameof(Handler));
            _handler = value;
        }
    }

    public IFormatter Formatter
    {
        get => _formatter;
        set
        {
            ArgumentNullException.ThrowIfNull(value, nameof(Formatter));
            _formatter = value;
        }
    }

    public IEnumerable<string> Process(IEnumerable<int> numbers)
    {
        return numbers.Select(x =>
        {
            var number = new Number(x);
            _handler.Handle(number);
            return _formatter.FormatSubstitutions(number.Substitutions);
        });
    }
}