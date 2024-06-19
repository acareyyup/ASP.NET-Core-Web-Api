using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Presentation.Controller
{
    [ApiController]
    [Route("api")]
    public class RootController : ControllerBase
    {
        private readonly LinkGenerator _linkGenerator;

        public RootController(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }


        public async Task<IActionResult> GetRoot([FromHeader(Name = "Accept")] string mediaType)
        {
            if (mediaType.Contains("application/vnd.ASPNETCOREAPI.apiroot"))
            {

            }


            return NoContent(); // 204
        }





    }
}
