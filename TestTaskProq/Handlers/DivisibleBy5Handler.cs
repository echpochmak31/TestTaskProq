namespace TestTaskProq.Handlers;

public class DivisibleBy5Handler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 5 == 0)
        {
            number.Substitutions.Add("buzz");
        }
        base.Handle(number);
    }
}