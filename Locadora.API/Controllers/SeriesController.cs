using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private GestaoServices _serieServices = new GestaoServices();

        [HttpPost]

        public IActionResult CadastroDeSerie([FromBody] SerieViewModel serieRecebido)
        {
            Serie objetorecebido = _serieServices.CadastrarSerie(serieRecebido);

            return Created("Serie", objetorecebido);
        }

    }
}
