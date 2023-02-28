namespace RateApplication.Models;

public class Feedback
{
    public int Id { get; set; }
    public User User { get; set; }
    public int Usefulness { get; set; }
    public string Text { get; set; }
    public short? Grade { get; set; } 
    public DateTime CreatedOn { get; set; }
}