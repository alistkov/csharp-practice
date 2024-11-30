namespace LINQ._5.Practice;

class Program
{
    static void Main(string[] args)
    {
    }

    public static Guid[] SelectApplicationsByDate(Application[] applications)
    {
        return applications
            .Where(a => a.CreatedAt > new DateTime(2024, 1, 1))
            .Select(a => a.Id)
            .ToArray();
    }
}