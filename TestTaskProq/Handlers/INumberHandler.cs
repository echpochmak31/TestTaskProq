namespace TestTaskProq.Handlers;

public interface INumberHandler
{
    void SetNext(INumberHandler next);
    void Handle(INumber number);
}