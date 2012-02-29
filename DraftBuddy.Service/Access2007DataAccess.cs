using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using DraftBuddy.Common.Interfaces;
using DraftBuddy.Service.Properties;

namespace DraftBuddy.Service
{
    public class Access2007DataAccess
    {
        private string _connectionString = Settings.Default.AccessConnectionString;

        public List<IPlayer> GetMockDraftPlayers()
        {
            DataTable table = new DataTable();
            using (OleDbConnection oleDbConnection = new OleDbConnection(_connectionString))
            {
                oleDbConnection.Open();
                string sql = "SELECT draft.*, week FROM draft2 draft INNER JOIN Team ON draft.Team = Team.team";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, oleDbConnection);
                adapter.Fill(table);
            }

            List<IPlayer> players = new PlayerAdapter().ConvertPlayers(table);

            return players;
        }
    }
}