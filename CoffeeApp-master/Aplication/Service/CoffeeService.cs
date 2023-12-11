using Aplication.Domain.Dtos;
using Aplication.Domain.Models;
using Aplication.Interfaces.Repository;

namespace Aplication.Service
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeService(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public async Task<CoffeeListDto> GetAll()
        {
            var coffeeList = await _coffeeRepository.GetAll();

            return new CoffeeListDto()
            {
                Coffees = coffeeList.ToList(),
            };
        }

        public async Task<RecomendationResponseDto> Calculate(CreateRecomendationDto consumption)
        {
            var coffeeLevels = await _coffeeRepository.GetCafeinneLevels();
            var list = new List<Recomendation>();
            
            var teste = new RecomendationResponseDto();
            foreach (var coffee in consumption.Recomendations)
            {
                var getCode = coffee.Code;
                var findCoffee = coffeeLevels.FirstOrDefault(x => x.Code == getCode);
                var time = Convert.ToInt32(CalculateCaffeineLevel(Convert.ToDouble(findCoffee.Level), coffee.Time, 300)) ;

                var recomendation = new Recomendation();
                recomendation.Name = findCoffee.Name;
                recomendation.Code = coffee.Code;
                recomendation.Wait = time;
                list.Add(recomendation);
                

            }
            teste.Recomendations = list;

            return teste;

        }

        public double CalculateCaffeineLevel(double N0, double t, double T)
        {
            return N0 * Math.Pow(0.5, t / T);
        }

    }

    }
