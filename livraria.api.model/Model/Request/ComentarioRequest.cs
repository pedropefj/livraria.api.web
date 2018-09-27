using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Request
{
    public class ComentarioRequest
    {
        public Comentario livro { get; set; }
    }

    public class ComentarioRequestModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new Comentario()
            {
                Texto = "Muito Bom",
                data = "2018-09-20",
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
