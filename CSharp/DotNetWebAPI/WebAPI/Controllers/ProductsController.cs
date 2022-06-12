using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class ProductsController : ControllerBase
    {
        // GET
        public IActionResult Index()
        {
            return Ok();
        }
    }
}