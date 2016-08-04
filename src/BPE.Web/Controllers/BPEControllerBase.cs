using Abp.AspNetCore.Mvc.Controllers;

namespace BPE.Web.Controllers
{
    public abstract class BPEControllerBase: AbpController
    {
        protected BPEControllerBase()
        {
            LocalizationSourceName = BPEConsts.LocalizationSourceName;
        }
    }
}