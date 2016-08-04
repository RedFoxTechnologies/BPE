using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace BPE
{
    [DependsOn(
        typeof(BPECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BPEApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}