using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using livraria.api.mode.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace livraria.api.Controllers
{
    public abstract class BaseController : ApiController
    {
        /// <summary>
        /// Método para construir uma resposta padrão.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [NonAction]
        public HttpResponseMessage ResponseBasic(HttpStatusCode statusCode, string content = "")
        {
            if (string.IsNullOrEmpty(content))
            {
                return new HttpResponseMessage()
                {
                    StatusCode = statusCode
                };
            }
            return new HttpResponseMessage()
            {
                StatusCode = statusCode,
                Content = new StringContent(content, System.Text.Encoding.UTF8, "application/json")
            };
        }

        /// <summary>
        /// Método para construir uma resposta padrão com um JSON.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        /// 
        [NonAction]

        public HttpResponseMessage ResponseBasicJson(HttpStatusCode statusCode, object content)
        {
            if (content == null)
            {
                return new HttpResponseMessage()
                {
                    StatusCode = statusCode
                };
            }

            if (statusCode.Equals(HttpStatusCode.NoContent))
                return new HttpResponseMessage()
                {
                    StatusCode = statusCode
                };

            var retorno = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                Content = new StringContent(JsonConvert.SerializeObject(content
                    , new JsonSerializerSettings { ContractResolver = new JsonNameToPropertyNameContractResolver() })
                    , System.Text.Encoding.UTF8, "application/json")
            };

            return retorno;
        }


    }


}