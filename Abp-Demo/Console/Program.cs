//https://docs.abp.io/en/abp/latest/Getting-Started-Console-Application
using Demo.Services;
using System;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application = 
                AbpApplicationFactory.Create<AppModule>(opt =>opt.UseAutofac()))
            {
                application.Initialize();

                using (var scope = application.ServiceProvider.CreateScope())
                {
                    var helloWorldService = scope.ServiceProvider.GetService<HelloWorldService>();
                    helloWorldService.SayHello();
                }

                Console.WriteLine("Press ENTER to stop application...");
                Console.ReadLine();
            }
        }
    }
}
