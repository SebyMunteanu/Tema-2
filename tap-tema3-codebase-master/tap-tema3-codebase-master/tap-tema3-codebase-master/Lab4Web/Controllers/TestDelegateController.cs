using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        [HttpGet("test-1")]
        public string Test1(string name)
        {
            var callback = _delegateService.Hello;
            
            return _delegateService.Introduction(name, callback);
        }

        [HttpGet("test-2")]
        public string Test2(string name, bool bye)
        {
            Func<string, string, string> callback;
            if (bye)
            {
                callback = (p1, p2) => $"Bye {p1} {p2}"; //expresie lambda
            }
            else
            {
               callback = _delegateService.Hello;
            }
            
            return _delegateService.Introduction(name, callback);
        }
    }
}
