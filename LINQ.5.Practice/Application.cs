namespace LINQ._5.Practice;

public class Application
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

    public Application(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
        CreatedAt = DateTime.Now;
    }
}