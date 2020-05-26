//https://docs.abp.io/en/abp/latest/Getting-Started-Console-Application

using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Demo
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AppModule : AbpModule
    {
      
    }
}
