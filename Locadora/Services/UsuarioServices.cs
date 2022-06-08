using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Services
{
    public class UsuarioServices
    {
        public Usuario CadastrarUsuario(
            UsuarioViewModel usuarioRecebeido)
        {
            Usuario usuario = 
                new Usuario(usuarioRecebeido);
            Armazenamento.Usuarios.Add(usuario);

            return usuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            return Armazenamento.Usuarios
                .OrderBy(usuario => usuario.Nome)
                .ThenBy(usuario => usuario.Idade).ToList();
        }

        public Usuario Obterusuario( string idrecebido)
        {
            List<Usuario> lista = ListarUsuarios();
            if(lista.Any(u => u.Id.ToString() == idrecebido))
            {
                Usuario usuario = lista.Where(u => u.Id.ToString() == idrecebido).First();
                return usuario;
            }
            return null;
        }
    }
}
