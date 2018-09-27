using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class PedidoResquest
    {
        public List<int> IdLivro { get; set; }

        public double Desconto { get; set; }

        public double Total { get; set; }

    }

    public class PedidoResquestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new PedidoResquest
            {
                Desconto = 0,
                Total = 100,
                IdLivro = new List<int>()
                {
                    1,
                    2
                }
            };

        }
    }
}
