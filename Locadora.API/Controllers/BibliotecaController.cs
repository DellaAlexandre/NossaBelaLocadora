using Locadora.Models;
using Locadora.Respository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BibliotecaController : ControllerBase
    {
        [HttpGet]
        public List<Item> ListarItens()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Item> listaitems =
                Armazenamento.Biblioteca;
            return listaitems;
        }
    }
}
