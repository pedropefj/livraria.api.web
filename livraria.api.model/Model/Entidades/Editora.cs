using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Entidades
{
    public class Editora
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nome { get; set; }

    }
}
