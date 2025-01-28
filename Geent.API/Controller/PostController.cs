using Geent.Application.DTOs.Response;
using Geent.Application.Interface.Service;
using Geent.Domain.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace Geent.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(string userCreation)
        {
            try
            { var posts = new List<Post>();

              posts = await _postService.GetAll(userCreation);
            {
           
                return Ok(posts);
        };
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet("GetAllMidias")]
        public async Task<IActionResult> GetAllMidia([FromQuery]int type)
        {
            try
            {

              var midias =   await _postService.GetAllMidias(type);


                return Ok(midias);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Post post)
        {
            try
            {
              await _postService.CreatePost(post);

              return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("GetMidiaById")]
        public async Task<IActionResult> GetMidiaById([FromQuery] int id)
        {
            try
            {
                var midia = await _postService.GetMidiaById(id);

                return Ok(midia);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("GetAllPostsByUserCreation")]
        public async Task<IActionResult> GetAllByUserCreation([FromQuery] string userCreation)
        {
            try
            {
                var posts = await _postService.GetAllByUserCreation(userCreation);

                return Ok(posts);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
