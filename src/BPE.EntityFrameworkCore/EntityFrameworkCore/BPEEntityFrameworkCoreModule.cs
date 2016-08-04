using System.Reflection;
using Abp.EntityFrameworkCore;
using Abp.Modules;

namespace BPE.EntityFrameworkCore
{
    [DependsOn(
        typeof(BPECoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BPEEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}