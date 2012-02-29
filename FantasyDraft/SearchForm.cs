using System.Windows.Forms;

namespace DraftBuddy
{
    public partial class SearchForm : Form
    {
        private string _PlayerName = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForm"/> class.
        /// </summary>
        /// <param name="playerName">Name of the player.</param>
        public SearchForm(string playerName)
        {
            InitializeComponent();
            _PlayerName = playerName;
        }

        private void SearchFormLoad(object sender, System.EventArgs e)
        {
            Text = _PlayerName;
            webBrowser1.Navigate(string.Format("http://search.espn.go.com/{0}/", _PlayerName));
        }
    }
}