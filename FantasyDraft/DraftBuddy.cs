using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DraftBuddy.Common.Constants;
using DraftBuddy.Common.EventArgs;
using DraftBuddy.Common.Interfaces;
using DraftBuddy.Presentation;
using DraftBuddy.Presentation.Presenters;

namespace DraftBuddy
{
    public partial class DraftBuddy : Form, IDraftBuddyView
    {
        private DataGridPlayerBindingList _bindingList;
        private DraftBuddyPresenter _presenter;

        public DraftBuddy()
        {
            InitializeComponent();
            _presenter = new DraftBuddyPresenter(this);
        }

        /// <summary>
        ///     Occurs when [get players by position].
        /// </summary>
        public event EventHandler<PlayersByPositionEventArgs> GetPlayersByPosition;

        /// <summary>
        ///     Occurs when [get players to watch].
        /// </summary>
        public event EventHandler<PlayersToWatchEventArgs> GetPlayersToWatch;

        /// <summary>
        ///     Occurs when [update player].
        /// </summary>
        public event EventHandler<SimpleEventArgs<IPlayer>> UpdatePlayer;

        /// <summary>
        ///     Occurs when [add person].
        /// </summary>
        public event EventHandler<SimpleEventArgs<string>> AddPerson;

        /// <summary>
        ///     Occurs when [search].
        /// </summary>
        public event EventHandler<SearchEventArgs> Search;

        /// <summary>
        ///     Occurs when [player picked].
        /// </summary>
        public event EventHandler DraftPlayer;

        public event Action<string> FantasyTeamDisplay;

        /// <summary>
        ///     Gets the new person team view.
        /// </summary>
        /// <returns></returns>
        public IFantasyTeamView GetNewPersonTeamView()
        {
            return new FantasyTeamView();
        }

        /// <summary>
        ///     Sets the players.
        /// </summary>
        /// <param name="players">The players.</param>
        public void SetPlayers(List<IPlayer> players)
        {
            _bindingList = new DataGridPlayerBindingList(players);
            UxDataGridView.DataSource = _bindingList;
        }

        private void FantasyDraftLoad(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string>
                                {
                                    PositionConstants.QuarterBack,
                                    PositionConstants.RunningBack,
                                    PositionConstants.WideReceiver,
                                    PositionConstants.TightEnd,
                                    PositionConstants.Defense,
                                    PositionConstants.Kicker
                                };

            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, false));

            showOnlyMyTeamToolStripMenuItem_Click(sender, e);
        }

        private void UxDataGridViewCurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (UxDataGridView.IsCurrentCellDirty)
            {
                UxDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void UxDataGridViewPaint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in UxDataGridView.Rows)
            {
                var player = row.DataBoundItem as IPlayer;
                if (player != null)
                {
                    if (player.IsDrafted)
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void UxTextBoxSearchKeyUp(object sender, KeyEventArgs e)
        {
            UxTextBoxSearch.ForeColor = Color.Black;

            if (e.KeyValue == (int) Keys.Enter)
            {
                if (Search != null)
                {
                    Search(sender, new SearchEventArgs(UxTextBoxSearch.Text));
                }

                UxTextBoxSearch.Focus();
                UxTextBoxSearch.SelectAll();
            }
        }

        private void UxTextBoxSearchClick(object sender, EventArgs e)
        {
            UxTextBoxSearch.Text = "";
        }

        private void FantasyDraftKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    RefreshView(e, sender);
                    break;
            }
        }

        private void RefreshView(KeyEventArgs e, object sender)
        {
            if (UxRadioButtonAll.Checked)
            {
                UxRadioButtonAllClick(sender, e);
            }
            else if (UxRadioButtonQB.Checked)
            {
                UxRadioButtonQbClick(sender, e);
            }
            else if (UxRadioButtonRb.Checked)
            {
                UxRadioButtonRbClick(sender, e);
            }
            else if (UxRadioButtonWr.Checked)
            {
                UxRadioButtonWrClick(sender, e);
            }
            else if (UxRadioButtonTe.Checked)
            {
                UxRadioButtonTeClick(sender, e);
            }
            else if (UxRadioButtonDef.Checked)
            {
                UxRadioButtonDefClick(sender, e);
            }
            else if (UxRadioButtonPk.Checked)
            {
                UxRadioButtonPkClick(sender, e);
            }
            else if (UxRadioButtonWatch.Checked)
            {
                UxRadioButtonWatchClick(sender, e);
            }
            else if (UxRadioButtonWrRb.Checked)
            {
                UxRadioButtonWrRbClick(sender, e);
            }
        }

        private void UxDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var sortDirectionTagValue = (bool?) UxDataGridView.Tag;
            var shouldSortAscending = (sortDirectionTagValue.HasValue && sortDirectionTagValue.Value) ||
                                      !sortDirectionTagValue.HasValue;

            string propertyName = UxDataGridView.Columns[e.ColumnIndex].DataPropertyName;
            var sortDirection = shouldSortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            _bindingList.ApplySort(propertyName, sortDirection);

            UxDataGridView.Tag = !shouldSortAscending;
            UxDataGridView.Refresh();
        }

        private void UpdateRadioButtonText(RadioButton radioButton)
        {
            foreach (Control c in UxGroupBoxView.Controls)
            {
                if (c is RadioButton)
                {
                    c.Font = new Font(c.Font, FontStyle.Regular);
                }
            }

            radioButton.Font = new Font(radioButton.Font, FontStyle.Bold);
        }

        private void UxDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            string columnName = UxDataGridView.Columns[e.ColumnIndex].Name;
            var player = UxDataGridView.Rows[e.RowIndex].DataBoundItem as IPlayer;

            if (columnName != "IsWatching")
            {
                return;
            }

            if (UpdatePlayer != null)
            {
                UpdatePlayer(sender, new SimpleEventArgs<IPlayer>(player));
            }
        }

        private void UxDataGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (UxDataGridView.Columns[e.ColumnIndex].Name != "FantasyTeam")
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            if (UxDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            var player = UxDataGridView.SelectedRows[0].DataBoundItem as IPlayer;

            if (player == null)
            {
                return;
            }

            if (AddPerson != null)
            {
                AddPerson(sender, new SimpleEventArgs<string>(player.FantasyTeam));
            }

            if (UpdatePlayer != null)
            {
                UpdatePlayer(sender, new SimpleEventArgs<IPlayer>(player));
            }

            if (DraftPlayer != null)
            {
                DraftPlayer(sender, e);
            }

            Cursor = Cursors.Default;
        }

        private void UxRadioButtonAllClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string>
                                {
                                    PositionConstants.QuarterBack,
                                    PositionConstants.RunningBack,
                                    PositionConstants.WideReceiver,
                                    PositionConstants.TightEnd,
                                    PositionConstants.Defense,
                                    PositionConstants.Kicker
                                };

            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));

            UpdateRadioButtonText(UxRadioButtonAll);
        }

        private void UxRadioButtonQbClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.QuarterBack};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonQB);
        }

        private void UxRadioButtonRbClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.RunningBack};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonRb);
        }

        private void UxRadioButtonWrClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.WideReceiver};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonWr);
        }

        private void UxRadioButtonWrRbClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.WideReceiver, PositionConstants.RunningBack};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonWrRb);
        }

        private void UxRadioButtonTeClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.TightEnd};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonTe);
        }

        private void UxRadioButtonDefClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.Defense};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonDef);
        }

        private void UxRadioButtonPkClick(object sender, EventArgs e)
        {
            if (GetPlayersByPosition == null)
            {
                return;
            }

            var positions = new List<string> {PositionConstants.Kicker};
            GetPlayersByPosition(sender, new PlayersByPositionEventArgs(positions, UxCheckBoxShowDrafted.Checked));
            UpdateRadioButtonText(UxRadioButtonPk);
        }

        private void UxRadioButtonWatchClick(object sender, EventArgs e)
        {
            if (GetPlayersToWatch != null)
            {
                GetPlayersToWatch(sender, new PlayersToWatchEventArgs(UxCheckBoxShowDrafted.Checked));
            }

            UpdateRadioButtonText(UxRadioButtonWatch);
        }

        private void DraftBuddyFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Are you sure you want to close?",
                                                  @"Exit?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void UxDataGridViewDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in UxDataGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void showOnlyMyTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UxFantasyTeamViewButton.Text = "My Team";

            if (FantasyTeamDisplay != null)
            {
                FantasyTeamDisplay("my");
            }
        }

        private void showAllTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UxFantasyTeamViewButton.Text = "All Teams";

            if (FantasyTeamDisplay != null)
            {
                FantasyTeamDisplay("all");
            }
        }

        private void showNoTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UxFantasyTeamViewButton.Text = "No Teams";

            if (FantasyTeamDisplay != null)
            {
                FantasyTeamDisplay("no");
            }
        }

        private void UxFantasyTeamViewButton_Click(object sender, EventArgs e)
        {
            UxFantasyTeamViewButton.ContextMenuStrip = UxFantasyTeamContextMenu;
            UxFantasyTeamContextMenu.Show(UxFantasyTeamViewButton, new Point(0, UxFantasyTeamViewButton.Height));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _presenter.SetFantasyTeamName(UxFantasyTeamNameTextBox.Text);
        }
    }
}