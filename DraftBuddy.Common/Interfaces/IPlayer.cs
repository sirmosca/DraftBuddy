using System.ComponentModel;

namespace DraftBuddy.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [Browsable(false)]
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ReadOnly(true)]
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>The team.</value>
        [ReadOnly(true)]
        string ProfessionalTeam { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        [ReadOnly(true)]
        string Position { get; set; }

        /// <summary>
        /// Gets or sets the bye week.
        /// </summary>
        /// <value>The bye week.</value>
        [DisplayName("Bye Week")]
        [ReadOnly(true)]
        int ByeWeek { get; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>The rank.</value>
        [ReadOnly(true)]
        int Rank { get; set; }

        /// <summary>
        /// Gets or sets the draft.
        /// </summary>
        /// <value>The draft.</value>
        [ReadOnly(true)]
        decimal AveragePick { get; set; }

        /// <summary>
        /// Gets or sets the overall.
        /// </summary>
        /// <value>The overall.</value>
        [ReadOnly(true)]
        [Browsable(false)]
        decimal Overall { get; set; }

        /// <summary>
        /// Gets or sets the standard deviation.
        /// </summary>
        /// <value>The standard deviation.</value>
        [DisplayName("Std. Dev.")]
        [ReadOnly(true)]
        [Browsable(false)]
        decimal StandardDeviation { get; set; }

        /// <summary>
        /// Gets or sets the high.
        /// </summary>
        /// <value>The high.</value>
        [ReadOnly(true)]
        decimal High { get; set; }

        /// <summary>
        /// Gets or sets the low.
        /// </summary>
        /// <value>The low.</value>
        [ReadOnly(true)]
        decimal Low { get; set; }

        /// <summary>
        /// Gets or sets the times picked.
        /// </summary>
        /// <value>The times picked.</value>
        [DisplayName("# Drafted")]
        [ReadOnly(true)]
        int TimesDrafted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is watching.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is watching; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Watch")]
        bool IsWatching { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is drafted.
        /// </summary>
        /// <value><c>true</c> if this instance is drafted; otherwise, <c>false</c>.</value>
        [DisplayName("Drafted")]
        [Browsable(false)]
        bool IsDrafted { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [owning player].
        /// </summary>
        /// <value><c>true</c> if [owning player]; otherwise, <c>false</c>.</value>
        [DisplayName("Fantasy Team")]
        string FantasyTeam { get; set; }

        /// <summary>
        /// Gets or sets the custom column.
        /// </summary>
        /// <value>The custom column.</value>
        [DisplayName("Custom")]
        double CustomColumn { get; set; }
    }
}