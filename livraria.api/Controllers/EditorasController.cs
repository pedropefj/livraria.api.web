using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
    public class EditorasController : BaseController
    {
        private ILivrariaBLL _livrariaBLL;

        public EditorasController(ILivrariaBLL livrariaBLL)
        {
            _livrariaBLL = livrariaBLL;
        }
        /// <summary>
        /// Lista todos as editoras.
        /// </summary>
        /// <response code="200">Lista de Autores</response>
        ///  <response code="204">Nenhuma Autor encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpGet]
        [SwaggerResponseExample(200, typeof(EditorasResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodasEditorasResponse400), jsonConverter: typeof(StringEnumConverter))]
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
        /// Lista uma editora.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista uma editora</response>
        ///  <response code="204">Nenhuma Autor encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet("{id}")]
        [SwaggerResponseExample(200, typeof(AutorResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetEditoraResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(AutorResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage Get(int id)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(id));
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
        /// Cria uma editora.
        /// </summary>
        ///  <response code="201">Editora Criada</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(EditoraRequest), typeof(EditoraRequestModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(PostEditoraResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        [ProducesResponseType(201, Type= null)]

        public HttpResponseMessage Post([FromBody]AutorRequest autor)
        {
            try
            {
                _livrariaBLL.criarAutor(autor);
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
        /// Deleta uma editora
        /// </summary>
        ///<param name="id">Código identificador do editora</param>   
        ///  <response code="200">Editora deletada</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpDelete("{id}")]
        [ProducesResponseType(200, Type = null)]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [SwaggerResponseExample(400, typeof(DeleteEditoraResponse400), jsonConverter: typeof(StringEnumConverter))]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                _livrariaBLL.deletarAutor(id);
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
        /// Atualiza a editora
        /// </summary>
        ///<param name="id">Código identificador da editora</param>   
        ///  <response code="200">Editora atualizado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPut("{id}")]

        [SwaggerResponseExample(200, typeof(AutorResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(UpdateEditoraResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(AutorResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage Update([FromQuery]int id, [FromBody] AutorRequest autor)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.updateAutor(id, autor));
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