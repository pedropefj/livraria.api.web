using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class EditoraRequest
    {
        [JsonIgnore]

        public int Id { get; set; }

        public string Nome { get; set; }
    }

    public class EditoraRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new EditoraRequest
            {
                Id = 1,
                Nome = "teste",
                    
            };

        }
    }
}
