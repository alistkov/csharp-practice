namespace LINQ._3.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static DateTime[] SortDates(DateTime[] dates)
    {
        return dates.OrderByDescending(d => d).ToArray();
    }
}