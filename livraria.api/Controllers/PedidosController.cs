using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using livraria.api.mode.Model.Request;
using livraria.api.mode.Model.Response;
using livraria.api.mode.Model.ValidacaoException;
using livraria.api.model.Interfaces;
using livraria.api.model.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Examples;

namespace livraria.api.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]

    public class PedidosController : BaseController
    {
        private ILivrariaBLL _livrariaBLL;

        public PedidosController(ILivrariaBLL livrariaBLL)
        {
            _livrariaBLL = livrariaBLL;
        }
        /// <summary>
        /// Lista todos os pedidos.
        /// </summary>
        /// <response code="200">Lista todos os pedidos</response>
        ///  <response code="204">Nenhum pedido encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpGet]
        [SwaggerResponseExample(200, typeof(PedidosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodosCarrinhosResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(PedidosResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage Get()
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutores());
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }

        /// <summary>
        /// Lista um pedido.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista o pedido</response>
        ///  <response code="204">Nenhuma pedido encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet("{idPedido}")]
        [SwaggerResponseExample(200, typeof(PedidoResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(PedidoResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage Get(int idPedido)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idPedido));
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }

        /// <summary>
        /// Realizar pedido.
        /// </summary>
        ///  <response code="201">Pedido Criado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(PedidoRequest), typeof(PedidoResquestModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(PostCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        [ProducesResponseType(201, Type = null)]

        public HttpResponseMessage Post([FromBody]PedidoResquest pedido)
        {
            try
            {
                //_livrariaBLL.criarAutor(autor);
                var retorno = ResponseBasicJson(HttpStatusCode.Created, null);
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }
        /// <summary>
        /// Deletar pedido
        /// </summary>
        ///  <response code="200">Pedido deletado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [ProducesResponseType(200, Type = null)]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [SwaggerResponseExample(400, typeof(LimpaCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [HttpDelete]
        [Route("{idPedido}")]

        public HttpResponseMessage Delete(int idPedido)
        {
            try
            {
                //_livrariaBLL.deletarAutor(id);
                var retorno = ResponseBasicJson(HttpStatusCode.OK, null);
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }

        /// <summary>
        /// Status de entrega de um pedido.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista o status do pedido</response>
        ///  <response code="204">Nenhuma pedido encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet]
        [SwaggerResponseExample(200, typeof(PedidoResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(PedidoResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("{idPedido}/statusEntrega")]
        public HttpResponseMessage GetStatusPedido(int idPedido)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idPedido));
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }

        /// <summary>
        /// Realizar pagamento.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Pagamento realizado</response>
        ///  <response code="204">Nenhuma pedido encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpPut]
        [SwaggerResponseExample(200, typeof(PedidoResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(PedidoResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("{idPedido}/pagamento")]
        public HttpResponseMessage GetPagamento(int idPedido)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idPedido));
                return retorno;
            }
            catch (ValidacaoException e)
            {
                return ResponseBasicJson(e.MensagemError.StatusCode, e.MensagemError);
            }
            catch (Exception e)
            {
                MensagemError msg = MensagensUtil.ObterMensagem(HttpStatusCode.BadRequest, "M199");
                return ResponseBasicJson(msg.StatusCode, msg);
            }
        }



    }
}