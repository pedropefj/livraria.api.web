using livraria.api.mode.Model.Entidades;
using livraria.api.model.Util;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;
using System.Net;

namespace livraria.api.mode.Model.Response
{
    public class EditorasResponse
    {
        public List<Editora> editoras;
    }

    public class EditorasResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new EditorasResponse
            {
                editoras = new List<Editora>()
                {
                    new Editora()
                    {
                        Nome = "teste",
                    },
                    new Editora()
                    {
                        Nome = "teste1",
                    }
                }
            };

        }
    }

    public class TodasEditorasResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
    public class GetEditoraResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class PostEditoraResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0006" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class DeleteEditoraResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0007" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }

    public class UpdateEditoraResponse400 : IExamplesProvider
    {
        public object GetExamples()
        {
            List<string> listaCodigos = new List<string> { "M199", "M0001", "M0007" };
            var retorno = ExemplosUtil.ListarMensagens(listaCodigos, HttpStatusCode.BadRequest);
            return retorno;
        }
    }
}
