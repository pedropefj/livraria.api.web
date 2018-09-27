using livraria.api.mode.Model.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;

namespace livraria.api.model.Util
{
    public class ExemplosUtil
    {
        public static List<MensagemError> ListarMensagens(List<string> listaCodigos, HttpStatusCode statusCode)
        {
            List<MensagemError> listaMsgs = new List<MensagemError>();

            foreach (string codigo in listaCodigos)
            {
                try
                {
                    string msg = mensagens_livraria_api.ResourceManager.GetString(codigo);
                    if (!string.IsNullOrEmpty(msg))
                        listaMsgs.Add(new MensagemError() { StatusCode = statusCode, Codigo = codigo.Replace("M", ""), Mensagem = msg });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

            }
            return listaMsgs.OrderBy(s => Convert.ToInt32(s.Codigo)).ToList();
        }
        private static void acrescentaMensagens(ref List<MensagemError> lista, List<string> listaCodigos, HttpStatusCode statusCode, ResourceManager resource)
        {
            foreach (string codigo in listaCodigos)
            {
                try
                {
                    string msg = resource.GetString(codigo);
                    if (!string.IsNullOrEmpty(msg))
                        lista.Add(new MensagemError() { StatusCode = statusCode, Codigo = codigo.Replace("M", ""), Mensagem = msg });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

            }
        }
    }
}
