namespace LINQ._2.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static string[] FilterByStringLength(string[] strings)
    {
        return strings.Where(s => s.Length > 3).ToArray();
    }
}