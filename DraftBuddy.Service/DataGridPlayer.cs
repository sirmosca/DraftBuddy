using System.ComponentModel;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Service
{
    /// <summary>
    /// Used to display player information on a data grid view
    /// </summary>
    public class DataGridPlayer : IPlayer
    {
        /// <summary>
        /// Gets or sets the standard deviation.
        /// </summary>
        /// <value>The standard deviation.</value>
        [DisplayName("Std. Dev.")]
        [ReadOnly(true)]
        [Browsable(false)]
        public decimal StandardDeviation { get; set; }

        /// <summary>
        /// Gets or sets the high.
        /// </summary>
        /// <value>The high.</value>
        [ReadOnly(true)]
        public decimal High { get; set; }

        /// <summary>
        /// Gets or sets the low.
        /// </summary>
        /// <value>The low.</value>
        [ReadOnly(true)]
        public decimal Low { get; set; }

        /// <summary>
        /// Gets or sets the times picked.
        /// </summary>
        /// <value>The times picked.</value>
        [DisplayName("# Picked")]
        [ReadOnly(true)]
        public int TimesDrafted { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ReadOnly(true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>The team.</value>
        [ReadOnly(true)]
        public string ProfessionalTeam { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        [ReadOnly(true)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the bye week.
        /// </summary>
        /// <value>The bye week.</value>
        [DisplayName("Bye Week")]
        [ReadOnly(true)]
        public int ByeWeek { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>The rank.</value>
        [ReadOnly(true)]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets the pick.
        /// </summary>
        /// <value>The pick.</value>
        [ReadOnly(true)]
        public decimal AveragePick { get; set; }

        /// <summary>
        /// Gets or sets the overall.
        /// </summary>
        /// <value>The overall.</value>
        [ReadOnly(true)]
        [Browsable(false)]
        public decimal Overall { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is watching.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is watching; otherwise, <c>false</c>.
        /// </value>
        [DisplayName("Watch")]
        public bool IsWatching { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is picked.
        /// </summary>
        /// <value><c>true</c> if this instance is picked; otherwise, <c>false</c>.</value>
        [DisplayName("Picked")]
        [Browsable(false)]
        public bool IsDrafted
        {
            get { return !string.IsNullOrEmpty(FantasyTeam); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [owning player].
        /// </summary>
        /// <value><c>true</c> if [owning player]; otherwise, <c>false</c>.</value>
        [DisplayName("Owning Player")]
        public string FantasyTeam { get; set; }

        /// <summary>
        /// Gets or sets the custom column.
        /// </summary>
        /// <value>The custom column.</value>
        [DisplayName("Custom")]
        public double CustomColumn { get; set; }
    }
}