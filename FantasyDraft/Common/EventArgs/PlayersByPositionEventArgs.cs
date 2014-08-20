using System.Collections.Generic;

namespace DraftBuddy.Common.EventArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayersByPositionEventArgs : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersByPositionEventArgs"/> class.
        /// </summary>
        /// <param name="positions">The positions.</param>
        /// <param name="showPicked">if set to <c>true</c> [show picked].</param>
        public PlayersByPositionEventArgs(List<string> positions, bool showPicked)
        {
            Positions = positions;
            ShowPicked = showPicked;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show picked].
        /// </summary>
        /// <value><c>true</c> if [show picked]; otherwise, <c>false</c>.</value>
        public bool ShowPicked { get; private set; }

        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <value>The position.</value>
        public List<string> Positions { get; private set; }
    }
}