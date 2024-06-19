using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controller
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/books")]
    public class BooksV2Controller : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BooksV2Controller(IServiceManager manager)
        {
            _manager = manager;
        }


    }
}
