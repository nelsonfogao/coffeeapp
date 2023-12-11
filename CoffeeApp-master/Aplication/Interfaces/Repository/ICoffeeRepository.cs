using Aplication.Domain.Models;

namespace Aplication.Interfaces.Repository
{
    public interface ICoffeeRepository
    {
        Task<IEnumerable<Coffee>> GetAll();
        Task<IEnumerable<CafeinneLevel>> GetCafeinneLevels();

    }
}
