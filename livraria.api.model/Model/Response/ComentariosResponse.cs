using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class ComentariosResponse
    {
        public List<Comentario> comentarios;
    }

    public class ComentariosResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new ComentariosResponse() {
                comentarios = new List<Comentario>()
                {
                   new Comentario()
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
                    },
                   new Comentario()
                   {
                        Texto = "Otimo",
                        data = "2018-09-24",
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
                    }
                }
            };
        }
    }

    
}
