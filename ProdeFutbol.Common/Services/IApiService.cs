using ProdeFutbol.Common.Models;
using System.Threading.Tasks;

namespace ProdeFutbol.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}
