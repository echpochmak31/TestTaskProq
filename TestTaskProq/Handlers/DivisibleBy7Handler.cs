namespace TestTaskProq.Handlers;

public class DivisibleBy7Handler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 7 == 0)
        {
            number.Substitutions.Add("guzz");
        }
        base.Handle(number);
    }
}