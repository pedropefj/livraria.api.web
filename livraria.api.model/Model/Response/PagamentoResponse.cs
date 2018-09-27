using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Response
{
    public class PagamentoResponse
    {
        public Double Valor { get; set; }

        public string Tipo { get; set; }

        public string Data { get; set; }

        public bool Sucesso { get; set; }
    }

    public class PagamentoResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new PagamentoResponse
            {
               Data = "2018-09-27",
               Tipo = "CARTAO",
               Valor = 1000,
               Sucesso = true
            };

        }
    }
}
