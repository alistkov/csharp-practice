namespace Methods._2.Practice;

public class StringValidator
{
    public bool IsStringNotEmpty(string text)
    {
        return !string.IsNullOrEmpty(text);
    }
}