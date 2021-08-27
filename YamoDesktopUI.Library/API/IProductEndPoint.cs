using System.Collections.Generic;
using System.Threading.Tasks;
using YamoDesktopUI.Library.Models;

namespace YamoDesktopUI.Library.API
{
    public interface IProductEndPoint
    {
        Task<List<ProductModel>> GetAllAsync();
    }
}