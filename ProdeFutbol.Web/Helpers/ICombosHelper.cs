using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProdeFutbol.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboTeams();

        IEnumerable<SelectListItem> GetComboTeams(int id);
    }
}
