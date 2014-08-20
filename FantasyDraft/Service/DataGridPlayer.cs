using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Service
{
    /// <summary>
    ///     Used to display player information on a data grid view
    /// </summary>
    public class DataGridPlayer : IPlayer
    {
        private string _fantasyTeam;

        public DataGridPlayer(double adp,
                              double overall,
                              string name,
                              string position,
                              string nflTeam,
                              int numberOfTimesDrafted,
                              int bye)
        {
            ADP = adp;
            Overall = overall;
            Name = name;
            Position = position;
            NflTeam = nflTeam;
            NumberOfTimesDrafted = numberOfTimesDrafted;
            Bye = bye;
        }

        public double ADP { get; private set; }
        public double Overall { get; private set; }
        public string Name { get; private set; }
        public string Position { get; private set; }
        public string NflTeam { get; private set; }
        public int NumberOfTimesDrafted { get; private set; }
        public int Bye { get; private set; }
        public bool IsWatching { get; set; }

        public string FantasyTeam
        {
            get { return _fantasyTeam; }
            set
            {
                _fantasyTeam = value;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _fantasyTeam = value.Trim();
                }
            }
        }

        public bool IsDrafted
        {
            get { return !string.IsNullOrWhiteSpace(FantasyTeam); }
        }
    }
}