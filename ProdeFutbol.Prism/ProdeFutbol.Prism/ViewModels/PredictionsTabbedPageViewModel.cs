﻿using Prism.Navigation;
using ProdeFutbol.Common.Models;
using ProdeFutbol.Prism.Helpers;

namespace ProdeFutbol.Prism.ViewModels
{
    public class PredictionsTabbedPageViewModel : ViewModelBase
    {
        private TournamentResponse _tournament;

        public PredictionsTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.PredictionsFor;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("tournament"))
            {
                _tournament = parameters.GetValue<TournamentResponse>("tournament");
                Title = $"{_tournament.Name}";
            }
        }
    }
}
