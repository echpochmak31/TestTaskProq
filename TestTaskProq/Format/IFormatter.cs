namespace TestTaskProq.Format;

public interface IFormatter
{
    string FormatSubstitutions(IEnumerable<string> substitutions);
}