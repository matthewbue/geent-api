using Geent.Application.Interface.Service;
using Geent.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Geent.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MidiaController : ControllerBase
    {
        private readonly IMidiaService _midiaService;
        public MidiaController(IMidiaService midiaService)
        {
            _midiaService = midiaService;
        }

        [HttpGet("GetAllMidias")]
        public async Task<IActionResult> GetAllMidia([FromQuery] int type)
        {
            try
            {

                var midias = await _midiaService.GetAllMidias(type);


                return Ok(midias);
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
                var midia = await _midiaService.GetMidiaById(id);

                return Ok(midia);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
