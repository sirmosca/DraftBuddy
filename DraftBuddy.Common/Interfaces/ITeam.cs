namespace DraftBuddy.Common.Interfaces
{
    public interface ITeam
    {
        /// <summary>
        /// Gets or sets the professional team.
        /// </summary>
        /// <value>The professional team.</value>
        string ProfessionalTeam { get; set; }

        /// <summary>
        /// Gets or sets the bye week.
        /// </summary>
        /// <value>The bye week.</value>
        int ByeWeek { get; set; }
    }
}