namespace TestTaskProq.Handlers;

public abstract class BasicNumberHandler : INumberHandler
{
    private INumberHandler? _next;
    public void SetNext(INumberHandler next)
    {
        _next = next;
    }

    public virtual void Handle(INumber number)
    {
        _next?.Handle(number);
        if (number.Substitutions.Count == 0)
        {
            number.Substitutions.Add(number.Value.ToString());
        }
    }
}