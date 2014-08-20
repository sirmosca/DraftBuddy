using System.ComponentModel;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    public class FantasyTeamPlayer : IPlayer
    {
        public FantasyTeamPlayer(IPlayer player)
        {
            ADP = player.ADP;
            Overall = player.Overall;
            Name = player.Name;
            Position = player.Position;
            NflTeam = player.NflTeam;
            NumberOfTimesDrafted = player.NumberOfTimesDrafted;
            Bye = player.Bye;
            IsWatching = player.IsWatching;
            FantasyTeam = player.FantasyTeam;
        }

        public double ADP { get; private set; }
        public double Overall { get; private set; }
        public string Name { get; private set; }
        public string Position { get; private set; }
        public string NflTeam { get; private set; }

        [Browsable(false)]
        public int NumberOfTimesDrafted { get; private set; }

        public int Bye { get; private set; }

        [Browsable(false)]
        public bool IsWatching { get; set; }

        [Browsable(false)]
        public string FantasyTeam { get; set; }

        [Browsable(false)]
        public bool IsDrafted
        {
            get { return !string.IsNullOrWhiteSpace(FantasyTeam); }
        }
    }
}