using livraria.api.mode.Model.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.model.Model.Entidades
{
    public class Livro
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nome { get; set; }

        public  Editora Editora { get; set; }

        public Autor Autor { get; set; }

        public string Ano { get; set; }

        public double Preco { get; set; } 

    }
}
