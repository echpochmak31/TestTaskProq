namespace TestTaskProq.Format;

public class GoodBoyFormatter : IFormatter
{
    public string FormatSubstitutions(IEnumerable<string> substitutions)
    {
        if (!substitutions.Contains("dog") || !substitutions.Contains("cat")) return string.Join('-', substitutions);
        var modified = new List<string>() {"good-boy"};
        modified.AddRange(substitutions.Where(x => !x.Equals("dog") && !x.Equals("cat")).ToList());
        return string.Join('-', modified);
    }
}