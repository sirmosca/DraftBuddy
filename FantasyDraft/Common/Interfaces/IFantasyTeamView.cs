using System;
using System.Collections.Generic;
using DraftBuddy.Common.EventArgs;

namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// </summary>
    public interface IFantasyTeamView
    {
        /// <summary>
        ///     Gets the owning person.
        /// </summary>
        /// <value>The owning person.</value>
        string FantasyTeam { get; }

        /// <summary>
        ///     Sets the data.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <param name="players">The players.</param>
        void SetData(string person, List<IPlayer> players);

        /// <summary>
        ///     Shows this instance.
        /// </summary>
        void ShowView();

        /// <summary>
        ///     Occurs when [unsubscribing].
        /// </summary>
        event EventHandler<SimpleEventArgs<string>> Unsubscribing;

        void CloseView();
    }
}