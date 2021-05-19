using ContentstackApp.Content;
using System.Threading.Tasks;

namespace ContentstackApp.Interfaces
{
    public interface IHeaderService
    {
        Task<ResponseHeader> GetHeaderDataAsync();
    }
}
