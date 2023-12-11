using Aplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Domain.Dtos
{
    public class RecomendationResponseDto
    {
        public List<Recomendation> Recomendations { get; set; }
    }
}
