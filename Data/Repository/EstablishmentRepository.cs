using RateApplication.Models;

namespace RateApplication.Data.Repository;

public class EstablishmentRepository: GeneralRepository<Establishment>
{
    public EstablishmentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}