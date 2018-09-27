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

    public class LivrosController : BaseController
    {
        private ILivrariaBLL _livrariaBLL;

        public LivrosController(ILivrariaBLL livrariaBLL)
        {
            _livrariaBLL = livrariaBLL;
        }

        /// <summary>
        /// Lista todos os Livros.
        /// </summary>
        /// <response code="200">Lista de Livros</response>
        ///  <response code="204">Nenhuma Livro encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpGet]
        [SwaggerResponseExample(200, typeof(LivrosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodosAutoresResponse400), jsonConverter: typeof(StringEnumConverter))]
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
        /// Lista um Livro.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista o Livro</response>
        ///  <response code="204">Nenhuma Livro encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet("{id}")]
        [SwaggerResponseExample(200, typeof(LivroResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetLivroResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(LivrosResponse))]
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
        /// Cria um Livro.
        /// </summary>
        ///  <response code="201">Livro Criado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(LivroRequest), typeof(LivroRequestModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(PostLivroResponse400), jsonConverter: typeof(StringEnumConverter))]
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
        /// Deleta um livro
        /// </summary>
        ///<param name="id">Código identificador do livro</param>   
        ///  <response code="200">Livro deletado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpDelete("{id}")]
        [ProducesResponseType(200, Type = null)]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [SwaggerResponseExample(400, typeof(DeleteLivroResponse400), jsonConverter: typeof(StringEnumConverter))]

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
        /// Atualiza um livro
        /// </summary>
        ///<param name="id">Código identificador do livro</param>   
        ///  <response code="200">Livro atualizado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPut("{id}")]

        [SwaggerResponseExample(200, typeof(LivrosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(UpdateLivroResponse400), jsonConverter: typeof(StringEnumConverter))]
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

        /// <summary>
        /// Lista todos comentarios
        /// </summary>
        /// <response code="200">Lista de Livros</response>
        ///  <response code="204">Nenhum Livro encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [Route("comentarios")]
        [HttpGet]
        [SwaggerResponseExample(200, typeof(ComentariosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodosComentariosResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(ComentarioResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        public HttpResponseMessage GetComentarios()
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
        /// Lista comentarios de um livro.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista os comentarios</response>
        ///  <response code="204">Nenhum comentario encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet]
        [SwaggerResponseExample(200, typeof(ComentariosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetComentarioLivroResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(ComentariosResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("{idLivro}/comentarios")]

        public HttpResponseMessage GetLivroComentarios(int idLivro)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idLivro));
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
        /// Lista um comentario especifico de um livro.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista os comentarios</response>
        ///  <response code="204">Nenhum comentario encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet]
        [SwaggerResponseExample(200, typeof(ComentarioResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(GetComentarioResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(ComentarioResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("{idLivro}/comentarios/{idComentario}")]

        public HttpResponseMessage GetLivroComentario(int idLivro, int idComentario)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK, _livrariaBLL.obterAutor(idLivro));
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
        /// Cria um comentario.
        /// </summary>
        ///  <response code="201">Comentario Criado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(LivroRequest), typeof(ComentarioRequestModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(PostComentarioResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]

        [ProducesResponseType(201,Type = null)]
        [Route("{idLivro}/comentarios")]

        public HttpResponseMessage PostComentario([FromBody]ComentarioRequest comentario, int idLivro)
        {
            try
            {
                //_livrariaBLL.criarAutor(comentario);
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
        /// Filtro de Livro.
        /// </summary>
        ///<param name="id"></param>  
        /// <response code="200">Lista os Livro</response>
        ///  <response code="204">Nenhum Livro encontrado</response>
        /// <response code="400">"Ocorreu um erro na execução."</response>

        [HttpGet]
        [SwaggerResponseExample(200, typeof(LivrosResponseModelExample), jsonConverter: typeof(StringEnumConverter))]
        [SwaggerResponseExample(400, typeof(TodosLivrosResponse400), jsonConverter: typeof(StringEnumConverter))]
        [ProducesResponseType(200, Type = typeof(LivrosResponse))]
        [ProducesResponseType(400, Type = typeof(MensagemError))]
        [Route("filtro")]
        public HttpResponseMessage GetBuscaLivro(string key,string value)
        {
            try
            {

                var retorno = ResponseBasicJson(HttpStatusCode.OK,null);
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
