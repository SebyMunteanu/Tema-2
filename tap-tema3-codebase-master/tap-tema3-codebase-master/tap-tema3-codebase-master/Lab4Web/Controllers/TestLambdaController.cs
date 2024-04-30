using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        /*[HttpGet("test-1")]
        public string Get(int value)
        {
            var tuple = _lambdaService.Test1(value);
            return $"{tuple.Item1} / {tuple.Item2} / {tuple.Item3}";
        }
        */
        [HttpGet("test-1")]
        public string GetAsync(int value)
        {
            var tuple = _lambdaService.Test1Async(value).Result;
            return $"{tuple?.Item1} / {tuple?.Item2} / {tuple.Item3}";
        }

        [HttpGet("test-2")]
        public string TestLambdaWithoutParameters()
        {
            return _lambdaService.TestLambdaWithoutParameters();
        }

        [HttpGet("test-3")]
        public string TestLambdaWithParameters(int number)
        {
            return _lambdaService.TestLambdaWithParameters(number);
        }

        [HttpGet("test-4")]
        public string TestLambdaWithTwoParameters(int valoare1, int valoare2)
        {
            return _lambdaService.TestLambdaWithTwoParameters(valoare1, valoare2);
        }

        [HttpGet("test-5")]
        public string TestLambdaWithUnusedParameters()
        {
            return _lambdaService.TestLambdaWithUnusedParameters(12431312, 123132131); 
        }

        [HttpGet("test-6")]
        public string TestLambdaWithDefaultParameters(int x = 1, int y = 2)
        {
            return _lambdaService.TestLambdaWithDefaultParameters(x, y);
        }


    }
}
