using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class AutorRequest
    {
        public string Nome { get; set; }

        public string Genero { get; set; }
    }

    public class AutorRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new AutorRequest
            {
                Nome = "Pedro",
                Genero = "Masculino"
            };

        }
    }
}
