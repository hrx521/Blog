using Blog.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application
{
    public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
