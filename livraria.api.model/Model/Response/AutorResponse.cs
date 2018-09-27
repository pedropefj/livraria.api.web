using livraria.api.mode.Model.Entidades;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;

namespace livraria.api.mode.Model.Response
{
    public class AutorResponse
    {
        public Autor autor;
    }

    public class AutorResponseModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new Autor()
            {
                Nome = "teste",
                Genero = "teste"
            };

        }
    }
}
