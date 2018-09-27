using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class CarrinhosResponse
    {
        public List<Carrinho> carrinhos;
    }

    public class CarrinhosResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new CarrinhosResponse()
            {
                carrinhos = new List<Carrinho>()
                {
                    new Carrinho()
                    {
                    Livros = new List<Livro>()
                        {
                            new Livro(){
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
                            },new Livro(){
                                Nome = "Harry Potter 2",
                                Ano = "2003",
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
                        Total = 200

                    }
                }
                
            };
        }
    }

    public class TodosCarrinhosResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
    public class GetCarrinhoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class PostCarrinhoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0005" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class DeleteCarrinhoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0010","M0011" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class LimpaCarrinhoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0010" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class UpdateCarrinhoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0005" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
}
