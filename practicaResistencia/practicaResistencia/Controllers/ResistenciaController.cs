using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicaResistencia.Infraestructure;

namespace practicaResistencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        public string CalcularResistencia (string banda1, string banda2, string banda3, string banda4)
        {
            var repository = new ResistenciaRepository();
            string resultado = repository.Calcular(banda1, banda2, banda3, banda4);
            return resultado;
        }
    }
}
