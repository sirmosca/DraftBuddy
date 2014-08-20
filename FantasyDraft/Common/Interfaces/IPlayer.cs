using System.ComponentModel;

namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPlayer
    {
        double ADP { get; }

        double Overall { get; }

        string Name { get; }

        string Position { get; }

        string NflTeam { get; }

        int NumberOfTimesDrafted { get; }

        int Bye { get; }

        bool IsWatching { get; set; }

        string FantasyTeam { get; set; }

        [Browsable(false)]
        bool IsDrafted { get; }
    }
}