namespace TestTaskProq;

public interface INumber
{
    public int Value { get; }
    public ICollection<string> Substitutions { get; }
}