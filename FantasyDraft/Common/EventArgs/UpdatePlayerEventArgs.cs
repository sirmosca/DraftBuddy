namespace DraftBuddy.Common.EventArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePlayerEventArgs : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayerEventArgs"/> class.
        /// </summary>
        /// <param name="isWatching">if set to <c>true</c> [is watching].</param>
        /// <param name="playerId">The player id.</param>
        public UpdatePlayerEventArgs(bool isWatching, int playerId)
        {
            IsWatching = isWatching;
            PlayerId = playerId;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is watching.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is watching; otherwise, <c>false</c>.
        /// </value>
        public bool IsWatching { get; private set; }

        /// <summary>
        /// Gets or sets the player id.
        /// </summary>
        /// <value>The player id.</value>
        public int PlayerId { get; private set; }
    }
}