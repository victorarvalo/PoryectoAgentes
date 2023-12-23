
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agentes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentAController : ControllerBase
    {
        private readonly Agentes.Application.Services.AgentA.AgentAService _agentAService;

        public AgentAController(Application.Services.AgentA.AgentAService agentAService)
        {
            this._agentAService = agentAService;
        }

        [HttpPost]
        public IActionResult Funcionality1([FromBody] List<string> args)
        {
            string result = _agentAService.GetFuncionality1(args);
            return Ok(result);
        }
    }
}
