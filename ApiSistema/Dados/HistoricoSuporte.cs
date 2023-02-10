using ApiSistema.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ApiSistema.Controllers;
using ApiSistema.Dados;
using ApiSistema.Poco;
using ApiSistema.DataBase;


namespace ApiSistema.Dados
{
    /// <summary>
    /// acesso ao SQL list e insert
    /// </summary>
    public class HistoricoSuporte
    {
        public string Listar()
        {
            string Retorno = string.Empty;
            try
            {
                DataSet HSuporte = new DataSet();
                ConnectDB oConnect = new ConnectDB();

                using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
                {
                    dbConnection.Open();
                    try
                    {
                        // 1. inicia o SqlDataAdapter passando o comando SQL para selecionar historico de suporte
                        // e a conexão com o banco de dados
                        SqlDataAdapter SqlEquipamento = new SqlDataAdapter("SELECT * from HistoricoSuporte", dbConnection);
                        // 2. preenchimento do dataset
                        SqlEquipamento.Fill(HSuporte);
                        Retorno = JsonConvert.SerializeObject(HSuporte, Formatting.Indented).ToString();
                    }
                    catch (Exception) { }
                    dbConnection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Retorno;
        }
        internal string Insert_Suporte(string equipamento, string dataManutencao, string anotacao, string id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// metodo de insert no banco de dados usando as variaveis equpamento, datamanutencao, anotacao

        public string Insert_Suporte(
            
             string Equipamento,
             string DataManutencao,
             string Anotacao)
        {
            ConnectDB oConnect = new ConnectDB();

            String Retorno = string.Empty;

            using (SqlConnection dbConnection = new SqlConnection(oConnect.StringConnect()))
            {
                dbConnection.Open();
                try
                {
                    ///String CommandoInsert = INSERT INTO dbo.[HistoricoSuporte] +
                    /// Ajusta o Insert para seu projeto
                    String CommandoInsert = "INSERT INTO HistoricoSuporte" +
                        $"( " + $"Equipamento," + $"Data," + $"Anotacao)" +$" VALUES " +
                        $"( " +
                        $"'{Equipamento}'," + $"'{DataManutencao}'," + $"'{Anotacao}')";

                    SqlCommand command_tmp =
                    new
                    SqlCommand(CommandoInsert, dbConnection);

                    command_tmp.ExecuteNonQuery();
                    ///retorno do metodo ok
                    Retorno = "OK";
                }
                ///tratamento de erro
                catch (Exception ex)
                {
                    Retorno = "erro de envio" + ex;
                }
                dbConnection.Close();
            }
            return Retorno;
        }
    }
}
