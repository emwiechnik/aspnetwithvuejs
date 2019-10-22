using System.Threading.Tasks;
using System.Web.Http;

namespace WithVueJs2.Controllers
{
  public class DataController : ApiController
  {
    [HttpGet]
    public async Task<string> GetMessage()
    {
      return await Task.FromResult("Hello from the API!");
    }
  }
}
