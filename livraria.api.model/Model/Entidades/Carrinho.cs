using livraria.api.model.Model.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Entidades
{
    public class Carrinho
    {
        [JsonIgnore]
        public int Id { get; set; }

        public double  Total { get; set; }

        public List<Livro> Livros { get; set; }

    }
}
