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
}
