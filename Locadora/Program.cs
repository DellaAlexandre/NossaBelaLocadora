using Locadora.API.Services;
using Locadora.Services;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;

namespace Locadora
{
    public class Program
    {
        private static UsuarioServices _usuarioServices = new UsuarioServices();
        private static GestaoServices _gestaoItens = new GestaoServices();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a locadora de vídeos");

            bool continuar = true;
            do
            {
                Console.WriteLine("Digite o número da sua opção:");
                Console.WriteLine("1 - Cadastrar usuários");
                Console.WriteLine("2 - Listar usuários");
                Console.WriteLine("3 - Cadastrar filme/série");
                Console.WriteLine("4 - Alugar filme/série");
                Console.WriteLine("5 - Devolver filme/série");
                Console.WriteLine("Qualquer outro número para sair");

                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do usuário, por gentileza");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade do usuário");
                        int idade = int.Parse(Console.ReadLine());

                        UsuarioViewModel modelo = new UsuarioViewModel();
                        modelo.Nome = nome;
                        modelo.Idade = idade;

                        _usuarioServices.CadastrarUsuario(modelo);
                        break;
                    case 2:
                        _usuarioServices.ListarUsuarios();
                        break;
                    case 3:
                        _gestaoItens.Cadastrar();
                        break;
                    default:
                        continuar = false;
                        break;
                }
            } while (continuar);

        }
    }
}
