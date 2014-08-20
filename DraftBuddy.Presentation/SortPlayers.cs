using System;
using System.Collections;
using System.Collections.Generic;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    public class SortPlayers
    {
        /// <summary>
        /// Sorts the plalyers.
        /// </summary>
        /// <param name="sortDirection">The sort direction.</param>
        /// <param name="players">The players.</param>
        /// <param name="dataPropertyName">Name of the data property.</param>
        public void SortPlayerList(SortDirection sortDirection, List<IPlayer> players, string dataPropertyName)
        {
            if (players == null || players.Count == 0)
            {
                return;
            }

            GenericComparer comp = new GenericComparer(typeof(IPlayer), dataPropertyName) {SortingOrder = sortDirection};
            players.Sort(Comparison(comp));
        }

        /// <summary>
        /// Sorts the player list.
        /// </summary>
        /// <param name="sortDirection">The sort direction.</param>
        /// <param name="players">The players.</param>
        public void SortPlayerList(SortDirection sortDirection, List<IPlayer> players)
        {
            if (players == null || players.Count == 0)
            {
                return;
            }

            GenericComparer comp = new GenericComparer(typeof(IPlayer), "Rank") { SortingOrder = sortDirection };
            players.Sort(Comparison(comp));
        }

        private Comparison<IPlayer> Comparison(IComparer comp)
        {
            return comp.Compare;
        }
    }
}