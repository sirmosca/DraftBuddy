using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Service
{
    public class DataAccess
    {
        private string _connectionString = "Data Source=filename;Version=3;";

        public void CreateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string sql =
                        "drop table draft; create table draft (Id real primary key, pick real, overall real, name varchar(50), pos varchar(10), team varchar(10), times real, week real, rank real)";
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<IPlayer> GetMockDraftPlayers()
        {
            DataTable table = new DataTable();
            using (SQLiteConnection oleDbConnection = new SQLiteConnection(_connectionString))
            {
                oleDbConnection.Open();
                string sql = "SELECT * FROM draft ";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, oleDbConnection);
                adapter.Fill(table);
            }

            List<IPlayer> players = new PlayerAdapter().ConvertPlayers(table);

            return players;
        }

        public void PopulateData(List<IPlayer> players)
        {
            players.Sort((p1, p2) => p1.Rank.CompareTo(p2.Rank));
            foreach (var player in players)
            {
                StringBuilder builder = new StringBuilder();

                builder.Append("insert into draft (pick, overall, name, pos, team, times, week, rank)");
                builder.AppendFormat(
                    "values ({0}, {1}, '{2}', '{3}', '{4}', {5}, {6}, {7})",
                    player.AveragePick,
                    player.Overall,
                    player.Name,
                    player.Position,
                    player.ProfessionalTeam,
                    player.TimesDrafted,
                    player.ByeWeek,
                    player.Rank);

                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(builder.ToString(), connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}