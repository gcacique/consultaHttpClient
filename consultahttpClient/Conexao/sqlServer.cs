using System;
using System.Data.SqlClient;
using System.IO;

namespace consultahttpClient.Conexao
{
    public class sqlServer
    {
        

        public sqlServer()
        {
            string retornoApi = executarApi.ConsultaVerboGet<Entidades.viaCep>(string.Format("http://viacep.com.br/ws/01001000/json/"));
            

        }

        
    }
}