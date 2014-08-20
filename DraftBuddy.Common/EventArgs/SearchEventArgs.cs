namespace DraftBuddy.Common.EventArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchEventArgs : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEventArgs"/> class.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        public SearchEventArgs(string searchText)
        {
            SearchText = searchText;
        }

        /// <summary>
        /// Gets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; private set; }
    }
}