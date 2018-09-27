using livraria.api.mode.Model.Response;
using System;

namespace livraria.api.mode.Model.ValidacaoException
{
    public class ValidacaoException : Exception
    {
        public MensagemError MensagemError { get; set; }

        public ValidacaoException(MensagemError mensagem)
        {
            MensagemError = mensagem;
        }
    }
}
