using System.Collections.Generic;

namespace DraftBuddy.Common.Interfaces
{
    public interface IDataAccess
    {
        /// <summary>
        /// Gets the mock draft player stats
        /// </summary>
        /// <returns></returns>
        List<IPlayer> GetMockDraftPlayers();

        /// <summary>
        /// Gets the teams.
        /// </summary>
        /// <returns></returns>
        List<ITeam> GetTeams();

        /// <summary>
        /// Saves the mock draft players
        /// </summary>
        /// <param name="players">The players.</param>
        void SaveMockDraftData(IEnumerable<IPlayer> players);

        /// <summary>
        /// Saves the teams.
        /// </summary>
        /// <param name="teams">The teams.</param>
        void SaveTeams(IEnumerable<ITeam> teams);
    }
}