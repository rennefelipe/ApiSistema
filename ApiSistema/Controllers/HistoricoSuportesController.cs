using Microsoft.AspNetCore.Mvc;
using System;
using ApiSistema.Dados;
using ApiSistema.Poco;
using ApiSistema.DataBase;
using ApiSistema.Tools;
using HistoricoSuporte = ApiSistema.Dados.HistoricoSuporte;

namespace ApiSistema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    ///controller da API para o poco HistoricoSuporte
    public class SuporteController : Controller
    {
        [HttpGet]
        public string ListarSuporte()
        {
            HistoricoSuporte oSuporte = new HistoricoSuporte();
            return oSuporte.Listar();
        }
        [HttpPost]
        ///metotodo post
        public string InsertSuporte(string Equipamento, string DataManutencao, string Anotacao)
        {
            string Retorno = string.Empty;
            try
            {
                HistoricoSuporte oEquipamento = new HistoricoSuporte();
                Retorno = oEquipamento.Insert_Suporte(Equipamento, DataManutencao, Anotacao);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu pal" + ex);
                ////thr "Erro de comunicao";
                //Console.WriteLine("Deu pal " + ex);
            }
            return Retorno;
        }
    }
}
