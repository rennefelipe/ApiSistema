using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ApiSistema.DataBase
{
    /// <summary>
    /// poco de conecao
    /// </summary>
    public class ConnectionStrings
    {
        public string MYSQL_DBHOST { get; set; }
        public string MYSQL_DBPORT { get; set; }
        public string MYSQL_PASSWORD { get; set; }
        public string MYSQL_USER { get; set; }
        public string MYSQL_DATABASE { get; set; }
    }
    public class StruConfig
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }
}
       

