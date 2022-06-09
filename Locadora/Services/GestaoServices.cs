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
        private List<Filme> _filme = Armazenamento.Filmes;
        private List<Serie> _serie = Armazenamento.Series;
        private FilmeViewModel filmeRecebido;
        private SerieViewModel serieRecebido;
        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(); 

            filme.Titulo = filmeRecebido.Titulo;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Descricao = filmeRecebido.Descricao; 
            filme.QuantidadeDeOscars = filmeRecebido.QuantidadeDeOscars;

        _filme.Add(filme);

            return filme;
        }

        public Serie CadastrarSerie(SerieViewModel serieRecebida) 
        {
            Serie serie = new Serie();

            serie.Titulo = serieRecebida.Titulo;
            serie.Quantidade = serieRecebida.Quantidade;
            serie.Valor = serieRecebido.Valor;
            serie.Descricao = serieRecebido.Descricao;
            serie.Emmies = serieRecebida.Emmies;
            serie.Temporadas = serieRecebida.Temporadas;

            _serie.Add(serie);
            return serie;
        }

        public List<object> ListarItens()
        {
            List<object> lista = new List<object>();

            lista.AddRange(_filme);
            lista.AddRange(_serie);

            return lista;
        }


    }
}
