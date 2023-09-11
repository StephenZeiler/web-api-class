using Microsoft.AspNetCore.Mvc;
namespace DemoApi.Controllers
{
    public class InfoController : Controller
    {
        [HttpGet("/info")]
        public async Task<ActionResult> GetTheInfo()
        {
            return Ok($"Controller is good");
        }
    }
}
