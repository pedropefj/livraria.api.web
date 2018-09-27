using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class LivroRequest
    {
        public Livro livro { get; set; }
    }

    public class LivroRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new Livro()
            {
                Nome ="Harry Potter 1",
                Ano = "2000",
                Preco = 100,
                Editora = new Editora()
                {
                    Nome = "NAO SEI"
                },
                Autor = new Autor()
                {
                    Nome = "J.K Rolling",
                    Genero = "Feminino "
                }
            };

        }
    }
}
