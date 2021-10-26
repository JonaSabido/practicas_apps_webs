using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicaAlcohol.Infraestructure;

namespace practicaAlcohol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        [HttpGet]
        public string GetAlchohol(string bebida, float cantidad, float peso)
        {
            var repository = new AlcoholRepository();
            double alcoholemia = repository.Calculo(bebida, cantidad, peso);
            if(alcoholemia <= 0.8)
            {
                return alcoholemia.ToString("N3") + " Tenga un buen viaje";
            }
            else
            {
                return alcoholemia.ToString("N3") + " Necesita apoyo";
            }
        }
    }
}
