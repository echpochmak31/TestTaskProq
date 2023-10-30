namespace TestTaskProq;

public class Number : INumber
{
    public int Value { get; }
    public ICollection<string> Substitutions { get; }

    public Number(int number)
    {
        Value = number;
        Substitutions = new List<string>();
    }
}