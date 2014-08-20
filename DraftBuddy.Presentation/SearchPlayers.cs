using System.Collections.Generic;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchPlayers
    {
        /// <summary>
        /// Searches the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="players">The players.</param>
        /// <returns></returns>
        public List<IPlayer> SearchByName(string name, IEnumerable<IPlayer> players)
        {
            List<IPlayer> collection = new List<IPlayer>();

            foreach (IPlayer player in players)
            {
                if (player.Name.ToUpper().Contains(name.ToUpper()))
                {
                    collection.Add(player);
                }
            }

            return collection;
        }
    }
}