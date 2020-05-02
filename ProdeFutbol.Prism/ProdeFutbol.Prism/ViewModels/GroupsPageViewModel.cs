using Prism.Navigation;
using ProdeFutbol.Common.Helpers;
using ProdeFutbol.Common.Models;
using System.Collections.Generic;

namespace ProdeFutbol.Prism.ViewModels
{
    public class GroupsPageViewModel : ViewModelBase
    {
        private readonly ITransformHelper _transformHelper;
        private TournamentResponse _tournament;
        private List<Group> _groups;
        

        public GroupsPageViewModel(INavigationService navigationService, ITransformHelper transformHelper)
            : base(navigationService)
        {
            Title = "Groups";
            _transformHelper = transformHelper;
        }

        public List<Group> Groups
        {
            get => _groups;
            set => SetProperty(ref _groups, value);
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            _tournament = parameters.GetValue<TournamentResponse>("tournament");
            Title = _tournament.Name;
            Groups = _transformHelper.ToGroups(_tournament.Groups);
        }
    }
}
