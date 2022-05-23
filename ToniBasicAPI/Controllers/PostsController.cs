using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t.app.Services;

namespace ToniBasicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly PostsService _postsService;

        public PostsController(ILogger<PostsController> logger, PostsService postService)
        {
            _logger = logger;
            _postsService = postService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _postsService.Get();

            return null;
        }
    }
}
