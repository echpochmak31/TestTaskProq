namespace TestTaskProq.Handlers;

public class DivisibleBy4Handler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 4 == 0)
        {
            number.Substitutions.Add("muzz");
        }
        base.Handle(number);
    }
}