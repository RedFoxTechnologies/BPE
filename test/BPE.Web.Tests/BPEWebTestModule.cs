using System.Reflection;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using BPE.Web.Startup;

namespace BPE.Web.Tests
{
    [DependsOn(
        typeof(BPEWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BPEWebTestModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}