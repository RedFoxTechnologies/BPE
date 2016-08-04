using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using BPE.Configuration;
using BPE.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BPE.Web.Startup
{
    [DependsOn(
        typeof(BPEApplicationModule), 
        typeof(BPEEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BPEWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BPEWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BPEConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BPENavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BPEApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}