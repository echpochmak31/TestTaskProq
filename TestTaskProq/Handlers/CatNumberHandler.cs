namespace TestTaskProq.Handlers;

public class CatNumberHandler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 5 == 0)
        {
            number.Substitutions.Add("cat");
        }
        base.Handle(number);
    }
}