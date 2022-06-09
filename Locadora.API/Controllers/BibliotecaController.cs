using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {

        private GestaoServices _listaitens = new GestaoServices();

        [HttpGet]
        public IActionResult ListarItens()
        {
            List<object> itens = _listaitens.ListarItens();
           
            return Ok(itens);
        }
    }
}
