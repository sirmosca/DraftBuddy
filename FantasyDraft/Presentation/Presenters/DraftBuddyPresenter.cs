using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly List<string> _fantasyTeams = new List<string>();
        private readonly List<IFantasyTeamView> _fantasyTeamView = new List<IFantasyTeamView>();
        private List<IPlayer> _players;
        private IDraftBuddyView _view;
        private string _fantasyTeamName;
        private string _fantasyTeamDisplay;
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftBuddyPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public DraftBuddyPresenter(IDraftBuddyView view)
        {
            _view = view;
            _view.GetPlayersByPosition += GetPlayersByPosition;
            _view.GetPlayersToWatch += GetPlayersToWatch;
            _view.DraftPlayer += OnPlayerDrafted;
            _view.AddPerson += AddFantasyTeam;
            _view.UpdatePlayer += UpdatePlayer;
            _view.Search += OnSearchPlayers;
            _view.FantasyTeamDisplay += OnFantasyTeamDisplay;
            InitializeData();
        }

        private void OnSearchPlayers(object sender, SearchEventArgs e)
        {
            var players = _players.Where(p => p.Name.ToUpper().Contains(e.SearchText.ToUpper())).ToList();
            _view.SetPlayers(players);
        }

        private void UpdatePlayer(object sender, SimpleEventArgs<IPlayer> e)
        {
            var player = _players.FirstOrDefault(p => p.Overall.Equals(e.Value.Overall));

            if (player == null)
            {
                return;
            }

            player.FantasyTeam = e.Value.FantasyTeam;
            player.IsWatching = e.Value.IsWatching;
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        private void InitializeData()
        {
            DataAccess dataAccess = new DataAccess();
            _players = dataAccess.GetDraftData();
        }

        public void Dispose()
        {
            _view = null;
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }

            IFantasyTeamView personTeamViewToRemove = _fantasyTeamView.Find(p => p.FantasyTeam == observer.FantasyTeam);

            if (personTeamViewToRemove != null)
            {
                personTeamViewToRemove.CloseView();
                _fantasyTeamView.Remove(personTeamViewToRemove);
            }
        }

        /// <summary>
        /// Sets the people.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="string"/> instance containing the event data.</param>
        private void AddFantasyTeam(object sender, SimpleEventArgs<string> e)
        {
            if (string.IsNullOrEmpty(e.Value))
            {
                return;
            }

            string p = e.Value.Trim();
            if (!_fantasyTeams.Contains(p))
            {
                _fantasyTeams.Add(p);
            }

            bool cont = false;

            if (_fantasyTeamDisplay == "my")
            {
                if (_fantasyTeamName == e.Value)
                {
                    cont = true;
                }
            }
            else if (_fantasyTeamDisplay == "all")
            {
                cont = true;
            }

            if (!cont)
            {
                return;
            }

            //todo: should do this from the presenter
            bool found = _fantasyTeamView.Find(p1 => p1.FantasyTeam == p) != null;

            if (!found)
            {
                LaunchPersonTeamView(p);
            }
        }

        private void GetPlayersByPosition(object sender, PlayersByPositionEventArgs e)
        {
            var positions = e.Positions;
            var positionPlayers = e.ShowPicked
                                      ? _players.Where(p => positions.Contains(p.Position)).ToList()
                                      : _players.Where(p => positions.Contains(p.Position) && !p.IsDrafted).ToList();

            positionPlayers.Sort((p1, p2) => p1.Overall.CompareTo(p2.Overall));
            _view.SetPlayers(positionPlayers);
        }

        private void GetPlayersToWatch(object sender, PlayersToWatchEventArgs e)
        {
            List<IPlayer> players = e.ShowDrafted
                                        ? _players.Where(p => p.IsWatching).ToList()
                                        : _players.Where(p => p.IsWatching && !p.IsDrafted).ToList();
            _view.SetPlayers(players);
        }

        private void OnFantasyTeamDisplay(string view)
        {
            _fantasyTeamDisplay = view;
            if (view == "my")
            {
                IObserver[] copy = new IObserver[_observers.Count];
                _observers.CopyTo(copy);
                foreach (var observer in copy)
                {
                    if (observer.FantasyTeam != _fantasyTeamName)
                    {
                        Detach(observer);
                    }
                }

                AddFantasyTeam(this, new SimpleEventArgs<string>(_fantasyTeamName));
            }
            else if (view == "all")
            {
                foreach (var fantasyTeam in _fantasyTeams)
                {
                    AddFantasyTeam(this, new SimpleEventArgs<string>(fantasyTeam));
                }
            }
            else
            {
                foreach (var fantasyTeam in _fantasyTeams)
                {
                    var observer = _observers.FirstOrDefault(o => o.FantasyTeam == fantasyTeam);
                    Detach(observer);
                }
            }
        }

        private void LaunchPersonTeamView(string person)
        {
            IFantasyTeamView view = _view.GetNewPersonTeamView();
            string p = person.Trim();
            List<IPlayer> players = _players.FindAll(p1 => !string.IsNullOrEmpty(p1.FantasyTeam) && p1.FantasyTeam == p);
            IObserver observer = new FantasyTeamPresenter(view, person, this);
            view.SetData(person, players);
            _observers.Add(observer);
            _fantasyTeamView.Add(view);
            view.ShowView();
        }

        private void OnPlayerDrafted(object sender, EventArgs e)
        {
            foreach (IObserver observer in _observers)
            {
                foreach (string s in _fantasyTeams)
                {
                    if (observer.FantasyTeam == s)
                    {
                        List<IPlayer> basePlayers = _players.Where(player => player.FantasyTeam == s).ToList();

                        observer.UpdateView(basePlayers);
                    }
                }
            }
        }

        public void SetFantasyTeamName(string teamName)
        {
            _fantasyTeamName = teamName;
        }
    }
}