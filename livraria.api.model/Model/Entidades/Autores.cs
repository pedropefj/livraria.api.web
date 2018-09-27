﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Entidades
{
    public class Autor
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Genero { get; set; }

    }
}
