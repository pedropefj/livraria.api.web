using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class CarrinhoRequest
    {
        public int IdLivro { get; set; }
    }

    public class CarrinhoRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new CarrinhoRequest
            {
                IdLivro = 1
            };

        }
    }
}
