using RateApplication.DTO;
using RateApplication.Interfaces;
using RateApplication.Models;

namespace RateApplication.Services;

public class EstablishmentService:GenericService<Establishment, EstablishmentDto>
{
    public EstablishmentService(IRepository<Establishment> repository) : base(repository)
    {
    }
}