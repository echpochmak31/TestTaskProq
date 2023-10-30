using TestTaskProq.Handlers;

namespace TestTaskProq;

public class DivisibleBy3Handler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 3 == 0)
        {
            number.Substitutions.Add("fizz");
        }
        base.Handle(number);
    }
}