using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class LivroResponse
    {
        public Livro livro;
    }

    public class LivroResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new LivroResponse()
            {
                livro = new Livro()
                {
                    Nome = "Harry Potter 1",
                    Ano = "2000",
                    Editora = new Editora()
                    {
                        Nome = "NAO SEI"
                    },
                    Autor = new Autor()
                    {
                        Nome = "J.K Rolling",
                        Genero = "Feminino "
                    },
                    Preco = 100
                }
            };
        }
    }
}

