using System.Collections.Generic;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePlayers
    {
        /// <summary>
        /// Updates the player.
        /// </summary>
        /// <param name="players">The players.</param>
        /// <param name="playerToUpdate">if set to <c>true</c> [watch].</param>
        /// <param name="id">The id.</param>
        public void UpdatePlayer(IEnumerable<IPlayer> players, IPlayer playerToUpdate, int id)
        {
            List<IPlayer> collection = new List<IPlayer>();

            foreach (IPlayer player in players)
            {
                if (player.Id == id)
                {
                    collection.Add(player);
                }
            }

            foreach (IPlayer player in collection)
            {
                player.IsWatching = playerToUpdate.IsWatching;

                if (!string.IsNullOrEmpty(playerToUpdate.FantasyTeam))
                {
                    player.FantasyTeam = playerToUpdate.FantasyTeam.Trim().ToUpper();
                }
            }
        }
    }
}