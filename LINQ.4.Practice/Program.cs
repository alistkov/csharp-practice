namespace LINQ._4.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static string[] GetStringsWithPagination(string[] strings, int limit, int offset)
    {
        return strings.Skip(offset).Take(limit).ToArray();
    }
}