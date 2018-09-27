using livraria.api.mode.Model.Entidades;
using livraria.api.model.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class PedidosResponse
    {
        public List<Pedido> pedidos;
    }

    public class PedidosResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new PedidosResponse()
            {
                pedidos = new List<Pedido>()
                {
                    new Pedido()
                {
                    livros = new List<Livro>()
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
                    Desconto = 0,
                    Data = "2018-09-20",
                    Total = 200
                }
                } 
            };
        }
    }

    public class TodosPedidosResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class GetPedidoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }


    public class PostPedidoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0005" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class DelepedidoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0012" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
    public class StatusdidoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0012", "M0013" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class PagamentoPedidoResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0012", "M0014" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
}
