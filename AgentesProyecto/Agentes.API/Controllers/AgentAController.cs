using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Text.Json.Serialization;

namespace Agentes.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgentAController : ControllerBase
    {
        private readonly Agentes.Application.Services.AgentA.AgentAService _agentAService;

        public AgentAController(Application.Services.AgentA.AgentAService agentAService)
        {
            this._agentAService = agentAService;
        }

        [HttpPost]
        [SwaggerOperation("Funcionality1")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public IActionResult Funcionality1([FromBody] List<string> args)
        {
            string result = string.Empty;
            try
            {
                result = _agentAService.GetFuncionality1(args);
            }
            catch(Exception ex)
            {
                if(ex.Message == "!400")
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

        [HttpGet]
        [SwaggerOperation("Funcionality2")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public IActionResult Funcionality2(string arg)
        {
            Models.AnswerFuncionality2 answer = new Models.AnswerFuncionality2();
            try
            {
                answer.result = _agentAService.GetFuncionality2(arg);
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
            return Ok(answer);
        }
    }
}
