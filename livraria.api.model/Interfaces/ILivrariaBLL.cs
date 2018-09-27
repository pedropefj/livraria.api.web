using livraria.api.mode.Model.Request;
using livraria.api.mode.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.api.model.Interfaces
{
    public interface ILivrariaBLL
    {
        AutoresResponse obterAutores();

        AutorResponse obterAutor(int idAutor);

        bool criarAutor(AutorRequest autor);

        bool deletarAutor(int idAutor);

        AutorResponse updateAutor(int id, AutorRequest autor);

        EditorasResponse obterEditoras();

        EditoraResponse obterEditora(int iEditora);

        bool criarEditora(AutorRequest autor);

        bool deletarEditora(int idEditora);

        EditoraResponse updateEditora(int id, EditoraRequest editora);
    }
}
