using livraria.api.mode.Model.Entidades;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;

namespace livraria.api.mode.Model.Response
{
    public class EditoraResponse
    {
        public Editora editora;
    }

    public class EditoraResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new EditoraResponse
            {
                editora = 
                    new Editora()
                    {
                        Nome = "teste",
                    }
            };

        }
    }
}
