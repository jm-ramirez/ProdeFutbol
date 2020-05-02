using ProdeFutbol.Common.Models;
using System.Collections.Generic;

namespace ProdeFutbol.Common.Helpers
{
    public interface ITransformHelper
    {
        List<Group> ToGroups(List<GroupResponse> groupResponses);
    }
}
