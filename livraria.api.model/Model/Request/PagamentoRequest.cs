using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class PagamentoRequest
    {
        public Double Valor { get; set; }

        public string Tipo { get; set; }

        public string Data { get; set; }
    }

    public class PagamentoRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new PagamentoRequest
            {
               Data = "2018-09-27",
               Tipo = "CARTAO",
               Valor = 1000
            };

        }
    }
}
