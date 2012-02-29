using System;
using System.Collections.Generic;
using DraftBuddy.Common.EventArgs;

namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDraftBuddyView
    {
        /// <summary>
        /// Sets the players.
        /// </summary>
        /// <param name="players">The players.</param>
        void SetPlayers(List<IPlayer> players);

        /// <summary>
        /// Occurs when [get players by position].
        /// </summary>
        event EventHandler<PlayersByPositionEventArgs> GetPlayersByPosition;

        /// <summary>
        /// Occurs when [get players to watch].
        /// </summary>
        event EventHandler<PlayersToWatchEventArgs> GetPlayersToWatch;

        /// <summary>
        /// Occurs when [update player].
        /// </summary>
        event EventHandler<SimpleEventArgs<IPlayer>> UpdatePlayer;

        /// <summary>
        /// Occurs when [add person].
        /// </summary>
        event EventHandler<SimpleEventArgs<string>> AddPerson;

        /// <summary>
        /// Occurs when [search].
        /// </summary>
        event EventHandler<SearchEventArgs> Search;

        /// <summary>
        /// Occurs when [player picked].
        /// </summary>
        event EventHandler PlayerPicked;

        /// <summary>
        /// Gets the new person team view.
        /// </summary>
        /// <returns></returns>
        IFantasyTeamView GetNewPersonTeamView();
    }
}