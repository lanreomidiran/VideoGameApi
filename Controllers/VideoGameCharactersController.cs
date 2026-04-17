using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharactersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCharacters() 
        {
            var characters = new[] 
            {

            }
        }
    }
}
