using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class ComentarioResponse
    {
        public Comentario comentario;
    }

    public class ComentarioResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new ComentarioResponse(){
                comentario = new Comentario()
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
                }
            };
        }
    }

    public class TodosComentariosResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class GetComentarioLivroResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0005" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
    public class GetComentarioResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0005", "M0009" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class PostComentarioResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0008" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class DeleteComentarioResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0009" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class UpdateComentarioResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0009" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
}
