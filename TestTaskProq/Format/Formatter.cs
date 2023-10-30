namespace TestTaskProq.Format;

public class Formatter : IFormatter
{
    public string FormatSubstitutions(IEnumerable<string> substitutions)
    {
        return string.Join('-', substitutions);
    }
}