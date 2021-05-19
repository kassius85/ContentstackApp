using ContentstackApp.Content;
using System.Threading.Tasks;

namespace ContentstackApp.Interfaces
{
    public interface IHomeService
    {
        Task<ResponseHome> GetHomeDataAsync();
    }
}
