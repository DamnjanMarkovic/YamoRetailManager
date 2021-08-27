using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YamoDataManager.Library.DataAccess;
using YamoDataManager.Library.Models;

namespace YamoDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> Get()
        {
            ProductData productData = new ProductData();
            return productData.GetProducts();
        }
    }
}
