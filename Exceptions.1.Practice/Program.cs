namespace Exceptions._1.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static void CheckString(string text)
    {
        if (string.IsNullOrEmpty(text))
            throw new InvalidVariableValueException("String is empty!");
    }
}