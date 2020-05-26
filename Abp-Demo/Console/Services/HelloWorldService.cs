using System;
using Volo.Abp.DependencyInjection;

namespace Demo.Services
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
