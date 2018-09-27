using livraria.api.mode.Model.Request;
using livraria.api.mode.Model.Response;
using livraria.api.mode.Model.ValidacaoException;
using livraria.api.model.Interfaces;
using livraria.api.model.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Examples;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace livraria.api.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]

    public class CarrinhosController : BaseController
    {
        private ILivrariaBLL _livrariaBLL;

        public CarrinhosController(ILivrariaBLL livrariaBLL)
        {
            _livrariaBLL = livrariaBLL;
        }
        /// <summary>
        /// Lista todos os carrinhos.
        /// </summary>
        /// <response code="200">Lista todos os carrinhos</response>
        ///  <response code="204">Nenhuma carrinho encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpGet]
        [SwaggerResponseExample(200, typeof(CarrinhosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodosCarrinhosResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(AutoresResponse))]
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
        /// Lista um carrinho.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista o Carrinho</response>
        ///  <response code="204">Nenhuma Carrinho encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet("{idCarrinho}")]
        [SwaggerResponseExample(200, typeof(CarrinhoResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(AutorResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage Get(int idCarrinho)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idCarrinho));
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
        /// Adiciona item ao carrinho.
        /// </summary>
        ///  <response code="201">Item adcionado ao carrionho</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(CarrinhoRequest), typeof(CarrinhoRequestModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(PostCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        [ProducesResponseType(201, Type = null)]

        public HttpResponseMessage Post([FromBody]CarrinhoRequest carrinho)
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
        /// Limpa o carrinho
        /// </summary>
        ///  <response code="200">Carrinho limpo</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [ProducesResponseType(200, Type = null)]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [SwaggerResponseExample(400, typeof(LimpaCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]

        public HttpResponseMessage Delete()
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
        /// Remove item do carrinho
        /// </summary>
        ///<param name="id">Código identificador item no carrinho</param>   
        ///  <response code="200">Carrinho atualizado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpDelete]
        [SwaggerResponseExample(400, typeof(DeleteCarrinhoResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = null)]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("{idLivro}")]

        public HttpResponseMessage Delete([FromUri]int idLivro)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.updateAutor(idLivro, null));
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