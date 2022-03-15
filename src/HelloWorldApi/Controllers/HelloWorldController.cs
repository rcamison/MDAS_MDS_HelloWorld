using Microsoft.AspNetCore.Mvc;
using HelloWorldApi.UseCases;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly GetGreetingUseCase _getGreetingUseCase;

        public HelloWorldController(GetGreetingUseCase getGreetingUseCase)
        {
            _getGreetingUseCase = getGreetingUseCase;
        }

        [HttpGet(Name = "GetGreeting")]
        public ActionResult Get()
        {
            return Ok(_getGreetingUseCase.Execute());
        }
    }
}