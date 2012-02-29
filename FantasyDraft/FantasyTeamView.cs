using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DraftBuddy.Common.EventArgs;
using DraftBuddy.Common.Interfaces;
using DraftBuddy.Presentation;

namespace DraftBuddy
{
    public partial class FantasyTeamView : Form, IFantasyTeamView
    {
        private string _FantasyTeam = "";
        private int _Counter;

        public FantasyTeamView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when [unsubscribing].
        /// </summary>
        public event EventHandler<SimpleEventArgs<string>> Unsubscribing;

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <param name="players">The players.</param>
        public void SetData(string person, List<IPlayer> players)
        {
            _FantasyTeam = person;
            Text = string.Format("{0} Fantasy Team", _FantasyTeam);
            UxDataGridViewTeam.DataSource = players;
        }

        private void PersonTeamViewFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Unsubscribing != null)
            {
                Unsubscribing(e, new SimpleEventArgs<string>(_FantasyTeam));
            }
        }

        /// <summary>
        /// Gets the owning person.
        /// </summary>
        /// <value>The owning person.</value>
        public string FantasyTeam { get { return _FantasyTeam; } }

        private void UxDataGridViewTeamColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _Counter++;
            List<IPlayer> players = UxDataGridViewTeam.DataSource as List<IPlayer>;

            if (players == null)
            {
                MessageBox.Show(@"No data!! Is there anything in the grid?");
                return;
            }

            if (_Counter % 2 == 0)
            {
                new SortPlayers().SortPlayerList(SortDirection.Descending, players, UxDataGridViewTeam.Columns[e.ColumnIndex].DataPropertyName);
            }
            else
            {
                new SortPlayers().SortPlayerList(SortDirection.Ascending, players, UxDataGridViewTeam.Columns[e.ColumnIndex].DataPropertyName);
            }

            UxDataGridViewTeam.Refresh();
        }
    }
}