using Locadora.API.Services;
using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
     
        private UsuarioServices _usuarioServices = new UsuarioServices();
        
        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Usuario> listaUsuario = 
                Armazenamento.Usuarios;
            return listaUsuario;
        } 

        [HttpPost]
        public ActionResult CadastrarUsuario(
            [FromBody] UsuarioViewModel usuarioRecebido)
        {
           if (string.IsNullOrEmpty(usuarioRecebido.Nome)){
                return BadRequest("Nome do usuário não informado");
            }
            
           if(usuarioRecebido.Idade < 18){
                return BadRequest("Não é permitido o cadastro de pessoas menores de idade");
            }
            
            Usuario objetoRecebido = _usuarioServices.CadastrarUsuario(usuarioRecebido);

            return Created("usuarios", objetoRecebido);


        }


        [HttpGet ("{id}")]
        public IActionResult OberUsuario(string id)
        {
            Usuario usuario = _usuarioServices.Obterusuario(id);
            if (usuario == null) 
            { 
              return NotFound();
            }
            return Ok(usuario);
        }

    }
}
