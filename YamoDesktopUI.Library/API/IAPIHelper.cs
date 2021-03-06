using System.Net.Http;
using System.Threading.Tasks;
using YamoDesktopUI.Library.Models;

namespace YamoDesktopUI.Library.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);

        HttpClient APIClient { get; }
    }
}