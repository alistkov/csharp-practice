namespace ClassesAndObjects._2.Practice;

class Program
{
    public static void Main(string[] args)
    {
        DisplayVariableInfo<int>(3);
        DisplayVariableInfo<string>("text");
        DisplayVariableInfo<char>('a');
        DisplayVariableInfo<float>(1.2f);
    }
    
    public static void DisplayVariableInfo<T>(T value)
    {
        Console.WriteLine(value.GetType());
    }
}
