using Microsoft.AspNetCore.Mvc;

namespace OnlineLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {

        [HttpGet]
        [Route("[Action]")]
        public ActionResult<string> Send()
        {
            return "Admin!";
        }
    }
}
