using RateApplication.Models;

namespace RateApplication.Data.Repository;

public class FeedbackRepository : GeneralRepository<Feedback>
{
    public FeedbackRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}