using ContentstackApp.Content;
using System.Threading.Tasks;

namespace ContentstackApp.Interfaces
{
    public interface IProductDetailService
    {
        Task<ResponseProductDetail> GetProductDetailDataAsync(string id);
    }
}
