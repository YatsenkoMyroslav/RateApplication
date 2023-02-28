namespace RateApplication.Models;

public class Schedule
{
    public int Id { get; set; }
    public List<DaySchedule> DaysDictionary { get; set; }
}