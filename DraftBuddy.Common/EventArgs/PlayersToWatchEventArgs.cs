namespace DraftBuddy.Common.EventArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayersToWatchEventArgs : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersToWatchEventArgs"/> class.
        /// </summary>
        /// <param name="showPicked">if set to <c>true</c> [show picked].</param>
        public PlayersToWatchEventArgs(bool showPicked)
        {
            ShowPicked = showPicked;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show picked].
        /// </summary>
        /// <value><c>true</c> if [show picked]; otherwise, <c>false</c>.</value>
        public bool ShowPicked { get; private set; }
    }
}