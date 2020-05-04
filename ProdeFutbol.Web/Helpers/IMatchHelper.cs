using System.Threading.Tasks;

namespace ProdeFutbol.Web.Helpers
{
    public interface IMatchHelper
    {
        Task CloseMatchAsync(int matchId, int goalsLocal, int goalsVisitor);
    }
}
