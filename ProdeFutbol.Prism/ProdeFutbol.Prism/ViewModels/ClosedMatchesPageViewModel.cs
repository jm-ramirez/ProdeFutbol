﻿using Newtonsoft.Json;
using Prism.Navigation;
using ProdeFutbol.Common.Helpers;
using ProdeFutbol.Common.Models;
using ProdeFutbol.Prism.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace ProdeFutbol.Prism.ViewModels
{
    public class ClosedMatchesPageViewModel : ViewModelBase
    {
        private TournamentResponse _tournament;
        private List<MatchResponse> _matches;

        public ClosedMatchesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.Closed;
        }

        public List<MatchResponse> Matches
        {
            get => _matches;
            set => SetProperty(ref _matches, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            _tournament = parameters.GetValue<TournamentResponse>("tournament");
            LoadMatches();
        }

        private void LoadMatches()
        {
            List<MatchResponse> matches = new List<MatchResponse>();
            foreach (GroupResponse group in _tournament.Groups)
            {
                matches.AddRange(group.Matches);
            }

            Matches = matches.Where(m => m.IsClosed).OrderBy(m => m.Date).ToList();
        }
    }
}
