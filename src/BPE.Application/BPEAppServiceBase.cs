using Abp.Application.Services;

namespace BPE
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BPEAppServiceBase : ApplicationService
    {
        protected BPEAppServiceBase()
        {
            LocalizationSourceName = BPEConsts.LocalizationSourceName;
        }
    }
}