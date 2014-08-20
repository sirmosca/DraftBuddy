using System.Collections.Generic;
using System.Linq;
using DraftBuddy.Common.EventArgs;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation.Presenters
{
    /// <summary>
    /// 
    /// </summary>
    public class FantasyTeamPresenter : IObserver
    {
        private ISubject _Subject;
        private IFantasyTeamView _View;

        /// <summary>
        /// Initializes a new instance of the <see cref="FantasyTeamPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="owningPerson">The owning person.</param>
        /// <param name="subject">The subject.</param>
        public FantasyTeamPresenter(IFantasyTeamView view, string owningPerson, ISubject subject)
        {
            _View = view;
            _View.Unsubscribing += Unsubscribing;
            FantasyTeam = owningPerson;
            _Subject = subject;
        }

        /// <summary>
        /// Updates the view.
        /// </summary>
        /// <param name="players">The players.</param>
        public void UpdateView(List<IPlayer> players)
        {
            var fantasyTeamPlayers = players.Select(player => new FantasyTeamPlayer(player)).Cast<IPlayer>().ToList();

            _View.SetData(FantasyTeam, fantasyTeamPlayers);
        }

        /// <summary>
        /// Gets the owning player.
        /// </summary>
        /// <value>The owning player.</value>
        public string FantasyTeam { get; private set; }

        private void Unsubscribing(object sender, SimpleEventArgs<string> e)
        {
            _Subject.Detach(this);
        }
    }
}