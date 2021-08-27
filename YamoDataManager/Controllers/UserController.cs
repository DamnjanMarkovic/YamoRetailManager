using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using YamoDataManager.Library.DataAccess;
using YamoDataManager.Library.Models;

namespace YamoDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();

        }
    }
}


//-EGRlRWmgGp4uNDe0YDK9BOGINwR0XphmcsMMlmThg2IQdeUVPs8qPJcEeXUx0Jyj7aNo_YJihcw50ne44blVVx9-1pZ7VRoDS414SnX5t_mowe9Wu3jMmamX6mOxtllWMiZSAjgzFszpnq4AhUBiUXgycCVkY2nV2gKF1xi5Yj2wYyMF0ItKkSiPOQDk5K2hop7vR4qDmyPXaQxOl5mk3amwioUQBDiJioCud-_n5-Boc-iI_lyUQAEAj1w7jRbGgOsI-WHZZWcE4q20pHwlgfabm14wxpIyuvR6U7uM-CHQTEOqFbjhBuiYpyXWQDzNS0EZDYQxkYdyCvsA-p0_bJA4RgXcfrmFRAdBJ66JPucy1Z3raDuD6ESn2YgTD3Lha85jKwOwWE7M-RVwGzOPc0jae3smYuvzrSGcZP8xtWnu_b6_t0glwqB6n4I-lmBKLOijHlB-YHsNRRA8li-3Sp1YPCJNwvvZN5hDIPasZlKOdVR3urrgDNwNa_Mi_0r