namespace StaticDemo;

public static class MethodExtensions
{
    public static string ToUpper(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        return input.ToUpper();
    }
}
