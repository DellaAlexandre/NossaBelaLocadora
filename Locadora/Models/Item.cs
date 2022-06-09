using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Item()
        {
            Id = Guid.NewGuid();
        }

    }
}
