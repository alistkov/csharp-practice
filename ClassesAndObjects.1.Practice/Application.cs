namespace ClassesAndObjects._1.Practice;

public class Application(string description) : IApplication
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = description;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}