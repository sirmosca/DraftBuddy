using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraftBuddy.Common.EventArgs;
using DraftBuddy.Common.Interfaces;
using DraftBuddy.Presentation;

namespace DraftBuddy
{
    public partial class FantasyTeamView : Form, IFantasyTeamView
    {
        private string _fantasyTeam = "";
        private int _counter;

        public FantasyTeamView()
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            Show();
        }

        public void CloseView()
        {
            Dispose();
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
            _fantasyTeam = person;
            Text = string.Format("Team {0}", _fantasyTeam);
            List<FantasyTeamPlayer> fantasyTeam = players.Select(player => new FantasyTeamPlayer(player)).ToList();
            UxDataGridViewTeam.DataSource = fantasyTeam;
        }

        private void PersonTeamViewFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Unsubscribing != null)
            {
                Unsubscribing(e, new SimpleEventArgs<string>(_fantasyTeam));
            }
        }

        /// <summary>
        /// Gets the owning person.
        /// </summary>
        /// <value>The owning person.</value>
        public string FantasyTeam { get { return _fantasyTeam; } }

        private void UxDataGridViewTeamColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _counter++;
            List<FantasyTeamPlayer> players = UxDataGridViewTeam.DataSource as List<FantasyTeamPlayer>;

            if (players == null)
            {
                MessageBox.Show(@"No data!! Is there anything in the grid?");
                return;
            }

            var sortDirectionTagValue = (bool?)UxDataGridViewTeam.Tag;
            var shouldSortAscending = (sortDirectionTagValue.HasValue && sortDirectionTagValue.Value) ||
                                      !sortDirectionTagValue.HasValue;

            var sortDirection = shouldSortAscending ? SortDirection.Ascending : SortDirection.Descending;
            SortPlayerList(sortDirection, players, UxDataGridViewTeam.Columns[e.ColumnIndex].DataPropertyName);

            UxDataGridViewTeam.Tag = !shouldSortAscending;
            UxDataGridViewTeam.Refresh();
        }

        private void SortPlayerList(SortDirection sortDirection, List<FantasyTeamPlayer> players, string dataPropertyName)
        {
            if (players == null || players.Count == 0)
            {
                return;
            }

            GenericComparer comp = new GenericComparer(typeof(IPlayer), dataPropertyName) { SortingOrder = sortDirection };
            players.Sort(Comparison(comp));
        }

        private Comparison<IPlayer> Comparison(IComparer comp)
        {
            return comp.Compare;
        }
    }
}