namespace ClassesAndObjects._1.Practice;

class Program
{
    public static void Main(string[] args)
    {
        var application = new Application("Application description");
        DisplayApplicationInfo(application);
        
        var applicationDraft = new ApplicationDraft();
        DisplayApplicationInfo(applicationDraft);
    }

    public static void DisplayApplicationInfo(IApplication application)
    {
        Console.WriteLine($"Application Id: {application.Id}");
        Console.WriteLine($"Application created date: {application.CreatedAt}");
        Console.WriteLine($"Application description: {application.Description}");
    }
}

