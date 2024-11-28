namespace ClassesAndObjects._1.Practice;

public class ApplicationDraft : IApplication
{
    public ApplicationDraft() : this(string.Empty) {}

    public ApplicationDraft(string description)
    {
        Description = description;
    }
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}