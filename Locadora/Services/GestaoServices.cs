using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        private List<Item> _biblioteca = Armazenamento.Biblioteca;
        private FilmeViewModel filmeRecebido;
        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
                CadastrarFilme(filmeRecebido);
            }
            if (respotas == 2)
            {
                CadastrarSerie();
            }
        }

        public Item CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(); 

            filme.Titulo = filmeRecebido.Titulo;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Descricao = filmeRecebido.Descricao;
            filme.Duracao = filmeRecebido.Duracao;
            filme.QuantidadeDeOscars = filmeRecebido.QuantidadeDeOscars;

        _biblioteca.Add(filme);

            return filme;
        }

        public void CadastrarSerie()
        {
            Serie serie = new Serie();

            Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            serie.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos cópias desta série existem?");
            serie.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste séries?");
            serie.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas temporadas tem esta série?");
            serie.Temporadas = int.Parse(Console.ReadLine());

            _biblioteca.Add(serie);
        }
    }
}
