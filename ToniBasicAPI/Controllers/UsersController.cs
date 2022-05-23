using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t.app.Services;
using t.domain.Entities;

namespace ToniBasicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly UserService _userService;

        public UsersController(ILogger<PostsController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ObjectResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            try
            {
                var users = _userService.Get();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception : {ex.Message}");
                return GetErrorResult(ex);
            }                       
        }

        [Route("GetByID/{UserID}")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ObjectResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByID(int UserID)
        {
            try
            {
                var user = _userService.GetByID(UserID);
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception : {ex.Message}");
                return GetErrorResult(ex);
            }
        }

        [Route("Create")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ObjectResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Create(User user)
        {
            try
            {
                var userResult = _userService.Create(user);
                return Ok(userResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception : {ex.Message}");
                return GetErrorResult(ex);
            }
        }

        private ObjectResult GetErrorResult(Exception ex)
        {
            var problemDetails = new ProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Title = ex?.Message,
                Detail = ex?.StackTrace,
                Instance = HttpContext.Request.Path,
            };

            var errorResult = new ObjectResult(problemDetails)
            {
                ContentTypes = { "application/problem+json" },
                StatusCode = problemDetails.Status,
            };

            return errorResult;
        }
    }
}
