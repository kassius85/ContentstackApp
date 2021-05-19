using ContentstackApp.Content;
using System.Threading.Tasks;

namespace ContentstackApp.Interfaces
{
    public interface IProductService
    {
        Task<ResponseProduct> GetProductDataAsync();
    }
}
