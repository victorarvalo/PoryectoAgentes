using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agentes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentBController : ControllerBase
    {
        private readonly Application.Services.AgentB.AgentBService _agentBService;

        public AgentBController(Application.Services.AgentB.AgentBService agentBService)
        {
            _agentBService = agentBService;
        }

        [HttpPost]
        public IActionResult Funcionality1([FromBody] List<string> args)
        {
            string result = string.Empty;
            try
            {
                result = _agentBService.GetFuncionality1(args);
            }
            catch (Exception ex)
            {
                if (ex.Message == "!400")
                {
                    return BadRequest(ex.InnerException.Message);
                }
                if (ex.Message == "!500")
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Ok(result);
        }
    }
}
