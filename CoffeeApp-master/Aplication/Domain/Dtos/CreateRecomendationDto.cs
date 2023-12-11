using Aplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Domain.Dtos
{
    public class CreateRecomendationDto
    {
        public List<Consumption> Recomendations { get; set; }
    }
}
