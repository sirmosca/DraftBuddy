using System.Collections.Generic;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPlayers
    {
        /// <summary>
        /// Gets the player by position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="players">The players.</param>
        /// <param name="showPicked">if set to <c>true</c> [show picked].</param>
        /// <returns></returns>
        public IEnumerable<IPlayer> GetPlayersByPosition(string position, IEnumerable<IPlayer> players, bool showPicked)
        {
            ICollection<IPlayer> collection = new List<IPlayer>();

            if (showPicked)
            {
                foreach (IPlayer player in players)
                {
                    if (player.Position == position)
                    {
                        collection.Add(player);
                    }
                }
            }
            else
            {
                foreach (IPlayer player in players)
                {
                    if (player.Position == position && !player.IsDrafted)
                    {
                        collection.Add(player);
                    }
                }
            }

            List<IPlayer> playerList = new List<IPlayer>(collection);
            new SortPlayers().SortPlayerList(SortDirection.Ascending, playerList);

            return playerList;
        }

        /// <summary>
        /// Gets the player list to watch.
        /// </summary>
        /// <param name="players">The players.</param>
        /// <param name="showPicked">if set to <c>true</c> [show picked].</param>
        /// <returns></returns>
        public List<IPlayer> GetPlayersToWatch(IEnumerable<IPlayer> players, bool showPicked)
        {
            ICollection<IPlayer> collection = new List<IPlayer>();

            if (showPicked)
            {
                foreach (IPlayer player in players)
                {
                    if (player.IsWatching)
                    {
                        collection.Add(player);
                    }
                }
            }
            else
            {
                foreach (IPlayer player in players)
                {
                    if (player.IsWatching && !player.IsDrafted)
                    {
                        collection.Add(player);
                    }
                }
            }

            List<IPlayer> playerList = new List<IPlayer>(collection);
            playerList.Sort((r1, r2) => r1.Rank.CompareTo(r2.Rank));
            return playerList;
        }
    }
}