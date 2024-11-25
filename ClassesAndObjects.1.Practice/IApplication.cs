namespace ClassesAndObjects._1.Practice;

public interface IApplication
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}