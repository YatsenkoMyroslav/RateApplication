namespace RateApplication.Models;

public class Establishment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }
    public List<Feedback> Feedbacks { get; set; }
    public Schedule Schedule { get; set; }
    public Address Address { get; set; }
}