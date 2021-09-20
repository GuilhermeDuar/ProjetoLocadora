using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ResponseFactory
    {
        public static Response CreateSuccesResponse()
        {
            Response r = new Response()
            {
                Success = true,
                Message = "Operação realizada com sucesso."
            };
            return r;
        }

        public static Response CreateFailResponse()
        {
            Response r = new Response()
            {
                Success = false,
                Message = "Erro no Bando de Dados, contate um administrador."
            };
            return r;
        }
    }
}
