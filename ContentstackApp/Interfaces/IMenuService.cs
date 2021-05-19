using ContentstackApp.Content;
using System.Threading.Tasks;

namespace ContentstackApp.Interfaces
{
    public interface IMenuService
    {
        Task<ResponseMenu> GetMenuDataAsync();
    }
}
