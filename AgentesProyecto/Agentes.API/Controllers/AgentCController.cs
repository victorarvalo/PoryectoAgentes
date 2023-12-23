using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Agentes.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgentCController : ControllerBase
    {
        private readonly Application.Services.AgentC.AgentCService _agentCService;

        public AgentCController(Application.Services.AgentC.AgentCService agentCService)
        {
            _agentCService = agentCService;
        }

        [HttpPost]
        public IActionResult Funcionality1([FromBody] List<string> args)
        {
            string result = string.Empty;
            try
            {
                result = _agentCService.GetFuncionality1(args);
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

        [HttpGet]
        [SwaggerOperation("Funcionality2")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public IActionResult Funcionality2(string arg)
        {
            Models.AnswerFuncionality2 answer = new Models.AnswerFuncionality2();
            try
            {
                answer.result = _agentCService.GetFuncionality2(arg);
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
