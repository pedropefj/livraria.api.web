using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace livraria.api.mode.Model.Response
{
    public class MensagemError
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
        public string Codigo { get; set; }
        public string Mensagem { get; set; }

        public MensagemError(HttpStatusCode statusCode, string codigo, string mensagem)
        {
            StatusCode = statusCode;
            Codigo = codigo;
            Mensagem = mensagem;
        }

        public MensagemError() { }
    }
}
