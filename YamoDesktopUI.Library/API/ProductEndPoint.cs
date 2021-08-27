using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YamoDesktopUI.Library.Models;

namespace YamoDesktopUI.Library.API
{
    public class ProductEndPoint : IProductEndPoint
    {
        private IAPIHelper _apiHelper;
        public ProductEndPoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<ProductModel>> GetAllAsync()
        {
            using (HttpResponseMessage response = await _apiHelper.APIClient.GetAsync("/api/Product"))
            {

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<ProductModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
