using System;
using System.Collections.Generic;
using System.IO;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Service
{
    public class DataAccess
    {
        public List<IPlayer> GetDraftData()
        {
            var players = new List<IPlayer>();

            using (TextReader reader = new StreamReader(@".\draft_data.dat"))
            {
                string line = ReadHeaderRow(reader);
                while ((line = reader.ReadLine()) != null)
                {
                    var tokens = line.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);

                    double adp = Convert.ToDouble(tokens[0]);
                    double overall = Convert.ToDouble(tokens[1]);
                    string name = tokens[2];
                    string position = tokens[3];
                    string nflTeam = tokens[4];
                    int numberOfTimesDrafted = Convert.ToInt32(tokens[5]);
                    int bye = Convert.ToInt32(tokens[6]);
                    IPlayer player = new DataGridPlayer(adp, overall, name, position, nflTeam, numberOfTimesDrafted, bye);
                    players.Add(player);
                }
            }

            return players;
        }

        private string ReadHeaderRow(TextReader reader)
        {
            return reader.ReadLine();
        }
    }
}