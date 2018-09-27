using livraria.api.mode.Model.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.model.Model.Entidades
{
    public class Comentario
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Texto { get; set; }

        public  Livro livro { get; set; }

        public string data { get; set; }

    }
}
