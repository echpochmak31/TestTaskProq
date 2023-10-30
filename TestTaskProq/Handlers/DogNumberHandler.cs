namespace TestTaskProq.Handlers;

public class DogNumberHandler : BasicNumberHandler
{
    public override void Handle(INumber number)
    {
        if (number.Value % 3 == 0)
        {
            number.Substitutions.Add("dog");
        }
        base.Handle(number);
    }
}