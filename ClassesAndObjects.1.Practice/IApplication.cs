namespace ClassesAndObjects._1.Practice;

public interface IApplication
{
    public Guid Id { get; }
    public string Description { get; }
    public DateTime CreatedAt { get; }
}