using Microsoft.AspNetCore.Mvc;

namespace InMemoeryApp.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        //https://localhost:7034/
        //domain/api/Product
        [HttpGet]
        public string Products()
        {
            return "Merhaba arkdaşlar";
        }
    }
}
