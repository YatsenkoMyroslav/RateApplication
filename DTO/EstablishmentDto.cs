using RateApplication.Models;

namespace RateApplication.DTO;

public class EstablishmentDto
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public string Description { get; set; }
    public List<Feedback> Feedbacks { get; set; }
    public Schedule Schedule { get; set; }
    public Address Address { get; set; }
}