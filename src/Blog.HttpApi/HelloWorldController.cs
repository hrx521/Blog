using Blog.Application;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Blog.HttpApi
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController:AbpController
    {
        private readonly IHelloWorldService helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }
        [HttpGet]
        public string HelloWorld()
        {
            return this.helloWorldService.HelloWorld();
        }
    }
}
