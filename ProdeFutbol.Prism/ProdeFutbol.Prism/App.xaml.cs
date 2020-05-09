using Prism;
using Prism.Ioc;
using ProdeFutbol.Common.Helpers;
using ProdeFutbol.Common.Services;
using ProdeFutbol.Prism.ViewModels;
using ProdeFutbol.Prism.Views;
using Syncfusion.Licensing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProdeFutbol.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MjUxMTcxQDMxMzgyZTMxMmUzMGVQTWlyb1pBQVA2UDY5V1FqN1VYanIvWTBhTVEzbVBpRDJHR0grbTZ6bjg9");

            InitializeComponent();

            await NavigationService.NavigateAsync("/ProdeMasterDetailPage/NavigationPage/TournamentsPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.Register<IFilesHelper, FilesHelper>();
            containerRegistry.Register<IRegexHelper, RegexHelper>();
            containerRegistry.Register<ITransformHelper, TransformHelper>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TournamentsPage, TournamentsPageViewModel>();
            containerRegistry.RegisterForNavigation<GroupsPage, GroupsPageViewModel>();
            containerRegistry.RegisterForNavigation<MatchesPage, MatchesPageViewModel>();
            containerRegistry.RegisterForNavigation<ClosedMatchesPage, ClosedMatchesPageViewModel>();
            containerRegistry.RegisterForNavigation<TournamentTabbedPage, TournamentTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<ProdeMasterDetailPage, ProdeMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<MyPredictionsPage, MyPredictionsPageViewModel>();
            containerRegistry.RegisterForNavigation<MyPositionsPage, MyPositionsPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, RegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<RememberPasswordPage, RememberPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<ChangePasswordPage, ChangePasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<PredictionsForTournamentPage, PredictionsForTournamentPageViewModel>();
            containerRegistry.RegisterForNavigation<ClosedPredictionsForTournamentPage, ClosedPredictionsForTournamentPageViewModel>();
            containerRegistry.RegisterForNavigation<PredictionsTabbedPage, PredictionsTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<PositionsInTournamentPage, PositionsInTournamentPageViewModel>();
        }
    }
}
