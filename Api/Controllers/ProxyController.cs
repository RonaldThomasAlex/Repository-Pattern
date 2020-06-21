using BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProxyController : ControllerBase
    {
        private readonly ILogger<ProxyController> _logger;
        private readonly IBusinessLogic _businessLogic;
        public ProxyController(ILogger<ProxyController> logger, IBusinessLogic businessLogic)
        {
            _logger = logger;
            _businessLogic = businessLogic;
        }

        [HttpGet]
        public IActionResult Get(string input1,string input2)
        {
            _businessLogic.GetDataFromExternalService(input1, input2);
            return Ok();
        }

        [HttpPost]
        public IActionResult Save()
        {
            _businessLogic.SaveDataToDb();
            return Ok();
        }
    }
}
