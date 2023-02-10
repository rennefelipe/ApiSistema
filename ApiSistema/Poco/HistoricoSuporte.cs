using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistema.Poco
{
    /// <summary>
    /// poco da tabela historicoSuporte
    /// </summary>
    public class HistoricoSuporte
    {
        public int Id { get; set; }
        public string Equipamento { get; set; }
        public string DataManutencao { get; set; }
        public string Anotacao { get; set; }
    }
}
