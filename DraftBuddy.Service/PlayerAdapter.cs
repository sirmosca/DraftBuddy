using System;
using System.Collections.Generic;
using System.Data;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerAdapter
    {
        /// <summary>
        /// Converts the players.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns></returns>
        public List<IPlayer> ConvertPlayers(DataTable dataTable)
        {
            List<IPlayer> players = new List<IPlayer>();
            foreach (DataRow row in dataTable.Rows)
            {
                DataGridPlayer player = new DataGridPlayer
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString().Trim(),
                        Overall = Convert.ToDecimal(row["overall"]),
                        AveragePick = Convert.ToDecimal(row["pick"]),
                        Position = row["Pos"].ToString().Trim(),
                        ProfessionalTeam = row["Team"].ToString().Trim(),
                        TimesDrafted = Convert.ToInt32(row["Times"]),
                        Rank = Convert.ToInt32(row["Id"]),
                        FantasyTeam = "",
                        IsWatching = false,
                        ByeWeek = Convert.ToInt16(row["week"])
                    };
                players.Add(player);
            }

            players.Sort((p1, p2) => p1.Rank.CompareTo(p2.Rank));

            return players;
        }
    }
}