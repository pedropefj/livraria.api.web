using livraria.api.mode.Model.Entidades;
using livraria.api.mode.Model.Request;
using livraria.api.mode.Model.Response;
using livraria.api.model.Interfaces;
using System.Collections.Generic;

namespace livraria.api.negocio
{
    public class LivrariaBLL : ILivrariaBLL
    {
        public LivrariaBLL(){}

        public AutoresResponse obterAutores() {

            return new AutoresResponse
            {
                autores = new List<Autor>()
                {
                    new Autor()
                    {
                        Nome = "teste",
                        Genero = "teste"
                    },
                    new Autor()
                    {
                        Nome = "teste1",
                        Genero = "teste1"
                    }
                }
            };
        }

        public AutorResponse obterAutor(int idAutor)
        {
            return new AutorResponse()
            {
                autor = new Autor()
                {
                    Nome = "teste",
                    Genero = "teste"
                }
            };
        }

        public bool criarAutor(AutorRequest autor)
        {
            return true;
        }

        public bool deletarAutor(int idAutor)
        {
            return true;
        }

        public AutorResponse updateAutor(int id, AutorRequest autor)
        {
            return new AutorResponse()
            {
                autor = new Autor()
                {
                    Nome = autor.Nome,
                    Genero = autor.Genero
                }
            };
        }

        public EditorasResponse obterEditoras()
        {
            return new EditorasResponse
            {
                editoras = new List<Editora>()
                {
                    new Editora()
                    {
                        Nome = "teste",
                        Id = 1
                    },
                    new Editora()
                    {
                        Nome = "teste1",
                    }
                }
            };
        }

        public EditoraResponse obterEditora(int idEditora)
        {
            return new EditoraResponse
            {
                editora = new Editora()
                    {
                        Nome = "teste",
                        Id = 1
                    }
                
            };
        }

        public bool criarEditora(AutorRequest autor)
        {
            return true;
        }

        public bool deletarEditora(int idAutor)
        {
            return true;
        }

        public EditoraResponse updateEditora(int id, EditoraRequest editora)
        {
            return new EditoraResponse()
            {
                editora = new Editora()
                {
                    Nome = editora.Nome,
                }
            };
        }



    }
}
