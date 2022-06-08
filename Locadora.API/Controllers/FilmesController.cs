using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private GestaoServices _filmeServices = new GestaoServices();

        [HttpPost]
        public ActionResult CadastroDeFilme([FromBody] FilmeViewModel filmeRecebido)
        {
            Item objetoRecebido = _filmeServices.CadastrarFilme(filmeRecebido);
            
            return Created("Filme", objetoRecebido);

        }

    }
}
