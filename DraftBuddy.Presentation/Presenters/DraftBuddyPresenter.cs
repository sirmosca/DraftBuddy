using System;
using System.Collections.Generic;
using DraftBuddy.Common.EventArgs;
using DraftBuddy.Common.Interfaces;
using DraftBuddy.Service;

namespace DraftBuddy.Presentation.Presenters
{
    /// <summary>
    /// 
    /// </summary>
    public class DraftBuddyPresenter : ISubject, IDisposable
    {
        private List<IObserver> _Observers = new List<IObserver>();
        private List<string> _People = new List<string>();
        private List<IFantasyTeamView> _PersonTeamViews = new List<IFantasyTeamView>();
        private List<IPlayer> _Players;
        private IDraftBuddyView _View;

        /// <summary>
        /// Initializes a new instance of the <see cref="DraftBuddyPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public DraftBuddyPresenter(IDraftBuddyView view)
        {
            _View = view;
            _View.GetPlayersByPosition += GetPlayersByPosition;
            _View.GetPlayersToWatch += GetPlayersToWatch;
            _View.UpdatePlayer += UpdatePlayer;
            _View.Search += Search;
            _View.PlayerPicked += Notify;
            _View.AddPerson += AddPerson;
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        public void InitializeData()
        {
            DataAccess dataAccess = new DataAccess();
            _Players = dataAccess.GetMockDraftPlayers();
            
//            acces.CreateTable();
//            acces.PopulateData(_Players);
        }

        public void Dispose()
        {
            _View.GetPlayersByPosition -= GetPlayersByPosition;
            _View.GetPlayersToWatch -= GetPlayersToWatch;
            _View.UpdatePlayer -= UpdatePlayer;
            _View.Search -= Search;
            _View.PlayerPicked -= Notify;
            _View.AddPerson -= AddPerson;
            _View = null;
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Detach(IObserver observer)
        {
            if (_Observers.Contains(observer))
            {
                _Observers.Remove(observer);
            }

            IFantasyTeamView personTeamViewToRemove = _PersonTeamViews.Find(p => p.FantasyTeam == observer.OwningPlayer);

            if (personTeamViewToRemove != null)
            {
                _PersonTeamViews.Remove(personTeamViewToRemove);
            }
        }

        /// <summary>
        /// Sets the people.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="string"/> instance containing the event data.</param>
        private void AddPerson(object sender, SimpleEventArgs<string> e)
        {
            if (string.IsNullOrEmpty(e.Value))
            {
                return;
            }

            string p = e.Value.ToUpper().Trim();
            if (!_People.Contains(p))
            {
                _People.Add(p);
            }

            //todo: should do this from the presenter
            bool found = _PersonTeamViews.Find(p1 => p1.FantasyTeam == p) != null;

            if (!found)
            {
                LaunchPersonTeamView(p);
            }
        }

        private void GetPlayersByPosition(object sender, PlayersByPositionEventArgs e)
        {
            List<IPlayer> positionPlayers = new List<IPlayer>();
            GetPlayers getPlayers = new GetPlayers();

            foreach (string position in e.Positions)
            {
                positionPlayers.AddRange(getPlayers.GetPlayersByPosition(position, _Players, e.ShowPicked));
            }

            positionPlayers.Sort((p1, p2) => p1.Rank.CompareTo(p2.Rank));
            _View.SetPlayers(positionPlayers);
        }

        private void GetPlayersToWatch(object sender, PlayersToWatchEventArgs e)
        {
            List<IPlayer> players = new GetPlayers().GetPlayersToWatch(_Players, e.ShowPicked);
            _View.SetPlayers(players);
        }

        private void LaunchPersonTeamView(string person)
        {
            IFantasyTeamView view = _View.GetNewPersonTeamView();
            string p = person.Trim().ToUpper();
            List<IPlayer> players = _Players.FindAll(p1 => !string.IsNullOrEmpty(p1.FantasyTeam) && p1.FantasyTeam.ToUpper().Trim() == p);
            IObserver observer = new PersonTeamPresenter(view, person, this);
            view.SetData(person, players);
            _Observers.Add(observer);
            _PersonTeamViews.Add(view);
            view.Show();
        }

        private void Notify(object sender, EventArgs e)
        {
            foreach (IObserver observer in _Observers)
            {
                foreach (string s in _People)
                {
                    if (observer.OwningPlayer == s)
                    {
                        List<IPlayer> basePlayers = new List<IPlayer>();

                        foreach (IPlayer player in _Players)
                        {
                            if (player.FantasyTeam == s)
                            {
                                basePlayers.Add(player);
                            }
                        }

                        observer.UpdateView(basePlayers);
                    }
                }
            }
        }

        private void Search(object sender, SearchEventArgs e)
        {
            List<IPlayer> players = new SearchPlayers().SearchByName(e.SearchText, _Players);
            _View.SetPlayers(players);
        }

        private void UpdatePlayer(object sender, SimpleEventArgs<IPlayer> e)
        {
            new UpdatePlayers().UpdatePlayer(_Players, e.Value, e.Value.Id);
        }
    }
}