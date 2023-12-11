using Aplication.Domain.Dtos;
using Aplication.Domain.Models;

namespace Aplication.Interfaces.Repository
{
    public interface ICoffeeService
    {
        Task<CoffeeListDto> GetAll();
        Task<RecomendationResponseDto> Calculate(CreateRecomendationDto consumption);

    }
}
