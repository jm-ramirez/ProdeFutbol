using ProdeFutbol.Web.Data.Entities;
using ProdeFutbol.Web.Models;

namespace ProdeFutbol.Web.Helpers
{
    public interface IConverterHelper
    {
        TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

        TeamViewModel ToTeamViewModel(TeamEntity teamEntity);
    }
}
