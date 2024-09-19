using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatechistHelper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseController<T>
    {
        protected ILogger<T> logger;

        public BaseController(ILogger<T> logger)
        {
            this.logger = logger;
        }
    }
}
