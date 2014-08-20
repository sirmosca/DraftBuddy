using System.Collections.Generic;

namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Gets the owning player.
        /// </summary>
        /// <value>The owning player.</value>
        string OwningPlayer { get; }

        /// <summary>
        /// Updates the view.
        /// </summary>
        /// <param name="players">The players.</param>
        void UpdateView(List<IPlayer> players);
    }
}